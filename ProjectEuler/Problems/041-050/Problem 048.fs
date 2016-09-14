module Problem_048

let problem =
    let cutoff (n: int64) = n % 10000000000L
    let powerWithCutoff n =
        let rec next t n l =
            match l with
            | 0L -> t
            | _ -> next ((t*n) |> cutoff) n (l-1L)
        next 1L n n
    [1L..1000L] |> List.sumBy powerWithCutoff |> cutoff

// 9110846700