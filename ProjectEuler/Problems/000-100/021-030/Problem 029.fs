module Problem_029

open Xunit

let problem =
    [2..100] 
    |> List.collect (fun e -> 
        [2..100] 
        |> List.map (fun f -> (bigint e)**f)
    ) 
    |> List.distinct 
    |> List.length
     
[<Fact>]
let Test() = Assert.Equal(problem, 9183)