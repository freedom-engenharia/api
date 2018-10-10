using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Infraestrutura.Constantes;
using AutomacaoFreedomApi.Infraestrutura.mqtt.Utils;
using AutomacaoFreedomApi.Infraestrutura.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AutomacaoFreedomApi.Servico.Hardware.Concreta
{
    public static class MqttSubscribe{
        public static void Run() =>
               MqttUtils.Subscribe(TopicosMqtt.DEVICESGETALL, EventHandler);

        private static void EventHandler(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                var msg = SerializeUtil.DeserializeByteArrayToObject<FreedomBoard>(e.Message);


                var testes = msg.tipo;

            }
            catch (Exception ex)
            {

            }
        }


    }

}
