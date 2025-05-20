namespace LB6;

class Program
{
    static void task1()
    {
        Toy[] toys = new Toy[2]
        {
            new Toy("Toy 1", "Description", 3, "3-6 age", "for d"),
            new Toy("Toy 2", "Description", 4.5, "6-9 age", "for b"),
        };
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(toys[i]);
            Console.WriteLine(toys[i].GetHashCode());
        }

        Console.WriteLine(toys[0].Equals(toys[1]));
        //Toy toy1 = new Toy("Toy 1", "Toy 2", 3, "3-6 age", "for d");
        //Console.WriteLine(toy1);
    }

    static void task2()
    {
        Oval oval = new Oval(2, 2);
        Circle circle = new Circle(3);
        Triangle triangle = new Triangle(4, 5, 6);
        
        GeometricFigure[] arr = new GeometricFigure[3];
        arr[0] = oval;
        arr[1] = circle;
        arr[2] = triangle;

        for (int i = 0; i < arr.Length; i++)
        {
            
            Console.WriteLine(arr[i].Name);
            Console.WriteLine(arr[i]);
        }
    }

    static void Main(string[] args)
    {
        task2();
        Console.ReadKey();
    }
}