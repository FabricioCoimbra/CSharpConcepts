namespace HelloWorld.API.Service;

public static class FactoryPattern<BaseType, ImplementType> where ImplementType : class, BaseType, new()
{
    public static BaseType GetInstance()
    {
        BaseType objK = new ImplementType();
        return objK;
    }
}
