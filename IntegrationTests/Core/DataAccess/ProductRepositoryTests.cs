using Ebuy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.Core.DataAccess
{
    [TestClass]
    public class ProductRepositoryTests : RepositoryTestFixture<Product>
    {
        [TestMethod]
        public void ShouldSaveNewProduct()
        {
            AssertCanSaveNewEntity();
        }
    }
}