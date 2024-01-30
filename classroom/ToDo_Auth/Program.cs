using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using static ToDo_Auth.DbContext;

var builder = WebApplication.CreateBuilder(args);

// ...

// Token-ის შემქმნელი
var issuer = "myapp.com";

// Token-ის აუდიტორია
var audience = "myapp.com";

// Token-ის გასაღები
var secretKey = "secretKeyasdjaldkajdlaasdadasdasdnsadnadan";

builder.Services.Configure<JwtSettings>(s =>
{
    s.Issuer = issuer;
    s.Audience = audience;
    s.SecrectKey = secretKey;
});

// Token-ის ვალიდაციის პარამეტრები, რის მიხედვითაც asp.net მოახდენს ვალიდაციას
var tokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = issuer,
    ValidAudience = audience,
    ClockSkew = TimeSpan.Zero,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
};

// საჭირო სერვისების IoC-ში რეგისტრაცია
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => { options.TokenValidationParameters = tokenValidationParameters; });

builder.Services.AddDbContext<AppDbContext>(c => c.UseSqlServer(builder.Configuration["AppDbContextConnection"]));

// Policy-ს შექმნა და კონტეინერში დამატება
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MyApiUserPolicy",
        policy => policy.RequireClaim(ClaimTypes.Role, "api-user"));
});

// UserEntity და RoleEntity კლასების მიხედვით მოხდება ბაზაში ცხრილების შექმნა
builder.Services
    .AddIdentity<UserEntity, RoleEntity>(o =>
    {
        o.Password.RequireDigit = true;
        o.Password.RequireLowercase = true;
        o.Password.RequireUppercase = true;
        o.Password.RequireNonAlphanumeric = false;
        o.Password.RequiredLength = 8;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
app.UseAuthentication();

app.MapControllers();

app.Run();
