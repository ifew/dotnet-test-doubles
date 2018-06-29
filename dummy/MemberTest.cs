using System;
using Xunit;

namespace member_dummy
{
    public class MemberTest
    {
        [Fact]
        public void When_Member_Access_to_Profile() {
            Member member = new Member(new DummyAuthorize());
            string is_authorized = member.Profile();

            Assert.NotNull(is_authorized);
        }
    }
}