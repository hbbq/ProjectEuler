module Problem_045

let problem =
    let triangle (n:int64) = n * (n + 1L) / 2L
    let pentagonal (n:int64) = n * (n * 3L - 1L) / 2L
    let hexagonal (n:int64) = n * (n * 2L - 1L)
    let rec search a b c =
        let start = 40755L
        let t = triangle a
        if t <= start then search (a+1L) b c
        else
            let p = pentagonal b
            if p <= start then search a (b+1L) c
            else
                let h = hexagonal c
                if h <= start then search a b (c+1L)
                elif p >= 10000000000L then -p
                elif t = p && p = h then t
                elif t <= p && t <= h then search (a+1L) b c
                elif p <= t && p <= h then search a (b+1L) c
                else search a b (c+1L)
    search 1L 1L 1L

// 1533776805