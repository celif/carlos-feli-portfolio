using NUnit.Framework;
using System.Web.Optimization;
using BundleConfig;

namespace Testing
{
    public class Tests
    {
        [Test]
        public void RegisterBundleCollectionTest()
        {
            // There should be 5 newly registered bundles, if not, the test fails.
            int numberOfRegisteredBundles = 0;

            BundleConfig.BundleClass testBundle = new BundleConfig.BundleClass();
            BundleCollection testCollection = new BundleCollection();

            numberOfRegisteredBundles = BundleConfig.BundleClass.RegisterBundles(testCollection);

            if (numberOfRegisteredBundles != 5)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }
    }
}