using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview.Config
{
    public class ReadConfig
    {
        protected string ReadJson(string ToSearch)
        {
            string ReturnValue = string.Empty;
            using (StreamReader file = File.OpenText("Config\\Credentials.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);

                try
                {
                    ReturnValue = o2.GetValue(ToSearch).ToString();
                }
                catch (Exception e)
                {

                    throw new Exception("Value is null, cannot find exepected property");
                }


            }

            return ReturnValue;
        }

    }
}
