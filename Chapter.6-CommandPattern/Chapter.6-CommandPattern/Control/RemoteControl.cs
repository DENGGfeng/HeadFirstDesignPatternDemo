using System.Text;

namespace Chapter._6_CommandPattern
{
    public class RemoteControl
    {
        Command[] OnCommands;
        Command[] OffCommands;

        public RemoteControl()
        {
            OnCommands = new Command[7];
            OffCommands = new Command[7];
            for (int i = 0; i < 7; i++)
            {
                OnCommands[i] = new NoCommand();
                OffCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
        }


        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\n-------- Remote Control --------\n");
            for (int i = 0; i < OnCommands.Length; i++)
            {
                stringBuilder.Append($"[slot{i}] {OnCommands[i].GetType()} {OffCommands[i].GetType()} \n");
            }

            return stringBuilder.ToString();
        }
    }


}
