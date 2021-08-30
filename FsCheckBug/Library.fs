module Test

open NUnit.Framework
open FsCheck.NUnit


[<Property>]
let myProperty(s:float, v:float[]) =
    true


[<Test>]
let myTest() =
    ()
