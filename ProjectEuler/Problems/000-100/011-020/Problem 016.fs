module Problem_016

open Xunit

let problem =
    let calc n =
        2I**n |> fun e -> e.ToString("#000000000000000000000").ToCharArray() |> Array.map (fun e -> bigint (float (e.ToString()))) |> Array.sum
    calc 1000

[<Fact>]
let Test() = Assert.Equal(problem, 1366I)