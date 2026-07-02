using System;

Console.Write("Введите большую полуось эллипса: ");
double a_el = double.Parse(Console.ReadLine());
Console.Write("Введите малую полуось эллипса: ");
double b_el = double.Parse(Console.ReadLine());
Console.Write("Введите x для эллипса: ");
double x_el = double.Parse(Console.ReadLine());
Ellipse ellipse = new Ellipse(a_el, b_el, x_el);
ellipse.Print();

Console.Write("Введите a для гиперболы: ");
double a_hyp = double.Parse(Console.ReadLine());
Console.Write("Введите b для гиперболы: ");
double b_hyp = double.Parse(Console.ReadLine());
Console.Write("Введите x для гиперболы: ");
double x_hyp = double.Parse(Console.ReadLine());
Hyperbola hyperbola = new Hyperbola(a_hyp, b_hyp, x_hyp);
hyperbola.Print();

abstract class Function
{
    public abstract double F(double x);
    public abstract void Print();
}

class Ellipse : Function
{
    private double a;
    private double b;
    private double x;

    public Ellipse(double a, double b, double x)
    {
        this.a = a;
        this.b = b;
        this.x = x;
    }

    public override double F(double x)
    {
        return b * Math.Sqrt(1 - this.x * this.x / (a * a));
    }

    public override void Print()
    {
        Console.WriteLine("Эллипс: при x = " + x + " y = " + F(x).ToString("F2"));
    }
}

class Hyperbola : Function
{
    private double a;
    private double b;
    private double x;

    public Hyperbola(double a, double b, double x)
    {
        this.a = a;
        this.b = b;
        this.x = x;
    }

    public override double F(double x)
    {
        return b * Math.Sqrt(this.x * this.x / (a * a) - 1);
    }

    public override void Print()
    {
        Console.WriteLine("Гипербола: при x = " + x + " y = " + F(x).ToString("F2"));
    }
}
