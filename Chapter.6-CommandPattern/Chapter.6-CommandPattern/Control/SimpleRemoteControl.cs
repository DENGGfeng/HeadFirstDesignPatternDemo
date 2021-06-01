namespace Chapter._6_CommandPattern
{
    public class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl() { }
        public void SetCommand(Command command)
        {
            slot = command;
        }
        public void ButtonWasPressed() => slot.Execute();
    }
}
