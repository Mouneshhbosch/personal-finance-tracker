var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PersonalFinanceTracker_API>("personalfinancetracker-api");

builder.Build().Run();
