open System

let Rand = new Random()

let n = 15

let baza = [
    for i in 0..n-1 do
        yield [Rand.Next(1, 100000) ; Rand.Next(1, 100000)] ]

for i in 0..n-1 do
    printfn $"{i+1} pair: {baza[i]}"