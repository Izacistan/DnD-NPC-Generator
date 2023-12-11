using Microsoft.EntityFrameworkCore;
using DnD_NPC_Generator.Models;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.Client.Http;
using DnD_NPC_Generator.WebAPI;
using DnD_NPC_Generator.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddSession();

//Database Repository
builder.Services.AddScoped<ILegionRepository, LegionRepository>();
//Web API Scopes
builder.Services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient(builder.Configuration.GetConnectionString("GraphQLURI"), new NewtonsoftJsonSerializer()));
builder.Services.AddScoped<DNDConsumer>();


builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<NPCContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("NPCContext")));

builder.Services.AddDbContext<NPCContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));

// Setup Identity
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequiredLength = 3;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
})
    .AddEntityFrameworkStores<NPCContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Admin}/{action=Index}/{id?}");

    // Your existing routes go here
});


await NPCContext.CreateAdminUser(app.Services);

app.Run();
