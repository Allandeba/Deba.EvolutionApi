# Deba.EvolutionApi

![CI Status](https://github.com/allandeba/Deba.EvolutionApi/actions/workflows/publish.yml/badge.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/allandeba/Deba.EvolutionApi/blob/main/LICENSE)

Contém solução para integração com EvolutionApi V2

## Versionamento

Para adicionar minor ou major no package deve ser feito um commit com a seguinte nomenclatura:

- Major: `+semver: breaking` ou `+semver: major`
- Minor: `+semver: feature` ou `+semver: minor`
- Patch: `+semver: fix` ou `+semver: patch`

## Instalação

```bash
dotnet add package Deba.EvolutionApi
```

## Utilização

```bash
var options = new EvolutionApiOptions
{
    ApiUrl = "",
    ApiKey = "",
};

builder.Services.AddDebaEvolutionApi(options);
```