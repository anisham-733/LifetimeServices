using System;
public interface IOperation
{
    Guid OperationId { get; }
}
public interface IOperationTransient : IOperation
{

}

public interface IOperationScoped : IOperation
{

}

public interface IOperationSingleton : IOperation
{

}

public interface IOperationSingletonInstance : IOperation
{

}
public class Operations : IOperationScoped, IOperationSingleton, IOperationSingletonInstance, IOperationTransient
{
    public Operations() : this(Guid.NewGuid())
    {

    }
    public Operations (Guid Id)
    {
        OperationId= Id;


    }

    // Guid IOperation.OperationId => throw new NotImplementedException();

    public Guid OperationId { get; private set; }

}