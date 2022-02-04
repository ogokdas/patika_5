using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Lütfen sadece sayı yazınız." + Environment.NewLine + Ex.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            Console.ReadLine();


        }
    }
}
