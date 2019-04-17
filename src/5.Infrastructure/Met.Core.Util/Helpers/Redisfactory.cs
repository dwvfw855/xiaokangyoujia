using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mk.Chain.Core.Util.Helpers
{
    public  class Redisfactory
    {

        public static ConnectionMultiplexer GetOption()
        {
            ConfigurationOptions option = new ConfigurationOptions();
            option.EndPoints.Add("127.0.0.1", 6379);
            option.EndPoints.Add("127.0.0.1", 6380);
            option.EndPoints.Add("127.0.0.1", 6381);
            ConnectionMultiplexer sd = ConnectionMultiplexer.Connect(option);

            return sd;

        }






    }
}
