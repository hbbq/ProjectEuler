module Problem_053

open Xunit

let problem =
    let c n r = (Common.factorial n) / ((Common.factorial r) * (Common.factorial (n-r)))
    let c2 n r = 
        let u = [r+1..n] |> List.fold (fun a e -> a * bigint(e)) 1I
        let d = Common.factorial (n-r)
        u / d
    let test n = [1..n-1] |> List.map (fun e -> c2 n e) |> List.where (fun e -> e > 1000000I) |> List.length
    [20..100] |> List.sumBy test
       
[<Fact>]
let Test() = Assert.Equal(problem, 4075)