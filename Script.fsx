﻿#r @".\bin\Debug\GrassTypeProvider.dll"
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
grass3.Value |> printfn "%s" // はいはいわろすわろす\n

System.Console.ReadKey () |> ignore



