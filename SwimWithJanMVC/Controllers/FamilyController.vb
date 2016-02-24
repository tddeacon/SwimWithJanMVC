Imports System.Data.Entity

Namespace SwimWithJanMVC
    Public Class FamilyController
        Inherits System.Web.Mvc.Controller

        Private db As New SwimLessonsEntities

        '
        ' GET: /Family/

        Function Index() As ActionResult
            Return View(db.Customers.ToList())
        End Function

        '
        ' GET: /Family/Details/5

        Function Details(Optional ByVal id As String = Nothing) As ActionResult
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If
            Return View(customer)
        End Function

        '
        ' GET: /Family/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Family/Create

        <HttpPost()> _
        Function Create(ByVal customer As Customer) As ActionResult
            If ModelState.IsValid Then
                db.Customers.Add(customer)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(customer)
        End Function

        '
        ' GET: /Family/Edit/5

        Function Edit(Optional ByVal id As String = Nothing) As ActionResult
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If
            Return View(customer)
        End Function

        '
        ' POST: /Family/Edit/5

        <HttpPost()> _
        Function Edit(ByVal customer As Customer) As ActionResult
            If ModelState.IsValid Then
                db.Entry(customer).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(customer)
        End Function

        '
        ' GET: /Family/Delete/5

        Function Delete(Optional ByVal id As String = Nothing) As ActionResult
            Dim customer As Customer = db.Customers.Find(id)
            If IsNothing(customer) Then
                Return HttpNotFound()
            End If
            Return View(customer)
        End Function

        '
        ' POST: /Family/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As String) As RedirectToRouteResult
            Dim customer As Customer = db.Customers.Find(id)
            db.Customers.Remove(customer)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace