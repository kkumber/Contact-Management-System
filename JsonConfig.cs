using System;

namespace ContactManagementSystem
{
    static class JsonConfig
    {
        public static readonly JsonSerializerOptions Options = new({ WriteIndented = true })
    }

}
