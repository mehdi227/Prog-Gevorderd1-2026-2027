using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace BuildingBlocks.Results
{
    public class Result
    {
        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public IReadOnlyCollection<Error> Errors { get; }

        protected Result(bool isSuccess, IReadOnlyCollection<Error> errors)
        {
            IsSuccess = isSuccess;
            Errors = errors;
        }

        public static Result Success()
            => new(true, Array.Empty<Error>());

        public static Result Failure(IReadOnlyCollection<Error> errors)
            => new(false, errors);

        public static Result Failure(Error error) => Failure(new[] { error });
    }

    public class Result<T> : Result
    {
        private Result(
            bool isSuccess,
            T? value,
            IReadOnlyCollection<Error> errors): base(isSuccess, errors)
        {
            Value = value;
        }

        public T? Value { get; }        

        public static Result<T> Success(T value)
        {
            return new Result<T>(
                true,
                value,
                Array.Empty<Error>());
        }

        public static Result<T> Failure(IEnumerable<Error> errors)
        {
            return new Result<T>(
                false,
                default,
                errors.ToList());
        }

        public new static Result<T> Failure(Error error) => Failure(new[] { error });
    }

    
}
