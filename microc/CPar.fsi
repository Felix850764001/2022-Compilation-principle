// Signature file for parser generated by fsyacc
module CPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | COLON
  | DEAL
  | MATCHS
  | ALL
  | QUE
  | NOT
  | SEQOR
  | SEQAND
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | BOOL
  | TRY
  | CATCH
  | THROW
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | INC
  | DECR
  | SELFPLUS
  | SELFMINUS
  | SELFTIMES
  | SELFDIV
  | SELFMOD
  | TOCHAR
  | TOINT
  | TOFLOAT
  | POINT
  | SIZEOF
  | TYPEOF
  | CHAR
  | ELSE
  | IF
  | INT
  | FLOAT
  | NULL
  | PRINT
  | RETURN
  | VOID
  | WHILE
  | FOR
  | IN
  | DOWHILE
  | DO
  | UNTIL
  | DOUNTIL
  | SWITCH
  | CASE
  | MATCH
  | WITH
  | DEFAULT
  | STRING
  | STRUCT
  | PRINTLN
  | CREATEI
  | BREAK
  | CONTINUE
  | CSTFLOAT of (float32)
  | CSTCHAR of (char)
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTBOOL of (bool)
  | CSTINT of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_COLON
    | TOKEN_DEAL
    | TOKEN_MATCHS
    | TOKEN_ALL
    | TOKEN_QUE
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_BOOL
    | TOKEN_TRY
    | TOKEN_CATCH
    | TOKEN_THROW
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_INC
    | TOKEN_DECR
    | TOKEN_SELFPLUS
    | TOKEN_SELFMINUS
    | TOKEN_SELFTIMES
    | TOKEN_SELFDIV
    | TOKEN_SELFMOD
    | TOKEN_TOCHAR
    | TOKEN_TOINT
    | TOKEN_TOFLOAT
    | TOKEN_POINT
    | TOKEN_SIZEOF
    | TOKEN_TYPEOF
    | TOKEN_CHAR
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_INT
    | TOKEN_FLOAT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_RETURN
    | TOKEN_VOID
    | TOKEN_WHILE
    | TOKEN_FOR
    | TOKEN_IN
    | TOKEN_DOWHILE
    | TOKEN_DO
    | TOKEN_UNTIL
    | TOKEN_DOUNTIL
    | TOKEN_SWITCH
    | TOKEN_CASE
    | TOKEN_MATCH
    | TOKEN_WITH
    | TOKEN_DEFAULT
    | TOKEN_STRING
    | TOKEN_STRUCT
    | TOKEN_PRINTLN
    | TOKEN_CREATEI
    | TOKEN_BREAK
    | TOKEN_CONTINUE
    | TOKEN_CSTFLOAT
    | TOKEN_CSTCHAR
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTBOOL
    | TOKEN_CSTINT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Topdecs
    | NONTERM_Topdec
    | NONTERM_Vardec
    | NONTERM_StructDec
    | NONTERM_MemberList
    | NONTERM_VariableDeclareAndAssign
    | NONTERM_Vardesc
    | NONTERM_Fundec
    | NONTERM_Paramdecs
    | NONTERM_Paramdecs1
    | NONTERM_Block
    | NONTERM_StmtOrDecSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_Exprs1
    | NONTERM_StmtCase
    | NONTERM_StmtPattern
    | NONTERM_ConstBool
    | NONTERM_Const
    | NONTERM_ConstString
    | NONTERM_ConstFloat
    | NONTERM_ConstChar
    | NONTERM_Type
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program) 