using MaltedWPF;
using System;
using System.Linq;

namespace malted_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 2)
            {
                if (args[0] == "encrypt")
                {
                    string filename = args[1];
                    Console.Write("enter password: ");
                    // FIXME: use password input mode?
                    string password = Console.ReadLine();
                    password.Trim();
                    bool ok = Malted.EncryptFile(filename, password);
                    PrintOK(ok);
                } else if (args[0] == "decrypt")
                {
                    string filename = args[1];
                    Console.Write("enter password: ");
                    string password = Console.ReadLine();
                    password.Trim();

                    bool ok = Malted.DecryptFile(filename, password);
                    PrintOK(ok);
                } else
                {
                    PrintUsage();
                }

            } else
            {
                PrintUsage();
            }
        }

        private static void PrintOK(bool ok)
        {
            if (ok)
            {
                
            } else
            {
                Console.WriteLine("Problem with file or password. Check file exists and password is correct.");
            }
        }

        static void PrintUsage()
        {
            Console.WriteLine("USAGE: (encrypt|decrypt) filename");
        }
    }
}
