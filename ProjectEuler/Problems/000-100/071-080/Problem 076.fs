module Problem_076

open Xunit

let problem =
    let find x =
        let arr : int array = Array.zeroCreate (x + 1)
        arr.[0] <- 1;
        for fact in [1..x] do
            for pos in [fact..x] do
                arr.[pos] <- (arr.[pos] + arr.[pos-fact])
        arr.[x]        
    find 100
     
[<Fact>]
let Test() = Assert.Equal(problem, 190569292)