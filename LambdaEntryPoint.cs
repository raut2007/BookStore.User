using Amazon.Lambda.Core;
using Amazon.Lambda.AspNetCoreServer;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace YourNamespace; // Replace with YOUR namespace

public class LambdaEntryPoint : APIGatewayProxyFunction
{
    protected override void Init(IWebHostBuilder builder)
    {
        builder.UseStartup<Startup>(); // If you use Startup.cs
        // OR configure your services here if using minimal API
    }
}


//
//install package
# In your repository directory
dotnet add package Amazon.Lambda.AspNetCoreServer
dotnet add package Amazon.Lambda.Core
dotnet add package Amazon.Lambda.Serialization.SystemTextJson



# Install Lambda tools
dotnet tool install -g Amazon.Lambda.Tools

# Package your API
dotnet lambda package -c Release