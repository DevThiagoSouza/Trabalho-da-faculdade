using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engenharia_SoftWare_modern
{
    class Login
    {

        public string login { get; set; }
        public string senha { get; set; }

        public Login(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }
    }
}
