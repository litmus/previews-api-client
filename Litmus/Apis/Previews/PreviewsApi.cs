using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using Litmus.Apis.Previews.Models;

namespace Litmus.Apis.Previews
{
    /// <summary>
    /// Summary description for PreviewsApi
    /// </summary>
    public class PreviewsApi
    {
        private readonly RestClient restClient = new RestClient("https://previews-api.litmus.com");

        public PreviewsApi(string username, string password)
        {
            restClient.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public TestingApplication GetTestResult(int id)
        {
            var request = new RestRequest("/api/v1/Result/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", id.ToString());

            var response2 = restClient.Execute<TestingApplication>(request);

            return response2.Data;
        }

        public async Task<TestingApplication> GetTestResultAsync(int id)
        {
            var request = new RestRequest("/api/v1/Result/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", id.ToString());

            var response2 = await restClient.ExecuteTaskAsync<TestingApplication>(request);

            return response2.Data;
        }

        public List<string> GetSpamSeedAddresses()
        {
            var request = new RestRequest("/api/v1/SpamSeedAddresses", Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response2 = restClient.Execute<List<string>>(request);

            return response2.Data;
        }

        public async Task<List<string>> GetSpamSeedAddressesAsync()
        {
            var request = new RestRequest("/api/v1/SpamSeedAddresses", Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response2 = await restClient.ExecuteTaskAsync<List<string>>(request);

            return response2.Data;
        }


        #region Email Tests

        public EmailTest CreateEmailTest(EmailTest test)
        {
            var request = new RestRequest("/api/v1/EmailTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            
            request.AddBody(test);
            
            var response2 = restClient.Execute<EmailTest>(request);

            return response2.Data;
        }

        public async Task<EmailTest> CreateEmailTestAsync(EmailTest test)
        {
            var request = new RestRequest("/api/v1/EmailTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(test);

            var response2 = await restClient.ExecuteTaskAsync<EmailTest>(request);

            return response2.Data;
        }

        public List<TestingApplication> GetEmailTestingApplications()
        {
            var request = new RestRequest("/api/v1/EmailTests/TestingApplications", Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response2 = restClient.Execute<List<TestingApplication>>(request);

            return response2.Data;
        }

        public async Task<List<TestingApplication>> GetEmailTestingApplicationsAsync()
        {
            var request = new RestRequest("/api/v1/EmailTests/TestingApplications", Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response2 = await restClient.ExecuteTaskAsync<List<TestingApplication>>(request);

            return response2.Data;
        }

        public EmailTest GetEmailTest(int emailTestId)
        {
            var request = new RestRequest("/api/v1/EmailTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", emailTestId.ToString());

            var response2 = restClient.Execute<EmailTest>(request);

            return response2.Data;
        }

        public async Task<EmailTest> GetEmailTestAsync(int emailTestId)
        {
            var request = new RestRequest("/api/v1/EmailTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", emailTestId.ToString());

            var response2 = await restClient.ExecuteTaskAsync<EmailTest>(request);

            return response2.Data;
        }

        #endregion

        #region Page Tests
        
        public PageTest CreatePageTest(PageTest test)
        {
            var request = new RestRequest("/api/v1/PageTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(test);

            var response2 = restClient.Execute<PageTest>(request);

            return response2.Data;
        }

        public async Task<PageTest> CreatePageTestAsync(PageTest test)
        {
            var request = new RestRequest("/api/v1/PageTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(test);

            var response2 = await restClient.ExecuteTaskAsync<PageTest>(request);

            return response2.Data;
        }

        public List<TestingApplication> GetPageTestingApplications()
        {
             var request = new RestRequest("/api/v1/PageTests/TestingApplications", Method.GET);
             request.RequestFormat = DataFormat.Json;
            var response2 = restClient.Execute<List<TestingApplication>>(request);

            return response2.Data;
        }

        public async Task<List<TestingApplication>> GetPageTestingApplicationsAsync()
        {
            var request = new RestRequest("/api/v1/PageTests/TestingApplications", Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response2 = await restClient.ExecuteTaskAsync<List<TestingApplication>>(request);

            return response2.Data;
        }

        public PageTest GetPageTest(int pageTestId)
        {
            var request = new RestRequest("/api/v1/PageTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", pageTestId.ToString());

            var response2 = restClient.Execute<PageTest>(request);

            return response2.Data;
        }

        public async Task<PageTest> GetPageTestAsync(int pageTestId)
        {
            var request = new RestRequest("/api/v1/PageTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", pageTestId.ToString());

            var response2 = await restClient.ExecuteTaskAsync<PageTest>(request);

            return response2.Data;
        }

        #endregion

        #region Links Test

        public LinksTest CreateLinksTest(string html)
        {
            var request = new RestRequest("/api/v1/LinkTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(html);

            var response2 = restClient.Execute<LinksTest>(request);

            return response2.Data;
        }

        public async Task<LinksTest> CreateLinksTestAsync(string html)
        {
            var request = new RestRequest("/api/v1/LinkTests", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(html);

            var response2 = await restClient.ExecuteTaskAsync<LinksTest>(request);

            return response2.Data;
        }

        public LinksTest GetLinksTest(int linkTestId)
        {
            var request = new RestRequest("/api/v1/LinkTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", linkTestId.ToString());

            var response2 = restClient.Execute<LinksTest>(request);

            return response2.Data;
        }

        public async Task<LinksTest> GetLinksTestAsync(int linkTestId)
        {
            var request = new RestRequest("/api/v1/LinkTests/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("id", linkTestId.ToString());

            var response2 = await restClient.ExecuteTaskAsync<LinksTest>(request);

            return response2.Data;
        }

        #endregion

        #region Code Analysis

        public CodeAnalysisTest CreateCodeAnalysisTest(string html)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(html);

            var response2 = restClient.Execute<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public async Task<CodeAnalysisTest> CreateCodeAnalysisTestAsync(string html)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(html);

            var response2 = await restClient.ExecuteTaskAsync<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public CodeAnalysisTest CreateCodeAnalysisTestByTestingApplication(string html, List<TestingApplication> testingApplications)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.RequestFormat = DataFormat.Json;

            var test = new CodeAnalysisTestByTestingApplications
            {
                Html = html,
                TestingApplications = testingApplications.Select(n => n.ApplicationName).ToList()
            };

            request.AddBody(test);

            var response2 = restClient.Execute<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public async Task<CodeAnalysisTest> CreateCodeAnalysisTestByTestingApplicationAsync(string html, List<TestingApplication> testingApplications)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.RequestFormat = DataFormat.Json;

            var test = new CodeAnalysisTestByTestingApplications
            {
                Html = html,
                TestingApplications = testingApplications.Select(n => n.ApplicationName).ToList()
            };

            request.AddBody(test);

            var response2 = await restClient.ExecuteTaskAsync<CodeAnalysisTest>(request);

            return response2.Data;
        }


        #endregion

    }
}