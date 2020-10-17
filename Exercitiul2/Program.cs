using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Scrieti un program care sa afiseze primele 10 numere naturale.(while)

//namespace Exercitiul1
//{
//    class Program
//    {
//        static void Main(string[] args)

//        {
//            int i = 0;
//            while (i < 10)
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//            Console.ReadLine();
//        }
//    }
//}


//2.	Scrieti un program care sa afiseze suma primelor 10 numere naturale.

//    namespace Exercitiul2
//{
//    class Program
//    {
//        static void Main(string[] args)

//        {
//            int i = 0;
//            int sum = 0;
//            while (i <= 10)
//            {
//                sum = sum + i;       
//                i++;
//            }
//            Console.WriteLine(sum);
//            Console.ReadLine();
//        }
//    }
//}


// 3.Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.

//namespace Exercitiul3
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int i=1;

//            Console.WriteLine("Enter value:");
//            int n = Convert.ToInt32(Console.ReadLine());

//            while(i < n)
//            {
//                Console.WriteLine(i);
//                i++;
//            }

//            Console.ReadLine();
//        }

//    }
//}

// 4.	Cititi un numar de la tastatura.Afisati toate numerele de la 3 pana la numarul citit de voi.


//namespace Exercitiul4
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 3;

//            Console.WriteLine("Enter value:");
//            int n = Convert.ToInt32(Console.ReadLine());

//            while (i <= n)
//            {
//                Console.WriteLine(i);
//                i++;
//            }

//            Console.ReadLine();
//        }

//    }
//}

//5.	Cititi un numar de la tastatura.Afisati suma numerelor mai mici decat numarul citit de voi.


//namespace Exercitiul5
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            int sum = 0;
//            Console.WriteLine("Enter value:");
//            int n = Convert.ToInt32(Console.ReadLine());

//            while (i < n)
//            {
//                sum = sum + i;        
//                i++;
//            }
//            Console.WriteLine(sum);
//            Console.ReadLine();
//        }

//    }
//}

//6.	Afisati cubul primelor 5 numere naturale.

//namespace Exercitiul6
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int i=0;
//            int c = 1;

//            while (i < 5)
//            {
//                c = i * i * i;
//                Console.WriteLine(c);
//                i++;
//            }
//            Console.ReadLine();
//        }

//    }
//}

//7.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.


namespace Exercitiul7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter value:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (i < n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            Console.ReadLine();
        }

    }
}

