# Atlassian MCP Server Setup

This file documents the Atlassian Remote MCP server configuration for this workspace.

## MCP server

- MCP server URL: `https://mcp.atlassian.com/v1/mcp/authv2`
- Official setup guide: https://support.atlassian.com/atlassian-rovo-mcp-server/docs/getting-started-with-the-atlassian-remote-mcp-server/
- Jira integration reference: https://deepwiki.com/atlassian/atlassian-mcp-server/5.1-jira-integration-and-workflows

## Jira connection

- Jira base URL: `https://giobarr.atlassian.net`
- Jira user email: `giovanbarreira@bol.com.br`
- Jira API token: set in environment variable `JIRA_API_TOKEN` or in a secure credential store
- Cloud ID: `7262f766-f476-49d4-b697-85dde8fb3aaf` (resolved via `getAccessibleAtlassianResources`)
- Jira Project Key: `SCRUM` (project name "My Software Team")
- Issue types available: `Epic`, `Tarefa` (Task), `Subtarefa` (Subtask)
- Jira Transitions (workflow used by this project):
  - `11` → Tarefas pendentes (Backlog / To Do)
  - `21` → Em andamento (In Progress)
  - `31` → Em análise (In Review)
  - `41` → Concluído (Done)

## MCP tools (To create and move tickets)

The actual tool names exposed by the Atlassian MCP server (verified working, prefix may vary
per connection, e.g. `mcp_atlassian-mc2_*`):

- `getAccessibleAtlassianResources` — resolve the Cloud ID from the Jira site URL
- `getVisibleJiraProjects` — list/search projects and their issue types
- `getJiraIssue` — get issue details
- `createJiraIssue` — create an issue (`cloudId`, `projectKey`, `issueTypeName`, `summary`, `description`)
- `getTransitionsForJiraIssue` — list available workflow transitions for an issue
- `transitionJiraIssue` — move an issue to a new status via transition `id`
- `searchJiraIssuesUsingJql` — search issues with JQL
- `getJiraProjectIssueTypesMetadata` / `getJiraIssueTypeMetaWithFields` — issue type/field metadata
- `addCommentToJiraIssue` — add a comment

### Verified example

Created `SCRUM-12` and moved it Backlog → In Progress → In Review → Done using the transition
IDs above, confirming the workflow and tool names in this file are correct.