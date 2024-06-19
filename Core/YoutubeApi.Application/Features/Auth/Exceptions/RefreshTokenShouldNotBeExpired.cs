using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpired : BaseException
    {
        public RefreshTokenShouldNotBeExpired() : base("Oturum süresi sona ermiştir. Lütfen tekrar giriş yapınız.") { }
    }
}
