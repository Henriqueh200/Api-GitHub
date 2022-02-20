using GitHubProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubProject.Services.Interfaces
{
    public interface IGithubService
    {
        /// <summary>
        ///  Get repositories from GitHub
        /// </summary>
        /// <param name="organizationName"></param>
        /// <returns></returns>
        Task<List<Repository>> GetGithubRepositoriesAsync(string organizationName);
    }
}
