module Problem_004

let problem =
    let x n = [100..999] |> List.map (fun e -> e * n)
    [100..999] 
    |> List.collect (fun e -> x e) 
    |> List.sortDescending
    |> List.map (fun e -> e.ToString()) 
    |> List.map (fun e -> (e, e |> Common.String.Reverse))
    |> List.tryFind (fun (a,b) -> a = b)
    |> fun e -> fst e.Value

// 906609