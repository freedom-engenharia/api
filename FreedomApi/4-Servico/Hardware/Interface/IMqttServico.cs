
using uPLibrary.Networking.M2Mqtt;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace AutomacaoFreedomApi.Servico.Hardware.Interface
{
    public interface IMqttServico
    {
        void Connect();
        void Connect(MqttClient client);
        void Disconnect();
        void Disconnect(MqttClient client);
        void Publish(string topic, object message);
        void Subscribe(string[] topics, MqttMsgPublishEventHandler eventHandler);
    }
}
