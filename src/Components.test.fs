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

Jest.describe("MaterialUiLogin component", fun () ->
    let element = RTL.render(Components.MaterialUiLogin())

    Jest.test("should render login form", fun () ->
        let usernameLabel = element.getByText("Username")
        let passwordLabel = element.getByText("Password")
        let submitButton = element.getByText("Submit")
        Jest.expect(usernameLabel).toBeInTheDocument()
        Jest.expect(passwordLabel).toBeInTheDocument()
        Jest.expect(submitButton).toBeInTheDocument()
    )

    Jest.test("should show success message on submit", fun () ->
        let submitButton = element.getByText("Submit")
        RTL.fireEvent.click(submitButton)
        let successMessage = element.getByText("Login successful!")
        Jest.expect(successMessage).toBeInTheDocument()
    )
)
