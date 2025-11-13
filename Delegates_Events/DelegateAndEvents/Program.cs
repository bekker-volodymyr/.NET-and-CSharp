namespace DelegateAndEvents
{
    public class Button
    {
        public Action? OnClickDelegate;
        public event Action? OnClick;

        public void Click()
        {
            OnClick?.Invoke();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button();

            btn.OnClickDelegate = () => Console.WriteLine("Delegate On Click!");
            btn.OnClick += () => Console.WriteLine("Event On Click!");

            btn.OnClickDelegate(); // Працює - можливий виклик ззовні
            // btn.OnClick(); // Помилка - виклик події ззовні класу неможливий
        }
    }
}
