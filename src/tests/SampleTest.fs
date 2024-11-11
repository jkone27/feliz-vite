module SampleTest

open Fable.Mocha
open Fable.Core.JsInterop

let tests = testList "Sample Tests" [
    testCase "1 + 1 equals 2" <| fun _ ->
        Expect.equal (1 + 1) 2 "1 + 1 should equal 2"
]

Mocha.runTests tests
