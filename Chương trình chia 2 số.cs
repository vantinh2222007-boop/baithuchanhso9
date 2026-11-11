
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            int kq = a / b;

            Console.WriteLine($"Ket qua: {a} / {b} = {kq}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Loi: Khong the chia cho 0.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Vui long nhap so nguyen.");
        }
        finally
        {
            Console.WriteLine("Chuong trinh ket thuc.");
        }
    }
}
