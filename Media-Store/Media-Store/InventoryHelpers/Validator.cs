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
                return ErrorCodes.INVALID_IDENTIFER;
            if (!CheckInputsize(toValidate[0]))
                return ErrorCodes.INVALID_IDENTIFER;
            if (!CheckInputsize(toValidate[1]))
                return ErrorCodes.INVALID_NAME;
            if (!IntParsing(toValidate[2]))
                return ErrorCodes.INVALID_PRICE;
            if (Int32.Parse(toValidate[2]) > Int32.MaxValue || Int32.Parse(toValidate[2]) < 0)
                return ErrorCodes.INVALID_PRICE;
            if (!CheckInputsize(toValidate[3]))
                return ErrorCodes.INVALID_PUBLISHER;
            if (!CheckInputsize(toValidate[4]))
                return ErrorCodes.INVALID_ENTRY5;
            return ErrorCodes.SUCCESS;
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
        internal bool withinRange(int i)
        {
            if(i<0 || i > 999)
            {
                return false;
            }
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
