module Problem_028

open Xunit

let problem =
    let lst1 = [1]@[2..2..2000]
    let s = seq {
        for n in [8..4..4000] do
            yield n
            yield n
    }
    let lst2 = [0;5;4]@(s |> Seq.toList)
    let nums = [1..1001] |> List.map (fun e -> (lst1 |> List.take e |> List.sum) + (lst2 |> List.take e |> List.sum))
    let sum1 = nums |> List.sum
    nums |> List.sum
     
[<Fact>]
let Test() = Assert.Equal(problem, 669171001)