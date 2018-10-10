using AutomacaoFreedomApi.Servico.Hardware.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AutomacaoFreedomApi.Infraestrutura.mqtt.Rum
{
    public class MqttRun
    {
        public static void Inicializar()
        {
            MqttSubscribe.Run();          
        }

    }

}