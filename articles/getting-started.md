# Getting started

This page is part of the runnable example in this repository. It demonstrates the same installation flow that another DocFX project can use.

## Use the template in another site

From your own DocFX project's root, add this repository as a submodule and append its template **after** `modern`:

```sh
git submodule add https://github.com/bahe-msft/docfx-theme-flexoki.git themes/flexoki
```

```json
{
  "build": {
    "template": ["default", "modern", "themes/flexoki/template"]
  }
}
```

Run `docfx docfx.json` to build and `docfx serve _site` to preview it. Your site can keep its own `toc.yml`, Markdown pages, and API metadata configuration. Remember to run `git submodule update --init` after cloning your site. Alternatively, copy only `template/` and use `"template": ["default", "modern", "template"]`; keep the root `LICENSE` and `THIRD_PARTY_NOTICES.md` when redistributing the theme.

> [!NOTE]
> DocFX modern loads `template/public/main.css` after its built-in CSS. Copying the Starlight CSS directly would not work: Starlight's selectors and `data-theme` attribute differ from DocFX's markup and `data-bs-theme` attribute.

## What the sample includes

The navigation on the left leads to a [Markdown and component showcase](showcase.md), [customization guidance](customizing.md), and an API reference generated from a small [C# project](xref:Flexoki.Sample.Swatch). The search box, previous/next links, and theme picker are supplied by DocFX.

### How themes behave

DocFX remembers your choice of light, dark, or automatic mode. Flexoki follows that choice, including for syntax highlighting and the surfaces used by search and navigation. No JavaScript is necessary in this theme.

### Accessibility

Navigation and interactive controls retain DocFX's focus behavior. The theme adds visible focus rings and preserves underlines for article links; it does not use color alone to identify them.
