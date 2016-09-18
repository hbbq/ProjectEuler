module Problem_017

open Xunit

let problem =
    let c0to9 =
        [0;3;3;5;4;4;3;5;5;4]
    let c0to19 =
        c0to9@[3;6;6;8;8;7;7;9;8;8]
    let c20to99 =
        [6;6;5;5;5;7;6;6]
        |> List.collect (fun e -> c0to9 |> List.map (fun f -> e+f))
    let c0to99 =
        c0to19@c20to99
    let c100to999 =
        c0to9
        |> List.skip 1
        |> List.collect (fun e -> c0to99 |> List.map (fun f -> e+f+7+3))
    let c0to999 =
        c0to99@c100to999
    c0to999 |> List.sum |> fun e -> e+11-(9*3)

[<Fact>]
let Test() = Assert.Equal(problem, 21124)