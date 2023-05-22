using System;
using System.Collections.Generic;

namespace Library
{
    public interface IPersonajeMagico : IPersonaje
    {
        public void AgregarHechizo(Hechizo hechizo);
        public void BorrarHechizo(Hechizo hechizo);
        public void AgregarElementoMagico(IItemMagico item);
        public void BorrarElementoMagico(IItemMagico item);
    }
}