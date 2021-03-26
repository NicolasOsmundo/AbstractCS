using System;
public abstract class ClasseBase
{
    public virtual void Metodo()
    {
        Console.WriteLine("Método ClasseBase");
    }
    public abstract void MetodoAbstrato();
}
public class Derivada: ClasseBase
{
    public override void Metodo()
    {
        Console.WriteLine("Método Derivado");
    }
    public override void MetodoAbstrato()
    {
        Console.WriteLine("Metodo MetodoAbstrato");    
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Derivada b = new Derivada();
        b.Metodo();
        ClasseBase c = new Derivada();
        c.Metodo();
        c.MetodoAbstrato();
        Console.Read();
    }
}
