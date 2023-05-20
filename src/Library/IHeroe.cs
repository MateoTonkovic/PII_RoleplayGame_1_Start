using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    // Your additional using statements go here
    
    public interface IHeroe : IPersonaje
    {
        int Vida { get; set; }
        int Ataque { get; set; }
        int ValorPuntosDeVictoria { get; set; }
        int Defensa { get; set; }

        int ObtenerVida();
        int ObtenerDefensa();
        int ObtenerAtaque();
        void Atacar(IPersonaje personaje);
        void AgregarElemento(IElemento elemento);
        void QuitarElemento(IElemento elemento);
        void ObtenerValorPuntosDeVictoria();
        void AgregarPuntosDeVictoria(int puntosDeVictoria);
    
    }
}
