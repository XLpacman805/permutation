# permutation using TPL
A simple example of using TPL from .NET Core to do some multithreaded permutations. Written in C#

There are two threads for this. The main thread and tAlpha. tAlpha is responsible for getting the factorial of n while the main thread
is responsible for getting the factoral of (n - r). Once both threads are complete, the method calcPerm calculates all possible permutations
using only 4 digits, with 10 different selections available. 
