using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenAPIMASTERCreate.Model
{
    public class Data
    {
        #pragma warning disable S1104 // Fields should not have public accessibility
        public Dictionary<string, string> user = new Dictionary<string, string>
        {
            {"Sample","password"},
            {"Direct","password" }
        };
        #pragma warning restore S1104 // Fields should not have public accessibility

    }
}
