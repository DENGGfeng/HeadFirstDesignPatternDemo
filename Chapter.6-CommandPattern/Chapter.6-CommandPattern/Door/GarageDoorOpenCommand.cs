namespace Chapter._6_CommandPattern
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor door;
        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Open();
        }
    }
}
