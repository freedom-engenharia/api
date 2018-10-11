using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFreedomApi.Infraestrutura.Util
{
    public class SerializeUtil
    {
 
            public static object DeserializeByteArrayToObject(byte[] array)
            {
                var json = DeserializeByteArrayToStringJson(array);

                try
                {
                    return JsonConvert.DeserializeObject(json);
                }
                catch (Exception)
                {
                    return json;
                }
            }

            public static T DeserializeByteArrayToObject<T>(byte[] array)
            {
                var json = DeserializeByteArrayToStringJson(array);

                json = json.Replace(@"\n", "").Replace(@"\", "").Trim();

                if (json.StartsWith("\""))
                    json = json.Substring(1);

                if (json.EndsWith("\""))
                    json = json.Substring(0, json.Length - 1);

                return JsonConvert.DeserializeObject<T>(json);
            }

            public static byte[] SerializeObjectToByteArray(object obj)
            {
                var json = SerializeObjectToString(obj);

                return Encoding.Default.GetBytes(json);
            }

            public static StringContent SerializeObjectToStringContent(object obj)
            {
                var setting = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Serialize };

                var json = JsonConvert.SerializeObject(obj, Formatting.None, setting);

                return new StringContent(json, Encoding.UTF8, "application/json");
            }

            private static string DeserializeByteArrayToStringJson(byte[] array) =>
                Encoding.Default.GetString(array);

            private static string SerializeObjectToString(object obj)
            {
                var setting = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

                return JsonConvert.SerializeObject(obj, Formatting.None, setting);
            }
        
    }
}
