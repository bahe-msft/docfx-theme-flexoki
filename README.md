# Flexoki for DocFX

A CSS-first [Flexoki](https://stephango.com/flexoki) theme for the [DocFX modern template](https://dotnet.github.io/docfx/docs/template.html), inspired by [Starlight Theme Flexoki](https://github.com/delucis/starlight-theme-flexoki). The repository is also a **runnable sample documentation site**.

## Preview the sample

Requires the .NET 8 SDK and DocFX. Tested with DocFX 2.80.1:

```sh
dotnet tool install --global docfx --version 2.80.1
# Ensure ~/.dotnet/tools is on PATH, then from the repository root:
docfx docfx.json --warningsAsErrors
docfx serve _site
```

Visit the URL printed by `docfx serve`. The sample contains a responsive [landing hero](index.md), a [component showcase](articles/showcase.md) (tabs, link buttons, tables, details, alerts, and source snippets), navigation, search, and a generated .NET API reference. `_site/` and other build artifacts are ignored by Git.

## Use the theme in another DocFX site

From your **other** DocFX project's root, add this repository as a Git submodule (so you can update it later):

```sh
git submodule add https://github.com/bahe-msft/docfx-theme-flexoki.git themes/flexoki
```

Merge this `template` setting into your existing `docfx.json` build configuration, **after** the built-in templates. Paths are relative to `docfx.json`:

```json
{
  "build": {
    "template": ["default", "modern", "themes/flexoki/template"]
  }
}
```

Build with `docfx docfx.json` and serve the output. On a fresh clone of your project, run `git submodule update --init` before building. The theme itself needs no npm packages, custom template partials, or custom JavaScript. Your existing TOC, articles, and API metadata can stay as they are.

**Without submodules:** copy just `template/` into your project and use `["default", "modern", "template"]` instead. When redistributing the theme, **retain `LICENSE` and `THIRD_PARTY_NOTICES.md`** with it (or incorporate them into your project's license notices).

Only `template/public/main.css` is required for the **theme**. The sample's `docfx.json`, pages, C# project, and `images/` (including the hero art) are optional example content. If you copy the hero markup from `index.md`, also copy its image or use your own and include it in `build.resource`.

## How it works

- **Color modes:** DocFX modern handles light, dark, and auto switching; the CSS follows its `html[data-bs-theme]` attribute. Cyan is the default accent. See [customization](articles/customizing.md) for changing it.
- **Landing hero:** `_layout: landing` in `index.md` selects DocFX's landing layout. The `.fx-hero` HTML and CSS provide the hero itself; DocFX has no Starlight `<Hero>` component.
- **Components:** DocFX-native tabs and alerts are restyled. Link buttons are normal HTML `<a class="btn …">` links using DocFX's Bootstrap styles; `<details>` is native HTML.
- **Code:** DocFX modern uses highlight.js, so this theme translates Flexoki syntax colors into `.hljs-*` styles rather than using Starlight's Expressive Code themes.

This theme targets **DocFX modern**, not the legacy `default` template alone. It preserves DocFX's built-in navigation, search, API pages, and theme picker.

## Repository layout

| Path | Purpose |
| --- | --- |
| `template/public/main.css` | Reusable DocFX modern theme. |
| `docfx.json`, `toc.yml`, `index.md` | Runnable sample site configuration, navigation, and landing page. |
| `articles/` | Guides and component showcase. |
| `samples/Flexoki.Sample/` | Minimal .NET project for generating API reference pages. |
| `images/` | Sample logo, favicon, and original hero art. |
| `.github/workflows/build.yml` | Sample build check with warnings treated as errors. |

## License and credits

Original code and artwork in this repository are [MIT-licensed](LICENSE). Flexoki's palette and the Starlight theme are also MIT-licensed; their copyright and license notices are in [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md). This is an independent DocFX port, not an Astro/Starlight plugin.
