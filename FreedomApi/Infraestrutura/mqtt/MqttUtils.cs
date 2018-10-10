using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace AutomacaoFreedomApi.Infraestrutura.mqtt.Utils
{
    public static class MqttUtils
    {
       
        public static void Subscribe(string[] topics, MqttMsgPublishEventHandler eventHandler)
        {
            var qosLevels = new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };

            var mqttClient = new MqttClient("broker.hivemq.com");
            mqttClient.MqttMsgPublishReceived += eventHandler;
            mqttClient.Subscribe(topics, qosLevels);

            mqttClient.Connect(Guid.NewGuid().ToString());
        }
    }
}