# Customizing

The entire theme lives in `template/public/main.css`. You can edit that stylesheet without a build step. [Starlight Theme Flexoki](https://github.com/delucis/starlight-theme-flexoki) is a design reference, not a dependency.

## Choose another accent

The default accent is cyan. For another Flexoki shade, change the `--fx-accent`, `--fx-accent-soft`, and `--fx-accent-hover` values under **both** the light and dark selectors in `template/public/main.css`. Update the corresponding Bootstrap `--bs-link-color-rgb`, `--bs-link-hover-color-rgb`, `--bs-primary-rgb`, and focus ring values as well: Bootstrap's utilities read RGB values separately from CSS colors.

The Starlight theme supports red, orange, yellow, green, cyan, blue, purple, and magenta. Pick the light shade around level 700 and dark shade around level 300, then check interactive-control contrast in both modes. See the [Flexoki palette](https://stephango.com/flexoki#palette) for the full scale.

## Add a landing hero

DocFX modern supports a landing page via `_layout: landing`, but has no Starlight-style `hero` frontmatter or `<Hero>` component. The sample [`index.md`](../index.md) shows a reusable `.fx-hero` HTML block with a title, tagline, link-button actions, and a decorative SVG image. Its styling is in `template/public/main.css` and works without JavaScript. When you replace the image, include it in `build.resource` in `docfx.json` and use `alt=""` only if it is decorative.

## Change site metadata

Change the name, logo, footer, and search setting in `docfx.json`'s `build.globalMetadata` block. The included vector logo is only for this example; substitute your own branding when using the template elsewhere.

## Add your own styles

Since DocFX modern loads `public/main.css` as the customization entry point, edit the installed copy or add overrides at the **end** of the file. Keep the `data-bs-theme` selectors so the dark mode, auto mode, and saved user choice continue to work.
