using System;
using Moq;
using Xunit;

namespace member_mock
{
    public class MemberTest
    {
        [Fact]
        public void When_Member_Access_to_Profile() {
            MockAuthorize mock = new MockAuthorize();
            Member member = new Member(mock);
            string is_authorized = member.Profile();

            Assert.True(mock.VerifyCheckAuthorize());
            Assert.Equal("Welcome to member area", is_authorized);
        }

        [Fact]
        public void When_Member_Access_to_Profile_By_Using_Moq() {
            var mock = new Mock<IAuthorize>();
            mock.Setup(auth => auth.CheckAuthorize(It.IsAny<string>(), It.IsAny<string>())).Returns(true).Verifiable();
            
            Member member = new Member(mock.Object);

            mock.Verify(auth => auth.CheckAuthorize(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}