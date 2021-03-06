﻿module Problem_021

open Xunit

let problem =
    let divisorsum = (Common.getDivisors >> Seq.sum)
    let test n =
        let divSum1 = divisorsum n
        let divSum2 = divisorsum divSum1
        divSum2 = n && divSum1 <> divSum2
    {1..10000} |> Seq.filter test|> Seq.sum
       
[<Fact>]
let Test() = Assert.Equal(problem, 31626)