using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
  public  interface ITokenHelper //Bir gün farklı bir token aracı kullanabiliriz. O nedenle .
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);  //Kullanıcı bilgisi ve rollerini vermiş oldum.
    }
}
