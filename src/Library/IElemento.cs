public interface IElemento
{
    int Ataque { get; set; }
    int Defensa { get; set; }
    int Curacion { get; set; }
    bool EsMagico { get; set; }
}

//HAY QUE CAMBIAR IElementoAtaque + IElementoDefensa