namespace Collections.CalcExample
{
    internal class CalcInt : ICalc<CalcInt>
    {
        int _number = 0;
        public CalcInt(int n)
        {
            _number = n;
        }

        public CalcInt Sum(CalcInt b)
        {
            return new CalcInt(_number + b._number);
        }
    }
}
