class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arreglo);

        string direccion = SolicitarDireccion();
        int posiciones = SolicitarPosiciones();

        if (direccion == "izquierda")
        {
            RotarIzquierda(ref arreglo, posiciones);
        }
        else if (direccion == "derecha")
        {
            RotarDerecha(ref arreglo, posiciones);
        }
        else
        {
            Console.WriteLine("Dirección no válida. Se usará la dirección por defecto (izquierda).");
            RotarIzquierda(ref arreglo, posiciones);
        }

        Console.WriteLine("\nArreglo rotado:");
        ImprimirArreglo(arreglo);
    }

    static string SolicitarDireccion()
    {
        Console.Write("\nIngrese la dirección (izquierda/derecha): ");
        return Console.ReadLine().ToLower();
    }

    static int SolicitarPosiciones()
    {
        Console.Write("Ingrese el número de posiciones a rotar: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void RotarIzquierda(ref int[] arreglo, int posiciones)
    {
        int n = arreglo.Length;
        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            temp[(i + n - posiciones) % n] = arreglo[i];
        }
        Array.Copy(temp, arreglo, n);
    }

    static void RotarDerecha(ref int[] arreglo, int posiciones)
    {
        int n = arreglo.Length;
        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            temp[(i + posiciones) % n] = arreglo[i];
        }
        Array.Copy(temp, arreglo, n);
    }

    static void ImprimirArreglo(int[] arreglo)
    {
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
