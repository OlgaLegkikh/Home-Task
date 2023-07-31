namespace Optional_Task_1
{
    public interface ITextInteractions
    {
        string RequestInput(string prompt);
        bool RequestInputInBool(string prompt);
        uint RequestInputInInt(string prompt);
    }
}