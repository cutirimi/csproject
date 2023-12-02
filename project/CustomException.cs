using System;

namespace project
{
    public class CustomException : Exception        //예외처리 클래스
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
    }
}
