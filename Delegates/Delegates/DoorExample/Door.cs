namespace Delegates.DoorExample
{
    internal class Door
    {
        public delegate void DoorDelegate();
        public event DoorDelegate OnOpenDoor;
        public bool IsOpen { get; private set; }
        public void OpenDoor()
        {
            OnOpenDoor.Invoke();
        }
    }
}
