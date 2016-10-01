module ProblemsTests

open Xunit
open Shouldly

[<Fact>] let Problem_001() = Problem_001.problem.ShouldBe(233168)