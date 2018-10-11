using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoFreedomApi.Infraestrutura.Constantes
{
    public class MqttConstantes
    {
        public static readonly string[] TOPICO_SUBSCRIBERS = new string[] { "FREEDOMBOARD/RESPOSTA/GETALL/API" };
        public static readonly string MQTT_SERVER = "broker.hivemq.com";
    }
}
