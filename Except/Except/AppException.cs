using System;
using System.Collections.Generic;
using System.Text;

namespace Except
{
    class AppException : Exception
    {
        public string MethodName { get; set; }
    }
}
