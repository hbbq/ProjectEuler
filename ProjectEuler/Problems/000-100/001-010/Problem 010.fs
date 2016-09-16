module Problem_010

open Xunit

let problem =
    Common.primeSequence |> Seq.takeWhile (fun e -> e < 2000000L) |> Seq.sum
  
[<Fact>]
let Test() = Assert.Equal(problem, 142913828922L)