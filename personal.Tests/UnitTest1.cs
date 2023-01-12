using Microsoft.VisualStudio.TestTools.UnitTesting;
using personal.Controllers;

namespace personal.Tests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void Test1()
        {
            DefaultApiController _controller = new DefaultApiController();
            
            try
            {
                Microsoft.AspNetCore.Mvc.ObjectResult result = (Microsoft.AspNetCore.Mvc.ObjectResult)_controller.PersonalStatusGet();
                Assert.IsNotNull(result.Value);
            }
            catch
            {
                Assert.Fail();
            }

        }
    }
}