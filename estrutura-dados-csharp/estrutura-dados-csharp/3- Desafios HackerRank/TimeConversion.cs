using System;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class TimeConversion
    {
        public string CalculateTime(string paramHora)
        {
            string[] arrHora;
            var horaFormatada = 0.00;
            var posicaoHora = 0;
            var horaFinal = string.Empty;
            string horaResult = string.Empty;
            var stringConcat = string.Empty;

            horaResult = paramHora.Replace("PM", " ");
            arrHora = horaResult.Split(':');


            if (paramHora.Contains("PM"))
            {
                horaResult = CalculaHoraPM(posicaoHora, horaResult, arrHora, horaFormatada);
            }
            else
            {
                horaResult = CalculaHoraAM(posicaoHora, horaResult, arrHora, horaFormatada, stringConcat, paramHora);
            }

            return horaResult;
        }

        public string CalculaHoraPM(int posicaoHora, string horaResult, string[] arrHora, double horaFormatada)
        {
            posicaoHora = Convert.ToInt32(horaResult.Substring(0, 2));

            if (posicaoHora > 12)
            {
                horaResult = horaResult.Replace(arrHora[0], horaFormatada.ToString());
            }
            else
            {
                horaFormatada = Convert.ToInt32(arrHora[0]) + 12;
                horaResult = horaResult.Replace(arrHora[0], horaFormatada.ToString());
            }

            return horaResult;
        }

        public string CalculaHoraAM(int posicaoHora, string horaResult, string[] arrHora, double horaFormatada, string stringConcat, string paramHora)
        {
            horaResult = paramHora.Replace("AM", " ");
            posicaoHora = Convert.ToInt32(horaResult.Substring(0, 2));

            if (posicaoHora < 12)
            {
                horaFormatada = Convert.ToInt32(arrHora[0]) + 12;
            }
            else if (posicaoHora > 12)
            {
                horaFormatada = Convert.ToInt32(arrHora[0]) - 12;
                stringConcat = "0" + horaResult;
                horaResult = stringConcat;
            }
            else if (posicaoHora == 0 || posicaoHora == 12)
            {
                horaResult = horaResult.Replace(arrHora[0], horaFormatada.ToString());
                stringConcat = "0" + horaResult;
                horaResult = stringConcat;
            }

            return horaResult;
        }
    }
}
