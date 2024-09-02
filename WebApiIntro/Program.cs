using Microsoft.EntityFrameworkCore;
using WebApiIntro.Contexts;
using WebApiIntro.Reposiotries.Abstracts;
using WebApiIntro.Reposiotries.Concretes;
using WebApiIntro.UnitofWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("default")));


builder.Services.AddScoped<ICarRepository, CarReposiotry>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICarGalleryRepository, CarGalleryRepository>();
builder.Services.AddScoped<UnitOfWork>();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
