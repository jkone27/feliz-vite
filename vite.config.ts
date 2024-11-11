import { defineConfig } from 'vite'
import reactRefresh from '@vitejs/plugin-react-refresh'
import fable from 'fable-vite-plugin'
import { defineConfig } from 'vitest/config'

export default defineConfig({
    plugins: [reactRefresh(), fable()],
    test: {
        include: ['src/tests/**/*.fs']
    }
})
