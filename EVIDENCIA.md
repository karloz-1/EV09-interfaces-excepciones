# Evidencia de ejecución

Salidas obtenidas en consola con `dotnet run` y SDK de .NET 10.0.115.

## Reto interfaces: `IMediaPlayer`

Comando:

```bash
dotnet run --project Retos/RetoInterfaces/RetoInterfaces.csproj
```

Salida:

```text
=== RETO INTERFACES: IMediaPlayer ===
Pista cargada: Pista 1 - All I Ever Wanted (Radio Edit)
Reproduciendo: Pista 1 - All I Ever Wanted (Radio Edit)
Pista en pausa: Pista 1 - All I Ever Wanted (Radio Edit)
Pista actual: Pista 1 - All I Ever Wanted (Radio Edit)
Pista detenida: Pista 1 - All I Ever Wanted (Radio Edit)
Pista cargada: Pista 2 - Dream On The Floor (Radio Edit)
Reproduciendo: Pista 2 - Dream On The Floor (Radio Edit)
Pista en pausa: Pista 2 - Dream On The Floor (Radio Edit)
Pista actual: Pista 2 - Dream On The Floor (Radio Edit)
Pista detenida: Pista 2 - Dream On The Floor (Radio Edit)
Fin del programa.
```

Casos comprobados: carga de pista, reproducción, pausa, consulta de la pista actual, detención y carga de una segunda pista.

## Reto excepciones: validación de edad

Comando:

```bash
dotnet run --project Retos/RetoExcepciones/RetoExcepciones.csproj
```

Salida:

```text
=== RETO EXCEPCIONES: validacion de edad ===

Probando el valor: 25
Edad valida: 25 anios.
Finally: se cerro el proceso de validacion.

Probando el valor: abc
Error: la edad debe ser un numero entero.
Finally: se cerro el proceso de validacion.

Probando el valor: -5
Error: La edad -5 no es valida. Debe estar entre 0 y 120 anios. No se permiten edades negativas.
Finally: se cerro el proceso de validacion.

Probando el valor: 150
Error: La edad 150 no es valida. Debe estar entre 0 y 120 anios.
Finally: se cerro el proceso de validacion.
Fin del programa.
```

Casos comprobados: edad válida (25), entrada no numérica (`abc`), edad negativa (`-5`) y edad fuera de rango (`150`). En todos los casos se ejecuta el bloque `finally`.
