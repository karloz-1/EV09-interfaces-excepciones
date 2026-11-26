# EV09 - Interfaces y manejo de excepciones

Este repositorio contiene la solución de la evidencia **220501097-04-AA1 – EV09 – Aplicación de la programación orientada a objetos en C# - Interfaces y manejo de excepciones**.

La guía pide dos retos, cada uno en su propio proyecto de consola:

1. **Reto interfaces:** interfaz `IMediaPlayer` implementada por `MusicPlayer`.
2. **Reto excepciones:** validación de edad con `EdadInvalidaException`.

## Estructura

```text
EV09-Interfaces-Excepciones.slnx
Retos/
  RetoInterfaces/
    IMediaPlayer.cs
    MusicPlayer.cs
    Program.cs
  RetoExcepciones/
    EdadInvalidaException.cs
    Program.cs
EVIDENCIA.md
```

## Requisito usado

SDK de .NET 10.0.115 (`dotnet --version`).

## Cómo ejecutar

Desde la raíz del repositorio:

```bash
dotnet build EV09-Interfaces-Excepciones.slnx
dotnet run --project Retos/RetoInterfaces/RetoInterfaces.csproj
dotnet run --project Retos/RetoExcepciones/RetoExcepciones.csproj
```

La evidencia de las ejecuciones está en [EVIDENCIA.md](EVIDENCIA.md).
