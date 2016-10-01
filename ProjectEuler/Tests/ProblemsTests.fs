module ProblemsTests

open Xunit
open Shouldly

[<Fact>]
let Problem_001() = 
    Problem_001.problem.ShouldBe(233168)

[<Fact>]
let Problem_002() =
    Problem_002.problem.ShouldBe(4613732)

[<Fact>]
let Problem_003() =
    Problem_003.problem.ShouldBe(6857L)

[<Fact>]
let Problem_004() = 
    Problem_004.problem.ShouldBe(906609L)