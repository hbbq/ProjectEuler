module Problem_010

let problem =
    Common.primeSequence |> Seq.takeWhile (fun e -> e < 2000000L) |> Seq.sum

// 142913828922