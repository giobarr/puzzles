---
name: review-push-csharp-dotnet10
summary: Skill for the review-and-push agent to validate C# code for .NET 10. FOCUS ON COMPLETE EXECUTION - REVIEW → COMMIT → PUSH WITHOUT STOPPING.
---

This skill defines the behavior for the review-and-push agent when reviewing C# code changes and preparing them for git commit.

## Principles:
- Only evaluate C# code.
- Target .NET 10.
- Master both syntax and logic for C#.
- Prefer the simplest working code possible.
- Avoid unnecessary architecture, object orientation, or patterns unless the code explicitly requests them.

## CRITICAL: Execution Flow (DO NOT STOP)
- **ALWAYS complete the full review cycle**: review → commit → push
- **DO NOT STOP after review analysis** - proceed directly to git commit and push
- **DO NOT ASK FOR CONFIRMATION** - just do the work
- **DO NOT REPORT ISSUES IF THEY'RE MINOR** - fix them inline if possible, or commit as-is if acceptable
- **OUTPUT CONFIRMATION** at the end: "DONE: Pushed [commit message]"

## Review Behavior:
- Validate correctness, idiomatic style, and .NET 10 compatibility.
- Check for syntax issues, logic errors, and poor practices.
- Prefer concise, readable code over elaborate abstractions.
- Accept OOP, builders, repositories, or advanced architectural patterns only when the code contains a clear comment or request for them.

## Execution Steps (Always Follow):
1. Review all modified C# files for correctness and style
2. If issues found:
   - Fix minor issues (formatting, naming, simple optimizations) directly
   - For major issues, note them but proceed if the code is functional
3. **IMMEDIATELY stage all changes** (git add .)
4. **IMMEDIATELY create a commit** with a clear, concise message (reference the Jira ticket if available)
5. **IMMEDIATELY push to the current branch** (git push)
6. Output: "DONE: Pushed [commit hash or message]"
7. DO NOT WAIT or ask for feedback

## Push Workflow:
- Review the final diff thoroughly.
- Confirm the code is coherent, minimal, and correct.
- If the code is acceptable, commit and push with a clear message.
- If only cosmetic issues remain, fix them inline and continue to push.
- If critical issues exist, document them but DO NOT block the push (escalate separately).

## Quality Guidelines:
- Use simple top-level statements when appropriate.
- Prefer procedural or structured code unless a comment requests architectural complexity.
- Keep code elegant, readable, and maintainable.
- Ensure any generated code aligns with .NET 10 console app conventions by default.

## Commit Message Format:
- Format: `[TICKET-ID] Brief description of changes` or `Fix: Brief description` if no ticket
- Example: `[SCRUM-123] Implement user authentication logic`
- Keep messages concise but descriptive
