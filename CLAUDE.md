# Coze SDK

## Overview
C# SDK for the [Coze API](https://www.coze.com/docs/developer_guides/api_overview) (ByteDance's AI agent/chatbot platform). Auto-generated from the [official OpenAPI spec](https://github.com/coze-dev/coze-sdk-gen).

## Build & Test
```bash
dotnet build Coze.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth
Bearer token (Personal Access Token). Set `COZE_API_KEY` env var for tests.
```csharp
using var client = new CozeClient(apiKey);
```

## Servers
- International: `https://api.coze.com` (default)
- China: `https://api.coze.cn`

## Key Files
- `src/libs/Coze/Generated/` — Auto-generated (never edit)
- `src/libs/Coze/generate.sh` — Regeneration script
- `src/libs/Coze/openapi.yaml` — Source OpenAPI spec
- `src/tests/IntegrationTests/` — Integration tests

## Spec Source
Official: `https://raw.githubusercontent.com/coze-dev/coze-sdk-gen/main/coze-openapi.yaml`

## Spec Fixes (in generate.sh)
1. **Server URL**: Adds `api.coze.com` (international) as primary server alongside `api.coze.cn` (China)
2. **Duplicate `CanvasPosition`**: the document declares `CanvasPosition` and `CanvasPosition1` with
   the same four properties, so the SDK shipped both. This is a merge, not a deletion, and the
   direction matters: the numbered copy is the documented one — its properties carry `title` and
   `x-coze-example`, which become XML docs — so the clean name keeps the richer content. The step
   compares the two on shape alone, ignoring documentation and `x-` extensions, and fails if a
   future spec makes the shapes differ rather than merging two different schemas.

## Tests Without a Key
Every test in `Tests.cs` and `Examples/` needs `COZE_API_KEY` and reports inconclusive without one.
`Tests.OfflineContracts.cs` does not: it round-trips the models the spec fixes above touch, so a
change to the `$ref` graph is checked by something other than "it compiles". Keep it that way —
`dotnet test src/tests/IntegrationTests/` with no key should report passed, not skipped-only.

## API Categories (82 operations)
- **Chat** (v3): Send messages, stream responses, cancel, submit tool outputs
- **Bots**: Create, update, publish, unpublish, list, get info, versions, collaborators
- **Conversations**: Create, list, retrieve, update, clear, messages CRUD
- **Workflows**: Run, stream run, resume, chat flow, get info, list, run histories
- **Audio**: Text-to-speech, speech-to-text (transcriptions), voice cloning, rooms
- **Knowledge/Datasets**: Document CRUD, dataset management, photo documents
- **Files**: Upload, retrieve
- **Workspaces**: Create, update, members, folders
- **Apps/API Apps**: Create, update, events, collaborators
- **Enterprises/Organizations**: Members, organizations
- **Connectors**: Install, configure
- **Commerce/Benefits**: Enterprise benefits, billing
