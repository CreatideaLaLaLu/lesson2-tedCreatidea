using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsinchu.Culture.Travel.Service.DataBase
{
   public class NamingRuleService
    {

        public int TestFunction(int index)
        {switch (index){case 1:break; default:break;
            }

            if (index == 0) DoTrue(); 
            else
                DoFalse();


            if(DoTrue()==true){DoTrue();}

            return (index * (index + 1) / 2);
        }


        private bool DoTrue()
        {
            return true;
        }

        private bool DoFalse()
        {
            return false;
        }



        public void TestStringFunction(string value)
        {
            string NewString = "ABCDEFG"; //新字串

            if(value !=null | value !="")value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

        }


    }
}
