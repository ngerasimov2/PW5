namespace PW5._3
{
    // Интерфейс IFilter
    interface IFilter
    {
        string Execute(string textLine);
    }
    // Класс DigitFIlter
    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string text = "";
            // Для каждого символа в строке
            foreach (char c in textLine)
            {
                if (char.IsLetter(c)) // Если это буква
                {
                    text += c;
                }
            }

            return text;
        }
    }
    // Класс LetterFIlter
    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string text = "";
            // Для каждого символа в строке
            foreach (char c in textLine)
            {
                if (char.IsDigit(c)) // Если это цифра
                {
                    text += c;
                }
            }

            return text;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IFilter digitFilter = new DigitFilter();
            IFilter letterFilter = new LetterFilter();

            string text = "a4a5a3ga3g3agedf3eatay";

            Console.WriteLine($"Исходный текст: {text}");
            Console.WriteLine($"Текст после применения DigitFilter: {digitFilter.Execute(text)}");
            Console.WriteLine($"Текст после применения LetterFilter: {letterFilter.Execute(text)}");

            Console.ReadKey();
        }
    }
}