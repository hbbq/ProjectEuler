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
 
[<Fact>]
let Problem_005() = 
    Problem_005.problem.ShouldBe(232792560L)
        
[<Fact>]
let Problem_006() = 
    Problem_006.problem.ShouldBe(25164150)
        
[<Fact>]
let Problem_007() =
    Problem_007.problem.ShouldBe(104743L)

[<Fact>]
let Problem_008() =
    Problem_008.problem.ShouldBe(23514624000L)