using System.Collections.Generic;

namespace Library
{
    public interface ILibroDeHechizo
    {
        List<Hechizo> Hechizos { get; }
        void AgregarHechizo(Hechizo hechizo);
        void QuitarHechizo(Hechizo hechizo);
    }
}
