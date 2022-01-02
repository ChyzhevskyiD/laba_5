using System;

namespace laba_5555_3_
{
    class Shop
    {
        public string[] sizeClothes = { "XXS", "XS", "S", "M", "L" };
        public string euroSize;
        public Shop(string euroSize)
        {
            this.euroSize = euroSize;
        }
        public string GetSize
        {
            get
            {
                return euroSize;
            }
        }
        public string EuroSize
        {
            set
            {
                euroSize = value;
                if (euroSize == "32")
                {
                    euroSize = sizeClothes[0];
                }
                else if (euroSize == "34")
                {
                    euroSize = sizeClothes[1];
                }
                else if (euroSize == "38")
                {
                    euroSize = sizeClothes[2];
                }
                else if (euroSize == "40")
                {
                    euroSize = sizeClothes[3];
                }
            }
        }
        public void getDescription()
        {
            if (euroSize == sizeClothes[0])
            {
                Console.WriteLine("Дитячий розмiр");
            }
            else
            {
                Console.WriteLine("Дорослий розмiр");
            }
            Console.WriteLine();
        }
    }
    interface IMenswear
    {
        void dressMan();
    }
    interface IWomenswear
    {
        void dressWoman();
    }
    abstract class Clothes
    {
        public int sizeClothes;
        public double price;
        public string color;
        public Clothes(int sizeClothes, double price, string color)
        {
            this.sizeClothes = sizeClothes;
            this.price = price;
            this.color = color;
        }
    }
    class TShirt : Clothes, IMenswear, IWomenswear
    {
        public TShirt(int sizeClothes, double price, string color) : base(sizeClothes,
       price, color)
        { }
        public void dressMan()
        {
            Console.WriteLine("Футболка чоловiча:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
        public void dressWoman()
        {
            Console.WriteLine("Футболка жiноча:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }
    class Pants : Clothes, IMenswear, IWomenswear
    {
        public Pants(int sizeClothes, double price, string color) : base(sizeClothes,
       price, color)
        { }
        public void dressMan()
        {
            Console.WriteLine("Штани чоловiчi:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
        public void dressWoman()
        {
            Console.WriteLine("Штани жiночi:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }
    class Skirt : Clothes, IWomenswear
    {
        public Skirt(int sizeClothes, double price, string color) : base(sizeClothes, price, color)
        { }
        public void dressWoman()
        {
            Console.WriteLine("Спiдниця жiноча:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }
    class Necktie : Clothes, IMenswear
    {
        public Necktie(int sizeClothes, double price, string color) : base(sizeClothes, price, color)
        { }
        public void dressMan()
        {
            Console.WriteLine("Краватка чоловiча:");
            Console.WriteLine($"Розмiр: {sizeClothes}, Колiр: {color}, Цiна {price}");
        }
    }
    class Atelier
    {
        public void dressMan()
        {
            Console.WriteLine("Одягнути Чоловiка");
            IMenswear[] menswears = { new TShirt(36, 266.28, "синiй"), new Pants(36, 683,"чорний"), new Necktie(36, 89.80, "сiрий") };
            foreach (IMenswear str in menswears)
            {
                str.dressMan();
            }
            Console.WriteLine();
        }
        public void dressWoman()
        {
            Console.WriteLine("Одягнути Жiнку: ");
            IWomenswear[] womenswears = { new TShirt(36, 526.15, "рiзнокольоровий"), new Pants(36, 917, "бiлий"), new Skirt(36, 370, "бiлий") };
            foreach (IWomenswear str in womenswears)
            {
                str.dressWoman();
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть один iз запропонованих розмiрiв (32, 34, 36, 38, 40): ");
           
            string size = Console.ReadLine();
            Shop shop = new Shop(size);
            shop.EuroSize = shop.GetSize;
            shop.getDescription();
            Atelier atelier = new Atelier();
            atelier.dressMan();
            atelier.dressWoman();
        }
    }
}
