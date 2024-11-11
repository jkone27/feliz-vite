module Components.Hello

open Feliz

let Hello() =
    Html.div [
        Html.h2 "Hello, world!"
        Html.p "This is a sample component."
    ]
