using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddDbContext<CasmanDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("CasmanConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICaseDetails, CaseDetails>();
builder.Services.AddScoped<IPractionerDetails,PractionerDetails>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<ICaseRepository, CaseRepository>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
