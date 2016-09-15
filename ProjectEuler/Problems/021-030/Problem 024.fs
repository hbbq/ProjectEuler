module Problem_024

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
    let mutable picked = []
    for p in s do
        let lft = [0..9] |> Common.List.exclude picked |> List.toArray
        picked <- picked@[lft.[p]]
    picked |> List.fold (fun a e -> a + e.ToString()) "" |> int64

// 2783915460