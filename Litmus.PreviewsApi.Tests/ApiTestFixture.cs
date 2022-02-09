using NUnit.Framework;
using System;
using System.Net;
using System.Security.Authentication;

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

        /// <summary>
        /// Golden path smoke test to make sure the api client can retrieve a completed result.
        /// </summary>
        /// <param name="resultId"></param>
        [Test]
        [TestCase(-1)]
        public void IsGetResultWorking(long resultId = 0)
        {
            if (resultId <= 0)
            {
                throw new ArgumentException("You need to supply a result id that you have access to for this test to work.");
            }
            var api = new Apis.Previews.PreviewsApi(ApiKey, ApiPassword);
            var result = api.GetTestResult(resultId);
            Assert.NotNull(result);
            Assert.AreEqual(resultId, result.Id);
        }

        /// <summary>
        /// Golden path smoke test to make sure the api client can retrieve a completed test.
        /// </summary>
        /// <param name="testId"></param>
        [Test]
        [TestCase(-1)]
        public void IsGetTestWorking(int testId = 0)
        {
            if (testId <= 0)
            {
                throw new ArgumentException("You need to supply a email test id that you have access to for this test to work.");
            }
            var api = new Apis.Previews.PreviewsApi(ApiKey, ApiPassword);
            var test = api.GetEmailTest(testId);
            Assert.NotNull(test);
            Assert.AreEqual(testId, test.Id);
        }
    }
}