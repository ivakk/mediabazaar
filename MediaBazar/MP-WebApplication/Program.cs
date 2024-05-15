using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.TeamFoundation.TestManagement.WebApi;
using MP_BusinessLogic;
using MP_BusinessLogic.InterfacesDal;
using MP_BusinessLogic.InterfacesLL;
using MP_BusinessLogic.Services;
using MP_DataAccess;
using MP_DataAccess.DALManagers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Configure authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new PathString("/Login");
        options.LogoutPath = new PathString("/Logout");
        options.AccessDeniedPath = new PathString("/AccessDenied");
    });

//builder.Services.AddTransient<UserService>();
//builder.Services.AddTransient<UserDAL>();
builder.Services.AddTransient<IUserDalManager, UserDAL>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IBrandDalManager, BrandDAL>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<ICategoryDalManager, CategoryDAL>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IDepartmentDalManager, DepartmentDAL>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();
builder.Services.AddTransient<IProductDalManager, ProductDAL>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ISubCategoryDalManager, SubCategoryDAL>();
builder.Services.AddTransient<ISubCategoryService, SubCategoryService>();

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

// Enable cookie authentication
app.UseAuthentication();
app.UseAuthorization();

// Enable sessions
app.UseSession();


app.MapRazorPages();

app.Run();
