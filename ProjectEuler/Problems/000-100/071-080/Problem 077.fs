module Problem_077

open Xunit

let problem =
    let find x = 
        let primes = Common.primeSequence |> Seq.map int |> Seq.takeWhile (fun e -> e <= x) |> Seq.toList
        let arr : int array = Array.zeroCreate (x + 1)
        arr.[0] <- 1;
        for prime in primes do
            for pos in [prime..x] do
                arr.[pos] <- (arr.[pos] + arr.[pos-prime])
        arr |> Array.mapi (fun i e -> i, e) |> Array.find (fun (i, e) -> e >= 5000)
    find 1000 |> fst
     
[<Fact>]
let Test() = Assert.Equal(problem, 71)