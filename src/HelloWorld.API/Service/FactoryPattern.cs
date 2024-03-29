namespace HelloWorld.API.Service;

/// <summary>
/// Simple way to implement a generic factory
/// </summary>
/// <typeparam name="BaseType"></typeparam>
/// <typeparam name="ImplementType"></typeparam>
public static class FactoryPattern<BaseType, ImplementType> where ImplementType : class, BaseType, new()
{
    /// <summary>
    /// Return a new instance of <typeparamref name="ImplementType"/>
    /// </summary>
    /// <returns></returns>
    public static BaseType GetInstance()
    {
        BaseType objK = new ImplementType();
        return objK;
    }
}
