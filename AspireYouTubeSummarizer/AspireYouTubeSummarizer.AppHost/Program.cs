var builder = DistributedApplication.CreateBuilder(args);

var config = builder.Configuration;

var apiapp = builder.AddProject<Projects.AspireYoutubeSummarizer_ApiApp>("apiapp")
                     .WithEnvironment("OpenAI__Endpoint", config["OpenAI:Endpoint"])
                     .WithEnvironment("OpenAI__ApiKey", config["OpenAI:ApiKey"])
                     .WithEnvironment("OpenAI__DeploymentName", config["OpenAI:DeploymentName"]); ;

builder.AddProject<Projects.AspireYouTubeSummarizer_WebApp>("webapp")
       .WithExternalHttpEndpoints()
       .WithReference(apiapp);

builder.Build().Run();
