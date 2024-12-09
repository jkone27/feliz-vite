module ComponentsTests

// https://shmew.github.io/Fable.Jester/#/

open Fable.ReactTestingLibrary
open Fable.Jester
open Feliz

// Import the main app component
open App

Jest.describe("Counter component", fun () ->
    let element = RTL.render(Components.Counter())
        
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
