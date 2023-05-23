using BookShare.Infrastructure.Contexts;
using BookShare.Infrastructure.Repositories;
using BookShare.Services.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BookShareDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookShareDb")));

// Add services to the container.
//repositories
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IAnuncioRepository, AnuncioRepository>();


//services
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IAnuncioService, AnuncioService>();



builder.Services.AddControllers();


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

app.Run();