Imports System.Data.Entity

Namespace SwimWithJanMVC
    Public Class LessonDateController
        Inherits System.Web.Mvc.Controller

        Private db As New SwimLessonsEntities

        '
        ' GET: /LessonDate/

        Function Index() As ActionResult
            Return View(db.LessonDates.ToList())
        End Function

        '
        ' GET: /LessonDate/Details/5

        Function Details(Optional ByVal id As Date = Nothing) As ActionResult
            Dim lessondate As LessonDate = db.LessonDates.Find(id)
            If IsNothing(lessondate) Then
                Return HttpNotFound()
            End If
            Return View(lessondate)
        End Function

        '
        ' GET: /LessonDate/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /LessonDate/Create

        <HttpPost()> _
        Function Create(ByVal lessondate As LessonDate) As ActionResult
            If ModelState.IsValid Then
                db.LessonDates.Add(lessondate)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(lessondate)
        End Function

        '
        ' GET: /LessonDate/Edit/5

        Function Edit(Optional ByVal id As Date = Nothing) As ActionResult
            Dim lessondate As LessonDate = db.LessonDates.Find(id)
            If IsNothing(lessondate) Then
                Return HttpNotFound()
            End If
            Return View(lessondate)
        End Function

        '
        ' POST: /LessonDate/Edit/5

        <HttpPost()> _
        Function Edit(ByVal lessondate As LessonDate) As ActionResult
            If ModelState.IsValid Then
                db.Entry(lessondate).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(lessondate)
        End Function

        '
        ' GET: /LessonDate/Delete/5

        Function Delete(Optional ByVal id As Date = Nothing) As ActionResult
            Dim lessondate As LessonDate = db.LessonDates.Find(id)
            If IsNothing(lessondate) Then
                Return HttpNotFound()
            End If
            Return View(lessondate)
        End Function

        '
        ' POST: /LessonDate/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As Date) As RedirectToRouteResult
            Dim lessondate As LessonDate = db.LessonDates.Find(id)
            db.LessonDates.Remove(lessondate)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace