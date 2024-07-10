using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//lamtuandat
//2033212004
namespace _2033212004_lamtuandat
{
    internal class Nhan2SoNguyenLon
    {
        static void Main()
        {
            Console.Write("Nhap so nguyen lon thu nhat: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen lon thu hai: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            BigInteger result = num1 * num2;

            Console.WriteLine($"\nKet qua cua phep nhan la: {result}");
        }
    }
}
