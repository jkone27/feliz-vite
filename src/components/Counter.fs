module App.Components.Counter

open Feliz

[<ReactComponent>]
let El() =
    let (count, setCount) = React.useState(0)

    Html.div [
        prop.className "card"
        prop.children [
            Html.h2 "Counter.fs Yes"
            Html.button [
                prop.onClick (fun _ -> setCount(count + 1))
                prop.text $"count is {count}"
            ]
            Html.p [
                Html.text "Edit "
                Html.code "src/App.fs"
                Html.text " and save to test HMR yes"
            ]
        ]
    ]
        