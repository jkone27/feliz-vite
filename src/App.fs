module App

open Feliz

let App() =
    Html.div [
        Html.h1 "Welcome to Feliz + Next.js + Vite"
        Html.p "This is a sample application."
        Components.Hello()
    ]
