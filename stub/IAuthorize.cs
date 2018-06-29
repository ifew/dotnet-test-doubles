using System;

namespace member_stub
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

    public class StubAuthorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            return true;
        }
    }
}