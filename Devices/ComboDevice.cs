namespace HerancaMultipla.Devices
{
    public class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            System.Console.WriteLine($"ComboDevice processing: {doc}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
        public void Print(string document)
        {
            System.Console.WriteLine($"ComboDevice print: {document}");
        }
    }
}