module p001

open System
open System.Globalization

let p009 =
    let triplets = [1..998] |> List.collect (fun e -> [1..(999-e)] |> List.map (fun f -> (e,f,(1000-e-f))))
    triplets |> List.tryFind (fun (a,b,c) -> a*a + b*b = c*c) |> (fun e -> e.Value) |> (fun (a,b,c) -> a*b*c)

let p010 =
    let isNotMultiple n x = x = n || x % n <> 0.0
    let rec RemoveMultiples listn listx =
        match listn with
        | head::tail -> RemoveMultiples tail (List.filter (isNotMultiple head) listx)
        | [] -> listx
    let PrimesUpTo n =
        let max = sqrt n
        RemoveMultiples [2.0..max] [2.0..n]
    PrimesUpTo 2000000.0 |> List.sum |> (fun e -> float(e).ToString("00000000000000"))
