using pract;
using pract.DAO;
using pract.Data;
using Microsoft.EntityFrameworkCore;
using pract.DAO;
using pract.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddDbContext<PractDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped <IClientRepository,ClientRepository>();
builder.Services.AddScoped<IServiceRepoitory, ServiceRepository>();
builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IMasterRepository, MasterRepository>();
builder.Services.AddScoped<IPartRepository, PartRepository >();
builder.Services.AddScoped<IReceprionistRepository, ReceptionistRepository>();
builder.Services.AddScoped<IRepairRepository, RepairRepository>();
builder.Services.AddScoped<IRepairServiceRepository, RepairServiceRepository>();
builder.Services.AddScoped<IServiceRepoitory, ServiceRepository>();
builder.Services.AddScoped<IUsedPartRepository, UsedPartRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().
    AddSorting().AddFiltering();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(cors => cors
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(_ => true)
.AllowCredentials()
);
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<PractDbContext>();
    dbContext?.Database.EnsureCreated();
    DataSeeder.SeedData(dbContext!);
}

app.MapGraphQL("/graphgl");

app.Run();