module Problem_012

open Xunit

let problem =
    let factorCount (n:int64) = 
        seq {
            let fn = float n
            yield 2
            yield! seq {
                for t in ([2.0..sqrt fn] |> List.filter (fun e -> fn % e = 0.0)) do
                    yield 2
            }
        }
        |> Seq.sum
    Common.infinite 1 
    |> Seq.map int64 
    |> Seq.scan (fun a e -> a + e) 0L
    |> Seq.tryFind (fun e -> factorCount e > 500)
    |> fun e -> e.Value
    
[<Fact>]
let Test() = Assert.Equal(problem, 76576500L)