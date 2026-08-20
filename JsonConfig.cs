using System;
using System.Text.Json;

namespace ContactManagementSystem
{
    static class JsonConfig
    {
        public static readonly JsonSerializerOptions Options = new JsonSerializerOptions { WriteIndented = true };
    }

}
