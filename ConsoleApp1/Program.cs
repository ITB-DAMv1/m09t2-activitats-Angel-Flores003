using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Thread thread = new Thread(() => Console.WriteLine("1"));
            Thread thread1 = new Thread(() => Console.WriteLine("2"));
            Thread thread2 = new Thread(() => Console.WriteLine("3"));
            Thread thread3 = new Thread(() => Console.WriteLine("4"));
            Thread thread4 = new Thread(() => Console.WriteLine("5"));
            Thread thread5 = new Thread(() => Console.WriteLine("6"));
            Thread thread6 = new Thread(() => Console.WriteLine("7"));
            Thread thread7 = new Thread(() => Console.WriteLine("8"));
            Thread thread8 = new Thread(() => Console.WriteLine("9"));
            Thread thread9 = new Thread(() => Console.WriteLine("10"));            

            thread.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();

            thread.Join(); // Wait for the thread to finish
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            thread5.Join();
            thread6.Join();
            thread7.Join();
            thread8.Join();
            thread9.Join();*/

            /*Thread thfinal = new Thread(Count);

            thfinal.Start();

            thfinal.Join(); // Wait for the thread to finish*/

            //Ej 2
            /*Process[] processos = Process.GetProcesses();

            foreach (Process p in processos)
            {
                try
                {
                    Console.WriteLine($"Nom: {p.ProcessName}, PID: {p.Id}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"No s'ha pogut obtenir informació d'un procés: {ex.Message}");
                }
            }*/

            //Ej 3
            /*Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            //Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");

            Thread.Sleep(3000); // Espera 3 segundos

            Process[] procesosChrome = Process.GetProcessesByName("chrome");

            Console.WriteLine($"S'han trobat {procesosChrome.Length} processos de Chrome.");

            foreach (var navegador in procesosChrome)
            {
                LlistarFilsDelNavegador(navegador);
                Console.WriteLine("-------------------------------------");
            }*/

            //Ej 5
            /*Thread thread1 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 1"));
            Thread thread2 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 2"));
            Thread thread3 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 3"));
            Thread thread4 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 4"));
            Thread thread5 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 5"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();*/

            /*Thread thread1 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 1"));
            Thread thread2 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 2"));
            Thread thread3 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 3"));
            Thread thread4 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 4"));
            Thread thread5 = new Thread(() => Console.WriteLine($"Hola! Soc el fil número 5"));

            thread5.Start();
            Thread.Sleep(500); 
            thread4.Start();
            Thread.Sleep(500); 
            thread3.Start();
            Thread.Sleep(500); 
            thread2.Start(); 
            Thread.Sleep(500); 
            thread1.Start();*/

            //Ej 6
            Thread camell1 = new Thread(Camello1);
            Thread camell2 = new Thread(Camello2);
            Thread camell3 = new Thread(Camello3);
            Thread camell4 = new Thread(Camello4);
            Thread camell5 = new Thread(Camello5);

            camell1.Start();
            camell2.Start();
            camell3.Start();
            camell4.Start();
            camell5.Start();

            camell1.Join();
            camell2.Join();
            camell3.Join();
            camell4.Join();
            camell5.Join();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tots els camells han acabat la seva carrera.");
        }

        static void Count()
        {
            const int maxCount = 10;
            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine(maxCount - i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
        }

        static void LlistarFilsDelNavegador(Process navegador)
        {
            try
            {
                Console.WriteLine($"Fils del procés {navegador.ProcessName} (PID: {navegador.Id}):");

                foreach (ProcessThread fil in navegador.Threads)
                {
                    Console.WriteLine($"ID del fil: {fil.Id}, Inici: {fil.StartTime}, Prioritat: {fil.BasePriority}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error llistant fils: {ex.Message}");
            }
        }
        static void Camello1()
        {            
            Random descans = new Random();
            int contador = 0;
            for (int i = 0; i < 101; i++)
            {
                int descanso = descans.Next(0, 131);
                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Camello 1, vuelta {contador}");
                Thread.Sleep(descanso);
                contador++;
            }
        }
        static void Camello2()
        {
            Random descans = new Random();
            int contador = 0;
            for (int i = 0; i < 101; i++)
            {
                int descanso = descans.Next(0, 121);
                //Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Camello 2, vuelta {contador}");
                Thread.Sleep(descanso);
                contador++;
            }
        }
        static void Camello3()
        {
            Random descans = new Random();
            int contador = 0;
            for (int i = 0; i < 101; i++)
            {
                int descanso = descans.Next(0, 101);
                //Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Camello 3, vuelta {contador}");               
                Thread.Sleep(descanso);
                contador++;
            }
        }
        static void Camello4()
        {
            Random descans = new Random();
            int contador = 0;
            for (int i = 0; i < 101; i++)
            {
                int descanso = descans.Next(0, 111);
                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Camello 4, vuelta {contador}");               
                Thread.Sleep(descanso);
                contador++;
            }
        }
        static void Camello5()
        {
            Random descans = new Random();
            int contador = 0;
            for (int i = 0; i < 101; i++)
            {
                int descanso = descans.Next(0, 141);
                //Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Camello 5, vuelta {contador}");                
                Thread.Sleep(descanso);
                contador++;
            }
        }
    }
}