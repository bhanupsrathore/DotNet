Blazor is a .NET based framework for composing interactive Web UI using combinations
of HTML and C# code known as 'Razor Components'. It includes support for
1. delivering the minimal .NET runtime (mono) to the web-brower in form of
   a 'Web Assembly' (WASM) so that it can execute managed (compiled C#) code
   of razor components.
2. hosting the razor components in an ASP.NET core web-application to provide 
   the backend services required by these components while they execute within
   the client's web-browser.

Quickly create a minimal hosted WASM project

1. Install the custom project template<br>
      dotnet new -i BlazorWasmHostedMin
2. Create new project with above template<br>
      dotnet new blazorwasmhostedmin -o ModernWebApp<br>
      dotnet build

