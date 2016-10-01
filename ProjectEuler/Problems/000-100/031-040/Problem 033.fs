module Problem_033

open Xunit
open Shouldly

let problem =
    123

//Not 

[<Fact>]
let Test() = problem.ShouldBe(123);