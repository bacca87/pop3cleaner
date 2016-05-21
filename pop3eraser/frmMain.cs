﻿using System;
using System.Windows.Forms;
using OpenPop.Pop3;
using OpenPop.Common.Logging;
using System.Threading;

namespace Pop3Eraser
{
    public partial class frmMain : Form, IOutput
    {
        private Thread currentThread;
        private AuthenticationMethod authMethod;
        private bool test = false;

        public frmMain()
        {
            InitializeComponent();

            POP3EraserLogger log = new POP3EraserLogger(this);
            DefaultLogger.SetLog(log);

            cmbAuthMethod.SelectedIndex = 2;

            currentThread = new Thread(ExecuteThread);
        }
        
        private void ExecuteThread()
        {
            try
            {
                using (Pop3Client client = new Pop3Client())
                {
                    Write("Connecting to " + txtAddress.Text + "...\n");
                    client.Connect(txtAddress.Text, (int)nPort.Value, chkSSL.Checked);
                    Write("Login with " + txtUsername.Text + "...\n");                    
                    client.Authenticate(txtUsername.Text, txtPassword.Text, authMethod);

                    int messageCount = client.GetMessageCount();
                    
                    setProgressBarMaximum(messageCount);
                    Write("Detected " + messageCount + " message/s to delete.\n");

                    if (!test && messageCount > 0)
                    {
                        Write("Start deleting messages, the operation may take a long time...\n");
                        client.DeleteAllMessages();
                        Write("All messages deleted!\n");
                    }                    

                    client.Disconnect();
                    Write("Disconnected from " + txtAddress.Text + ".\n");
                }
            }
            catch { }
        }

        #region IOutput Methods

        public void Write(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Write), new object[] { value });
                return;
            }

            txtLogGeneral.AppendText(DateTime.Now.ToLongTimeString() + " - " + value + "\n");
        }

        public void Debug(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Debug), new object[] { value });
                return;
            }

            if (value.Contains("PASS"))
                value = "PASS " + new String('*', txtPassword.Text.Length);

            txtLogPop3.AppendText(DateTime.Now.ToLongTimeString() + " - " + value + "\n");

            if (value.Contains("DELE"))
            {
                // hack for speed up progress bar animation
                progressBar.Value++;
                progressBar.Value--;
                progressBar.Value++;
            }
        }

        #endregion

        private bool checkInputs()
        {
            bool ok = true;

            if(string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Please fill the required field");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Please fill the required field");
                ok = false;
            }

            return ok;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!currentThread.IsAlive && checkInputs())
            {
                currentThread = new Thread(ExecuteThread);
                currentThread.IsBackground = true;

                if (MessageBox.Show("This operation cannot be undone. Would you like to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                test = false;
                progressBar.Value = 0;
                authMethod = (AuthenticationMethod)cmbAuthMethod.SelectedIndex; //hack for getting the auth method from a separate thread
                currentThread.Start();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!currentThread.IsAlive && checkInputs())
            {
                currentThread = new Thread(ExecuteThread);
                currentThread.IsBackground = true;

                test = true;
                progressBar.Value = 0;
                authMethod = (AuthenticationMethod)cmbAuthMethod.SelectedIndex; //hack for getting the auth method from a separate thread
                currentThread.Start();
            }
        }

        private void chkSSL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSSL.Checked)
                nPort.Value = 995;
        }
        
        public void setProgressBarMaximum(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(setProgressBarMaximum), new object[] { value });
                return;
            }

            progressBar.Maximum = value;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetInputFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAddress.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbAuthMethod.SelectedIndex = 2;
            nPort.Value = 110;
            chkSSL.Checked = false;
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtLogGeneral.Text = string.Empty;
            txtLogPop3.Text = string.Empty;
        }

        private void tabLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLogGeneral.ScrollToCaret();
            txtLogPop3.ScrollToCaret();
        }
    }
}
