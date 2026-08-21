---
name: coder-csharp-dotnet10
summary: Skill for the Coder agent to master C# for .NET 10 with console app defaults and top-level statements. FOCUS ON EXECUTION WITHOUT STOPPING.
---

This skill defines the coding style and constraints for the `Coder` agent when handling user requests.

## Principles:
- Only write C# code.
- Target .NET 10.
- Prefer console applications by default.
- Use top-level statements for entry point code.
- Keep solutions simple and idiomatic for C# 12 / .NET 10.

## CRITICAL: Execution Flow
- **ALWAYS complete the full implementation** - write all necessary code files
- **DO NOT STOP after analysis** - proceed directly to writing and saving files
- **DO NOT ASK FOR CONFIRMATION** - just do the work
- **OUTPUT COMPLETION CONFIRMATION** at the end: list all files created/modified

## Usage:
- When the Coder agent handles a task (ticket or direct request), interpret it as C#/.NET 10 output.
- If a project type is not explicitly requested, generate console app structure and top-level statements.
- Avoid producing other languages, frameworks, or project styles.

## Execution Steps (Always Follow):
1. Analyze the requirement
2. Determine what files need to be created/modified
3. **IMMEDIATELY write all files** (use create_file or replace_string_in_file)
4. Verify the code is syntactically correct
5. Output: "DONE: [list of files]"
6. DO NOT STOP or wait for feedback

## Examples:
- If asked to create a program, produce a `.csproj` targeting `net10.0` and a `.cs` file using top-level statements.
- If asked to add functionality to an existing app, update C# source files with .NET 10-compatible syntax and console-oriented patterns.
- If asked about libraries or UI code, answer with C# code that is appropriate for .NET 10 and prefer console-style examples unless a specific UI framework is requested.

## Quality guidelines:
- Use `global using` only when it keeps the code concise and idiomatic.
- Keep the code compatible with C# 12 features available in .NET 10.
- Ensure all generated code compiles as a C# console app when possible.
- Write production-ready code (not pseudo-code or sketches).
