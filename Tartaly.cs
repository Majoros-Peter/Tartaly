using System;

namespace WpfApp10;

class Tartaly
{
    private string nev;
    private int a, b, c;
    private double aktLiter;

    public Tartaly(String nev, int a, int b, int c)
    {
        this.nev = nev;
        this.a = a;
        this.b = b;
        this.c = c;
        aktLiter = 0;
    }
    public Tartaly(String nev)
    {
        this.nev = nev;
        a = b = c = 10;
        aktLiter = 0;
    }
    public double Terfogat { get => a * b * c; }

    public void DuplazMeretet()
    {
        int rnd = new Random().Next(3);
        if (rnd == 0) a *= 2;
        else if (rnd == 1) b *= 2;
        else c *= 2;
    }
    public void TeljesLeengedes() => aktLiter = 0;

    public double Toltottseg { get => aktLiter / Terfogat * 100000; }
    public void Tolt(double liter)
    {
        if (liter + this.aktLiter > Terfogat / 1000)
            Console.WriteLine("Ennyi nem fér bele");
        else
            aktLiter += liter;
    }

    public override string ToString()
    {
        return $"{this.nev}: {this.Terfogat * 1000:n1} cm3 = ({this.Terfogat:n2} liter)," +
            $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
            $" méretei: {this.a}x{this.b}x{this.c} cm";
    }

}