import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import fable from 'fable-vite-plugin'
import { defineConfig } from 'vitest/config'

export default defineConfig({
    plugins: [react(), fable()],
    test: {
        include: ['src/tests/**/*.fs']
    }
})
