module Problem_024

open Xunit

let problem =
    let s = seq {
        let mutable lft = (1000000 - 1)
        for n in [1..10] do
            let valu = Common.factorial (10-n) |> int
            let choices = 11 - n
            let n = floor (float(lft) / (float valu)) |> int
            lft <- lft - (n * valu)
            yield n
    }
    let mutable picked = ref []
    for p in s do
        let lft = [0..9] |> Common.List.exclude picked.Value |> List.toArray
        picked := picked.Value@[lft.[p]]
    picked.Value |> List.fold (fun a e -> a + e.ToString()) "" |> int64

[<Fact>]
let Test() = Assert.Equal(problem, 2783915460L)