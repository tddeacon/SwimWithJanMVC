Imports System.Data.Entity

Namespace SwimWithJanMVC
    Public Class KidsController
        Inherits System.Web.Mvc.Controller

        Private db As New SwimLessonsEntities

        '
        ' GET: /Kids/

        Function Index() As ActionResult
            Dim kids = db.Kids.Include(Function(k) k.Customer)
            Return View(kids.ToList())
        End Function

        '
        ' GET: /Kids/Details/5

        Function Details(Optional ByVal id As String = Nothing) As ActionResult
            Dim kid As Kid = db.Kids.Find(id)
            If IsNothing(kid) Then
                Return HttpNotFound()
            End If
            Return View(kid)
        End Function

        '
        ' GET: /Kids/Create

        Function Create() As ActionResult
            ViewBag.CustomerLogin = New SelectList(db.Customers, "CustomerLogin", "FirstName")
            Return View()
        End Function

        '
        ' POST: /Kids/Create

        <HttpPost()> _
        Function Create(ByVal kid As Kid) As ActionResult
            If ModelState.IsValid Then
                db.Kids.Add(kid)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.CustomerLogin = New SelectList(db.Customers, "CustomerLogin", "FirstName", kid.CustomerLogin)
            Return View(kid)
        End Function

        '
        ' GET: /Kids/Edit/5

        Function Edit(Optional ByVal id As String = Nothing) As ActionResult
            Dim kid As Kid = db.Kids.Find(id)
            If IsNothing(kid) Then
                Return HttpNotFound()
            End If
            ViewBag.CustomerLogin = New SelectList(db.Customers, "CustomerLogin", "FirstName", kid.CustomerLogin)
            Return View(kid)
        End Function

        '
        ' POST: /Kids/Edit/5

        <HttpPost()> _
        Function Edit(ByVal kid As Kid) As ActionResult
            If ModelState.IsValid Then
                db.Entry(kid).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.CustomerLogin = New SelectList(db.Customers, "CustomerLogin", "FirstName", kid.CustomerLogin)
            Return View(kid)
        End Function

        '
        ' GET: /Kids/Delete/5

        Function Delete(Optional ByVal id As String = Nothing) As ActionResult
            Dim kid As Kid = db.Kids.Find(id)
            If IsNothing(kid) Then
                Return HttpNotFound()
            End If
            Return View(kid)
        End Function

        '
        ' POST: /Kids/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As String) As RedirectToRouteResult
            Dim kid As Kid = db.Kids.Find(id)
            db.Kids.Remove(kid)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace