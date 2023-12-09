

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, delta, x1, x2;

        Console.WriteLine("Oblicz rownanie ax2+bx+c=0");
        Console.WriteLine("Podaj a:");
        a = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Podaj wartosc inna niz 0");
        }
        else
        {
            Console.WriteLine("Podaj b.");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c.");
            c = double.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta < 0) { Console.WriteLine("Rownianie nie ma zadnych rozwiazan"); }

            else
                if (delta == 0)
            {
                x1 = -b / (2 * a);
                
                Console.WriteLine(" x = {0:##.##}.", x1);
            }
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                
                Console.WriteLine("x1 = {0:##.##}, x2 = {1:##.##}", x1, x2);
            }

        }

    }

}