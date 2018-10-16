using SeleniumInterview.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview
{
    public class ReadTxt : ReadConfig
    {
        public string GetURL
        { get { return ReadJson("Url"); } }

        public string GetUsername
        { get { return ReadJson("Username"); } }

        public string GetPassword
        { get { return ReadJson("Password"); } }

    }
}
