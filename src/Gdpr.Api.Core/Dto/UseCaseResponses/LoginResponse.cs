using System.Collections.Generic;
using Gdpr.Api.Core.Interfaces;

namespace Gdpr.Api.Core.Dto.UseCaseResponses
{
    public class LoginResponse : UseCaseResponse
    {
        public Token Token { get; }
        public IEnumerable<Error> Errors { get; }
        public LoginResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public LoginResponse(Token token, bool success = false, string message = null) : base(success, message)
        {
            Token = token;
        }
    }
}