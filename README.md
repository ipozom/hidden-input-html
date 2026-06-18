# Hidden Input HTML Test Project

This repository contains a minimal ASP.NET Core Razor Pages application built to test detection of HTML hidden input elements in C# source code.

## Purpose

The project is designed to support Checkmarx One testing by including:

- Static hidden inputs in Razor markup
- Dynamically generated hidden HTML strings in C# code
- Rendering of generated HTML via `@Html.Raw(...)`

This allows scanning tools to detect patterns such as `type="hidden"` in both static and dynamic HTML generation contexts.

## Project Structure

- `HiddenInputHtmlApp/` - ASP.NET Core Razor Pages application
  - `Pages/Index.cshtml` - sample page with hidden inputs
  - `Pages/Index.cshtml.cs` - code-behind with C#-generated hidden input examples

## How to run

1. Open a terminal and navigate to the project folder:

```powershell
cd "C:\Users\ipozo\Documents\projects\hidden-input-html\HiddenInputHtmlApp"
```

2. Run the application:

```powershell
dotnet run
```

3. Open the browser and go to the displayed URL, typically:

```text
http://localhost:5000
```

4. Visit the home page to confirm the sample hidden inputs are rendered.

## Build verification

To verify the project compiles successfully:

```powershell
dotnet build
```

## Notes for scanning

Scan the `HiddenInputHtmlApp` source tree with Checkmarx One. Key files to inspect:

- `HiddenInputHtmlApp/Pages/Index.cshtml`
- `HiddenInputHtmlApp/Pages/Index.cshtml.cs`

The app includes:

- `<input type="hidden" ... />` in Razor markup
- `"<input type='hidden' ... />"` generated in C# string literal
- `BuildHiddenInput()` building hidden input with string interpolation

This should help validate detection of hidden HTML input elements in both static and dynamic C#-generated HTML.
