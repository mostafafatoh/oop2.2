namespace oop2._2
{
    internal class Program
    {static void Test(Car car)
        {
            int x = 3;
        }
        static void Main(string[] args)
        {
            int num = 5;
            Car c = new Car();
            
            c.price = 1999;
            Car c2 = c; 
            Console.WriteLine(c.price);
            //c= new Car();
            //c.price=5555;
            Test(c);
        }
    }
}
