using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lamtuandat
//2033212004
namespace _2033212004_lamtuandat
{
    class MergeSort
    {
        const int MAX = 100;

        static void NhapMang(int[] a, int n)
        {
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

        static void Merge(int[] a, int l, int m, int r)
        {
            int[] b = new int[r - l + 1];
            int i = l, j = m + 1, k = 0;

            while (i <= m && j <= r)
            {
                if (a[i] <= a[j])
                {
                    b[k++] = a[i++];
                }
                else
                {
                    b[k++] = a[j++];
                }
            }

            while (i <= m)
            {
                b[k++] = a[i++];
            }

            while (j <= r)
            {
                b[k++] = a[j++];
            }

            for (k = 0; k < b.Length; k++)
            {
                a[l + k] = b[k];
            }
        }

        static void MergeSortAlgorithm(int[] a, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r) / 2;
                MergeSortAlgorithm(a, l, mid);
                MergeSortAlgorithm(a, mid + 1, r);
                Merge(a, l, mid, r);
            }
        }

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            NhapMang(a, n);

            Console.WriteLine("\nMang chua duoc sap xep: ");
            XuatMang(a, n);

            MergeSortAlgorithm(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi duoc sap xep: ");
            XuatMang(a, n);
        }
    }
}
