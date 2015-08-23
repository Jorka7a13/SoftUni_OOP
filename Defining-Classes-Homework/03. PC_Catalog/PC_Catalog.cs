// Problem 3. PC Catalog

// Define a class Computer that holds name, several components and price. 
// The components (processor, graphics card, motherboard, etc.) should be objects of class Component, 
// which holds name, details (optional) and price. 

using System;
using System.Linq;
using System.Collections.Generic;

public class PC_Catalog
{
    public class Computer
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be empty!");
                }
                this.name = value;
            }
        }

        public Component CPU { get; set; }
        public Component RAM { get; set; }
        public Component GraphicsCard { get; set; }
        public Component Motherboard { get; set; }
        public Component HDD { get; set; }

        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, Component cpu, Component graphicsCard) : this(name)
        {
            this.CPU = cpu;
            this.GraphicsCard = graphicsCard;
        }

        public Computer(string name, Component cpu, Component ram, Component graphicsCard, 
            Component motherboard, Component hdd) 
            : this(name, cpu, graphicsCard)
        {
            this.RAM = ram;
            this.Motherboard = motherboard;
            this.HDD = hdd;
        }

        public double CalcTotalPrice()
        {
            double totalPrice = 0;

            if (this.CPU != null)
            {
                totalPrice += this.CPU.Price;
            }
            if (this.RAM != null)
            {
                totalPrice += this.RAM.Price;
            }
            if (this.GraphicsCard != null)
            {
                totalPrice += this.GraphicsCard.Price;
            }
            if (this.Motherboard != null)
            {
                totalPrice += this.Motherboard.Price;
            }
            if (this.HDD != null)
            {
                totalPrice += this.HDD.Price;
            }

            return totalPrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.name + ":");

            if (this.CPU != null)
            {
                Console.Write("CPU: " + this.CPU.Name + " - " + this.CPU.Price + " BGN");
                if (this.CPU.Details != null)
                {
                    Console.WriteLine(" -- Details: " + this.CPU.Details);
                }
                else
                {
                    Console.Write("\n");
                }
            }
            if (this.RAM != null)
            {
                Console.Write("RAM: " + this.RAM.Name + " - " + this.RAM.Price + " BGN");
                if (this.RAM.Details != null)
                {
                    Console.WriteLine(" -- Details: " + this.RAM.Details);
                }
                else
                {
                    Console.Write("\n");
                }
            }
            if (this.GraphicsCard != null)
            {
                Console.Write("GraphicsCard: " + this.GraphicsCard.Name + " - " + this.GraphicsCard.Price + " BGN");
                if (this.GraphicsCard.Details != null)
                {
                    Console.WriteLine(" -- Details: " + this.GraphicsCard.Details);
                }
                else
                {
                    Console.Write("\n");
                }
            }
            if (this.Motherboard != null)
            {
                Console.Write("Motherboard: " + this.Motherboard.Name + " - " + this.Motherboard.Price + " BGN");
                if (this.Motherboard.Details != null)
                {
                    Console.WriteLine(" -- Details: " + this.Motherboard.Details);
                }
                else
                {
                    Console.Write("\n");
                }
            }
            if (this.HDD != null)
            {
                Console.Write("HDD: " + this.HDD.Name + " - " + this.HDD.Price + " BGN");
                if (this.HDD.Details != null)
                {
                    Console.WriteLine(" -- Details: " + this.HDD.Details);
                }
                else
                {
                    Console.Write("\n");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total price: " + CalcTotalPrice() + " BGN");
        }
    }

    public class Component
    {
        private string name;
        private double price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be empty!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price must be a positive number!");
                }
                this.price = value;
            } 
        }

        public string Details { get; set; }

        public Component(string name, double price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            Computer cheapComputer = new Computer("Some cheap wreck", 
                new Component("AMD FX-4300 3.8GHz Socket AM3+ 8MB Cache", 135.0, "Some CHEAP details"),
                new Component("Diamond Radeon HD 7750 1GB DDR5 PCI Express", 220.0));

            Computer mediocreComputer = new Computer("Middle ground PC",
                new Component("Intel Core i3-4160 Haswell Dual-Core 3.6GHz", 245.0), 
                new Component("8GB Corsair Vengeance DDR3 1600MHz", 120.0),
                new Component("Gigabyte R7 260X GDDR5-1GB 2xDVI/HDMI/DP", 320.0),
                new Component("ASUS Z87-Plus", 220.0),
                new Component("Crucial m4 128GB 2.5-Inch SATA 6Gb/s SSD", 310.0));

            Computer expensiveComputer = new Computer("Fastest Expensive Porsche Design PC",
                new Component("Intel Xeon Processor E7-8893 v2", 6841.00, "Success is in the details"),
                new Component("[TridentX] F3-1600C7D-16GTX", 320.0),
                new Component("GTX Titan Z", 4800.0), 
                new Component("ASUS Striker Extreme LGA 775 NVIDIA nForce 680i SLI ATX", 740.0),
                new Component("PNY - Optima 240GB Internal Serial ATA III SSD", 140.0));

            List<Computer> computers = new List<Computer> {cheapComputer, expensiveComputer, mediocreComputer};
            List<Computer> sortedComputers = computers.OrderBy(computer => computer.CalcTotalPrice()).ToList();

            foreach (var computer in sortedComputers)
            {
                computer.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}