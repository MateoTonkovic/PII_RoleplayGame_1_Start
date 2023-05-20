namespace Library
{
    public interface IPersonaje
    {
        int Vida { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        int PuntosDeVictoria { get; set; }
        int ObtenerVida();
        int ObtenerDefensa();
        int ObtenerAtaque();
        void AgregarElemento(IElemento elemento);
        void QuitarElemento(IElemento elemento);
        void Curar(int vida);
        void RecibirAtaque(int ataque);

    }
}