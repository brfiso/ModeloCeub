using Microsoft.EntityFrameworkCore;
using ModeloCeub.Data;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<CeubDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CeubConnection")));

builder.Services.AddScoped<IMedicoService, MedicoService>();
builder.Services.AddScoped<IEnfermeiroService, EnfermeiroService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
