Imports System.Data.Entity

Namespace SwimWithJanMVC
    Public Class LessonsController
        Inherits System.Web.Mvc.Controller

        Private db As New SwimLessonsEntities

        '
        ' GET: /Lessons/

        Function Calendar() As ActionResult
            Dim lessons = db.Lessons.Include(Function(l) l.Kid).Include(Function(l) l.LessonDate)
            Return View(lessons.ToList())
        End Function

        '
        ' GET: /Lessons/Details/5

        Function Details(Optional ByVal id As String = Nothing) As ActionResult
            Dim lesson As Lesson = db.Lessons.Find(id)
            If IsNothing(lesson) Then
                Return HttpNotFound()
            End If
            Return View(lesson)
        End Function

        '
        ' GET: /Lessons/Create

        Function Create() As ActionResult
            ViewBag.CustomerLogin = New SelectList(db.Kids, "CustomerLogin", "LastName")
            ViewBag.Date = New SelectList(db.LessonDates, "Date", "Hour")
            Return View()
        End Function

        '
        ' POST: /Lessons/Create

        <HttpPost()> _
        Function Create(ByVal lesson As Lesson) As ActionResult
            If ModelState.IsValid Then
                db.Lessons.Add(lesson)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.CustomerLogin = New SelectList(db.Kids, "CustomerLogin", "LastName", lesson.CustomerLogin)
            ViewBag.Date = New SelectList(db.LessonDates, "Date", "Hour", lesson.Date)
            Return View(lesson)
        End Function

        '
        ' GET: /Lessons/Edit/5

        Function Edit(Optional ByVal id As String = Nothing) As ActionResult
            Dim lesson As Lesson = db.Lessons.Find(id)
            If IsNothing(lesson) Then
                Return HttpNotFound()
            End If
            ViewBag.CustomerLogin = New SelectList(db.Kids, "CustomerLogin", "LastName", lesson.CustomerLogin)
            ViewBag.Date = New SelectList(db.LessonDates, "Date", "Hour", lesson.Date)
            Return View(lesson)
        End Function

        '
        ' POST: /Lessons/Edit/5

        <HttpPost()> _
        Function Edit(ByVal lesson As Lesson) As ActionResult
            If ModelState.IsValid Then
                db.Entry(lesson).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.CustomerLogin = New SelectList(db.Kids, "CustomerLogin", "LastName", lesson.CustomerLogin)
            ViewBag.Date = New SelectList(db.LessonDates, "Date", "Hour", lesson.Date)
            Return View(lesson)
        End Function

        '
        ' GET: /Lessons/Delete/5

        Function Delete(Optional ByVal id As String = Nothing) As ActionResult
            Dim lesson As Lesson = db.Lessons.Find(id)
            If IsNothing(lesson) Then
                Return HttpNotFound()
            End If
            Return View(lesson)
        End Function

        '
        ' POST: /Lessons/Delete/5

        <HttpPost()> _
        <ActionName("Delete")> _
        Function DeleteConfirmed(ByVal id As String) As RedirectToRouteResult
            Dim lesson As Lesson = db.Lessons.Find(id)
            db.Lessons.Remove(lesson)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace