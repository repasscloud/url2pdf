<div align="center">
  <a href="#">
  	<img src="https://media.giphy.com/media/JIX9t2j0ZTN9S/giphy-downsized.gif" alt="Logo project" height="160" />
  </a>
  <br>
  <br>
  <p>
    <b>url2pdf</b>
  </p>
  <p>
     <i>Url2Pdf to capture a URL to a PDF for later</i>
  </p>
  <p>

[![Build Status](https://travis-ci.com/repasscloud/url2pdf.svg?branch=master)](https://travis-ci.com/repasscloud/url2pdf)
[![NPM version](https://img.shields.io/npm/v/url2pdf?style=flat-square)](https://img.shields.io/npm/v/url2pdf?style=flat-square)
[![Package size](https://img.shields.io/bundlephobia/min/url2pdf)](https://img.shields.io/bundlephobia/min/url2pdf)
[![Dependencies](https://img.shields.io/david/repasscloud/url2pdf.svg?style=popout-square)](https://david-dm.org/repasscloud/url2pdf)
[![devDependencies Status](https://david-dm.org/repasscloud/url2pdf/dev-status.svg?style=flat-square)](https://david-dm.org/repasscloud/url2pdf?type=dev)
[![code style: prettier](https://img.shields.io/badge/code_style-prettier-ff69b4.svg?style=flat-square)](https://github.com/prettier/prettier)
[![Twitter](https://img.shields.io/twitter/follow/repasscloud.svg?label=Follow&style=social)](https://twitter.com/repasscloud)

  </p>
</div>

---

**Content**

* [Features](##features)
* [Install](##install)
* [Usage](##usage)
* [Exemples](##exemples)
* [Documentation](##documentation)
* [API](##Api)
* [Contributing](##contributing)
* [Maintainers](##maintainers)

## Features ✨
* Capture PNG of website
* Capture PDF of website

## Install 🐙
1. Clone repository
2. dotnet build

## Usage 💡

```bash
url2pdf --url https://example.com [--pdf]
```

`--url` sets the URL to capture

`--pdf` is a switch to produce a PDF file


## Exemples 🖍

Capture Amazon.com as a PDF
```
url2pdf --url https://www.amazon.com --pdf
```

Capture MSN as a JPG
```
url2pdf --url https://msn.com
```

## Libraries 📚
Libraries used in project:

- [iText7 v7.2.5](https://www.nuget.org/packages/itext7)
- [Noksa.WebDriver.ScreenshotsExtensions v0.1.5.4](https://www.nuget.org/packages/Noksa.WebDriver.ScreenshotsExtensions)
- [Selenium.Support v4.8.2](https://www.nuget.org/packages/Selenium.Support)
- [Selenium.WebDriver v4.8.2](https://www.nuget.org/packages/Selenium.WebDriver)
- [Selenium.WebDriver.GeckoDriver v0.33.0](https://www.nuget.org/packages/Selenium.WebDriver.GeckoDriver)
- [SixLabors.ImageSharp v3.0.1](https://www.nuget.org/packages/SixLabors.ImageSharp)


## Contributing 🍰
Please make sure to read the [Contributing Guide]() before making a pull request.

Thank you to all the people who already contributed to this project!

## Maintainers 👷
List of maintainers, replace all `href`, `src` attributes by your maintainers datas.
<table>
  <tr>
    <td align="center"><a href="https://repasscloud.com"><img src="https://avatars.githubusercontent.com/u/67032541?s=200&v=4" width="100px;" alt="RePass Cloud Pty Ltd"/><br /><sub><b>RePass Cloud Pty Ltd</b></sub></a><br /><a href="#" title="Code">💻</a></td>
  </tr>
  <tr>
    <td align="center"><a href="https://twitter.com/danijeljw"><img src="https://avatars.githubusercontent.com/u/2172792?v=4" width="100px;" alt="Danijel-James Wynyard"/><br /><sub><b>Danijel-James Wynyard</b></sub></a><br /><a href="#" title="Code">💻</a></td>
  </tr>
</table>

## License ⚖️
MIT License

---
<div align="center">
	<b>
		<a href="https://www.npmjs.com/package/get-good-readme">File generated with get-good-readme module</a>
	</b>
</div>
