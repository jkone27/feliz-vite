module CounterTests

open Fable.ReactTestingLibrary
open Feliz

// Import the main app component
open App

Vitest.describe "Counter component" (fun () ->
    // beforeEach (
    //     // Setup logic here
    // )
    let element = RTL.render(Components.Counter())

    Vitest.it "should render initial count" (fun () ->
        let countElement = element.getByText("count is 0")
        Vitest.expectAs countElement |> fun e -> e.toBeTruthy()
    )

    Vitest.it "should increment count on button click" (fun () ->
        let buttonElement = element.getByRole("button")
        RTL.fireEvent.click(buttonElement)
        let updatedButtonElement = RTL.screen.getByText("count is 1")
        Vitest.expectAs updatedButtonElement |> fun e -> e.toBeTruthy()
    )
)
