module Root

open Feliz
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./index.css"

let root = ReactDOM.createRoot(document.getElementById "root")
root.render(App.Main.El())