using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace vizsga
{
    class EgyediException : Exception
    {
        public EgyediException()
        {
        }

        public EgyediException(string message) : base(message)
        {
        }

        public EgyediException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EgyediException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
