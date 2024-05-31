using Microsoft.EntityFrameworkCore;
using TodoList.Classes;
using TodoList.Components;
using TodoList.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddServerSideBlazor();



builder.Services.AddScoped<TodoService>();



var connStr = builder.Configuration.GetConnectionString("DbConnect");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connStr, ServerVersion.AutoDetect(connStr)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting(); 
app.UseAntiforgery();

  

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
