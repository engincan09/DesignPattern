using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Adapter
{
    public class CustomOperation
    {
        private readonly IJsonSerializer _jsonSerialize;

        public CustomOperation(IJsonSerializer jsonSerialize)
        {
            _jsonSerialize = jsonSerialize;
        }

        public string SerializeObject(object obj)
        {
            return _jsonSerialize.SerializeObject(obj);
        }
    }
}
