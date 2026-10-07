namespace KasiTix.Domain.Exceptions;

public abstract class DomainException(string message) : Exception(message);
public sealed class NotFoundException(string message) : DomainException(message);
public sealed class ConflictException(string message) : DomainException(message);
public sealed class UnprocessableEntityException(string message) : DomainException(message);