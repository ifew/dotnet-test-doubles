using System;
using Xunit;

namespace member_spy
{
    public class MemberTest
    {
        [Fact]
        public void When_Member_Access_to_Profile() {
            SpyAuthorize spy = new SpyAuthorize();
            Member member = new Member(spy);
            string is_authorized = member.Profile();

            Assert.True(spy.checkAuthorizeWasCalled);
        }
    }
}