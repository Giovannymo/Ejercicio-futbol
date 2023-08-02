namespace Federacion_Ejercicio;
public class Jugador : Federacion
{   
    
    private string PosicionJuego { get; set; }
    private int Dorsal { get; set; }
    
    public Jugador(string Nombre, int Edad, string CiudadOrigen, string _PosicionJuego, int _Dorsal ):base(Nombre, Edad, CiudadOrigen)
    {
        this.Id = Guid.NewGuid().ToString();
        this.PosicionJuego = _PosicionJuego;
        this.Dorsal = _Dorsal;
    }

    public void Entrenar(){
         Console.WriteLine($"Soy {this.Nombre} y estoy entrenando");
    }
    public void Salud(string salud = "estable"){
        Console.WriteLine($"El estado de salud de {this.Nombre} es {salud}");
    }
    public void CambioPosicion(string NuevaPosicion){
        this.PosicionJuego = NuevaPosicion;
        Console.WriteLine($"El jugador {this.Nombre} ahora juega en la posición {this.PosicionJuego}");
    }


}
