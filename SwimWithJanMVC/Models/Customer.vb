'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Customer
    Public Property CustomerLogin As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Address As String
    Public Property City As String
    Public Property State As String
    Public Property Zip As String
    Public Property CellPhone As String
    Public Property HomePhone As String
    Public Property Comments As String
    Public Property Password As String

    Public Overridable Property Kids As ICollection(Of Kid) = New HashSet(Of Kid)

End Class