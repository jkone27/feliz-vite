module AppTest

open Fable.Mocha
open Fable.Core.JsInterop
open Feliz

let tests = testList "App Tests" [
    testCase "App renders correctly" <| fun _ ->
        let app = ReactDOM.renderToString(App())
        Expect.isTrue (app.Contains("Welcome to Feliz + Next.js + Vite")) "App should render the welcome message"
]

Mocha.runTests tests
