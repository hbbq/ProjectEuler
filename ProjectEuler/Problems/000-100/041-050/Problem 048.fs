module Problem_048

open Xunit

let problem =
    let cutoff (n: int64) = n % 10000000000L
    let powerWithCutoff n =
        let rec next t n l =
            match l with
            | 0L -> t
            | _ -> next ((t*n) |> cutoff) n (l-1L)
        next 1L n n
    [1L..1000L] |> List.sumBy powerWithCutoff |> cutoff

[<Fact>]
let Test() = Assert.Equal(problem, 9110846700L)