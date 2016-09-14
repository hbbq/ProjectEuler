module p071

let p076 =
    let find x =
        let arr : int array = Array.zeroCreate (x + 1)
        arr.[0] <- 1;
        for fact in [1..x] do
            for pos in [fact..x] do
                arr.[pos] <- (arr.[pos] + arr.[pos-fact])
        
    find 100
    
let p077 =
    let isPrime n =
        if n<2 then false
        elif n = 2 then true
        else
            {2..int(sqrt (float n))} |> Seq.tryFind (fun e -> n % e = 0) |> (fun e -> e.IsNone)
    let seq = Seq.initInfinite (fun e -> if e = 0 then 2 else e * 2 + 1) |> Seq.filter isPrime
    let find x = 
        let primes = seq |> Seq.takeWhile (fun e -> e <= x) |> Seq.toList
        let arr : int array = Array.zeroCreate (x + 1)
        arr.[0] <- 1;
        for prime in primes do
            for pos in [prime..x] do
                arr.[pos] <- (arr.[pos] + arr.[pos-prime])
        arr |> Array.mapi (fun i e -> i, e) |> Array.find (fun (i, e) -> e >= 5000)
    find 1000

