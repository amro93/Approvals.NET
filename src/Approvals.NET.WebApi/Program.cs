using Approvals.NET.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Approvals.NET.Infrastructure.Presistence.EfCore;
using Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application;
using Approvals.NET.Application.Identity.Tenants;
using Approvals.NET.Application.Identity.Users;
using Approvals.NET.WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("ApplicationDb");

/*
 * refactor to add AddApprovals(c => c.UseEfCore(o => ...efcore options))
 * 
 * 
 */
builder.Services.AddAppEfCore(connectionString!);

builder.Services.AddDefaultIdentity<ApplicationUser>(o =>
{

})

    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.AddHealthChecks();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<ICurrentUser, CurrentUser>();
builder.Services.AddSingleton<ICurrentTenant, CurrentTenant>();

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