module Problem_030

open Xunit

let problem =
    let arr = [|0..9|] |> Array.map (fun e -> e*e*e*e*e)
    let test n =
        let sum =
            n.ToString().ToCharArray() |> Array.map (fun e -> e.ToString() |> int) |> Array.sumBy (fun e -> arr.[e])
        sum = n
    [2..1000000] |> List.filter test |> List.sum

[<Fact>]
let Test() = Assert.Equal(problem, 443839)