using MVC_test.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.Use(async (ctx, next) =>
{
    var log = new Log()
    {
        Timespan = DateTime.Now,
        Url = ctx.Request.Path,
        Resultstatuscode=ctx.Response.StatusCode
    };
    var Filepath = @"D:\Test\logfile.txt";
    using( var writer = File.AppendText(Filepath))
    {
        writer.WriteLine($"Timestamp:{log.Timespan},Url:{log.Url},Statuscode:{log.Resultstatuscode}");
    }
    await next();
});





app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
