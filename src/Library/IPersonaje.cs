namespace Library
{
    public interface IPersonaje
    {
        int Vida { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        int Curacion { get; set; }
        int ObtenerVida();
        int ObtenerDefensa();
        int ObtenerAtaque();
        void Atacar(IPersonaje personaje);
        void Curar(IPersonaje personaje);
        void AgregarElemento(IElemento elemento);
        void QuitarElemento(IElemento elemento);
    }
}