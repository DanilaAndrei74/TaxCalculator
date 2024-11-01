var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithDataVolume()
    .WithPgAdmin(); ;
var postgresdb = postgres.AddDatabase("postgresdb");

builder.AddProject<Projects.Aspire_MigrationService>("migrations")
    .WithReference(postgresdb);

builder.AddProject<Projects.CommifyInterview_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(postgresdb); ;


builder.Build().Run();
