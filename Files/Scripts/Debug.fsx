#light
#time
#r @"../../Src/IronJS/bin/Debug/IronJS.dll"

open System
open IronJS
open IronJS.Hosting.FSharp

module Ijs = IronJS.Hosting.FSharp

IronJS.Support.Debug.registerConsolePrinter()

let ctx = Ijs.createContext()
ctx |> Ijs.Utils.createPrintFunction

let src = @"
  while(true) {
    try { 
        
    } catch(exn) {
        
    } finally {
      print('breaking');
      break;
    }
  }
"

ctx |> Ijs.execute src

