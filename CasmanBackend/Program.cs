using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using CasmanSln.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });

builder.Services.AddDbContext<CasmanDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("CasmanConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICaseDetails, CaseDetails>();
builder.Services.AddScoped<IPractionerDetails,PractionerDetails>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<ICaseRepository, CaseRepository>();
builder.Services.AddScoped<IDrpdwns, Drpdwns>();
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("CasmanFrontend",
        policy => policy.WithOrigins("http://localhost:3000") // React dev server
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CasmanFrontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
