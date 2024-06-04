using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
        internal class TXTRegister
        {
            private static TXTRegister realInstance;
            private TXTRegister() { }
            public static TXTRegister Instances
            {
                get
                {
                    realInstance = realInstance != null ? realInstance : new();
                    return realInstance;
                }
            }


            public void logToTxt(string txtInfo)
            {
                try
                {
                    string directorioDbg = Directory.GetCurrentDirectory();
                    string directProyecto = Directory.GetParent(directorioDbg).Parent.Parent.FullName;

                    StreamWriter sw = new StreamWriter(Path.Combine(directProyecto, "db.txt"), true);
                    sw.WriteLine();
                    sw.WriteLine(txtInfo);
                    sw.Close();
                    Console.WriteLine();


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fallo aqui: {ex.Message}");
                }

            }


        }
    }
