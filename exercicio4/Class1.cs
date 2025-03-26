using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Lampada
    {
    private bool Ligada;

    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("A lâmpada foi ligada.");
    }

    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("A lâmpada foi desligada.");
    }

    public void MostrarEstado()
    {
        if (Ligada)
            Console.WriteLine("A lâmpada está ligada.");
        else
            Console.WriteLine("A lâmpada está desligada.");
    }
}

