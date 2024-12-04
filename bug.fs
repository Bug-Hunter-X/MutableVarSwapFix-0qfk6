let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20

//In the above example, I am trying to swap the values of two mutable variables using a function called swap. However, the values are not swapped correctly, and I am getting unexpected output. This is because I am not passing the variables by reference, but rather by value. Thus, the changes made inside the swap function are not reflected in the original variables.

//To fix this problem, you need to pass the variables by reference using the ref keyword.

let mutable x = 10
let mutable y = 20

let swap (x: byref<int>) (y: byref<int>) =
    let temp = x
    x <- y
    y <- temp

swap &x &y
printfn "%d %d" x y //This will print 20 10