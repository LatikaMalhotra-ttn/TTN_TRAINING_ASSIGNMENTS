using jwt_ass_final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_ass_final.Data
{
    public interface ITokenGeneration
    {
        string GenerateJSONWebToken(UserModel userinfo);

    }
}
