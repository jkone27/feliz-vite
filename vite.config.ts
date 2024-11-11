import { defineConfig } from 'vite'
import reactRefresh from '@vitejs/plugin-react-refresh'
import fable from 'fable-vite-plugin'

export default defineConfig({
    plugins: [reactRefresh(), fable()]
})
