module Problem_007

open Xunit

let problem =
    Common.primeSequence |> Seq.take 10001 |> Seq.last

[<Fact>]
let Test() = Assert.Equal(problem, 104743L)
