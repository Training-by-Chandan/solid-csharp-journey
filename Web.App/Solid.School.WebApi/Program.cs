using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Solid.School.Data;
using Solid.School.Repository;
using Solid.School.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
var corsSpec = "_corsSpec";

builder.Services.AddCors(p =>
{
    p.AddPolicy(name: corsSpec,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = "ABC",
        ValidIssuer = "XYZ",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("aslqwtyuioxcvnmqwyui"))
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
DependencyConfig(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(corsSpec);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

static void DependencyConfig(IServiceCollection services)
{
    #region Repository

    services.AddTransient<IStudentRepository, StudentRepository>();
    services.AddTransient<IClassRepository, ClassRepository>();

    #endregion Repository

    #region Services

    services.AddTransient<IStudentService, StudentService>();
    services.AddTransient<IClassService, ClassService>();

    #endregion Services
}