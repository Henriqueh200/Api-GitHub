using GitHubProject.Models;
using RestEase;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GitHubProject.Services.RestEase
{
    [Header("User-Agent","GitHubAccess")]
    public interface IGitHub
    {
        /// <summary>
        /// Get repositories from GitHub
        /// </summary>
        /// <param name="organization">GitHub organization</param>
        /// <returns>list of repositories</returns>
        [Get("orgs/{organization}/repos")]
        Task<List<Repository>> GetRepositoriesAsync([Path] string organization);
       
    }
}
