module Problem_023

open Xunit

let problem =
    let limit = 28123
    let arr : int array = Array.create (limit + 1) 0
    let divisorDiff n =
       Common.getDivisors n |> Seq.sum |> fun e -> e - n
    let abundants =
        for x in [12..limit] do
            if arr.[x] = 0 then
                let d = divisorDiff x
                if d > 0 then
                    for y in [x..x..limit] do 
                        arr.[y] <- 1
                elif d = 0 then                    
                    for y in [x*2..x..limit] do 
                        arr.[y] <- 1
                else
                    arr.[x] <- 0
        let s = seq {
            for x in [12..limit] do
                if arr.[x] = 1 then yield x
        }
        s |> Seq.toList
    let sums =
        abundants
        |> List.collect (fun e ->
            abundants |> List.map (fun f -> e + f) |> List.takeWhile (fun f -> f <= limit)
        )
        |> List.distinct
        |> List.sum
    [1..limit] |> List.sum |> fun e -> e - sums
   
[<Fact>]
let Test() = Assert.Equal(problem, 4179871)