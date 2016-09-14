module p021

let p021 =
    let divisors n = {1..n/2} |> Seq.filter (fun e -> n % e = 0)
    let divisorsum n = n |> divisors |> Seq.sum
    let test n =
        let b = divisorsum n
        let a = divisorsum b
        if (a = n && a <> b) then n
        else 0
    {1..10000} |> Seq.map test |> Seq.distinct |> Seq.sum

    
//let p023 =
//    let divisors n = [1..n/2] |> List.filter (fun e -> n % e = 0)
//    let divisorsum n = n |> divisors |> List.sum
//    let max = 28123
//    let abundants = [1..max] |> List.where (fun e -> divisorsum e > e)
//    let abundantsums = abundants |> List.collect (fun e -> abundants |> List.where (fun i -> i < e) |> List.map (fun x -> x+e)) |> List.where (fun e -> e <= max) |> List.distinct
//    [1..max] |> List.filter (fun e -> not(List.contains e abundantsums)) |> List.sum

let p024 =
    let notIn s v = v |> List.where (fun e -> not (List.contains e s))
    let set = [0..9]
    let permute s =
        let rec repeat thusfar = seq {
            let left = s |> notIn thusfar
            match left with
            | [] -> yield (thusfar)// |> Seq.fold (fun a b -> a*10 + b) 0)
            | _ -> for nn in left do yield! repeat (thusfar@[nn])
        }
        repeat []
    permute set |> Seq.take 1000000 |> Seq.last

let p029 =
    [2..100] |> List.collect (fun e -> [2..100] |> List.map (fun f -> (bigint e)**f)) |> List.distinct |> List.length