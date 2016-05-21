namespace Pop3Eraser
{
    interface IOutput
    {
        void Write(string message);
        void Debug(string message);
    }
}
