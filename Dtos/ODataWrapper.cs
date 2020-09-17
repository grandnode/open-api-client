using System;
using System.Collections.Generic;
using System.Text;

namespace openapi_sample_client.Dtos
{
    public class ODataWrapper<T>
    {
        public T Value { get; set; }
    }
}
