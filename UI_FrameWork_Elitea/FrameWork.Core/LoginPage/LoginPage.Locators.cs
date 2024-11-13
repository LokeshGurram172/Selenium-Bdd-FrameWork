using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.Core.LoginPage
{
    partial class LoginPage
    {
         private readonly By _userName = By.Id("user-name");
         private readonly By _password = By.Id("password");
         private readonly By _loginbtn = RelativeBy.WithLocator(By.TagName("input")).Below(By.Id("password"));
         private readonly By _errorMsg = By.XPath("//button[@class='error-button']");
         private readonly By _productPage = By.XPath("//span[text()='Products']");
    }
}
