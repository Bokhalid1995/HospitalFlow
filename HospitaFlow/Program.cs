using FluentValidation;
using Hangfire;
using Hangfire.SqlServer;
using HospitaFlow.Api;
using HospitaFlow.Api.Services.HangFire;
using HospitaFlow.Application.Common.Behaviors;
using HospitaFlow.Application.Common.Exceptions;
using HospitaFlow.Application.Features.Application.PatientFileFeature.Commands.Validations;
using HospitaFlow.Core;
using HospitaFlow.Infrastructure.Data;
using HospitaFlow.Infrastructure.Jobs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("HospitalFlowDb");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddAppDI();
builder.Services.AddHangfireServices(builder.Configuration);
var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();


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
