module Problem_019

open Xunit

let problem =
    let mutable d = 0
    let months = [|31;28;31;30;31;30;31;31;30;31;30;31|]
    let s = seq {
        for y in [1900..2000] do
            for m in [0..11] do
                if y > 1900 && d = 6 then yield (y,m)
                if m = 1 && y % 4 = 0 && (y % 100 <> 0 || y % 400 = 0) then d <- d + 1
                d <- (d + months.[m]) % 7
    }
    s |> Seq.length
      
[<Fact>]
let Test() = Assert.Equal(problem, 171)