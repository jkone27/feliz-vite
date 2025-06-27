module ComponentsTests

// https://shmew.github.io/Fable.Jester/#/
// here jest is used as vitest has much API compatibility

// this is a 'hack' atm, 
// to add extra bindings manually 
// for API compat, see the file `vitest.ts`

open Fable.ReactTestingLibrary
open Fable.Jester

// Import the main app component
open App

Jest.describe("Counter component", fun () ->
    let element = RTL.render(App.Main.El())
        
    Jest.test("should render initial count", fun () ->
        let countElement = element.getByText("count is 0")
        Jest.expect(countElement).toBeInTheDocument()
    )

    Jest.test("should increment count on button click", fun () ->
        let buttonElement = element.getByRole("button" )
        RTL.fireEvent.click(buttonElement)
        let updatedButtonElement = element.getByText("count is 1")
        Jest.expect(updatedButtonElement).toBeInTheDocument()
    )
)
