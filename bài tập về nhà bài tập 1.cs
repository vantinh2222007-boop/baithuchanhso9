
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> ds = new List<int>();

        try
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 5)
            {
                throw new Exception("Danh sach phai co it nhat 5 so.");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so thu " + (i + 1) + ": ");
                int x = int.Parse(Console.ReadLine());
                ds.Add(x);
            }

            if (ds.Count == 0)
            {
                throw new Exception("Danh sach rong.");
            }

            double tong = 0;

            foreach (int x in ds)
            {
                tong += x;
            }

            double tbc = tong / ds.Count;

            Console.WriteLine("Trung binh cong: " + tbc);
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Vui long nhap so nguyen.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }
}
