module Problem_026

open Xunit

let problem =
    let test (n:int) =
        let str = (10I**1500) / bigint(n) |> fun e -> e.ToString()
        if str.EndsWith("00000000000000000") then 1
        else
            let nums = 
                str
                |> fun e -> e.ToCharArray()
                |> Array.map (fun e -> int(e.ToString()))
                |> Array.toList
                |> List.skip 200
            let testpattern l =
                let pat =
                    let c = nums |> List.take l
                    c@c@c
                let ll = min (List.length pat) (List.length nums)
                (pat |> List.take ll) = (nums |> List.take ll)
            {1..(List.length nums)} |> Seq.find testpattern
    [1..999] |> List.map (fun e -> e, test e) |> List.sortByDescending snd |> List.head |> fst

[<Fact>]
let Test() = Assert.Equal(problem, 983)