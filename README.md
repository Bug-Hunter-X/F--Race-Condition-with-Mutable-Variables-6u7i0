# F# Race Condition Example

This example demonstrates a race condition in F# that occurs when multiple threads concurrently access and modify shared mutable variables. 

The `bug.fs` file contains code that uses two recursive functions to increment mutable counters (`x` and `y`). Because these functions run concurrently, the final values of `x` and `y` will be unpredictable and vary on each execution, demonstrating the race condition. 

The `bugSolution.fs` file provides a solution using F#'s `lock` construct to synchronize access to the mutable variables, guaranteeing predictable results.

## How to Reproduce

1. Compile and run `bug.fs`. Observe the inconsistent output.
2. Compile and run `bugSolution.fs`. Observe the consistent output (x and y should be 1000000).