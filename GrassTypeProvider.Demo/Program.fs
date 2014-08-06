﻿
open GrassTypeProvider

type Grass1 = Grass<"wvwwWWwWWWwvWwwwwWWwWWWwWWWWwWWWWWwWWWWWWwWWWWWWWwWwwwwwwwwwwwwWWWwWWWWWwWWWWWWWwWWWWWWWWWwWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWwWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwWwwwwwWWwwwwWWWwwww">
let grass1 = new Grass1()
grass1.Run() // orz
grass1.Value |> printfn "%s" // orz

type Grass2 = Grass<"wvwwWWwWWWwvWwwwwWWwWWWwWWWWwWWWWWwWWWWWWwWWWWWWWwWwwwwwwwwwwwwWWWWwWWWWWWWwWWWWWWWWWWWWWWwWWWWWWWWWWWwwWWWWWWWWWWwwWWWWWWWWWWWWwWWWWWWWWWWwwWWWWWWWWWWwwwwwwWWWWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWWwwWWWWWWWWWWWWWWWWWwwWWWWWWWWWWWWWWWWWwwwwwWWWWWWWWWWWWWWWWWWWWwwWWWWWWWWWWWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwwwwwWwwwwwwwwwwWWwwwwwwwWWWwwwwwwwWWWWwWWWWWwwwwwwwwWWWWWWwwwwwwwwwwwwwwwwWWWWWWWwwwwwwwwwwwwwwwwwwwwWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwWWWWWWWWWwwwwWWWWWWWWWWwwwwwwwwwwwWWWWWWWWWWWwwwwwwwWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwWWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwwww">
let grass2 = new Grass2()
grass2.Run() // Hello, world!
grass2.Value |> printfn "%s" // Hello, world!

type Grass3 = Grass<"wwwwvwvwwWWwvwwWwwvwwwwWWWwwWwwWWWWWWwwwwWwwvwWWwWwwvwWWWwwwwwWwwwwwwWWwWWWwWWWWWWwWWWWWWWWwwwWwwWWWWWWWWWWwWwwwwwWWWWWWWWWWWwwwwwWWWWWWWWWWWWwwwwWWWWWWWWWWWWWwwwWWWWWWWWWWWWWWwwwWWWWWWWWWWWWWWWwWWWWWWWWWWWWWWWWWWwwwWwwwwwwwwwwwwwwWWWWWWWWWWWWWWWWWWWwwwwwwwwWwwWWWWWWWWWWWWWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwwwWwwwwwwwwwwwwwwwwwwwwwwwwwwwwwWWwwwwwwwwwwwwwwwwwwwwwwwwはwwwwwWWWWWWWWWWWWWWWwWwwwWWWWわいWWWWWWWwwwWwwWWWWWWWWWWWWwwwwろはwWwwwwwwwWWWWWWWWWWWWWWWWWwwwwすいwwwWwwWWWWWWWWWWWWWWWWWWwwwwwわwwwwWwwWWWWWWWWWWWWWWWWWWWWWろWWWWWWWWWwwwwwwwwwwwWwwWWWWWWWすWWWWWWWWWwwwwwwwwwwwwwWwwwwwwwwwwwwwwwWWWWWWWWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwWwwwwwwwwwwwwwwWWwwwwwwwwwWWWwwWWWWwwwwwwwwwwwwwwwWWWWWwwWWWWWWwwwwWWWWWWWwwWWWWWWWWwwwwWWWWWWWWWwwWWWWWWWWWWwwwwwwwwwwwwwWWWWWWWWWWWWWWWWWWWWWWWWWWWWwwwwwwwwwwwWwwwWWwwwwwwwwwwwwwwwwwwWWWwwWWWWwwwwwwwwwwwwwwwwwwwwwwwwWWWWWwwWWWWWWwwwwwwwWWWWWWWwwWWWWWWWWwwwwwwWWWWWWWWWwwWWWWWWWWWWwwwwwwWWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwww">
let grass3 = new Grass3()
grass3.Run() // はいはいわろす\n
grass3.Value |> printfn "%s" // はいはいわろす\n

[<Literal>]
let www4 = """
wvwwWWwWWWwvWwwwwWWwWWWwWWWWwWWWWWw
WWWWWWwWWWWWWWwWwwwwwwwwwwwwWWWWwWW
WWWWWwWWWWWWWWWWWWWWwWWWWWWWWWWWwwW
WWWWWWWWWwwWWWWWWWWWWWWwWWWWWWWWWWw
wWWWWWWWWWWwwwwwwWWWWWWWWWWWWWWWwWW
WWWWWWWWWWWWWWWWWWWwWWWWWWWWWWWWWWW
WWWwwWWWWWWWWWWWWWWWWWwwWWWWWWWWWWW
WWWWWWwwwwwWWWWWWWWWWWWWWWWWWWWwwWW
WWWWWWWWWWWWWWWWWWWWwWWWWWWWWWWWWWW
WWWWWWWWWWWwwwwwwwwwwwwwwwwwwwwwwww
wwWwwwwwwwwwwWWwwwwwwwWWWwwwwwwwWWW
WwWWWWWwwwwwwwwWWWWWWwwwwwwwwwwwwww
wwWWWWWWWwwwwwwwwwwwwwwwwwwwwWWWWWW
WWwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
wwwWWWWWWWWWwwwwWWWWWWWWWWwwwwwwwww
wwWWWWWWWWWWWwwwwwwwWWWWWWWWWWWWwww
wwwwwwwwwwwwwwwWWWWWWWWWWWWWwwwwwww
wwwwwwwwwwwwwwwwww
"""

type Grass4 = Grass<www4>
let grass4 = new Grass4()
grass4.Run() // Hello, world!\n
grass4.Value |> printfn "%s" // Hello, world!\n


type Grass5 = Grass<"www5.www">
let grass5 = new Grass4()
grass5.Run() // Hello, world!\n
grass5.Value |> printfn "%s" // Hello, world!\n

System.Console.ReadKey () |> ignore


(*
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // 整数の終了コードを返します
*)
