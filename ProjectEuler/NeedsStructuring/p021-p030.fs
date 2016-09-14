module p021

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