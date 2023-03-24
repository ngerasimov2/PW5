namespace PW5
{
    // Интерфейс Animal
    interface IAnimal
    {
        void Voice();
    }
    // Класс Сова
    class Owl : IAnimal
    {
        // Поле с текущим временем
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt")); // В файле написано 12
        }
        // Метод Voice
        public void Voice()
        {
            int currentTime = GetCurrentTime();

            if((currentTime >= 8) && (currentTime <= 21)) 
            {
                Console.WriteLine("Тисе, я сплю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }
    // Класс Собака
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
    // Класс Кот
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }

    // Класс Корова
    class Cow : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мууууу!");
        }
    }
    // Класс Мышка
    class Mouse : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Пи-пи!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // СОздание списка с животными
            List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Owl());
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Cow());
            myAnimals.Add(new Mouse());

            // Для каждого animal в списке
            foreach(IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }

            Console.ReadKey(true);
        }
        // Метод PetAnimal
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Мы гладим зверушку, а она нам говорит:");
            animal.Voice();
        }
    }
}