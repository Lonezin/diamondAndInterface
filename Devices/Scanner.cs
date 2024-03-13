namespace HerancaMultipla.Devices
{
    public class Scanner : Device
    {
        public override void ProcessDoc(string doc)
        {
            System.Console.WriteLine($"Scanner processing: {doc}");
        }
        public string Scan(string scan)
        {
            return "Scanner scna result";
        }
    }
}