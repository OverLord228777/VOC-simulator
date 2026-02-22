using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOC_simulator
{
    internal class Registration
    {
        public static void signUp(string login, string pswd)
        {
            string path = "base.txt";
            File.AppendAllText(path, login);
            File.AppendAllText(path, ":");
            File.AppendAllText(path, pswd);
            File.AppendAllText(path, "\n");

            RegBase.createBase();
            RegBase.insertLoginAndPassword(login, pswd);
        }
    }
}
