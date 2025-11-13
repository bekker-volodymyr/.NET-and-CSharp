namespace DelegatesFromBCL
{
    public class Button
    {
        // Оголошення події
        public event EventHandler? Click;

        // Метод для виклику події
        public void SimulateClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
