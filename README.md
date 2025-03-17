# Feliz Vite (a happy life)

![CI](https://github.com/jkone27/feliz-vite/actions/workflows/ci.yml/badge.svg)

![alt text](sample-splash-page.png)

This template was created for a blog post for [fsAdvent calendar 2024](https://jkone27-3876.medium.com/feliz-navidad-fd1869b31044)

The template provides a minimal setup to get React working in Vite with HMR and some ESLint rules, it starts from the basic vite template but it was adapted to run [F#](https://dotnet.microsoft.com/en-us/languages/fsharp) via [Fable](https://fable.io/), and use [Feliz](https://zaid-ajaj.github.io/Feliz/) library for awesome React built in F# DSL. 

As an alternative to the official dotnet [template for Feliz](https://zaid-ajaj.github.io/Feliz/#/Feliz/ProjectTemplate) it adopts the remarkable [Vite Fable Plugin](https://fable.io/vite-plugin-fable/). 

![alt text](vite-fable-plugin.png) 

Currently, two official plugins are available (for react):

- [@vitejs/plugin-react](https://github.com/vitejs/vite-plugin-react/blob/main/packages/plugin-react/README.md) uses [Babel](https://babeljs.io/) for Fast Refresh
- [@vitejs/plugin-react-swc](https://github.com/vitejs/vite-plugin-react-swc) uses [SWC](https://swc.rs/) for Fast Refresh

## special thanks 🦔
- [ZaidAjaj](https://github.com/Zaid-Ajaj)
- [Nojaf](https://github.com/nojaf)
- [MangelMaxime](https://github.com/MangelMaxime)


## npm

clone via git to use with `npm`, you can then install and run as usual 

```
npm i
```

the first install process might take a while, please report issues if u find any, then:

```
npm run dev
```

## bun

if you want to use `bun` 

```cli
bun create jkone27/feliz-vite
```

you can delete `package-lock.json` file then, to have dotnet tools installed correctly **cd** into your directory and run:

```
bun install -D --trust vite-plugin-fable
```

then 
```
bun install
```

then
```
bun run dev
```
