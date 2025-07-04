using Apps.AmazonTextract.Actions;
using Apps.AmazonTextract.Models.Request;
using Blackbird.Applications.Sdk.Common.Files;
using Tests.AmazonTextract.Base;

namespace Tests.AmazonTextract
{
    [TestClass]
    public class AnalysisTests : TestBase
    {
        [TestMethod]
        public async Task DetectDocumentText_ValidFile_ShouldReturnBlocks()
        {
            var action = new AnalysisActions(InvocationContext, FileManager);
            var response = await action.DetectDocumentText(new FileRequest
            {
                File = new FileReference
                {
                    Name = "Test3.png",
                }
            });

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Assert.IsNotNull(response);

        }

        [TestMethod]
        public async Task AnalyzeIdentityDocuments_ValidFile_Success()
        {
            var action = new AnalysisActions(InvocationContext, FileManager);
            var response = await action.AnalyzeIdentityDocuments(new FileRequest
            {
                File = new FileReference
                {
                    Name = "Test3.png",
                }
            });

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Assert.IsNotNull(response);

        }

        [TestMethod]
        public async Task AnalyzeExpensesDocuments_ValidFile_Success()
        {
            var action = new AnalysisActions(InvocationContext, FileManager);
            var response = await action.AnalyzeExpense(new FileRequest
            {
                File = new FileReference
                {
                    Name = "Test3.png",
                }
            });

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Assert.IsNotNull(response);

        }
    }
}
