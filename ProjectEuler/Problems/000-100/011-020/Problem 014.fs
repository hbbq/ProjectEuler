module Problem_014

open Xunit

let problem =
    let seq n =
        let rec i n = seq {
            let isEven y =y % 2.0 = 0.0
            yield n
            match n with
            | 1.0 -> ()
            | _ -> 
                if (isEven n) then yield! i (n/2.0)
                else yield! i (n*3.0+1.0)
        }
        i n
    [1.0..1000000.0] |> List.map (fun e -> (e, (seq e |> Seq.length))) |> List.sortByDescending (fun (a,b) -> b) |> List.head |> fst |> int64

[<Fact>]
let Test() = Assert.Equal(problem, 837799L)