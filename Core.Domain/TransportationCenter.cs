using Core.Domain.Helper;
using Google.Protobuf.WellKnownTypes;
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.DTO;
using System.Runtime.ExceptionServices;

namespace Core.Domain
{
    public class TransportationCenter
    {
        public string Name { get; private set; }

        public TransportationCenter(string name)
        {
            Name = name;
        }
    }
}
