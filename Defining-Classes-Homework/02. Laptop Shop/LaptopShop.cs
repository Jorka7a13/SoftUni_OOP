//Problem 2. Laptop Shop

//Define a class Laptop that holds the following information about a laptop device: 
//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.

using System;

class LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private short? ram;
        private string graphicsCard;
        private short? hdd;
        private string screen;
        private decimal price;
        private Battery battery;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model must not be an empty string!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Manufacturer must not be an empty string!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Processor must not be an empty string!");
                }
                this.processor = value;
            }
        }

        public short? RAM
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RAM must be a positive number!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card must not be an empty string!");
                }
                this.graphicsCard = value;
            }
        }

        public short? HDD
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HDD must be a positive number!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Screen must not be an empty string!");
                }
                this.screen = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be a positive number!");
                }
                this.price = value;
            }
        }

        public Battery Battery { get; set; }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor = null,
            short? ram = null, string graphicsCard = null, short? hdd = null, string screen = null, Battery battery = null) 
            : this(model, price, manufacturer)
        {
            this.Battery = battery;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
        }

        public override string ToString()
        {
            string result = "Model: " + this.Model;

            if (this.Manufacturer != null)
            {
                result += ", Manufacturer: " + this.Manufacturer;
            }

            if (this.Processor != null)
            {
                result += ", Processor: " + this.Processor;
            }

            if (this.RAM != null)
            {
                result += ", RAM: " + this.RAM + " GB";
            }

            if (this.GraphicsCard != null)
            {
                result += ", GraphicsCard: " + this.GraphicsCard;
            }

            if (this.HDD != null)
            {
                result += ", HDD: " + this.HDD + " GB SSD";
            }

            if (this.Screen != null)
            {
                result += ", Screen: " + this.Screen;
            }

            if (this.Battery != null)
            {
                result += String.Format(", Battery: {0}, Battery Life: {1} hours", this.Battery.Model, this.Battery.Life);
            }

            result += ", Price: " + this.Price + " lv.";

            return result;
        }
    }

    class Battery
    {
        private string model;
        private double life; // Livin' the double life maaan!

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Battery model must not be an empty string!");
                }
                this.model = value;
            }
        }

        public double Life
        {
            get { return this.life; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life must be a positive number!");
                }
                this.life = value;
            }
        }

        public Battery(string model, double life)
        {
            this.Model = model;
            this.Life = life;
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Laptop mandatoryLaptop = new Laptop("HP 250 G2", 699.00M);
            Console.WriteLine(mandatoryLaptop);
            
            Console.WriteLine();

            Laptop fullLaptop = new Laptop("Lenovo Yoga 2 Pro", 699.00M, "Lenovo", 
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400",
                128, "13.3 (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5));
            Console.WriteLine(fullLaptop);

            Console.WriteLine();

            Laptop partialLaptop = new Laptop("Lenovo Yoga 2 Pro", 699.00M, "Lenovo", // No battery and screen
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400",
                128);
            Console.WriteLine(partialLaptop);
        }
    }
}