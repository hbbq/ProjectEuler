module Problem_031

open Xunit

let problem =
    let coins = [1;2;5;10;20;50;100;200]
    let find x =
        let arr : int array = Array.zeroCreate (x + 1)
        arr.[0] <- 1;
        for coin in coins do
            for pos in [coin..x] do
                arr.[pos] <- (arr.[pos] + arr.[pos-coin])
        arr.[x]        
    find 200

[<Fact>]
let Test() = Assert.Equal(problem, 73682)