using System;
using System.Collections.Generic;

public class Mago<T>
{
    public string Nombre { get; set; }

    public int Vida { get; set; } = 100;

    public int Ataque { get; set; } = 10;

    public int Defensa { get; set; } = 10;

    public List<string> Items = new List<string>();

    public Mago(string nombre)
    {
        this.Nombre = nombre;
    }

    public int ObtenerDaño()
    {
        return this.Ataque;
    }

    public int ObtenerDefensa()
    {
        return this.Defensa;
    }
    public void RecibirDaño(int ataque)
    {
        int DañoTotal = ataque - this.Defensa;

        if (DañoTotal > 0)
        {
            this.Vida -= DañoTotal;
        }
    }

    public void AgregarItem(string nombreDeItem, int defensaDeItem, int ataqueDeItem)
    {
        this.Items.Add(nombreDeItem);
        this.Ataque += ataqueDeItem;
        this.Defensa += defensaDeItem;
    }

    public void RemoverItem(string nombreDeItem, int defensaDeItem, int ataqueDeItem)
    {
        this.Items.Remove(nombreDeItem);
        this.Ataque -= ataqueDeItem;
        this.Defensa -= defensaDeItem;
    }
}