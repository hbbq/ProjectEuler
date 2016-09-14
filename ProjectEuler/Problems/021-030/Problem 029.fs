module Problem_029

let problem =
    [2..100] 
    |> List.collect (fun e -> 
        [2..100] 
        |> List.map (fun f -> (bigint e)**f)
    ) 
    |> List.distinct 
    |> List.length

// 9183