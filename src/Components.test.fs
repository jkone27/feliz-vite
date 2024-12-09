module ComponentsTests

open Fable.ReactTestingLibrary
open Fable.Jester
open Feliz

// Import the main app component
open App

Jest.describe("Counter component", fun () ->
    Jest.test("should render initial count", fun () ->
        RTL.render(Components.Counter())
        let countElement = RTL.screen.getByText("count is 0")
        Jest.expect(countElement).toBeInTheDocument()
    )

    Jest.test("should increment count on button click", fun () ->
        RTL.render(Components.Counter())
        let buttonElement = RTL.screen.getByText("count is 0")
        RTL.fireEvent.click(buttonElement)
        let updatedButtonElement = RTL.screen.getByText("count is 1")
        Jest.expect(updatedButtonElement).toBeInTheDocument()
    )
)
