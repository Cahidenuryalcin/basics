var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
/* statik dosyaların default olarak ayarlanmış olan klasörü (wwwroot)
kullanırken 
src="~/wroot_alindaki_image_klasör_adi/......

wwroot'un haricinde bir klasör için
kaynak  
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-8.0

app.UseStaticFiles(new StaticfileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Enviroment.ContentRootPath, "MyStaticFiles")),
    RequestPath= "/StaticFiles"
}); 
*/

//ulaşırken de 
/*
<img src="~/StaticFiles/images/red-rose.jpg" class="img" alt="A red rose" />
*/

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
