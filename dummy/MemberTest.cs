using System;
using Xunit;

namespace member_dummy
{
    public class MemberTest
    {
        [Fact]
        public void When_Called_Member_Should_Be_Object_Type_Member() {
            Member member = new Member(new DummyAuthorize());

            Assert.IsType<Member>(member);
        }
    }
}