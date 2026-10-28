# AGENTS.md

Notes for anyone, human or AI agent, changing this code. There is no README; this file is the only guide.

## What this is

A tiny console program in C# on .NET 8 (`net8.0`) that prints the current Windows identity: user name,
authentication type, whether it is authenticated, system or guest, and the impersonation level. It then waits for a
key press.

It uses `System.Security.Principal.WindowsIdentity`, so it only works on Windows. It compiles elsewhere, but it
throws when run on Linux or macOS.

## Commands

```bash
dotnet build whoami.csproj        # there is no solution file
dotnet run --project whoami.csproj   # Windows only; press a key to exit
```

There are no tests yet.

## Layout

- `Program.cs`: the whole program, in top-level statements.
- `whoami.csproj`: console app, `net8.0`, nullable and implicit usings on.
- `bin/` and `obj/`: Debug build output from `net8.0`, committed to the repository. There is no `.gitignore`.
- `.idea/`: JetBrains Rider settings.

## Rules that keep it working

- **Committed build output.** `bin/` and `obj/` are tracked by git, so building changes tracked files. Don't
  commit rebuilt output by accident, and don't delete those folders without deciding to stop tracking them.
- **Windows-only API.** Keep the `WindowsIdentity` calls behind Windows; if you want it to run elsewhere, guard
  them with `OperatingSystem.IsWindows()`.

## Making a change

- Keep it a single `Program.cs` unless it grows a real reason to split.
- Run it on Windows to check the output, since there are no tests.
