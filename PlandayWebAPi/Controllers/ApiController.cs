

using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace PlandayApi.Controllers
    {
    /// <summary>
    /// under development / construction....
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
        {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        }
    }
