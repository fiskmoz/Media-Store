using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{

    public static class ErrorCodes
    {
        public const Int32 INVALID_IDENTIFER = 0;
        public const Int32 INVALID_NAME = 1;
        public const Int32 INVALID_PRICE = 2;
        public const Int32 INVALID_PUBLISHER = 3;
        public const Int32 INVALID_ENTRY5 = 4;
        public const Int32 INVALID_ENTRY6 = 5;
        public const Int32 INVALID_REMOVE_TARGET = 6;
        public const Int32 INVALID_ADD_COPIES = 7;
        public const Int32 INVALID_ADD_TARGET = 8;
        public const Int32 INVALID_BUY_COPIES = 9;
        public const Int32 INVALID_BUY_TARGET = 10;
        public const Int32 INVALID_PRODUCT_BELOW_ZERO = 11;
        public const Int32 INVALID_OUTOFRANGE = 12;
        public const Int32 SUCCESS = 14;

        public const char SEPARATOR = ':';

    }
}
