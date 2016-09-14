module Problem_005

let problem =
    let productOfPrimes = [2.0..20.0] |> List.filter (int >> Common.isPrime) |> List.fold (fun acc e -> acc * e) 1.0
    let productOfAll = [2.0..20.0] |> List.fold (fun acc e -> acc * e) 1.0
    let seq = {productOfPrimes..productOfPrimes..productOfAll}
    seq 
    |> Seq.where (fun e -> 
        {3.0..19.0} 
        |> Seq.tryFind (fun f -> e % f <> 0.0) 
        |> fun e -> e.IsNone
    )
    |> Seq.head

// 232792560