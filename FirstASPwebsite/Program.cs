using FirstASPwebsite.Models;
using FirstASPwebsite.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<JsonFilePostService>();
builder.Services.AddControllers();

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

app.UseEndpoints(endpoints =>
{
    //endpoints.MapGet("/posts", (context) =>
    //{
    //    var posts = app.Services.GetService<JsonFilePostService>().GetPosts();
    //    var json = JsonSerializer.Serialize<IEnumerable<Post>>(posts);
    //    return context.Response.WriteAsync(json);
    //});

    endpoints.MapControllers();
});

app.Run();
