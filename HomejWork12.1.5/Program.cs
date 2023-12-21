namespace HomejWork12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User {Name = "Ivan", Login = "Ivan1", IsPremium = true},
                new User {Name = "Dmitriy", Login = "Dmitry3", IsPremium = false},
                new User {Name = "Maria" , Login = "Cat83", IsPremium=true}
            };
            foreach (var user in users)
            {
                Console.WriteLine("===================================");
                Greet(user);
                Console.WriteLine("===================================");
                Console.WriteLine();
                Thread.Sleep(6000);
            }
        }

        public static void Greet(User user)
        {
            var def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}, приветствуем вас на нашем сервисе", user.Name);
            if (user.IsPremium)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                ShowAds();
            }
            Console.ForegroundColor = def;
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}