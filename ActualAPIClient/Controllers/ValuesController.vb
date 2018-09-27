Imports System.Web.Mvc

Namespace Controllers
    Public Class ValuesController
        Inherits Controller

        Private myServices As ValuesServices

        Public Sub New()
            myServices = New ValuesServices()
        End Sub

        ' GET: Values
        Async Function Index() As Threading.Tasks.Task(Of ActionResult)
            Dim results = Await myServices.GetAllAsync()

            Return View(results)
        End Function
    End Class
End Namespace