using System;

public struct Coordenada
{
    public double X { get; }
    public double Y { get; }

    public Coordenada(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double CalcularDistancia(Coordenada otraCoordenada)
    {
        double distanciaX = otraCoordenada.X - X;
        double distanciaY = otraCoordenada.Y - Y;
        return Math.Sqrt(distanciaX * distanciaX + distanciaY * distanciaY);
    }

    public double CalcularAngulo(Coordenada otraCoordenada)
    {
        double deltaX = otraCoordenada.X - X;
        double deltaY = otraCoordenada.Y - Y;
        return Math.Atan2(deltaY, deltaX);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coordenada punto1 = new Coordenada(3, 4);
        Coordenada punto2 = new Coordenada(6, 8);

        Console.WriteLine("Coordenada 1: " + punto1);
        Console.WriteLine("Coordenada 2: " + punto2);

        double distancia = punto1.CalcularDistancia(punto2);
        Console.WriteLine("Distancia entre los puntos: " + distancia);

        double angulo = punto1.CalcularAngulo(punto2);
        Console.WriteLine("Ángulo entre los puntos en radianes: " + angulo);
    }
}
