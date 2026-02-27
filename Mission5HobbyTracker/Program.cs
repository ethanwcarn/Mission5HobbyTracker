// Create a new WebApplication builder with default configuration from command-line args
var builder = WebApplication.CreateBuilder(args);

// Register MVC services (controllers + Razor views) into the dependency injection container
builder.Services.AddControllersWithViews();

// Build the configured WebApplication instance
var app = builder.Build();

// Check if the app is NOT running in the Development environment
if (!app.Environment.IsDevelopment())
{
    // Use a global exception handler that redirects to /Home/Error on unhandled exceptions
    app.UseExceptionHandler("/Home/Error");
    // Enable HTTP Strict Transport Security headers (default 30-day max-age)
    app.UseHsts();
}

// Redirect all HTTP requests to HTTPS for security
app.UseHttpsRedirection();

// Enable endpoint routing middleware so attribute/conventional routes are matched
app.UseRouting();

// Enable authorization middleware to enforce any [Authorize] attributes on controllers/actions
app.UseAuthorization();

// Serve static files from wwwroot (CSS, JS, images, etc.) with fingerprinted asset support
app.MapStaticAssets();

// Configure the default conventional route pattern: {controller=Home}/{action=Index}/{id?}
app.MapControllerRoute(
    name: "default", // Name of the route
    pattern: "{controller=Home}/{action=Index}/{id?}") // URL pattern with defaults
    .WithStaticAssets(); // Enable static asset delivery on this route

// Start the web application and begin listening for incoming HTTP requests
app.Run();
