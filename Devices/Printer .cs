namespace HerancaMultipla.Devices
{
    public class Printer : Device 
    {
        public override void ProcessDoc(string doc)
        {
            System.Console.WriteLine($"Printer processing: {doc}");
        }
        public void Print(string doc)
        {
            System.Console.WriteLine($"Printer print: {doc}");
        }
    }
}