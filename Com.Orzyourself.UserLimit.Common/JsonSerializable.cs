using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Com.Orzyourself.UserLimit.Common
{
    public class JsonSerializable
    {
        public static string SerializableToString(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static T DeserializeToObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public static List<T> DeserializeToObjectToList<T>(string str)
        {
            return JsonConvert.DeserializeObject<List<T>>(str);
        }

    }
}
