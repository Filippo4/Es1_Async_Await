using System;
using System.Threading.Tasks;

namespace Es1_Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            RiempiArray(array);

            Console.WriteLine("Inserisci un numero da cercare:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RicercaNumeroAsync(n, array).Result);

            Console.WriteLine("Inserisci un numero da cercare:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(RicercaNumeroAsync(n2, array).Result);
        }
        private static async Task<bool> RicercaNumeroAsync(int n, int[] array)
        {
            bool trovato = false;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (n == array[i])
                    {
                        trovato = true;
                    }
                }
            });
            return trovato;
        }
        private static void RiempiArray(int[] array)
        {
            Random r = new Random();
            for (int n = 0; n < 100; n++)
            {
                array[n] = r.Next(0, 100);
            }
        }

    }
}
