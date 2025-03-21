namespace Collections.CalcExample
{
    /// <summary>
    /// Клас, що реалізує узагальнений інтерфейс ICalc
    /// </summary>
    internal class CalcInt : ICalc<CalcInt>
    {
        int _number = 0;
        public CalcInt(int n)
        {
            _number = n;
        }

        // Під час реалізації використовується конкретний тип
        public CalcInt Sum(CalcInt b)
        {
            return new CalcInt(_number + b._number);
        }
    }
}
