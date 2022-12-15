using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.SOLID
{
    //Before ISP
    public interface ILogin1
    {

        void Logout();

        void ResetPassword();
    }

    public interface ILogin
    {
        void Register();
        void Login();
    }

    public interface IForgotPassword
    {
        void ForgotPassword();
    }

    public class RegisterNewCustomer : ILogin, IForgotPassword
    {
        public void ForgotPassword()
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void ResetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
