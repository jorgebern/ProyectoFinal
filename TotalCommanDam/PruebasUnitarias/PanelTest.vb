Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TotalCommanDam

<TestClass()> Public Class PanelTest

    Dim panel As New Panel()


   
    <TestMethod()> Public Sub TestCambiarRuta()

        panel.Ruta = "jorge"

    End Sub
    

    <TestMethod()> Public Sub TestCrearCarpeta()

        For i As Integer = 0 To 3
            panel.CrearCarpeta("jorge")
        Next


    End Sub


    <TestMethod()> Public Sub TestComprimir()

        For i As Integer = 0 To 3
            Assert.IsTrue(panel.Comprimir("pruebas", "compri.zip"))
        Next

    End Sub


    <TestMethod()> Public Sub TestObtenerDirectorios()

        Assert.IsNotNull(panel.obtenerdirectorios())

    End Sub

    <TestMethod()> Public Sub TestObtenerArchivos()

        Assert.IsNotNull(panel.obtenerArchivos())

    End Sub

    <TestMethod()> Public Sub TestEjecutarArchivos()

        panel.ejecutarArchivo("excepciones.txt")

    End Sub

    <TestMethod()> Public Sub TestObtenerInformacion()

        Assert.AreEqual(panel.obtenerInformacion("excepciones.txt"), "excepciones.txtÄ.txtÄC:\Users\JorgeBern\Desktop\Pruebas\excepciones.txtÄ31Ä30/05/2013 11:02:23Ä30/05/2013 11:02:43")

    End Sub

    <TestMethod()> Public Sub TestDescomprimir()

        Assert.IsTrue(panel.Descomprimir("compri.zip"))

    End Sub

    <TestMethod()> Public Sub TestDescomprimir2()

        For i As Integer = 0 To 3
            Assert.IsTrue(panel.Descomprimir("compri.zip"))
        Next


    End Sub

    <TestMethod()> Public Sub TestCrearFichero()

        For i As Integer = 0 To 3
            panel.CrearFichero("jorge.txt")
        Next
    End Sub


    <TestMethod()> Public Sub TestObtenerInformacion2()

        Assert.AreEqual(panel.obtenerInformacion("pruebas"), "pruebasÄCarpeta de ficherosÄC:\Users\JorgeBern\Desktop\Pruebas\pruebasÄ0Ä30/05/2013 15:51:15Ä30/05/2013 15:51:15")

    End Sub


    <TestMethod()> Public Sub TestCambiarExtension()

        panel.CambiarExtension("excepciones.txt", ".dat")

    End Sub


End Class