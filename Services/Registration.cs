using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Registration
    {
        public static void signUp(string login, string pswd, string role)
        {
            //string path = "base.txt";
            //File.AppendAllText(path, login);
            //File.AppendAllText(path, ":");
            //File.AppendAllText(path, pswd);
            //File.AppendAllText(path, "\n");

            RegBase.createRegBase();
            RegBase.insertLoginAndPassword(login, pswd, role);
        }

        public static void signIn(string login, string pswd)
        {

        }
    }
}
