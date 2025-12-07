namespace HospitaFlow.Application.Common.Responses
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        public static Result<T> Done(T data, string message = "Success")
        {
            return new Result<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static Result<T> Fail(string message, List<string>? errors = null)
        {
            return new Result<T>
            {
                Success = false,
                Message = message,
                Errors = errors
            };
        }
    }
}
