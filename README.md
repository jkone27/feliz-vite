# WIP: Feliz + Vite HMR + NextJs

## Create a Feliz Next.js App using Vite and Bun

This guide will help you create a repository like 'create-feliz-app' using Next.js, React, F# Feliz template, fable-vite plugin, and Bun.

### Prerequisites

- Node.js (>= 14.x)
- Bun (>= 0.1.0)
- .NET SDK (>= 5.0)

### Steps

1. **Create a new directory for your project:**

   ```sh
   mkdir my-feliz-app
   cd my-feliz-app
   ```

2. **Initialize a new Bun project:**

   ```sh
   bun init
   ```

3. **Install dependencies:**

   ```sh
   bun add next react react-dom fable-compiler@^3.7.0 fable-vite-plugin@^2.0.0
   ```

4. **Set up the project structure:**

   ```sh
   mkdir -p src/Components src/Pages
   touch src/index.fs src/App.fs src/Components/Hello.fs src/Pages/Index.fs vite.config.ts next.config.js
   ```

5. **Add the following content to `src/index.fs`:**

   ```fsharp
   module App

   open Feliz
   open Browser.Dom

   ReactDOM.render(
       App(),
       document.getElementById "root"
   )
   ```

6. **Add the following content to `src/App.fs`:**

   ```fsharp
   module App

   open Feliz

   let App() =
       Html.div [
           Html.h1 "Welcome to Feliz + Next.js + Vite"
           Html.p "This is a sample application."
           Components.Hello()
       ]
   ```

7. **Add the following content to `src/Components/Hello.fs`:**

   ```fsharp
   module Components.Hello

   open Feliz

   let Hello() =
       Html.div [
           Html.h2 "Hello, world!"
           Html.p "This is a sample component."
       ]
   ```

8. **Add the following content to `src/Pages/Index.fs`:**

   ```fsharp
   module Pages.Index

   open Feliz

   let Index() =
       Html.div [
           Html.h1 "Welcome to the Index Page"
           Html.p "This is the main page of the application."
       ]
   ```

9. **Add the following content to `vite.config.ts`:**

   ```typescript
   import { defineConfig } from 'vite'
   import reactRefresh from '@vitejs/plugin-react-refresh'
   import fable from 'fable-vite-plugin'

   export default defineConfig({
       plugins: [reactRefresh(), fable()]
   })
   ```

10. **Add the following content to `next.config.js`:**

    ```javascript
    module.exports = {
        reactStrictMode: true,
    }
    ```

11. **Update `package.json` with the following scripts:**

    ```json
    {
      "scripts": {
        "dev": "vite",
        "build": "vite build",
        "start": "vite preview"
      }
    }
    ```

12. **Run the development server:**

    ```sh
    bun dev
    ```

Your Feliz Next.js app using Vite and Bun should now be up and running!

### Running Unit Tests

To run unit tests using `vitest`, follow these steps:

1. **Install vitest and @vitest/ui:**

   ```sh
   bun add -D vitest @vitest/ui
   ```

2. **Add a test script to `package.json`:**

   ```json
   {
     "scripts": {
       "test": "vitest"
     }
   }
   ```

3. **Create a `tests` directory in `src` and add a sample test file `SampleTest.fs`:**

   ```fsharp
   module SampleTest

   open Fable.Mocha
   open Fable.Core.JsInterop

   let tests = testList "Sample Tests" [
       testCase "1 + 1 equals 2" <| fun _ ->
           Expect.equal (1 + 1) 2 "1 + 1 should equal 2"
   ]

   Mocha.runTests tests
   ```

4. **Configure vitest in `vite.config.ts` to include the `tests` directory:**

   ```typescript
   import { defineConfig } from 'vitest/config'

   export default defineConfig({
       test: {
           include: ['src/tests/**/*.fs']
       }
   })
   ```

5. **Run the tests:**

   ```sh
   bun test
   ```
