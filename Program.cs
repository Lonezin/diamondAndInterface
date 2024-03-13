using HerancaMultipla.Devices;

namespace Atividade
{
    class Program 
    {
        static void Main (string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003}; 
            s.ProcessDoc("My email");
            System.Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 1010};
            c.ProcessDoc("My dissertation ");
            c.Print("My dissertation ");
            System.Console.WriteLine(c.Scan());
       }
    }
}