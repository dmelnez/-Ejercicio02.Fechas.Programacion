namespace Ejercicio02.Fechas.Programacion
{


    class Program
    {
       public static void Main(string[] args)
        {

            // Fecha Actual
            DateTime fechaActual = DateTime.Now;

            //Dia
            int dia = fechaActual.Day;
            Console.WriteLine("DIA: " + dia);

            //Mes
      
            int mes = fechaActual.Month;
            Console.WriteLine("MES: " + mes);


            //Hora

            int hora = fechaActual.Hour;
            Console.WriteLine("HORAS: " + hora);

            //Minutos
            int minutos = fechaActual.Minute;
            Console.WriteLine("MINUTOS: " + minutos);

            //Segundos
            float segundos = fechaActual.Second;
            Console.WriteLine("SEGUNDOS: " + segundos);

            
            //Dia de la Semana
            var diaSemana = fechaActual.DayOfWeek;
            Console.WriteLine("DIA SEMANA: " + diaSemana);
            

            //Dia del Anio
            int diaAnio = fechaActual.DayOfYear;
            Console.WriteLine("DIA ANIO: " + diaAnio);






        }

    }

}
