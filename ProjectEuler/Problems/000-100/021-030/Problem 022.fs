module Problem_022

open Xunit

let problem =
    let fileName = 
        let mutable f = System.IO.Directory.GetCurrentDirectory().ToLower()
        while f.EndsWith("debug") || f.EndsWith("release") || f.EndsWith("bin") do
            f <- System.IO.Directory.GetParent(f).FullName
        System.IO.Path.Combine(f,"data","022","p022_names.txt")
    let names = System.IO.File.ReadAllText(fileName).Replace("\"", "").Split(',') |> Array.sort
    let aValue =
        System.Text.Encoding.Default.GetBytes("A").[0] |> int
    let getValue (c:string) =
        System.Text.Encoding.Default.GetBytes(c).[0] |> int |> fun e -> e + 1 - aValue
    let getValues (v:string) =
        v.ToCharArray()
        |> Array.map (fun e -> e.ToString())
        |> Array.sumBy getValue
        |> int64
    let namesSeq = seq {
        for x in [0..names.Length-1] do
            yield getValues(names.[x]) * (int64(x) + 1L)
    }
    namesSeq |> Seq.sum
   
[<Fact>]
let Test() = Assert.Equal(problem, 871198282L)