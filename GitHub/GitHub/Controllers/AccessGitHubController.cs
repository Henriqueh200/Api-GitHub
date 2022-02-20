using GitHubProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace GitHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccessGitHubController : ControllerBase
    {

        private readonly IGithubService _githubservice;

        public AccessGitHubController(IGithubService githubService)
        {

            _githubservice = githubService;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("Github-repository/{organization}")]
        public async Task<IActionResult> GetGithubRepositoryAsync([FromRoute]string organization)
        {
            var repositories = await _githubservice.GetGithubRepositoriesAsync(organization);  
            return Ok(repositories);

        }
    }
}
