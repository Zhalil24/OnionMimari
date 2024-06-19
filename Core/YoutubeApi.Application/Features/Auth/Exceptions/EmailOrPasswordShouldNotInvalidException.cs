using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotInvalidException() : base("Kullanıcı adı veya şifre yanlış! ") { }
    }
}
