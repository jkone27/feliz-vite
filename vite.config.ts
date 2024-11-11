import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import fable from 'fable-vite-plugin'

export default defineConfig({
    plugins: [react(), fable()]
})
