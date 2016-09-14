module Problem_020

let problem =
    let factorial n =
        {2..n} |> Seq.map (fun e -> bigint e) |> Seq.reduce (fun acc e -> acc * e) |> fun e -> e.ToString().ToCharArray() 
        |> Array.map (fun e -> float (e.ToString())) |> Array.sum
    factorial 100

// 648