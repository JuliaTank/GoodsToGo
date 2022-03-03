
module File2

//Patern matching and recursion 
let vowelToUpper c = 
    match c with
        |'a' -> 'A'
        |'e' -> 'E'
        |'i'-> 'I'
        |'o' -> 'O'
        |'u' -> 'U'
        |_ -> c

let a = vowelToUpper 'f'        

//use above on string
let rec stringVowToUpper (s:string)  =  
     match s with
         | "" -> ""
         | str -> (vowelToUpper s.[0]).ToString() + stringVowToUpper (s.[1 .. String.length s-1])
   
let a = stringVowToUpper "aww kotki" 
        
//same but using map function
let upperVowelStrMap (s:string) = String.map vowelToUpper s


//RECURSIVE LENGTH OF LIST
let rec pmLenght ls = 
    match ls with
        | [] -> 0
        | _ -> 1 + pmLenght ls.Tail
       

let a = pmLenght [2;3;4]


//RETURN SUM OF ALL numbers in list
let rec pmSum ls = 
     match ls with
         | [] -> 0
         | _ -> ls.Head + pmSum ls.Tail

let a = pmSum [2;3;5;8]

// takeSome n ls that returns list of first n elements from the list ls
//??????????????????????????????????????
let rec takeSome n ls = 
    match (n, ls) with
        | (0,_) -> []
        | (_, head::tail) -> head::takeSome (n-1) tail

let a = takeSome 2 ['a'; 'b'; 'c']


//fold
let rec pclFold f (ls:list<_>) init  = 
    match ls with 
        | []-> 

let a = pclFold '+' 0 [1;2;3]

//foldBack // NOT FINISHED 
let rec pclFoldBack f ls init = 
    match ls with
        | [] -> init
        | hd :: tl -> f hd :: pclFoldBack f tl init

let a = pclFoldBack (+) [1;2;3] 0
//same but with foldBack 
let sumFoldBack ls = List.foldBack (+) ls 0

//increment every element in list
let rec pclIncList ls =
    match ls with
        | []-> ls
        | hd::tl-> hd + 1 :: pclIncList tl


// DO 2.7 AND 2.8 
//let rec pclMap 

//1.1
let tupleMe = (293719, "Julia")

let deTupleMe (a,b) =
    printfn "%d  %s" a b

let a = deTupleMe tupleMe

//1.2
let rec myStrLength1 ls = 
    match ls with
    | [] -> 0
    | _ -> 1 + pmLenght ls.Tail

let rec myStrLength2 (ls:list<_>)= 
    ls.Length

let a = myStrLength1 [1;2;2]
let b = myStrLength2 [1;2;3]
//1.3
let rec takeSome n (ls:list<_>) = 
    if n <= ls.Length  then 
        match (n, ls) with
            | (0,_) -> []
            | (_, head::tail) -> head::takeSome (n-1) tail
            | (_, []) -> failwith "taking too many elements"
    else 
        failwith "n cannnot be bigger than list length :("

let a = takeSome 4 ['a'; 'b'; 'c']
//1.4
let rec pclElementAt (n:int) (ls:list<_>) = 
    if n <= ls.Length then
        ls.[n]
    else 
        failwith "n cannot be bigger than list length :("
let a  = pclElementAt 3 ['a';'b']