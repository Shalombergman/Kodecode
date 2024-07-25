


namespace Practice_Classes_in_C_
{
    enum Color
    {
        Red,
        Green,
        Blue,
    }
    internal class Program
    {
       
        
        static public void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car(Color.Red);
            cars[0] = new Car(Color.Blue);
            cars[0] = new Car(Color.Green);
            cars[0].DisplayColor();
        }

    }

}

