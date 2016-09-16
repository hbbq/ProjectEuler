module Problem_052

open Xunit

let problem = 
    let digits n = n.ToString() |> Seq.sort |> Seq.toList
    let isSame a b = (digits a) = (digits b)
    let test n =
        not ( {2..6} |> Seq.exists (fun e -> not ( isSame n (e*n)) ) )
    Common.infinite 1 |> Seq.tryFind test |> fun e -> e.Value
   
[<Fact>]
let Test() = Assert.Equal(problem, 142857)