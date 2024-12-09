using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Data; // Uygun namespace'i eklediğinizden emin olun

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL bağlantısını DbContext'e ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Uygulama yapılandırmasını buraya ekleyin

app.Run();
