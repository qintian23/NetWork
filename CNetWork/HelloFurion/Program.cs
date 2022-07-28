//Serve.Run("http://localhost:25161");

Serve.Run(RunOptions.Default.ConfigureBuilder(builder =>
    {
        builder.WebHost.UseSetting("UseUrls","http://localhost:25161"); // 不行啊
    }
));

[DynamicApiController]
public class HelloService
{
    public string Say()
    {
        return "Hello, Furion";
    }
}

// 同时支持dotnet run 和 dotnet watch run