// vite.config.js
import { defineConfig } from "file:///workspaces/feliz-vite/node_modules/vite/dist/node/index.js";
import fable from "file:///workspaces/feliz-vite/node_modules/vite-plugin-fable/index.js";
import react from "file:///workspaces/feliz-vite/node_modules/@vitejs/plugin-react/dist/index.mjs";
import { configDefaults } from "file:///workspaces/feliz-vite/node_modules/vitest/dist/config.js";
var vite_config_default = defineConfig({
  // order of plugins matters, fable needs to be first
  plugins: [
    fable({
      fsproj: "./src/App.fsproj",
      jsx: "automatic"
    }),
    react({
      include: /\.(fs|js|jsx|ts|tsx)$/,
      jsxRuntime: "classic"
    })
  ],
  root: "./src",
  build: {
    outDir: "../dist",
    sourcemap: "inline"
  },
  define: {
    // required if u have: `process is undefined` 
    // while loading react jsoncomponents
    "process.env": {}
  },
  test: {
    include: ["**/*.{test,spec}.{js,jsx,ts,tsx,fs}"],
    exclude: [...configDefaults.exclude, "dist", ".idea", ".git", ".cache"],
    environment: "jsdom",
    setupFiles: "../vitest.ts",
    transform: {
      "^.+\\.fs$": "vite-plugin-fable"
    }
  }
});
export {
  vite_config_default as default
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsidml0ZS5jb25maWcuanMiXSwKICAic291cmNlc0NvbnRlbnQiOiBbImNvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9kaXJuYW1lID0gXCIvd29ya3NwYWNlcy9mZWxpei12aXRlXCI7Y29uc3QgX192aXRlX2luamVjdGVkX29yaWdpbmFsX2ZpbGVuYW1lID0gXCIvd29ya3NwYWNlcy9mZWxpei12aXRlL3ZpdGUuY29uZmlnLmpzXCI7Y29uc3QgX192aXRlX2luamVjdGVkX29yaWdpbmFsX2ltcG9ydF9tZXRhX3VybCA9IFwiZmlsZTovLy93b3Jrc3BhY2VzL2ZlbGl6LXZpdGUvdml0ZS5jb25maWcuanNcIjtpbXBvcnQgeyBkZWZpbmVDb25maWcgfSBmcm9tICd2aXRlJztcbmltcG9ydCBmYWJsZSBmcm9tICd2aXRlLXBsdWdpbi1mYWJsZSc7XG5pbXBvcnQgcmVhY3QgZnJvbSAnQHZpdGVqcy9wbHVnaW4tcmVhY3QnO1xuaW1wb3J0IHsgY29uZmlnRGVmYXVsdHMgfSBmcm9tICd2aXRlc3QvY29uZmlnJztcblxuLy8gaHR0cHM6Ly9ub2phZi5jb20vdml0ZS1wbHVnaW4tZmFibGUvcmVjaXBlcy5odG1sI1VzaW5nLVJlYWN0XG4vLyBodHRwczovL25vamFmLmNvbS92aXRlLXBsdWdpbi1mYWJsZS9yZWNpcGVzLmh0bWwjRmFibGUtQ29yZS1KU1hcblxuZXhwb3J0IGRlZmF1bHQgZGVmaW5lQ29uZmlnKHtcbiAvLyBvcmRlciBvZiBwbHVnaW5zIG1hdHRlcnMsIGZhYmxlIG5lZWRzIHRvIGJlIGZpcnN0XG4gcGx1Z2luczogW1xuIFxuICBmYWJsZSh7IFxuICAgZnNwcm9qOiBcIi4vc3JjL0FwcC5mc3Byb2pcIiwgXG4gICBqc3g6ICdhdXRvbWF0aWMnXG4gIH0pLFxuICByZWFjdCh7XG4gICBpbmNsdWRlOiAvXFwuKGZzfGpzfGpzeHx0c3x0c3gpJC8sXG4gICBqc3hSdW50aW1lOiBcImNsYXNzaWNcIlxuICB9KVxuIF0sXG4gcm9vdDogXCIuL3NyY1wiLFxuIGJ1aWxkOiB7XG4gb3V0RGlyOiBcIi4uL2Rpc3RcIixcbiBzb3VyY2VtYXA6ICdpbmxpbmUnXG4gfSxcbiBkZWZpbmU6IHtcbiAvLyByZXF1aXJlZCBpZiB1IGhhdmU6IGBwcm9jZXNzIGlzIHVuZGVmaW5lZGAgXG4gLy8gd2hpbGUgbG9hZGluZyByZWFjdCBqc29uY29tcG9uZW50c1xuICdwcm9jZXNzLmVudic6IHt9XG4gfSxcbiB0ZXN0OiB7XG4gICBpbmNsdWRlOiBbJyoqLyoue3Rlc3Qsc3BlY30ue2pzLGpzeCx0cyx0c3gsZnN9J10sXG4gICBleGNsdWRlOiBbLi4uY29uZmlnRGVmYXVsdHMuZXhjbHVkZSwgJ2Rpc3QnLCAnLmlkZWEnLCAnLmdpdCcsICcuY2FjaGUnXSxcbiAgIGVudmlyb25tZW50OiAnanNkb20nLFxuICAgc2V0dXBGaWxlczogJy4uL3ZpdGVzdC50cycsIFxuICAgdHJhbnNmb3JtOiB7XG4gICAgICdeLitcXFxcLmZzJCc6ICd2aXRlLXBsdWdpbi1mYWJsZSdcbiAgIH1cbiB9XG59KVxuIl0sCiAgIm1hcHBpbmdzIjogIjtBQUFvUCxTQUFTLG9CQUFvQjtBQUNqUixPQUFPLFdBQVc7QUFDbEIsT0FBTyxXQUFXO0FBQ2xCLFNBQVMsc0JBQXNCO0FBSy9CLElBQU8sc0JBQVEsYUFBYTtBQUFBO0FBQUEsRUFFM0IsU0FBUztBQUFBLElBRVIsTUFBTTtBQUFBLE1BQ0wsUUFBUTtBQUFBLE1BQ1IsS0FBSztBQUFBLElBQ04sQ0FBQztBQUFBLElBQ0QsTUFBTTtBQUFBLE1BQ0wsU0FBUztBQUFBLE1BQ1QsWUFBWTtBQUFBLElBQ2IsQ0FBQztBQUFBLEVBQ0Y7QUFBQSxFQUNBLE1BQU07QUFBQSxFQUNOLE9BQU87QUFBQSxJQUNQLFFBQVE7QUFBQSxJQUNSLFdBQVc7QUFBQSxFQUNYO0FBQUEsRUFDQSxRQUFRO0FBQUE7QUFBQTtBQUFBLElBR1IsZUFBZSxDQUFDO0FBQUEsRUFDaEI7QUFBQSxFQUNBLE1BQU07QUFBQSxJQUNKLFNBQVMsQ0FBQyxxQ0FBcUM7QUFBQSxJQUMvQyxTQUFTLENBQUMsR0FBRyxlQUFlLFNBQVMsUUFBUSxTQUFTLFFBQVEsUUFBUTtBQUFBLElBQ3RFLGFBQWE7QUFBQSxJQUNiLFlBQVk7QUFBQSxJQUNaLFdBQVc7QUFBQSxNQUNULGFBQWE7QUFBQSxJQUNmO0FBQUEsRUFDRjtBQUNELENBQUM7IiwKICAibmFtZXMiOiBbXQp9Cg==
