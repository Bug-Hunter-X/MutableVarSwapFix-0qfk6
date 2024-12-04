# F# Mutable Variable Swapping Issue

This repository demonstrates a common error in F# related to mutable variable swapping.  The initial code attempts to swap two mutable variables within a function, but fails due to the pass-by-value nature of F#.  The solution shows how to correctly swap mutable variables using the `byref` keyword for pass-by-reference.

## Bug
The `bug.fs` file contains code that attempts to swap two mutable integers.  However, the swap function does not correctly modify the original variables.

## Solution
The `bugSolution.fs` file provides the corrected code using the `byref` keyword. This ensures that the function modifies the original variables instead of copies.