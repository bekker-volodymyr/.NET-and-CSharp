namespace ClassExample
{
    // internal - клас доступний тільки всередині поточної збірки
    internal class FieldsClassExamle
    {
        public int regularField; // звичайне поле, належить об'єкту
        public static int staticField; // статичне поле, належить класу (спільне для всіх об'єктів)
        public const int constField = 1; // константне поле, необхідно одразу ініціалізувати, неявно статичне
        public readonly int readonlyField; // належить об'єкту, необхідно ініціалізувати в конструкторі 1 раз
    }
}
