using System;

namespace _04.HTMLDispatcher
{
    class MainClass
    {
        public static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine();

            string img = HTMLDispatcher.CreateImage("img.png", "image", "Gandalf");
            string input = HTMLDispatcher.CreateInput("text", "userName", "For Frodo!");
            string url = HTMLDispatcher.CreateURL("https://www.youtube.com/watch?v=fjC7dctw7LU", "Harder, Better, Faster, Stronger", "The cake is a lie...");
            Console.WriteLine(img);
            Console.WriteLine(input);
            Console.WriteLine(url);
        }
    }
}
