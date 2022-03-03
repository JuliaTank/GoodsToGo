

module pclEx2

let x = 23
let myName = "Bobby"
let age = 25
let country = "Canada"
let y = 6 + 6

//result c is 20 
let a = 5
let b = let a = 10 in a + 5
let c = a + b 

//add 1 to given int
let addNum1 x = x+1
let b = addNum1 3
//add 10 to given int
let addNum10 x = x+10 
let a = addNum10 30
//use previous func to add 20 to given int
let addNum20 x = addNum10 x + 10
let addNum202 x = addNum10(addNum10 x)
let b = addNum20 10

//takes two integers as arguments and returns the largest of them.
let max2 (a , b ) =
    if a < b then  
        b
    else
        a
let a  = max2 (239, 310)

//takes an integer and prints out “even number” if the given integer is even otherwise it prints out “oddnumber”.
let evenOrOdd x = 
    if x%2 = 0 then 
        "even number"
    else 
        "odd number"

let a  = evenOrOdd 37

//takes two integersand prints out the two integers before adding them
let addXY (x, y) =
    printfn "x: %d y: %d result: %d" x y (x+y)
    x+y

let a = addXY (2, 3)

(*Define a function addNum_jk that takes two integers j,k 
as arguments and returns j + 10*k. For instance,addNum_jk 3 5 = 3 + 10*5 = 53. 
You are, however, not allowed to use addition and multiplication directly:
instead, you must write a recursive solution that calls addNum10 defined
in Exercise 02.03 above.(SoaddNum_jk3 5should be computed as3 + 10 + 10 + 10 + 10 + 10.)
*)
//add 10 to given int
let addNum10 x = x+10 

let rec addNum_jk (j, k) = 
    match k with
    | 0 -> j
    | _ -> addNum10(addNum_jk(j, k-1))

let a = addNum_jk (3, 5)

//other solution to same problem
let addNum10 x = x+10 

let rec addNum_jk (j, k) = 
    match k with
    | 0 -> j
    | _ -> addNum_jk(addNum10 j, k-1)

let a = addNum_jk (3, 5)

