using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoFreedomApi.Infraestrutura.Util
{
    public class StringConfiguracao
    {
        public DateTime pegaDataDaRespostaGetDevice(string valor) {

            string novaString = valor.Substring(0, 21);

            return converteStringEmDataTime(novaString);
        }

        public DateTime converteStringEmDataTime(string valor) {

            DateTime data = DateTime.Parse(valor);

            return data;
        }
    }
}
