let mutable x = 0
let mutable y = 0

let rec loop1 () =
    x <- x + 1
    if x < 1000000 then
        loop1 ()

let rec loop2 () =
    y <- y + 1
    if y < 1000000 then
        loop2 ()

loop1 ()
loop2 ()
printf "%d %d" x y