namespace HerancaMultipla.Devices
{
    public class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            System.Console.WriteLine($"Scanner processing: {doc}");
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}