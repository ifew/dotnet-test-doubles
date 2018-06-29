using System;

namespace member
{
    public class Member
    {
        Boolean authorized;

        public Member(Authorize authorized) {
            this.authorized = authorized.CheckAuthorize("ifew", "1234");
        }

        public string Profile() {
            if(this.authorized)
                return "Welcome to member area";

            return "This not member area";
        }
    }

    public class Authorize : IAuthorize {
        public Boolean CheckAuthorize(string username, string password) {
            if(username == "ifew" && password == "1234")
                return true;

            return false;
        }
    }

    interface IAuthorize
    {
        Boolean CheckAuthorize(string username, string password);
    }
}