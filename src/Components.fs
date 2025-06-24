namespace App

open Feliz
open Fable.Core
open Fable.Core.JsInterop

type Components() = 

    [<ReactComponent>]
    static member Counter() =
        let (count, setCount) = React.useState(0)

        let viteLogo: unit -> unit = import "default" "./assets/vite.svg"
        let reactLogo: unit -> unit = import "default" "./assets/react.svg"
        importSideEffects "./App.css"
        
        Html.div [
            Html.div [
                Html.a [
                    prop.href "https://vite.dev"
                    prop.target "_blank"
                    prop.children [
                        Html.img [
                            prop.src $"{viteLogo}"
                            prop.className "logo"
                            prop.alt "Vite logo"
                        ]
                    ]
                ]
                Html.a [
                    prop.href "https://react.dev"
                    prop.target "_blank"
                    prop.children [
                        Html.img [
                            prop.src $"{reactLogo}"
                            prop.className "logo react"
                            prop.alt "React logo"
                        ]
                    ]
                ]
                Html.a [
                    prop.href "https://fable.io/vite-plugin-fable"
                    prop.target "_blank"
                    prop.children [
                        Html.img [
                            prop.src "https://fable.io/vite-plugin-fable/img/logo.png"
                            prop.className "logo"
                            prop.alt "fable vite plugin logo"
                        ]
                    ]
                ]
            ]
            Html.h1 "Vite + React + Feliz"
            Html.div [
                prop.className "card"
                prop.children [
                    Html.button [
                        prop.onClick (fun _ -> setCount(count + 1))
                        prop.text $"count is {count}"
                    ]
                    Html.p [
                        Html.text "Edit "
                        Html.code "src/App.fs"
                        Html.text " and save to test HMR"
                    ]
                ]
            ]
            Html.p [
                prop.className "read-the-docs"
                prop.text " Click on the Vite, React or Fable Vite Plugin logos to learn more"
            ]
        ]