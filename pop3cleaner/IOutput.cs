namespace Pop3Cleaner
{
    interface IOutput
    {
        void Write(string message);
        void Debug(string message);
    }
}
