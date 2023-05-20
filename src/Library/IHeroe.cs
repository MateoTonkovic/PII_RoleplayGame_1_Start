using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    // Your additional using statements go here
    
    public interface IHeroe : IPersonaje
    {
        int ObtenerValorPuntosDeVictoria();
        void AgregarPuntosDeVictoria(int puntosDeVictoria);
    
    }
}
