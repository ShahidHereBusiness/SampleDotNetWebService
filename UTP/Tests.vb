Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Newtonsoft.Json
<TestClass()> Public Class Tests
    <TestMethod()>
    Public Sub TestMethodHello()
        Dim obj = New SOA.RequestCartesian().SayHello(New SOA.Request With {.Status = 0, .Message = "Success"})
        Console.WriteLine(JsonConvert.SerializeObject(obj))
    End Sub
    <TestMethod()>
    Public Sub TestMethodSingleton()
        Dim msg As String = "Hello World"
        Dim obj = New SOA.RequestCartesian().SayHello(New SOA.Request With {.Status = -2, .Message = msg})
        Console.WriteLine(JsonConvert.SerializeObject(obj))
    End Sub
    <TestMethod()>
    Public Sub TestMethodMultiplicity()
        Dim obj = New SOA.RequestCartesian().SayHello(New SOA.Request With {.Status = 1, .Message = "Enumeration"})
        Console.WriteLine(JsonConvert.SerializeObject(obj))
    End Sub
End Class