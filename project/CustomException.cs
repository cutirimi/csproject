﻿using System;

namespace project
{
    public class CustomException : ApplicationException        //예외처리 클래스
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
    }
}
