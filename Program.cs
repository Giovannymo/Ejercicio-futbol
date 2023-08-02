namespace Federacion_Ejercicio;

internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador= new Jugador("Milthon",22,"Floridablanca","Delantero",9);
        bool next = true;
        jugador.Entrenar();
        jugador.Salud();
        jugador.CambioPosicion("arquero");

        do{
            int Option = 0;
            switch(Option){
                case 0: 
                    next = false;             
                break;
            }

        }while(next);


    }
}