module Itok.Store.SQL.Interpreter

open Antlr4.Runtime
open Antlr4.Runtime.Tree
open Itok.Store.SQL.Core


let parse (input:string): Statement list =
    let stream = CharStreams.fromString(input)
    //let lexer = 
    []