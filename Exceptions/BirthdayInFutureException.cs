﻿using System;

namespace CSharpProgramming2020.Task2.Exceptions
{
    internal class BirthdayInFutureException: Exception
    {
        private string _message;

        public BirthdayInFutureException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get => _message;
        }

    }
}
