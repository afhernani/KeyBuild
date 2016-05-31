using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBuild
{
    public class GenerarContrasenha
    {
        string password;
        public GenerarContrasenha()
        {
            password = string.Empty;
        }
        public string PassWord(int length)
        {
            return PassWord(length, false);
        }
        public String PassWord(int length, bool special)
        {

            password = string.Empty;
            int iteration = 0;
            char randomNumber;
            Random random = new Random();

            while (iteration < length)
            {
                randomNumber = (char)((Math.Floor((random.NextDouble() * 100)) % 94) + 33);
                if (!special)
                {
                    if ((randomNumber >= 33) && (randomNumber <= 47)) { continue; }
                    if ((randomNumber >= 58) && (randomNumber <= 64)) { continue; }
                    if ((randomNumber >= 91) && (randomNumber <= 96)) { continue; }
                    if ((randomNumber >= 123) && (randomNumber <= 126)) { continue; }
                }
                iteration++;
                password += randomNumber;
            }
            return password;
        }
    }
}
