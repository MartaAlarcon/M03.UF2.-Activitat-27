using System; 
namespace Activitats
{
    public class ej27
    {
        public static void Main()
        {
            int num;
            int count = 0;
            Console.WriteLine("Escriu un nombre: ");
            num = Convert.ToInt32 (Console.ReadLine());
            int i = num;
            Console.WriteLine(DeterminarPrimRec(num, count, i));
        }
        public static bool DeterminarPrimIt (int num)
        {
            int count = 0;
            for (int i = num; i > 0; i--)
            {
                if (num%i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else return false;
        }
        public static bool DeterminarPrimRec (int num, int count, int i)
        {
            if (i == 0)
            {
                if (count == 2)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                if ((num % i) == 0)
                {
                    count++;
                }
                return DeterminarPrimRec(num, count, i -1);

            }
        }
    }
}