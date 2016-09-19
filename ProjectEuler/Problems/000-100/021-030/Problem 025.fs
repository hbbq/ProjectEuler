module Problem_025

open Xunit

let problem =
    let rec s this last index = seq {
        yield (index, this)
        yield! s (this+last) this (index+1)
    }
    s 1I 0I 1
    |> Seq.find (fun e -> (snd e).ToString().Length >= 1000) |> fst
     
[<Fact>]
let Test() = Assert.Equal(problem, 4782)