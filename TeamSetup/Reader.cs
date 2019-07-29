using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TeamSetup
{
    public class Reader
    {
        public List<People> Read(string filePath)
        {
            return JsonConvert.DeserializeObject<List<People>>(File.ReadAllText(filePath));
        }
    }
}
