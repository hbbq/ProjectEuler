module p051

let p052 = 
    let rec infinite start = seq {
        yield start
        yield! infinite (start + 1)
    }
    let digits n = n.ToString() |> Seq.sort |> Seq.toList
    let isSame a b = (digits a) = (digits b)
    let test n =
        not ( {2..6} |> Seq.exists (fun e -> not ( isSame n (e*n)) ) )
    infinite 1 |> Seq.tryFind test

let p053 =
    let f n = if n = 0L then bigint(1L) else [bigint(1L)..bigint(n)] |> List.fold (fun a e -> a*e) (bigint(1L))
    let c n r = (f n) / ((f r) * (f (n-r)))
    let c2 n r = 
        let u = [r+1L..n] |> List.fold (fun a e -> a * bigint(e)) (bigint 1)
        let d = f (n-r)
        u / d
    //f 13L * f 10L
    
    let test n = [1L..n-1L] |> List.map (fun e -> c2 n e) |> List.where (fun e -> e > bigint(1000000L)) |> List.length
    [20L..100L] |> List.sumBy test
    

let p055 =
    let test (n:int) =
        let ReverseString (s:string) = new string(Array.rev (s.ToCharArray()))
        let rec i n l =
            if l > 50 then l
            elif l > 1 && n.ToString() = ReverseString(n.ToString()) then l
            else i (n + bigint.Parse(ReverseString(n.ToString()))) (l + 1)
        i (bigint n) 1
   
    [1..9999] |> List.map test |> List.filter (fun e -> e > 50) |> List.length


