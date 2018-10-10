
using AutomacaoFreedomApi.Infraestrutura.Util;
using AutomacaoFreedomApi.Servico.Hardware.Interface;
using System;
using System.Diagnostics;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace AutomacaoFreedomApi.Servico.Hardware.Concreta
{
    public class MqttServico : IMqttServico
    {
        private readonly string _server;
        private readonly MqttClient _client;
        private readonly byte[] _qosLevels;

        public MqttServico(string servidor)
        {
            _server = "iot.eclipse.org"; 
            _client = new MqttClient(_server);
            _qosLevels = new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
        }

        public void Publish(string topic, object message)
        {
            Connect();

            _client.Publish(topic, SerializeUtil.SerializeObjectToByteArray(message));
        }

        public void Subscribe(string[] topics, MqttMsgPublishEventHandler eventHandler)
        {
           

            var mqttClient = new MqttClient(_server);

            mqttClient.MqttMsgPublishReceived += eventHandler;

            mqttClient.Subscribe(topics, _qosLevels);

            Connect(mqttClient);
        }

        public void Disconnect() =>
            _client.Disconnect();
        public void Disconnect(MqttClient client) =>
            client.Disconnect();

        public void Connect() =>
            _client.Connect("281712");
        public void Connect(MqttClient client) =>
            client.Connect("281712");
    }
}
