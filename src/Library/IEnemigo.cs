using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public interface IEnemigo : IPersonaje
    {
        public int PuntosDeVictoria { get; set; }
        int ObtenerPuntosDeVictoria();

    }
}
