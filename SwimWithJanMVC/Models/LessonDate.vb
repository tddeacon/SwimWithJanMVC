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

Partial Public Class LessonDate
    Public Property [Date] As Date
    Public Property Hour As String

    Public Overridable Property Lessons As ICollection(Of Lesson) = New HashSet(Of Lesson)

End Class
