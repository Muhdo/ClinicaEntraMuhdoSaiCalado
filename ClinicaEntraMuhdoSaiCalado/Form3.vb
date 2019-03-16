Imports System.Data.SqlClient
Public Class Form3
    Dim conexao As SqlConnection
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    Dim ListaUtente() As Utentes

    Dim ButaoGuardar As Boolean 'True = Adicionar, False = Editar
    Dim UtenteSaudeValido As Boolean = False
    Dim DataValido As Boolean = True
    Dim CidadeValido As Boolean = True
    Dim MoradaValido As Boolean = True
    Dim CodigoPostalValido As Boolean = True
    Dim ContactoValido As Boolean = True
    Dim EmailValido As Boolean = True

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao = New SqlConnection(connectionString)

        Dim queryUtentes As SqlCommand = New SqlCommand("SELECT Key_Utente, Nome, NumeroUtente, Cidade, Morada, CodigoPostal, NumeroContacto, Email FROM Utente")
        conexao.Open()

        queryUtentes.Connection = conexao

        reader = queryUtentes.ExecuteReader()

        Dim i = -1

        While reader.Read()
            i += 1
            ReDim Preserve ListaUtente(i)

            ListaUtente(i).KeyUtente = reader("Key_Utente")
            ListaUtente(i).Nome = reader("Nome")
            ListaUtente(i).NUtenteSaude = reader("NumeroUtente")
            ListaUtente(i).Cidade = reader("Cidade")
            ListaUtente(i).Morada = reader("Morada")
            ListaUtente(i).CodigoPostal = reader("CodigoPostal")
            ListaUtente(i).Contacto = reader("NumeroContacto")
            ListaUtente(i).Email = reader("Email")

            Lst_Utentes.Items.Add(New ListViewItem({ListaUtente(i).Nome, ListaUtente(i).NUtenteSaude}))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Private Sub Lst_Utentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Utentes.SelectedIndexChanged
        If Lst_Utentes.SelectedIndices.Count >= 1 Then
            Btn_EditarUtente.Enabled = True
        ElseIf Lst_Utentes.SelectedIndices.Count = 0 Then
            Btn_EditarUtente.Enabled = False
        End If
    End Sub

    Private Sub Btn_AdicionarUtente_Click(sender As Object, e As EventArgs) Handles Btn_AdicionarUtente.Click
        Tb_NomeUtente.Text = Nothing
        Tb_NumeroUtente.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        ButaoGuardar = True
        SwitchFields()
    End Sub

    Sub SwitchFields()
        If Tb_NomeUtente.ReadOnly = True Then
            Tb_NomeUtente.ReadOnly = False
            Tb_NumeroUtente.ReadOnly = False
            Dtp_DataNascimento.Enabled = True
            Tb_Cidade.ReadOnly = False
            Tb_Morada.ReadOnly = False
            Tb_CodigoPostal.ReadOnly = False
            Tb_Contacto.ReadOnly = False
            Tb_Email.ReadOnly = False
        Else
            Tb_NomeUtente.ReadOnly = True
            Tb_NumeroUtente.ReadOnly = True
            Dtp_DataNascimento.Enabled = False
            Tb_Cidade.ReadOnly = True
            Tb_Morada.ReadOnly = True
            Tb_CodigoPostal.ReadOnly = True
            Tb_Contacto.ReadOnly = True
            Tb_Email.ReadOnly = True
        End If
    End Sub

    Sub Validar()

    End Sub

    Private Sub Tb_NomeUtente_TextChanged(sender As Object, e As EventArgs) Handles Tb_NomeUtente.TextChanged
        Tb_NomeUtente.Text = Tb_NomeUtente.Text.TrimStart()
        Dim utente() As Char = Tb_NomeUtente.Text.ToCharArray()

        If Not String.IsNullOrEmpty(Tb_NomeUtente.Text.TrimStart()) AndAlso Not Char.IsUpper(utente(0)) Then
            utente(0) = Char.ToUpper(utente(0))
            Tb_NomeUtente.Text = New String(utente)
            Tb_NomeUtente.SelectionStart = Tb_NomeUtente.Text.Length
        End If

        For index = 0 To utente.Length - 1
            If index >= 1 AndAlso Char.IsWhiteSpace(utente(index)) AndAlso Char.IsWhiteSpace(utente(index - 1)) Then
                Tb_NomeUtente.Text = Tb_NomeUtente.Text.Remove(index, 1)
                Array.Clear(utente, 0, utente.Length)
                utente = Tb_NomeUtente.Text.TrimStart().ToCharArray()
                Tb_NomeUtente.SelectionStart = index
            End If
        Next

        If Tb_NomeUtente.Text.Length >= 6 Then

        End If
    End Sub

    Private Sub Tb_NumeroUtente_TextChanged(sender As Object, e As EventArgs) Handles Tb_NumeroUtente.TextChanged

    End Sub
End Class