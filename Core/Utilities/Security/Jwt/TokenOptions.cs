using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
  public  class TokenOptions
    {
        public string Audience { get; set; }//Tokenimizin kullanıcı kitlesi.
        public string Issuer { get; set; } //İmzalayıcı
        public int AccessTokenExpiration { get; set; }

        public string SecurityKey { get; set; }

    }
}
