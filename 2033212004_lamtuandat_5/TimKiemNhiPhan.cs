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
    internal class TimKiemNhiPhan
    {
        const int MAX = 100;

        static void NhapMang(int[] a, out int n)
        {
            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = Partition(a, left, right);
                QuickSort(a, left, s - 1);
                QuickSort(a, s + 1, right);
            }
        }

        static int Partition(int[] a, int left, int right)
        {
            int pivot = a[(left + right) / 2];
            int l = left;
            int r = right;

            while (l <= r)
            {
                while (a[l] < pivot) l++;
                while (a[r] > pivot) r--;

                if (l <= r)
                {
                    Swap(ref a[l], ref a[r]);
                    l++;
                    r--;
                }
            }
            return l;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int BinarySearch(int[] a, int left, int right, int x)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (a[mid] == x)
                    return mid;

                if (a[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            NhapMang(a, out n);
            Console.WriteLine("Mang duoc nhap:");
            XuatMang(a, n);

            QuickSort(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi sap xep la:");
            XuatMang(a, n);

            Console.Write("\nNhap so can tim: ");
            int x = int.Parse(Console.ReadLine());

            int kq = BinarySearch(a, 0, n - 1, x);
            if (kq == -1)
                Console.WriteLine($"Khong tim thay {x} trong mang");
            else
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq}");
        }
    }
}
