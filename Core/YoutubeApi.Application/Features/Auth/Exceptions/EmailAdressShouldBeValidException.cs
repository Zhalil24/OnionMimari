using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
    public class EmailAdressShouldBeValidException : BaseException
    {
        public EmailAdressShouldBeValidException() : base("Böyle bir email adresi bulunmamaktadır.") { }
    }
}
