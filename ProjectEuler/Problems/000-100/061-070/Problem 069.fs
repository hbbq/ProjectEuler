module Problem_069

open Xunit

let problem =
    let seq = Common.primeSequence |> Seq.takeWhile (fun e -> e <= 500000L) |> Seq.map int |> Seq.toList
    let findFactors n = seq |> List.filter (fun e -> n % e = 0)
    let facts = [2..1000000] |> List.map (fun e -> e, findFactors e) |> Map.ofList
    //let testFactors (x:list<int>) n = x |> List.tryFind (fun e -> n % e = 0) |> fun e -> e.IsNone
    //let testNum n =
    //    let f = findFactors n
    //    [1..n-1] |> List.filter (testFactors f) |> List.length |> fun e -> (float n) / (float e)
    //[2..100000] |> List.map (fun e -> e, (testNum e)) |> List.sortByDescending (fun (a, b) -> b) |> fun e -> fst e.Head
    facts

// NOT COMPLETED
       
[<Fact>]
let Test() = Assert.Equal("not completed", "")