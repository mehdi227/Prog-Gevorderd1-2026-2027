using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BuildingBlocks.Results
{
    public record Error
    {
        public string Value { get; }

        private Error(string value)
        {
            Value = value;
        }

        public static Error Create(string value)
        {
            return new Error(value);
        }
    }
}
