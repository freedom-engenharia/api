using AutomacaoFreedomApi.Servico.Hardware.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoFreedomApi.Infraestrutura.Mqtt
{
    public static class MqttRun
    {
        public static void Initialize()
        {
            MqttSubscribers.Run();
        }
    }
}
