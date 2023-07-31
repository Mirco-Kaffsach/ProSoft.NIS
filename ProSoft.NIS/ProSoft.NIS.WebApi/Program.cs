using ProSoft.NIS.Data.MsSqlServer;
using ProSoft.NIS.Data.MsSqlServer.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDataEngines();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
Console.WriteLine("Checking for database migrations");
MigrationHelper.Migrate<DatabaseContext>(app);
Console.WriteLine("Service is ready for requests");
app.Run();
