using Microsoft.AspNetCore.Mvc;
using ScaffNet.Features.CleanArchitecture;
using ScaffNetAPI.Dtos;
using ScaffNetAPI.Responses;

namespace ScaffNetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpPost("create-clean-architecture")]
        public ActionResult<BaseReponse> CreateCleanArchitecture([FromBody] CreateArchitectureTemplateDto dto)
        {
            // TODO: Add Validation

            // TODO: Build a middleware to handle exceptions
            try
            {
                CleanArchitectureScaffolder.Create(new CleanArchitectureArgs()
                {
                    SolutionName = dto.SolutionName,
                    SolutionPath = dto.Solutionpath,
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(ResponseList.ServerError500.StatusCode, ResponseList.ServerError500);
            }

            return Ok(new BaseReponse()
            {
                Message = "Clean Architecture created successfully",
                StatusCode = 200
            });
        }
    }
}
