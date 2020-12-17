﻿using System;
using Newtonsoft.Json;

namespace uiExp.Shared
{
    public static class DumpityDump
    {
        public static void Dump(this object obj)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(obj)); // your logger
        }
    }
}
