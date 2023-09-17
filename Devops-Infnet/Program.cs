using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Devops_Infnet.HealthCheck;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddHealthChecks()
                .AddUrlGroup(new Uri("http://httpbin.org/status/200"), "Api Terceiro não autenticada")
                .AddUrlGroup(uri: new Uri("http://viacep.com.br/ws/01001000/json/"), "Api Publica Cep não autenticada")
                .AddCheck<HealthCheckRandom>(name: "Api Terceiro Autenticada");
                

builder.Services.AddHealthChecksUI(s =>
{
    s.AddHealthCheckEndpoint("API-healthz", "https://localhost:7232/healthz");
    
})
.AddInMemoryStorage();
//builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPINSIGHTS_CONNECTIONSTRING"]);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRouting()
   .UseEndpoints(config =>
   {
       config.MapHealthChecks("/healthz", new HealthCheckOptions
       {
           Predicate = _ => true,
           ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
       });

       config.MapHealthChecksUI();
   });

app.Run();
