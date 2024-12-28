
using BlazorApp1.web.Pages;
using Bunit;

namespace TestProject1
{
    public class Tests: IDisposable
    {

        private Bunit.TestContext _ctx;

        [SetUp]
        public void Setup()
        {
            _ctx = new Bunit.TestContext();
        }

        [TearDown]
        public void TearDown()
        {
            _ctx.Dispose();
        }

        [Test]
        public void CounterStartsAtZero()
        {
            // Arrange
            var component = _ctx.RenderComponent<Counter>();

            // Act
            var initialCount = component.Find("p").TextContent;

            // Assert
            Assert.AreEqual("Current count: 0", initialCount);
        }

        [Test]
        public void ClickingButtonIncrementsCounter()
        {
            // Arrange
            var component = _ctx.RenderComponent<Counter>();

            // Act
            component.Find("button").Click();
            var incrementedCount = component.Find("p").TextContent;

            // Assert
            Assert.AreEqual("Current count: 1", incrementedCount);
        }

        public void Dispose()
        {
            ((IDisposable)_ctx).Dispose();
        }
        //    [SetUp]
        //    public void Setup()
        //    {
        //    }

        //    [Test]
        //    public void Test1()
        //    {
        //        // Arrange
        //        using var ctx = new TestContext();
        //        var component = ctx.RenderComponent<MyBlazorApp.Pages.Counter>();

        //        // Act
        //        var initialCount = component.Find("p").TextContent;

        //        // Assert
        //        Assert.Equal("Current count: 0", initialCount);
        //        // Assert.Pass();
        //    }
    }
}