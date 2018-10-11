using AutomacaoFreedomApi.Infraestrutura.Constantes;
using AutomacaoFreedomApi.Infraestrutura.Mqtt;
using AutomacaoFreedomApi.Infraestrutura.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AutomacaoFreedomApi.Servico.Hardware.Concreta
{
    public class MqttSubscribers
    {
        public static void Run() =>
           MqttUtils.Subscribe(MqttConstantes.TOPICO_SUBSCRIBERS, EventHandler);

        private static void EventHandler(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {

                var objeto = SerializeUtil.DeserializeByteArrayToObject(e.Message);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
