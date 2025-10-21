namespace ClassExample
{
    internal class Car
    {
        private string driverName;
        private int speed;
        public Car() : this("Нема водія", 0) { }
        public Car(string driverName, int speed)
        {
            this.driverName = driverName;
            this.speed = speed;
        }
    }
}