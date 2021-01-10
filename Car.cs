using System;

namespace CS
{
    class Car
    {
        public int id;
        public string color;
        public string model;
        public int speed;
        public double price = 100000000;
        public double discount;


        public Car()
        {
            set();
            get();
            calculatePrice();
        }


        public void set()
        {
            Console.Write("Please enter the car's id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the car's model:");
            model = Convert.ToString(Console.ReadLine());
            Console.Write("Please enter the car's color:");
            color = Convert.ToString(Console.ReadLine());

            setSpeed();
        }

        public void setSpeed()
        {
            Console.Write("Please enter the car's speed:");
            speed = Convert.ToInt32(Console.ReadLine());
            if (speed > 120)
            {
                Console.WriteLine("Speead can't be greather than 120:");
                Console.WriteLine(" [Try again]");
                setSpeed();
            }
        }

        public void calculatePrice(double defaultDiscount = 2.5)
        {
            Console.Write("Please enter discount percent:");
            discount = Convert.ToInt32(Console.ReadLine());

            discount = discount > 0 ? discount : defaultDiscount;

            price = price - (discount * price) / 100;

            Console.WriteLine(" price:" + price);
        }

        public void get()
        {
            Console.WriteLine("{0})  {1} ({2}) with {3} km/h speed ", id, model, color, speed);
        }
    }
}