using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFreedomApi.Infraestrutura.Util
{
    public class SerializeUtil
    {
        public static byte[] SerializeObjectToByteArray(object obj)
        {
            var json = SerializeObjectToString(obj);

            return Encoding.Default.GetBytes(json);
        }

        private static string SerializeObjectToString(object obj)
        {
            var setting = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

            return JsonConvert.SerializeObject(obj, Formatting.None, setting);
        }
    }
}
