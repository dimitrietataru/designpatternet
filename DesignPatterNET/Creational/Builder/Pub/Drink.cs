namespace Builder.Pub
{
    public class Drink
    {
        public string Name { private get; set; }
        public string Size { private get; set; }

        public new string ToString() => $"{Size} {Name}";
    }
}
