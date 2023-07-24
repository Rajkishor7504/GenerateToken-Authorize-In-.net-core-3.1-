using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenAPIMASTERCreate.Model
{
    public interface IJWTManager
    {
        string GetToken(string username,string password);
    }
}
