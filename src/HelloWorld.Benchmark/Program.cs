using BenchmarkDotNet.Running;
using HelloWorld.Benchmark;

Console.WriteLine("Hello, World! Starting Benchmark");
var summary = BenchmarkRunner.Run<BenchmarkEmployeeSalary>();
