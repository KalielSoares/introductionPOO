namespace POO {
    public class avaregeSalary {
        static void Main(string[] args) {

            Person x, y;

            x = new Person();
            y = new Person();

            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome:");
            x.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            x.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario:");
            x.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome:");
            y.name = Console.ReadLine();
            Console.WriteLine("Idade:");
            y.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario:");
            y.Salary = double.Parse(Console.ReadLine());

            double payament = (y.Salary + x.Salary) / 2;

            Console.WriteLine($"{payament} é a media salarial");
            

        }

    }
}
