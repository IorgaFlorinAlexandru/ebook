namespace Domain.Exceptions;

public class NotFoundException : Exception
{
        public NotFoundException()
        : base() { }

        public NotFoundException(string message)
            : base(message) { }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException) { }

        public NotFoundException(string name, string id)
            : base($"Entity {name} with Id: {id} was not found.") { }
}