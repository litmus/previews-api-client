using System.Net;
using System.Security.Authentication;
using NUnit.Framework;

namespace Litmus.PreviewsApi.Tests
{
    [TestFixture]
    public class ApiTestFixture
    {
        private const string ApiKey = "";
        private const string ApiPassword = "";

        [OneTimeSetUp]
        public void SetUp()
        {
            if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(ApiPassword))
            {
                throw new AuthenticationException("You need to supply and Api Key and Pasword to run this test.");
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        /// <summary>
        /// Golden path smoke test to make sure the api client is working as expected.
        /// </summary>
        [Test]
        public void IsPreviewsClientWorking()
        {
            var api = new Apis.Previews.PreviewsApi(ApiKey, ApiPassword);
            var applications = api.GetEmailTestingApplications();

            Assert.That(applications, Is.Not.Null);
            Assert.That(applications.Count, Is.GreaterThan(0));
        }
    }
}