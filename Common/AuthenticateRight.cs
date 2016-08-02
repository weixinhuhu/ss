using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class AuthenticateRight
    {
        public static bool AuthOperation(int operationId)
        {
            if(CommonClass.UserRightList == null)
                return false;
            return CommonClass.UserRightList.Contains(operationId);

        }
    }
}
