using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hypance.Core.AppUser.LoginUser;
using Hypance.Core.AppUser.PasswordReset;
using Hypance.Core.AppUser.RefreshTokenLogin;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hypance.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshTokenLogin([FromBody] RefreshTokenLoginCommandRequest refreshTokenLoginCommandRequest)
        {
            RefreshTokenLoginCommandResponse response = await _mediator.Send(refreshTokenLoginCommandRequest);
            return Ok(response);
        }

        [HttpPost("password-reset")]
        public async Task<IActionResult> PasswordReset([FromBody] PasswordResetCommandRequest passwordResetCommandRequest)
        {
            PasswordResetCommandResponse response = await _mediator.Send(passwordResetCommandRequest);
            return Ok(response);
        }

        // [HttpPost("verify-reset-token")]
        // public async Task<IActionResult> VerifyResetToken([FromBody] VerifyResetTokenCommandRequest verifyResetTokenCommandRequest)
        // {
        //     VerifyResetTokenCommandResponse response = await _mediator.Send(verifyResetTokenCommandRequest);
        //     return Ok(response);
        // }
        
    }
}