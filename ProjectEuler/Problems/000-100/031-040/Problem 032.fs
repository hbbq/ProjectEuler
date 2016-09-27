module Problem_032

open Xunit

let problem =
    let getDigits (n:int) =
        n.ToString().ToCharArray() |> Array.toList
    let test n =
        let digs = getDigits n
        if digs.Length <> (digs |> List.distinct |> List.length) || (digs |> List.tryFind (fun e -> e = '0') |> fun e -> e.IsSome) then
            false
        else
            let factors = Common.getDivisors n |> Seq.takeWhile (fun e -> e <= Common.Int.sqrt n)
            let test n f =
                let f2 = n / f
                let df = getDigits f
                let df2 = getDigits f2
                let dt = digs@df@df2
                dt.Length = 9 && (dt |> List.tryFind (fun e -> e = '0') |> fun e -> e.IsNone) && dt.Length = (dt |> List.distinct |> List.length)
            factors |> Seq.tryFind (fun e -> test n e) |> fun e -> e.IsSome            
    [1234..9876] |> List.filter test |> List.distinct |> List.sum

[<Fact>]
let Test() = Assert.Equal(problem, 45228)