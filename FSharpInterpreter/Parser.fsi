// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | LPARN
  | RPARN
  | STARTBLOCK
  | ENDBLOCK
  | PLUS
  | MINUS
  | TIMES
  | DIVIDE
  | ID of (string)
  | NUM of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPARN
    | TOKEN_RPARN
    | TOKEN_STARTBLOCK
    | TOKEN_ENDBLOCK
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIVIDE
    | TOKEN_ID
    | TOKEN_NUM
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Expression
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (FSharpInterpreter.AbstractSyntax.Expression) 
