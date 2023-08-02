namespace Federacion_Ejercicio;

public class Federacion
{
    public string Id {get;  set;}
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public string CiudadOrigen {get; set;}


    public Federacion ( string _Nombre, int _Edad, string _CiudadOrigen){
        this.Id =Guid.NewGuid().ToString();
        this.Nombre = _Nombre;
        this.Edad = _Edad;
        this.CiudadOrigen = _CiudadOrigen;
    }

   

}
