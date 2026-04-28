# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

This is a Pulumi provider for Dynatrace, built by bridging the [terraform-provider-dynatrace](https://github.com/dynatrace-oss/terraform-provider-dynatrace) via `pulumi-terraform-bridge`. The provider exposes Dynatrace resources and data sources to Pulumi programs in Node.js, Python, Go, .NET, and Java.

## Key Commands

```bash
# Build the provider binary and regenerate the schema
make tfgen

# Build the provider binary (depends on tfgen)
make provider

# Build all language SDKs (Node.js, Python, Go, .NET)
make build_sdks

# Build a specific SDK
make build_nodejs
make build_python
make build_go
make build_dotnet

# Full development build (provider + all SDKs)
make development

# Lint the provider
make lint_provider

# Run integration tests (requires real Dynatrace credentials)
cd examples && go test -v -tags=all -parallel 10 -timeout 2h

# Clean generated SDK output
make clean
```

## Architecture

The repo has three top-level Go modules:

- **`provider/`** — the core provider module. `resources.go` is the single file that registers every Terraform resource and data source with the Pulumi bridge. The `Provider()` function there is the main entry point.
- **`sdk/`** — generated multi-language SDKs (do not edit by hand; regenerate with `make build_sdks`).
- **`examples/`** — integration tests that provision real cloud resources.

### How the bridge works

1. `make tfgen` compiles `provider/cmd/pulumi-tfgen-dynatrace`, runs it to produce `provider/cmd/pulumi-resource-dynatrace/schema.json`, then invokes `go generate` to embed it as `schema-embed.json`.
2. `make provider` compiles `provider/cmd/pulumi-resource-dynatrace`, which embeds `schema-embed.json` at build time via `//go:embed`.
3. Language SDKs are generated from the schema by running the tfgen binary with each language target.

### Adding or modifying resources

All resource and data source mappings live in `provider/resources.go`. After any change there:
1. Run `make build_sdks` to regenerate all SDKs.
2. Commit the regenerated SDK files alongside the `resources.go` change.

### Provider configuration

The provider accepts `dt_env_url`, `dt_api_token`, and `dt_cluster_api_token`, which can also be supplied via environment variables `DYNATRACE_ENV_URL` / `DT_ENV_URL`, `DYNATRACE_API_TOKEN` / `DT_API_TOKEN`, etc.
