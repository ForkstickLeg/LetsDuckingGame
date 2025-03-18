import { fileURLToPath, URL } from "node:url";
import { defineConfig } from "vite";
import plugin from "@vitejs/plugin-vue";

export default defineConfig({
  plugins: [plugin()],
  resolve: {
    alias: {
      "@": fileURLToPath(new URL("./src", import.meta.url)),
    },
  },
  server: {
    proxy: {
      "^/weatherforecast": {
        target: process.env.ASPNETCORE_HTTPS_PORT
          ? `https://localhost:${process.env.ASPNETCORE_HTTPS_PORT}`
          : process.env.ASPNETCORE_URLS
          ? process.env.ASPNETCORE_URLS.split(";")[0]
          : "https://localhost:7090",
        secure: false,
      },
    },
    port: parseInt(process.env.DEV_SERVER_PORT || "63968"),
    https: undefined, // Disable HTTPS
  },
});
