using System;

namespace DXS_CSHARP_fundamentals.API
{
    internal class DateTimesAndTimesPan
    {
        public static void Execute()
        {
            //DATETIME
            DateTime hoje = DateTime.Now;
            DateTime primeiraData = DateTime.MinValue;
            DateTime ultimaDate = DateTime.MaxValue;
            var dataFacilDeSerCriada = new DateTime(year: 1994, day: 8, month: 6);
            Console.WriteLine(dataFacilDeSerCriada.AddDays(790));
            Console.WriteLine(dataFacilDeSerCriada.AddMonths(435));
            Console.WriteLine("ONTEM: " + (hoje.AddDays(-1)).ToString("dd"));
            Console.WriteLine("ONTEM: " + (hoje.AddDays(-1)).ToString("D"));
            Console.WriteLine("ONTEM: " + (hoje.AddDays(-1)).ToString("g"));
            Console.WriteLine("ONTEM: " + (hoje.AddDays(-1)).ToString("dd-MM-yyyy HH_mm"));
            Console.WriteLine(primeiraData.ToString() + " - " + hoje.ToString() + " - " + ultimaDate.ToString() + " | " + dataFacilDeSerCriada.ToString());

            //TIMESPAN
            var intervalo = new TimeSpan(days:10, hours:23, minutes:4, seconds: 2531);
            Console.WriteLine("TIMESPAN: " + intervalo.TotalDays.ToString());
            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddHours(7.8);
            //RESULTADO DE OPERACAO ENTRE DATETIMES = TIMESPAN
            intervalo = chegada - largada;
            Console.WriteLine("A MARATONA DUROU: " + intervalo.TotalHours.ToString("F2") + "hs");
            //A CADA ADD RETORNA UM NOVO TIMESPAN | OTIMO PARA CALCULAR E EXIBIR SEM ALTERAR O ORIGINAL
            intervalo = intervalo.Subtract(TimeSpan.FromHours(4));
            Console.WriteLine("A MARATONA DESSA VEZ DUROU: " + intervalo.TotalHours.ToString("F2") + "hs");
            //CONVERTER EM INTERVALO DE TEMPO [TIMESPAN]
            Console.WriteLine("Convertido: " + TimeSpan.Parse("10:10:10").TotalHours);
        }
    }
}
