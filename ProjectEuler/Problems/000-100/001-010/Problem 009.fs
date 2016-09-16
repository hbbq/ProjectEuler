module Problem_009

open Xunit

let problem =
    let pairs = 
        [1.0..998.0] 
        |> List.collect (fun e -> 
            [e+1.0..999.0-e] 
            |> List.map (fun f -> (e, f))
        )
    pairs 
    |> List.map (fun (a, b) -> (a, b, sqrt (a*a + b*b))) 
    |> List.filter (fun (a,b,c) -> a+b+c = 1000.0)
    |> List.head
    |> fun (a,b,c) -> a*b*c
    |> int64

[<Fact>]
let Test() = Assert.Equal(problem, 31875000L)