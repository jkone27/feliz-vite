import ora from "ora";
import { exec } from "child_process";
import path from "path";
import { fileURLToPath } from "url";
import fs from "fs";

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Ensure the script runs only when `vite-plugin-fable` is being installed
const packageJsonPath = path.resolve(__dirname, "package.json");

if (!fs.existsSync(packageJsonPath)) {
    console.log("Skipping postinstall: package.json not found");
    process.exit(0);
}

// Read the package.json to verify the package name
const packageJson = JSON.parse(fs.readFileSync(packageJsonPath, "utf8"));
if (!packageJson.devDependencies?.["vite-plugin-fable"]) {
    console.log("Skipping postinstall: Not vite-plugin-fable");
    process.exit(0);
}

const spinner = ora("Setting up vite-plugin-fable... Please wait").start();

const child = exec("npx fable --version", (error, stdout, stderr) => {
    if (error) {
        spinner.fail(`Failed: ${error.message}`);
        console.error(stderr);
        process.exit(1);
    } else {
        spinner.succeed("vite-plugin-fable setup completed!");
        console.log(stdout);
    }
});

child.on("exit", (code) => {
    if (code === 0) {
        spinner.succeed("vite-plugin-fable setup completed!");
    } else {
        spinner.fail("vite-plugin-fable setup failed!");
    }
});
