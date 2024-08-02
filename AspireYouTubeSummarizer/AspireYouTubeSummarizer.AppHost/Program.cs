var builder = DistributedApplication.CreateBuilder(args);

var apiapp = builder.AddProject<Projects.AspireYoutubeSummarizer_ApiApp>("apiapp");

builder.AddProject<Projects.AspireYouTubeSummarizer_WebApp>("webapp")
       .WithReference(apiapp);

builder.Build().Run();
