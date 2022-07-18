using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexProject;
using RegexProject.Sevice;
using System.Threading.Tasks;

namespace RegexTestProject
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public async Task TestMethod()
        {
            var url = "http://titan-diesel.com";


            var readContent = new ReadWebpage();

            await readContent.ReadWebPage(url);
        }
    }
}
