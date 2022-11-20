module FsAutoComplete.CodeFix.UnionCaseDoesNotTakeArguments

open FsToolkit.ErrorHandling
open FsAutoComplete.CodeFix
open FsAutoComplete.CodeFix.Types
open FsAutoComplete
open FsAutoComplete.LspHelpers
open FSharp.Compiler.Symbols
open FSharp.UMX
open FSharp.Compiler.Syntax
open FSharp.Compiler.Text

open FsToolkit.ErrorHandling
open FsAutoComplete.CodeFix
open FsAutoComplete.CodeFix.Types
open FsAutoComplete
open FsAutoComplete.LspHelpers
open FSharp.Compiler.Symbols
open FSharp.UMX
open FSharp.Compiler.Syntax
open FSharp.Compiler.Text

/// A code fix for the error FS0725: The union case does not take any arguments

let title = "This union case does not take arguments"

let fix: CodeFix =
  Run.ifDiagnosticByCode (Set.ofList [ "725" ]) (fun diagnostic codeActionParams ->
    asyncResult {
      return failwithf ""
      // logic goes here - return an array of Fix items
    })
