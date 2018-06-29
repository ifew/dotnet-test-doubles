using System;
using Xunit;

namespace member_stub
{
    public class MemberTest
    {
        [Fact]
        public void When_Member_Access_to_Profile() {
            Member member = new Member(new StubAuthorize());
            string is_authorized = member.Profile();

            Assert.Equal("Welcome to member area", is_authorized);
        }
    }
}