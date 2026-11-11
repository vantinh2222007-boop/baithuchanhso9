
using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

class TaiKhoanNganHang
{
    public double SoDu;

    public TaiKhoanNganHang(double soDu)
    {
        SoDu = soDu;
    }

    public void RutTien(double soTien)
    {
        if (soTien > SoDu)
        {
            throw new InsufficientFundsException("So du khong du de rut tien.");
        }

        SoDu -= soTien;

        Console.WriteLine("Rut tien thanh cong.");
        Console.WriteLine("So du con lai: " + SoDu);
    }
}

class Program
{
    static void Main()
    {
        TaiKhoanNganHang tk = new TaiKhoanNganHang(5000000);

        try
        {
            Console.WriteLine("So du ban dau: " + tk.SoDu);

            Console.Write("Nhap so tien can rut: ");
            double soTien = double.Parse(Console.ReadLine());

            tk.RutTien(soTien);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Vui long nhap so.");
        }
    }
}
