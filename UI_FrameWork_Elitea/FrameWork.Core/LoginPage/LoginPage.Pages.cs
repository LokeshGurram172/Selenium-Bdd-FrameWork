using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Core.LoginPage
{
    partial class LoginPage
    {
        public void EnterUsername(string username)
        {
            DriverUtility.EnterText(_userName, username);
        }

        public void EnterPassword(string password)
        {
            DriverUtility.EnterText(_password, password);
        }

        public void ClickLoginButton()
        {
            DriverUtility.Click(_loginbtn);
        }

        public bool IsErrorMessageVisible()
        {
            return DriverUtility.IsElementVisible(_errorMsg);
        }

        public bool IsProductPageVisible()
        {
            return DriverUtility.IsElementVisible(_productPage);
        }
    }
}
