using System;

namespace member_spy
{
    public interface IAuthorize
    {
        Boolean CheckAuthorize(string username, string password);
    }

    public class Authorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            if(username == "ifew" && password == "1234")
                return true;

            return false;
        }
    }

    public class SpyAuthorize : IAuthorize {
        public int checkAuthorizeWasCalled = 0;

        public Boolean CheckAuthorize(string username, string password) {
            checkAuthorizeWasCalled++;
            return true;
        }
    }
}