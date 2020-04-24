using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class UserForLoginDto :IDto //Yarın bir gün apiden ayrıldığımız zaman ortak kullanabilelim. MVC modelleri genelde Arayüzü ile alakalı olmalı. Örn Combobox değerleri. Genel modelse backende koymamız lazım.
    {
        public string  Email { get; set; }

        public string  Password { get; set; }
    }
}
