using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Tests
    {
        public static void checkBD()
        {
            string login = "gg";
            string pswd = "";
            RegBase.createBase();
            RegBase.insertLoginAndPassword(login, pswd);
            RegBase.selectLoginAndPassword();
        }
    }
}
