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
Install-Package Excubo.Blazor.Canvas -Version 2.1.1
```

#### .NET Cli:
```cmd
dotnet add package Excubo.Blazor.Canvas --version 2.1.1
```

#### Package Reference
```xml
<PackageReference Include="Excubo.Blazor.Canvas" Version="2.1.1" />
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

## JS naming convention

You want to use the canvas API in C# and use the same method names as you would in javascript? No problem! Starting with v2.0.0 of Excubo.Blazor.Canvas, you can write `context.JS` instead of `context` and you'll have what you're used to.
Note that this is only a different name. The cost of the method calls are still the same and every call is still async and therefore should be awaited.

```cs
// C# naming convention
await using (var ctx = await helper_canvas.GetContext2DAsync())
{
    await ctx.FontAsync("48px solid");
    await ctx.FillTextAsync("Hello", 0, 150);
}
// JS naming convention
await using (var ctx = await helper_canvas.GetContext2DAsync())
{
    await ctx.JS.font("48px solid");
    await ctx.JS.fillText("Hello", 0, 150);
}
```

## Helper groups for API regions

The HTML canvas API is a large collection of methods and fields. This sometimes makes it hard to find the right method for your task. In Excubo.Blazor.Canvas, the methods are additionally grouped into

- Canvas state
- Compositing
- Drawing images
- Drawing paths
- Drawing rectangles
- Drawing text
- Fill and stroke styles
- Filters
- Image smoothing
- Line styles
- Paths
- Pixel manipulation
- Shadows
- Text styles
- Transformations

You can make use of this by writing e.g. `await context.Shadows.BlurAsync(2.0); await context.CanvasState.SaveAsync();` instead of `await context.ShadowBlurAsync(2.0); await context.SaveAsync();`.
This helps make the intent of the code clearer, and helps finding the right method quicker.

Groups are a feature made possible by [Excubo.Generators.Grouping](https://github.com/excubo-ag/Generators.Grouping).

## Design principles

- Type-safety

Users get a type-safe API that is fully compatible with the canvas API.

- Performance

By combining calls into a batch, high performance is achieved. Whenever you perform a larger amount of calls, you should batch them

- No JS payload

There's no need to load _any_ javascript to use this library.

## Roadmap

For the current implementation state, see [the projects overview](https://github.com/excubo-ag/Blazor.Canvas/projects/)
