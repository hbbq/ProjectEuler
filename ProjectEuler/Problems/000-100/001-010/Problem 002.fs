module Problem_002

open Xunit

let problem =
    Common.fibonacciSeries 
    |> Seq.takeWhile (fun e -> e < 4000000) 
    |> Seq.filter (fun e -> e % 2 = 0) 
    |> Seq.sum
        
[<Fact>]
let Test() = Assert.Equal(problem, 4613732)