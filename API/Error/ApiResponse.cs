using System;

namespace API.Error
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "A bad request you have mad",
                401=> "Authorized, you are not",
                404 => "Ressource found, it was not",
                500 => "errors are the path to the dark side, Errors lead to anger, Anger leads to hate, hate leads to carrer change",
                 _ => null   
            };
        }

    }
}