module Problem_063

let problem =
    let pow n (x:int) =
        let rec m (x:bigint) (t:bigint) l =
            if l = 0 then x
            else m (x*t) t (l - 1)
        m (bigint 1) (bigint(x)) n
    let charCount x = x.ToString().Length
    let test x =
        [1..9] |> List.map (fun e -> pow x e) |> List.map charCount |> List.filter (fun e -> e = x) |> List.length
    [1..26] |> List.sumBy test

// 49