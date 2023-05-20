using System;
using System.Collections.Generic;

namespace Library
{
    public interface IPersonajeMagico : IPersonaje
    {
        public void AgregarHechizo(string hechizo);
        public void BorrarHechizo(string hechizo);
        public void AgregarElementoMagico(string item);
        public void BorrarElementoMagico(string item);
    }
}