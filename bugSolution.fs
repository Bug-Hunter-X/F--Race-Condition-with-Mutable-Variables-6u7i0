let x = System.Threading.Interlocked.Add(ref 0, 1)
let y = System.Threading.Interlocked.Add(ref 0, 1)

let rec loop1 () =
    let mutable x = 0
    lock x (fun () ->
        x <- x + 1
        if x < 1000000 then
            loop1 ())

let rec loop2 () =
    let mutable y = 0
    lock y (fun () ->
        y <- y + 1
        if y < 1000000 then
            loop2 ())

loop1 ()
loop2 ()
printf "%d %d" x y