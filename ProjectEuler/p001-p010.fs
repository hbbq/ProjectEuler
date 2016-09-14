module p001

open System
open System.Globalization

let p005 =
    let isPrime n = {2.0..n/2.0} |> Seq.tryFind (fun e -> n % e = 0.0) |> (fun e -> e.IsNone)
    let a = [2.0..20.0] |> List.filter isPrime |> List.fold (fun acc e -> acc * e) 1.0
    let b = [2.0..20.0] |> List.fold (fun acc e -> acc * e) 1.0
    let seq = {a..b}
    seq 
    |> Seq.where (fun e -> e % 20.0 = 0.0)
    |> Seq.where (fun e -> e % 19.0 = 0.0)
    |> Seq.where (fun e -> e % 18.0 = 0.0)
    |> Seq.where (fun e -> e % 17.0 = 0.0)
    |> Seq.where (fun e -> e % 16.0 = 0.0)
    |> Seq.where (fun e -> e % 15.0 = 0.0)
    |> Seq.where (fun e -> e % 14.0 = 0.0)
    |> Seq.where (fun e -> e % 13.0 = 0.0)
    |> Seq.where (fun e -> e % 12.0 = 0.0)
    |> Seq.where (fun e -> e % 11.0 = 0.0)
    |> Seq.where (fun e -> e % 10.0 = 0.0)
    |> Seq.where (fun e -> e % 9.0 = 0.0)
    |> Seq.where (fun e -> e % 8.0 = 0.0)
    |> Seq.where (fun e -> e % 7.0 = 0.0)
    |> Seq.where (fun e -> e % 6.0 = 0.0)
    |> Seq.where (fun e -> e % 5.0 = 0.0)
    |> Seq.where (fun e -> e % 4.0 = 0.0)
    |> Seq.where (fun e -> e % 3.0 = 0.0)
    |> Seq.where (fun e -> e % 2.0 = 0.0)
    |> Seq.take 1
    |> Seq.toList

let p006 =
    let square x = x * x
    let sumOfSquares x = x |> List.map square |> List.sum
    let squareOfSum x = x |> List.sum |> square
    let diff x = squareOfSum x - sumOfSquares x
    diff [1..100]

let p007 =
    let isPrime n = {2..n/2} |> Seq.tryFind (fun e -> n % e = 0) |> (fun e -> e.IsNone)
    let seq = Seq.initInfinite (fun e -> e + 2)
    seq |> Seq.filter isPrime |> Seq.take 10001 |> Seq.last

//p008

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
