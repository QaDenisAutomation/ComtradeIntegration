using NUnit.Framework;
using NUnit.Framework.Legacy;
using RestSharp;

namespace AutomatedTests.Tests
{
    [TestFixture]
    public class GitHubApiTests
    {
        private const string GitHubApiBaseUrl = "https://api.github.com";

        [Test]
        public void TestGetGitHubRepository()
        {
            var client = new RestClient(GitHubApiBaseUrl);
            var request = new RestRequest("/repos/{owner}/{repo}", Method.Get);
            request.AddUrlSegment("owner", "octocat");
            request.AddUrlSegment("repo", "Hello-World");

            // Act
            var response = client.Execute(request);

            
            ClassicAssert.AreEqual(200, (int)response.StatusCode);
            ClassicAssert.IsNotNull(response.Content);

            Console.WriteLine(response.Content);

        }

    }
}