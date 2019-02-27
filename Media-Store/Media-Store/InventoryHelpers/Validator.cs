using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class Validator
    {

        public Validator()
        {

        }
        internal int CreateValidation(List<string> toValidate, List<Product> comparision)
        {
            if (!CheckDuplicates(comparision, toValidate[0]))
                return 0;
            if (!CheckInputsize(toValidate[0]))
                return 0;
            if (!CheckInputsize(toValidate[1]))
                return 1;
            if (!IntParsing(toValidate[2]))
                return 2;
            if (Int32.Parse(toValidate[2]) > Int32.MaxValue || Int32.Parse(toValidate[2]) < 0)
                return 2;
            if (!CheckInputsize(toValidate[3]))
                return 3;
            if (!CheckInputsize(toValidate[4]))
                return 4;
            return 10;
        }

        private bool CheckDuplicates(List<Product> products, string ID)
        {
            foreach (Product prod in products)
            {
                if (prod.uniqueID == ID)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckInputsize(string str)
        {
            if (str.Length > 20 || str.Length < 2)
                return false;
            return true;
        }

        internal bool IntParsing(string str)
        {
            try
            {
                Int32.Parse(str);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private bool FloatParsing(string str)
        {
            try
            {
                float.Parse(str);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
