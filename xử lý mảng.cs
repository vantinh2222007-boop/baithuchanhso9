
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Nhap chi so (0-4): ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine($"Gia tri tai arr[{index}] = {arr[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Loi: Chi so khong hop le.");
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
