using Xunit;
using HelloTeacherApp.ConsoleApp;

namespace HelloTeacherApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TeacherName_ShouldBe_StanislavMarchenko()
        {
            Assert.Equal("Stanislav Marchenko", Program.TeacherName);
        }
    }
}
