using GitHubProject.Models;
using GitHubProject.Services.Interfaces;
using GitHubProject.Services.RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubProject.Services
{
    public class GitHubService : IGithubService
    {
        private const string LANGUAGE_DESCRIPTION = "C#";
        private const int COUNT_REPOSITORIES = 5;

        private readonly IGitHub _github;
        public GitHubService(IGitHub gitHub)
        {
            _github = gitHub;
        }

        public async Task<List<Repository>> GetGithubRepositoriesAsync(string organizationName)
        {

            var repositories = await _github.GetRepositoriesAsync(organizationName);
            repositories = repositories.Where(r => !string.IsNullOrWhiteSpace(r.Language)).Where(r => r.Language.Equals(LANGUAGE_DESCRIPTION, StringComparison.OrdinalIgnoreCase)).ToList();

            return repositories.OrderBy(r => Convert.ToDateTime(r.CreatedAt)).Take(COUNT_REPOSITORIES).ToList();
        }
    }
}
