namespace Constructors
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("Object Coppied!!");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object Duplicated!!");
        }
    }
}
