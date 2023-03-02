 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().WithRazorPagesRoot("/Pages");
//.AddRazorPagesOptions(option =>
//{
//    option.Conventions.AddPageRoute("/home", "");
//});

builder.Services.AddDistributedMemoryCache();

//add session for 1800s = 10mins
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(1800);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapRazorPages();
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=login}/{action=OnPostfLogin}");
//});
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
