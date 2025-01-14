using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configures API versioning for the application
builder.Services.AddApiVersioning(options => {
    // Sets that when the version is unspecified, the default version will be assumed.
    options.AssumeDefaultVersionWhenUnspecified = true;

    // Sets the default API version to 2.0.
    options.DefaultApiVersion = new ApiVersion(2, 0);

    // Enables reporting of available API versions in the response headers.
    options.ReportApiVersions = true;
});

// Configures the API explorer to handle API versions
builder.Services.AddVersionedApiExplorer(options => {
    // Sets the version group name format, using the 'v' prefix followed by 3 version digits (e.g., v1.0, v2.0).
    options.GroupNameFormat = "'v' VVV";

    // Replaces the API version directly in the URL, allowing the client to specify the API version in the URL.
    options.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
