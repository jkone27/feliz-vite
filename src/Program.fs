module Program

open Fable.Core.JsInterop
open Browser.Dom
open App

ReactDOM.render(
    App(),
    document.getElementById "root"
)
