using System.Net;
using Microsoft.AspNetCore.Mvc;
using Gdpr.Api.Serializer;
using Gdpr.Api.Core.Interfaces;
using Gdpr.Api.Core.Dto.UseCaseResponses;

namespace Gdpr.Api.Presenters
{
    public class LoginPresenter : IOutputPort<LoginResponse>
    {
        public ContentResult contentResult { get; }

        public LoginPresenter()
        {
            contentResult = new ContentResult();
            contentResult.ContentType = "application/json";
        }
        
        public void Handle(LoginResponse response)
        {
            contentResult.StatusCode = (int) (response.Success ? HttpStatusCode.OK : HttpStatusCode.Unauthorized);
            contentResult.Content = response.Success ? JsonSerializer.SerializeObject(response.Token) : JsonSerializer.SerializeObject(response.Errors);
        }
    }
}