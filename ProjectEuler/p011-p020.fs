module p011

//p011
//
//let p012 =
//    let numberOfDivisors n = [2..n/2] |> List.filter (fun e -> n % e = 0) |> (fun e -> List.length e + 2)
//    let sum n = [1.0..float(n)] |> List.sum
//    //let seq = Seq.initInfinite (fun e -> sum e)
//    let v = [2.0..500.0] |> List.fold (fun acc e -> acc * e) 1.0
//    let seq =
//        let rec i n x = seq {
//            yield x
//            yield! i (n+1) (x+n)
//        }
//        i 1 0
//    seq |> Seq.tryFind (fun e -> numberOfDivisors e > 500)

//p013

let p014 =
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
    [1.0..1000000.0] |> List.map (fun e -> (e, (seq e |> Seq.length))) |> List.sortByDescending (fun (a,b) -> b) |> List.take 1

//p015

let p016 =
    let bp n = (bigint 2.0)**(int (float n))
    let calc n =
        bp n |> fun e -> e.ToString("#000000000000000000000").ToCharArray() |> Array.map (fun e -> bigint (float (e.ToString()))) |> Array.sum
    calc 1000

let p020 =
    let factorial n =
        {2..n} |> Seq.map (fun e -> bigint e) |> Seq.reduce (fun acc e -> acc * e) |> fun e -> e.ToString().ToCharArray() 
        |> Array.map (fun e -> float (e.ToString())) |> Array.sum
    factorial 100