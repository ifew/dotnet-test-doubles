using System;
using Xunit;

namespace member_spy
{
    public class MemberTest
    {
        [Fact]
        public void When_Member_Access_to_Profile() {
            SpyAuthorize spy = new SpyAuthorize();
            Member member1 = new Member(spy);
            Member member2 = new Member(spy);
            string is_authorized = member1.Profile();

            Assert.Equal(2, spy.checkAuthorizeWasCalled);
        }
    }
}