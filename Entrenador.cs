
namespace Federacion_Ejercicio;

public class Entrenador : Federacion
{
    private string Especialidad { get; set; }
    private int CodigoFederacion { get; set; }
    public Entrenador(string Nombre, int Edad, string CiudadOrigen, string _Especialidad, int _CodigoFederacion ): base(Nombre, Edad, CiudadOrigen){
        this.Id =  Guid.NewGuid().ToString();
        this.Especialidad = _Especialidad;
        this.CodigoFederacion = _CodigoFederacion;
    }

    public void Dirigir(){
        Console.WriteLine($"El técnico {this.Nombre} está dirigiendo.");
    }

}