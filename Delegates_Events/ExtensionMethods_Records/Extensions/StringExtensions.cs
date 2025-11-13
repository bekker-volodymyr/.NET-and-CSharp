namespace ExtensionMethods_Records.Extensions
{
    public static class StringExtensions
    {
        // Розширення для рядка: перевіряє, чи рядок є паліндромом
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
                reversed += str[i];

            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
