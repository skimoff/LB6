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
        Toy t = new Toy("bear", "Description", 3, "3-6 age", "for d");
        Toy t1 = new Toy("Toy 1", "Description", 3, "3-6 age", "for b");
        Console.WriteLine(t.GetHashCode());
        Console.WriteLine(t.Equals(t1));
    }

    static void Main(string[] args)
    {
        task2();
        Console.ReadKey();
    }
}