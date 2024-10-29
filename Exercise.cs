namespace POO {
    public class Exercise {

        static void Main(string[] args) {

            Person x, y;

            x = new Person();
            y = new Person();

            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome:");
            x.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            x.age = int.Parse(Console.ReadLine());
            Console.WriteLine("ID:");
            x.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome:");
            y.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            y.age = int.Parse(Console.ReadLine());
            Console.WriteLine("ID:");
            y.id = int.Parse(Console.ReadLine());

            if (x.age > y.age)
            {
                Console.WriteLine($"{x.name} é a pessoa mais velha");
            }
            else
            {
                Console.WriteLine($"{y.name} é a pessoa mais velha");
            }

        }

    }
}
