using KafkaConsumer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<KafkaConsumerBackgroundWorker>();
using IHost host = builder.Build();

await host.RunAsync();