namespace Collections.CalcExample
{
    /// <summary>
    /// Узагальнений інтерфейс з методом обчислення суми
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICalc<T>
    {
        T Sum(T b);
    }
}
