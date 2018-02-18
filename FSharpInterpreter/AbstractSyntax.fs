namespace FSharpInterpreter

module AbstractSyntax =
    type Expression =
        | IntLiteral of int
        | PrimitiveOperation of string * Expression * Expression