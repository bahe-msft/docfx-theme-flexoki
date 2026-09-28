# Showcase

This page exercises DocFX's built-in Markdown renderer, highlight.js, and common documentation components.

## Text and links

Flexoki uses a **warm background**, clear *typography*, and [underlined article links](https://stephango.com/flexoki). Inline code such as `docfx docfx.json` sits on a subtly tinted surface. Long paragraphs should stay readable as the viewport changes.

> Good design makes the useful parts easy to find, without making everything compete for attention.

### Lists

1. Read a guide.
2. Explore the navigation tree.
3. Search for an API symbol.

- Paper and ink surfaces
- Eight original accent families (cyan by default)
- Light and dark code highlighting

## Alerts

> [!NOTE]
> Notes use the Flexoki blue accent.

> [!TIP]
> Tips use green. Use the toolbar to switch between light and dark modes.

> [!IMPORTANT]
> Important information uses purple.

> [!WARNING]
> Warnings use orange so they stand apart from ordinary text.

> [!CAUTION]
> Cautions use red for situations that need extra attention.

## Link buttons

DocFX modern includes Bootstrap button styles, but does not have Starlight's `<LinkButton>` component. Use normal HTML links with `btn` classes; the theme applies Flexoki colors to them:

<div class="fx-link-buttons">
<a class="btn btn-primary" href="getting-started.md">Get started</a>
<a class="btn btn-outline-secondary" href="customizing.md">Customize</a>
<a class="btn btn-link" href="../obj/api/Flexoki.Sample.Swatch.yml">Browse API</a>
</div>

For example, link to the source `.md` file; DocFX rewrites the URL to the generated `.html` page:

```html
<a class="btn btn-primary" href="getting-started.md">Get started</a>
```

## Tabbed content

DocFX tabs let readers switch between alternative examples. Select a language below; DocFX handles the selection without theme-specific JavaScript.

# [C#](#tab/csharp)

Get a named color from the sample API:

```csharp
using Flexoki.Sample;

Console.WriteLine(Swatch.Paper.Hex);
```

# [JavaScript](#tab/javascript)

Use the same color in a browser:

```js
const paper = '#FFFCF0';
document.documentElement.style.setProperty('--my-paper', paper);
```

---

## Syntax highlighting

```csharp
using Flexoki.Sample;

var swatch = new Swatch("Paper", "#FFFCF0");
Console.WriteLine($"{swatch.Name}: {swatch.Hex}");
```

```js
// Tokens are regular CSS custom properties.
const colors = { paper: '#fffcf0', ink: '#100f0f' };
console.log(colors.paper);
```

```css
:root[data-bs-theme='dark'] {
  --fx-paper: #100f0f;
  --fx-ink: #cecdc3;
}
```

### Code from a source file

DocFX can also pull a snippet directly from the [sample API source](xref:Flexoki.Sample.Swatch), so the documentation stays in sync with the code:

[!code-csharp[Swatch record](../samples/Flexoki.Sample/Swatch.cs#L6-L13)]

## Tables

| Role | Light | Dark |
| --- | --- | --- |
| Background | `#FFFCF0` | `#100F0F` |
| Foreground | `#100F0F` | `#CECDC3` |
| Default accent | `#1C6C66` | `#5ABDAC` |

## Details

Use native HTML `<details>` and `<summary>` to hide optional information without adding JavaScript:

<details>
<summary>Where do the Flexoki colors come from?</summary>
<p>The palette comes from <a href="https://stephango.com/flexoki">Steph Ango's Flexoki</a>. The light background is <code>#FFFCF0</code> (paper), while the dark background is <code>#100F0F</code> (ink).</p>
</details>

## Next steps

Learn [how to customize the theme](customizing.md), or visit the [generated API reference](xref:Flexoki.Sample.Swatch).
