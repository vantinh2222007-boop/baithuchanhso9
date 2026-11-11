
using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhap tuoi sinh vien: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18 || age > 60)
            {
                throw new InvalidAgeException("Tuoi phai trong khoang 18 - 60.");
            }

            Console.WriteLine($"Tuoi hop le: {age}");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi: Vui long nhap so nguyen.");
        }
    }
}
