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

Partial Public Class Kid
    Public Property CustomerLogin As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As String
    Public Property CurrentLevel As String
    Public Property StartLevel As String

    Public Overridable Property Customer As Customer
    Public Overridable Property Lessons As ICollection(Of Lesson) = New HashSet(Of Lesson)

End Class
