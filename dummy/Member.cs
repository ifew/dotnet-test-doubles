using System;

namespace member
{
    public class Member
    {
        Boolean authorized;

        public Member(IAuthorize authorize) {
            this.authorized = authorize.CheckAuthorize("ifew", "1234");
        }

        public string Profile() {
            return "Welcome to member area";
        }
    }
}