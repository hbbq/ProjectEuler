module p061

let p063 =
    let pow n (x:int) =
        let rec m (x:bigint) (t:bigint) l =
            if l = 0 then x
            else m (x*t) t (l - 1)
        m (bigint 1) (bigint(x)) n
    let charCount x = x.ToString().Length
    let test x =
        [1..9] |> List.map (fun e -> pow x e) |> List.map charCount |> List.filter (fun e -> e = x) |> List.length
    [1..23] |> List.sumBy test

let p069 =
    let isPrime n =
        if n<2 then false
        elif n = 2 then true
        else
            {2..int(sqrt (float n))} |> Seq.tryFind (fun e -> n % e = 0) |> (fun e -> e.IsNone)
    let seq = Seq.initInfinite (fun e -> if e = 0 then 2 else e * 2 + 1) |> Seq.takeWhile (fun e -> e <= 500000) |> Seq.filter isPrime |> Seq.toList
    let findFactors n = seq |> List.filter (fun e -> n % e = 0)
    let facts = [2..1000000] |> List.map (fun e -> e, findFactors e) |> Map.ofList
    //let testFactors (x:list<int>) n = x |> List.tryFind (fun e -> n % e = 0) |> fun e -> e.IsNone
    //let testNum n =
    //    let f = findFactors n
    //    [1..n-1] |> List.filter (testFactors f) |> List.length |> fun e -> (float n) / (float e)
    //[2..100000] |> List.map (fun e -> e, (testNum e)) |> List.sortByDescending (fun (a, b) -> b) |> fun e -> fst e.Head
    facts
    //ej klar...



