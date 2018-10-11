using AutomacaoFreedomApi.Infraestrutura.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace AutomacaoFreedomApi.Infraestrutura.Mqtt
{
    public static class MqttUtils
    {
        // Credentials
        private static readonly string _server = MqttConstantes.MQTT_SERVER;

        public static void Subscribe(string[] topics, MqttMsgPublishEventHandler eventHandler)
        {
            var qosLevels = new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };

            var mqttClient = new MqttClient(_server);
            mqttClient.MqttMsgPublishReceived += eventHandler;
            mqttClient.Subscribe(topics, qosLevels);

            mqttClient.Connect(Guid.NewGuid().ToString());
        }
    }
}
