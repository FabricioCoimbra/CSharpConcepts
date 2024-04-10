using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.Benchmark;

public interface IExampleInterface
{
    void DoSomething();
}
public class ExampleImplementation : IExampleInterface
{
    public void DoSomething()
    {
        // Faz algo
        var um = 1;
        var dois = um * 2;
        um = um * dois;
    }
}

public abstract class ExampleAbstractClass
{
    public abstract void DoSomething();
}

// Implementação da classe abstrata
public class ExampleConcreteClass : ExampleAbstractClass
{
    public override void DoSomething()
    {
        // Faz algo
        var um = 1;
        var dois = um * 2;
        um = um * dois;
    }
}

// Classe que possui métodos de benchmark
[MemoryDiagnoser]
public class InstantiationBenchmark
{
    private readonly IServiceProvider ProvicerScoped;
    private readonly IServiceProvider ProvicerSingleton;
    public InstantiationBenchmark()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<ExampleImplementation>();
        serviceCollection.AddScoped<IExampleInterface, ExampleImplementation>();
        serviceCollection.AddScoped<ExampleAbstractClass, ExampleConcreteClass>();

        ProvicerScoped = serviceCollection.BuildServiceProvider();

        var serviceCollectionSingleton = new ServiceCollection();
        serviceCollectionSingleton.AddSingleton<ExampleImplementation>();
        serviceCollectionSingleton.AddSingleton<IExampleInterface, ExampleImplementation>();
        serviceCollectionSingleton.AddSingleton<ExampleAbstractClass, ExampleConcreteClass>();

        ProvicerSingleton = serviceCollectionSingleton.BuildServiceProvider();
    }

    [Benchmark]
    public void DirectInstantiation()
    {
        var instance = new ExampleImplementation();
        instance.DoSomething();
    }

    [Benchmark]
    public void InterfaceInstantiation()
    {
        IExampleInterface instance = new ExampleImplementation();
        instance.DoSomething();
    }

    [Benchmark]
    public void AbstractClassInstantiation()
    {
        ExampleAbstractClass instance = new ExampleConcreteClass();
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Scoped_InterfaceInstantiation()
    {
        var instance = ProvicerScoped.GetService<IExampleInterface>()!;
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Scoped_AbstractClassInstantiation()
    {
        var instance = ProvicerScoped.GetService<ExampleAbstractClass>()!;
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Scoped_DirectInstantiation()
    {
        var instance = ProvicerScoped.GetService<ExampleImplementation>()!;
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Singleton_InterfaceInstantiation()
    {
        var instance = ProvicerSingleton.GetService<IExampleInterface>()!;
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Singleton_AbstractClassInstantiation()
    {
        var instance = ProvicerSingleton.GetService<ExampleAbstractClass>()!;
        instance.DoSomething();
    }

    [Benchmark]
    public void DI_Singleton_DirectInstantiation()
    {
        var instance = ProvicerSingleton.GetService<ExampleImplementation>()!;
        instance.DoSomething();
    }
}
