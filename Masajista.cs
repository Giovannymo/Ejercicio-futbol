namespace Federacion_Ejercicio;
public class Masajista : Federacion
{
    private string Titulacion { get; set; }
    private int AñosExperiencia { get; set; }
    public Masajista(string Nombre, int Edad, string CiudadOrigen, string _Titulacion, int _AñosExperiencia):base(Nombre,Edad,CiudadOrigen){
        this.Id =Guid.NewGuid().ToString();
        this.Titulacion = _Titulacion;
        this.AñosExperiencia = _AñosExperiencia;
    }

    public void TipoMasaje(string Tipo = " calentamiento"){
        Console.WriteLine($"El tipo de masaje aplicado es: {Tipo}");
    }
    public void Tecnica(string Tecnica = "amasamiento"){
        Console.WriteLine($"La tecnica de masaje aplicado es: {Tecnica}");
    }

}