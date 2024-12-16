module App

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Feliz.Router

importSideEffects "./index.css"

let root = ReactDOM.createRoot(document.getElementById "root")

let menu = 
    Html.div [
        Html.a [
            prop.href (Router.formatPath [])
            prop.text "Home"
        ]
        Html.a [
            prop.href (Router.formatPath ["login"])
            prop.text "Login"
        ]
    ]

let homePage = 
    Html.div [
        menu
        App.Components.Counter()
    ]

let loginPage = 
    Html.div [
        menu
        App.Components.MaterialUiLogin()
    ]

let app = 
    React.router [
        router.onUrlChanged (fun url ->
            match url with
            | [] -> homePage
            | ["login"] -> loginPage
            | _ -> Html.h1 "Page not found"
        )
    ]

root.render(app)