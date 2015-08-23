namespace _04.HTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string src, string alt, string title)
        {
            ElementBuilder elem = new ElementBuilder("img");
            elem.AddAttribute("src", src);
            elem.AddAttribute("alt", alt);
            elem.AddAttribute("title", title);

            return elem.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder elem = new ElementBuilder("a");
            elem.AddAttribute("href", url);
            elem.AddAttribute("title", title);
            elem.AddContent(text);

            return elem.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder elem = new ElementBuilder("input");
            elem.AddAttribute("type", type);
            elem.AddAttribute("name", name);
            elem.AddContent(value);

            return elem.ToString();
        }
    }
}