using System;

namespace Chapter._6_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleRemoteControl control = new SimpleRemoteControl();
            //Light light = new Light();
            //Command lightOn = new LightOnCommand(light);
            //control.SetCommand(lightOn);
            //control.ButtonWasPressed();
            //GarageDoor door = new GarageDoor();
            //Command doorOpen = new GarageDoorOpenCommand(door);
            //control.SetCommand(doorOpen);
            //control.ButtonWasPressed();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenRoomLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenRoomLightOff = new LightOffCommand(kitchenLight);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenRoomLightOn, kitchenRoomLightOff);

            Console.Write(remote.ToString());

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);

            Console.ReadKey();
        }
    }


}
