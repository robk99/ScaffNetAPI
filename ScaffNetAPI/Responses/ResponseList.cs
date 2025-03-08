using ScaffNetAPI.Errors;

namespace ScaffNetAPI.Responses
{
    public static class ResponseList
    {
        public static readonly BaseReponse ServerError500 = new BaseReponse()
        {
            Message = Errorlist.ServerError500,
            StatusCode = 500
        };
    }
}
