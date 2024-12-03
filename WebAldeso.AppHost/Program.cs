var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WebAldeso_ApiService>("apiservice");

builder.AddProject<Projects.WebAldeso_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
