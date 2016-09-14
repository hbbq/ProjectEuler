module Problem_002

let problem =
    Common.fibonacciSeries 
    |> Seq.takeWhile (fun e -> e < 4000000) 
    |> Seq.filter (fun e -> e % 2 = 0) 
    |> Seq.sum

// 4613732