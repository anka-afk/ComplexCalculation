using System;


public static class TestComplex
{
    public static void Main()
    {
        Complex comp1 = new Complex(100,100);
        Complex comp2 = new Complex(300,300);
        Console.WriteLine(comp2 + comp1);
        Console.WriteLine(comp2 + 100);
        Console.WriteLine(100 + comp2);
        Console.WriteLine(comp2 * comp1);
        Console.WriteLine(comp2 * 100);
        Console.WriteLine(100 * comp2);
        Console.WriteLine(comp2 - comp1);
        Console.WriteLine(comp2 - 100);
        Console.WriteLine(100 - comp2);
        Console.WriteLine(comp2 / comp1);
        Console.WriteLine(comp2 / 100);
        Console.WriteLine(100 / comp2);
    }
}

public class Complex
{
    decimal real;
    decimal imaginary;

    public override string ToString()
    {
        return $"{real}+{imaginary}i";
    }
    public Complex(decimal real,decimal imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public static Complex operator +(Complex c1,Complex c2)
    {
        decimal real = c1.real + c2.real;
        decimal imaginary = c1.imaginary + c2.imaginary;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator +(Decimal d,Complex c)
    {
        decimal real = d + c.real;
        decimal imaginary = c.imaginary;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator +(Complex c,Decimal d)
    {
        decimal real = d + c.real;
        decimal imaginary = c.imaginary;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator *(Complex c1,Complex c2)
    {
        decimal real = c1.real * c2.real - c1.imaginary * c2.imaginary;
        decimal imaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator *(Complex c1,decimal d)
    {
        decimal real = c1.real * d;
        decimal imaginary = c1.imaginary * d;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator *(decimal d,Complex c1)
    {
        decimal real = c1.real * d;
        decimal imaginary = c1.imaginary * d;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator -(Complex c1,Complex c2)
    {
        return c1 + (c2 * -1);
    }
    public static Complex operator -(decimal d,Complex c1)
    {
        return d + (c1 * -1);
    }
    public static Complex operator -(Complex c1,decimal d)
    {
        return c1 + (d * -1);
    }
    public static Complex operator /(Complex c1,Complex c2)
    {
        decimal real = (c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
        decimal imaginary = (c1.imaginary * c2.real - c1.real * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator /(Complex c1,decimal d)
    {
        decimal real = c1.real / d;
        decimal imaginary = c1.imaginary / d;
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
    public static Complex operator /(decimal d,Complex c1)
    {
        decimal real = (c1.real * d) / (c1.real * c1.real + c1.imaginary * c1.imaginary);
        decimal imaginary = (c1.imaginary * -d) / (c1.real * c1.real + c1.imaginary * c1.imaginary);
        Complex complex = new Complex(real,imaginary);
        return complex;
    }
}