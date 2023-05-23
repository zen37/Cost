using Cost.Areas.Identity;
using Cost_DataAccess;
using Cost_Services;
using Cost_Services.IRepository;
using Cost_Services.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqUU1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfR1xiSHdTf0dlWntZcQ==;Mgo+DSMBPh8sVXJ1S0R+WFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jTH9Sd0xjUH1Yc3JURw==;ORg4AjUWIQA/Gnt2VFhiQlVPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtSd0RqWXZcdndSQGE=;MjAxNTMxOUAzMjMxMmUzMjJlMzRGNzhJSU5SUVhRNDNJUVZXMFBVaC9ZaTdJZU1pYTBtUTFvNEJhaGo4K2k4PQ==;MjAxNTMyMEAzMjMxMmUzMjJlMzRROWp2SldtOFJncXBWWHB0aHM0UTVZNzlwbUFiNTFCMXpKNi9SRHkrbkNzPQ==;NRAiBiAaIQQuGjN/V0d+Xk9AfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Wd0RiUH9XcnNQR2df;MjAxNTMyMkAzMjMxMmUzMjJlMzRvQTVBSDBoUTBaRjhFR0R0NERvMGFDYkEydkwvQ2FMTm5MckRYdDRKVTYwPQ==;MjAxNTMyM0AzMjMxMmUzMjJlMzRvTXpWdFplVGZrbEdTYzlab0FSc204bnZsdVdkN2dmUzg2V2JaaU9KN0lZPQ==;Mgo+DSMBMAY9C3t2VFhiQlVPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXtSd0RqWXZcd3JWRmM=;MjAxNTMyNUAzMjMxMmUzMjJlMzRXNXJSUisxZWF0UjRnbmR0K01WbDcxY1Q3T1U1SDlTNHNOYm80cUgxODlrPQ==;MjAxNTMyNkAzMjMxMmUzMjJlMzROR21TLy9uQnRWWHpUZlVkRHk5SUN3VCtCRHM5U09tK2R2SlM2NDJqZ1BFPQ==;MjAxNTMyN0AzMjMxMmUzMjJlMzRvQTVBSDBoUTBaRjhFR0R0NERvMGFDYkEydkwvQ2FMTm5MckRYdDRKVTYwPQ==");

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddScoped<IComponentRepository, ComponentRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductComponentRepository, ProductComponentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
