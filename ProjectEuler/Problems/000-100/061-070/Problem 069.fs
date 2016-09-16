module Problem_069

open Xunit

let problem =
    let max = 1000000
    let rec gcd a b =
        if a = 0 then b
        else gcd (b%a) a
    let phi n =
        [2..n-1]
        |> List.filter (fun e -> (gcd e n) = 1)
        |> List.length
        |> fun e -> e + 1
    let test n =
        float(n) / float(phi n)
    [1..max]
    |> List.map (fun e -> e, test e)
    |> List.sortByDescending snd
    |> List.head

// NOT COMPLETED
       
[<Fact>]
let Test() = Assert.Equal("not completed", "")