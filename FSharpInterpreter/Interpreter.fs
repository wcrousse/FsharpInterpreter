namespace FSharpInterpreter

module Interpreter =
    open AbstractSyntax

    let rec evaluate (e : Expression) : int =
        match e with
        | IntLiteral(i) -> i
        | PrimitiveOperation(operator, lExpr, rExpr) ->
            let rOperand = evaluate rExpr
            let lOperand = evaluate lExpr
            match operator with
            | "+" -> lOperand + rOperand
            | "-" -> lOperand - rOperand
            | "*" -> lOperand * rOperand
            | "/" -> lOperand / rOperand
            | _ -> failwith "unsupported primative operation"