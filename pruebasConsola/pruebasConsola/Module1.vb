Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Module Module1

    'Public conn As New ADODB.Connection
    'Public rs As New ADODB.Recordset
    'Public rss As New ADODB.Recordset
    Public sql As String
    Public server1 As String
    Public database1 As String
    Public user1 As String
    Public password1 As String
    Public oid As String
    Public sid As String
    Public d As Date
    Public dt As String
    Public route As String

    Public con As New SqlConnection("Server=VIKY-PC\\SQLEXPRESS;Database=q2;Trusted_Connection=false;user id=sa;password=a;")
    Public i As Integer

    Public Function opendb()

        '  If conn.State = 1 Then conn.Close()
        '  conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=a;Initial Catalog=q2;Data Source=VIKY-PC")
        Return 0

    End Function

    Public Sub SetConnection(Optional ByVal Firstcomp As Boolean = False)
        Dim str As String
        str = "Data Source=VIKY-PC;Initial Catalog=q2;User ID=sa;password=a"
        Try
            If IsNothing(con) = False Then
                If con.State = ConnectionState.Closed Then
                    con.Close()
                End If
            End If
            con = New SqlConnection(str)
            con.Open()
        Catch ex As System.Exception
            MsgBox(ex.Message)
            MsgBox("No se ha conectado a la base de datos. Por favor revise su conexion.")
        End Try
    End Sub

    '"Data Source=ALVIN_MAKER_PC\PRUEBASLOCALES;Initial Catalog=Credito;User ID=sa;password=Info100100"
    Sub OpecConex()

        Try
            Dim conec As New SqlConnection()
            Dim comand As New SqlCommand()
            Dim dataset As New DataSet()
            conec.ConnectionString = "Data Source=VIKY-PC;Initial Catalog=q2;User ID=sa;password=a"
            conec.Open()
            comand.Connection = conec
            comand.CommandText = "select*from Tabla"
            Dim adp As New SqlDataAdapter(comand)
            adp.Fill(dataset)
            conec.Close()

        Catch ex As Exception
            MsgBox("Error de conexion: " + ex.Message)
        End Try
    End Sub


    Sub Main()
        OpecConex()
    End Sub

End Module
