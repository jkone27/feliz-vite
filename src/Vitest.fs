module Vitest

open Fable.Core
open Fable.Core.JsInterop

// Test suite
[<Import("describe", "vitest")>]
let describe: string -> (unit -> unit) -> unit = jsNative

[<Import("it", "vitest")>]
let it: string -> (unit -> unit) -> unit = jsNative

[<Import("test", "vitest")>]
let test: string -> (unit -> unit) -> unit = jsNative

// Lifecycle hooks
[<Import("beforeEach", "vitest")>]
let beforeEach: unit -> unit -> unit = jsNative

[<Import("afterEach", "vitest")>]
let afterEach: unit -> unit -> unit = jsNative

[<Import("beforeAll", "vitest")>]
let beforeAll: unit -> unit -> unit = jsNative

[<Import("afterAll", "vitest")>]
let afterAll: unit -> unit -> unit = jsNative

// Expectations
[<Import("expect", "vitest")>]
let expect: obj -> obj = jsNative

// Mocking
[<Import("vi", "vitest")>]
let vi: obj = jsNative

module Mock =
    let fn<'T>(): 'T = vi?fn()

    let spyOn<'T> (target: obj) (method: string): 'T = 
        vi?spyOn(target, method)

// Example matchers
type Matchers =
    [<Emit("$0.toBe($1)")>]
    member _.toBe(value: obj): unit = jsNative

    [<Emit("$0.toEqual($1)")>]
    member _.toEqual(value: obj): unit = jsNative

    [<Emit("$0.toContain($1)")>]
    member _.toContain(value: obj): unit = jsNative

    [<Emit("$0.toBeTruthy()")>]
    member _.toBeTruthy(): unit = jsNative

    [<Emit("$0.toBeFalsy()")>]
    member _.toBeFalsy(): unit = jsNative

// Helper to cast `expect` to use matchers
let inline expectAs<'T>(value: 'T): Matchers = 
    unbox<Matchers>(expect value)
