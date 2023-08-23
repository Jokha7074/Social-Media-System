using SMP.Data.Entities;

namespace SMP.Service.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message) 
    {   
    }
    public NotFoundException(string Message, Exception exception) : base(Message,exception)
    {
    }
}
