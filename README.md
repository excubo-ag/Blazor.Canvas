## Excubo.Blazor.Canvas

[![Nuget](https://img.shields.io/nuget/v/Excubo.Blazor.Canvas)](https://www.nuget.org/packages/Excubo.Blazor.Canvas/)
[![Nuget](https://img.shields.io/nuget/dt/Excubo.Blazor.Canvas)](https://www.nuget.org/packages/Excubo.Blazor.Canvas/)
[![GitHub](https://img.shields.io/github/license/excubo-ag/Blazor.Canvas)](https://github.com/excubo-ag/Blazor.Canvas)

Excubo.Blazor.Canvas is wrapper library around the HTML canvas API. It is written purely in C# (i.e., there is absolutely no javascript code you need to add to your project).

[Demo on github.io using Blazor Webassembly](https://excubo-ag.github.io/Blazor.Canvas/)

## How to use

### 1. Install the nuget package Excubo.Blazor.Canvas

Excubo.Blazor.Canvas is distributed [via nuget.org](https://www.nuget.org/packages/Excubo.Blazor.Canvas/).
[![Nuget](https://img.shields.io/nuget/v/Excubo.Blazor.Canvas)](https://www.nuget.org/packages/Excubo.Blazor.Canvas/)

#### Package Manager:
```ps
Install-Package Excubo.Blazor.Canvas -Version 1.2.1
```

#### .NET Cli:
```cmd
dotnet add package Excubo.Blazor.Canvas --version 1.2.1
```

#### Package Reference
```xml
<PackageReference Include="Excubo.Blazor.Canvas" Version="1.2.1" />
```

### 2. Use a `canvas`, or the helper component `Canvas`

```html
@using Excubo.Blazor.Canvas

<Canvas @ref="helper_canvas" width="150px" height="300px" />
<!--OR-->
@inject Microsoft.JSInterop.IJSRuntime js;
<canvas @ref="normal_canvas" width="600px" height="300px"></canvas>
```
```cs
@code {
    private Canvas helper_canvas;
    private ElementReference normal_canvas;
    protected override async Task OnAfterRenderAsync(bool first_render)
    {
        if (first_render)
        {
            await using (var ctx1 = await helper_canvas.GetContext2DAsync())
            {
                await ctx1.FontAsync("48px solid");
                await ctx1.FillTextAsync("Hello", 0, 150);
            }
            await using (var ctx2 = await js.GetContext2DAsync(normal_canvas))
            {
                await ctx2.FontAsync("48px serif");
                await ctx2.StrokeTextAsync("Excubo.Blazor.Canvas", 0, 150);
            }
        }
    }
}
```

Have a look at the fully working examples provided in [the sample project](https://github.com/excubo-ag/Blazor.Canvas/tree/main/TestProject_Components). A demo is available [here](https://excubo-ag.github.io/Blazor.Canvas/).

## Design principles

- Type-safety

Users get a type-safe API that is fully compatible with the canvas API.

- Performance

By combining calls into a batch, high performance is achieved. Whenever you perform a larger amount of calls, you should batch them

- No JS payload

There's no need to load _any_ javascript to use this library.

## Roadmap

For the current implementation state, see [the projects overview](https://github.com/excubo-ag/Blazor.Canvas/projects/)
