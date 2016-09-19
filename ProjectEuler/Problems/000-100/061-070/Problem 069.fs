module Problem_069

open Xunit

let problem =
    Common.primeSequence
    |> Seq.scan (fun a e -> a * e) 1L
    |> Seq.takeWhile (fun e -> e < 1000000L)
    |> Seq.last
       
[<Fact>]
let Test() = Assert.Equal(problem, 510510L)