module TryItOut
open System.IO
open Microsoft.FSharp.Text.Lexing
open FSharpInterpreter.AbstractSyntax
open FSharpInterpreter.Interpreter

let parse(str: string) : Expression =
    let lexbuf = LexBuffer<char>.FromString(str)
    try
        let huh = Lexer.Token lexbuf
        Parser.Main Lexer.Token lexbuf
    with
      | exn -> let pos = lexbuf.EndPos
               failwithf "%s near line %d, column %d\n"
                  (exn.Message) (pos.Line+1) pos.Column

let eval s = evaluate (parse s)

let exampleProgram1 = "4 + 5 - 2 * 3"