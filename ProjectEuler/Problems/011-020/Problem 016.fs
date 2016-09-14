module Problem_016

let problem =
    let calc n =
        2I**n |> fun e -> e.ToString("#000000000000000000000").ToCharArray() |> Array.map (fun e -> bigint (float (e.ToString()))) |> Array.sum
    calc 1000

// 1366