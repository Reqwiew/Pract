using pract;
using pract.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PractDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>().AddProjections().
    AddFiltering().AddSorting();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<PractDbContext>();
    dbContext?.Database.EnsureCreated();
    DataSeeder.SeedData(dbContext!);
}
app.MapGraphQL("/graphgl");

app.Run();