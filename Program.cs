using System.Security.Principal;

Console.WriteLine("=== WHOAMI ===");
Console.WriteLine();

// Get current Windows identity
var identity = WindowsIdentity.GetCurrent();

Console.WriteLine($"User Name: {identity.Name}");
Console.WriteLine($"Authentication Type: {identity.AuthenticationType}");
Console.WriteLine($"Is Authenticated: {identity.IsAuthenticated}");
Console.WriteLine($"Is System: {identity.IsSystem}");
Console.WriteLine($"Is Guest: {identity.IsGuest}");
Console.WriteLine($"Impersonation Level: {identity.ImpersonationLevel}");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();