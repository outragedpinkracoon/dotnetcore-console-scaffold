using Xunit;
using MyCats.Domain;

namespace CatTests
{
    public class CatTests
    {
        [Fact]
        public void MiaowTest() 
        {
            var cat = new Cat();
            Assert.Equal("miaow!",cat.Miaow());
        }
    }
}
