Public Class MandarEmail

    Dim _email As String
    Dim _contrasenya As String
    Dim _nombre As String
    Dim _destinatario As String
    Dim _asunto As String
    Dim _mensaje As String
    Dim _aceptar As Boolean

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property


    Public Property Contrasenya As String
        Get
            Return _contrasenya
        End Get
        Set(value As String)
            _contrasenya = value
        End Set
    End Property


    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    Public Property Destinatario As String
        Get
            Return _destinatario
        End Get
        Set(value As String)
            _destinatario = value
        End Set
    End Property


    Public Property Asunto As String
        Get
            Return _asunto
        End Get
        Set(value As String)
            _asunto = value
        End Set
    End Property


    Public Property Mensaje As String
        Get
            Return _mensaje
        End Get
        Set(value As String)
            _mensaje = value
        End Set
    End Property

    Public Property Aceptar As Boolean
        Get
            Return _aceptar
        End Get
        Set(value As Boolean)
            _aceptar = value
        End Set
    End Property



    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click

        Dim salir As Boolean = False

        If Txb_Email.Text = "" Then
            Txb_Email.BorderStyle = BorderStyle.FixedSingle
            salir = True
        End If

        If Not ValidarEmail(Txb_Email.Text) Then
            salir = True
            MsgBox("Dirección de Email incorrecta")
            Txb_Email.Focus()
            Txb_Email.Select(0, Txb_Email.TextLength)
        End If

        If Not ValidarEmail(Txb_destinatario.Text) Then
            salir = True
            MsgBox("Dirección de Email incorrecta")
            Txb_destinatario.Focus()
            Txb_destinatario.Select(0, Txb_destinatario.TextLength)
        End If

        If Txb_Contrasenya.Text = "" Then
            Txb_Contrasenya.BorderStyle = BorderStyle.FixedSingle
            salir = True
        End If

        If Txb_destinatario.Text = "" Then
            Txb_destinatario.BorderStyle = BorderStyle.FixedSingle
            salir = True
        End If
        
        If Not salir Then
            Email = Txb_Email.Text
            Contrasenya = Txb_Contrasenya.Text
            Nombre = Txb_Email.Text.Substring(0, Txb_Email.Text.IndexOf("@"))
            Destinatario = Txb_destinatario.Text
            Asunto = Txb_Asunto.Text
            Mensaje = Txb_Mensaje.Text
            Aceptar = True

            Me.Close()
        End If


    End Sub

    Private Sub Txb_Email_Enter(sender As Object, e As EventArgs) Handles Txb_Email.Enter

        Txb_Email.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub Txb_Contrasenya_Enter(sender As Object, e As EventArgs) Handles Txb_Contrasenya.Enter
        Txb_Contrasenya.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Txb_destinatario_Enter(sender As Object, e As EventArgs) Handles Txb_destinatario.Enter
        Txb_destinatario.BorderStyle = BorderStyle.Fixed3D
    End Sub

End Class