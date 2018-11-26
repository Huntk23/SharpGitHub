namespace SharpGitHub
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Threading.Tasks;

    public class GitHubClient
    {
        public static readonly Uri DefaultGitHubApiUrl = new Uri("https://api.github.com/");

        public GitHubClient(string userAgent)
            : this(DefaultGitHubApiUrl, userAgent)
        {
            
        }

        public GitHubClient(string baseAddress, string userAgent)
            : this(new Uri(baseAddress), userAgent)
        {
            
        }

        public GitHubClient(Uri baseAddress, string userAgent)
        {
            if (!baseAddress.IsWellFormedOriginalString() && (baseAddress.Scheme != Uri.UriSchemeHttp || baseAddress.Scheme != Uri.UriSchemeHttps))
            {
                throw new ArgumentException("The base address used is not a well formed or valid URL.", nameof(baseAddress));
            }
        }
    }
}