using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MetlinFitnessAssistent.Classes
{
    public class Validation
    {
        public static bool Password(string pass)
        {
            if(pass.Length<8||pass.Length>20)
            {
                return false;
            }
            string space = " ";
            if (pass.IndexOfAny(space.ToCharArray()) >= 1)
            {
                return false;
            }
            string nums = "0123456789";
            if (pass.IndexOfAny(nums.ToCharArray()) == -1)
            {
                return false;
            }
            string specSymb = "!\"#$%&'()*+,-./::<=>?@[\\]:_{|}";
            if (pass.IndexOfAny(specSymb.ToCharArray()) == -1)
            {
                return false;
            }
            string upSymb = "ABCDEFGHIJKLMNOPRSTUVWXYZ";
            if (pass.IndexOfAny(upSymb.ToCharArray()) == -1)
            {
                return false;
            }
            string lowSymb = "abcdefghijklmnoprstuvwxyz";
            if (pass.IndexOfAny(lowSymb.ToCharArray()) == -1)
            {
                return false;
            }
            return true;

        }

        public static bool Login(string login)
        {
            string space = " ";
            if (login.IndexOfAny(space.ToCharArray()) >= 1)
            {
                return false;
            }
            if (AppData.Context.User.Where(i=> i.Login==login).FirstOrDefault()!=null)
            {
                return false;
            }
            if (login.Length<2 || login.Length>50)
            {
                return false;
            }
            return true;

        }

        public static bool Name(string name)
        {
            string Symbs = "!\"#$%&'()*+,-./::<=>?@[\\]:_{|}0123456789 ";
            if (name.IndexOfAny(Symbs.ToCharArray()) >= 1 || name.Length<1)
            {
                return false;
            }         
            return true;
        }

        public static bool HeightAndWeight(string height)
        {
            if (int.TryParse(height, out int intheight)&& intheight>10 && intheight<300)
            {
                return true;
            }
            return false;                      
        }
        public static bool Birth(String birth)
        {
            if(Convert.ToDateTime(birth) >= DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
