using System;

namespace laba_5555_2_
{
    interface ITool
    {
        string KEY { set { KEY = "До мажор"; } }
        void play();
    }
    class Guitar : ITool
    {
        public int quantity { get; set; }
        public Guitar(int quantity)
        {
            this.quantity = quantity;
        }
        public void play()
        {
            Console.WriteLine($"Грає гiтара, кiлькiсть струн - {quantity}");
        }
    }
    class Drum : ITool
    {
        public double size { get; set; }
        public Drum(double size)
        {
            this.size = size;
        }
        public void play()
        {
            Console.WriteLine($"Грає барабан, розмiр - {size} см");
        }
    }
    class Trumpet : ITool
    {
        public double diameter { get; set; }
        public Trumpet(double diameter)
        {
            this.diameter = diameter;
        }
        public void play()
        {
            Console.WriteLine($"Грає труба, дiаметр - {diameter} см");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITool[] tools = { new Guitar(6), new Drum(50), new Trumpet(10) };
            foreach (ITool t in tools)
            {
                t.play();
            }
        }
    }
}
