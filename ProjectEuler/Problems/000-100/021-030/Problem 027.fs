module Problem_027

open Xunit

let problem =
    let alist = [-999L..999L]
    let blist = [-1000L..1000L]
    let tst (a:int64) (b:int64) =
        let frmla (n:int64) = n*n + a * n + b
        {0L..1000L} |> Seq.takeWhile (fun e -> frmla e |> Common.isPrime) |> Seq.length
    let ablist = alist |> List.collect (fun a -> blist |> List.map (fun b -> a, b))
    ablist |> List.map (fun (a, b) -> a, b, tst a b) |> List.sortByDescending (fun (a, b, c) -> c) |> List.head |> fun (a, b, c) -> a * b |> int

[<Fact>]
let Test() = Assert.Equal(problem, -59231)