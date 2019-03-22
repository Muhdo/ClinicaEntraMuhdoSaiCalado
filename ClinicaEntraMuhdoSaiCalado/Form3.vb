Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class Form3
    Dim conexao As SqlConnection
    ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    ReadOnly ValidarNome As Regex = New Regex("^[a-záàâãäåæçèéêëìíîïðñòóôõøùúûüýþÿı ]*$", RegexOptions.IgnoreCase)

    Dim ListaUtente As List(Of Utentes) = New List(Of Utentes)()


    Dim ButaoGuardar As Boolean 'True = Adicionar, False = Editar
    Dim CodigoUtente As Integer = 0

    Dim NomeValido As Boolean = False
    Dim UtenteSaudeValido As Boolean = False
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
        Dtp_DataNascimento.Value = Today
        conexao = New SqlConnection(connectionString)

        Dados()
    End Sub

    Private Sub Lst_Utentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Utentes.SelectedIndexChanged
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Tb_NomeUtente.Text = Nothing
        Tb_NumeroUtente.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Tb_NomeUtente.ReadOnly = True
        Tb_NumeroUtente.ReadOnly = True
        Dtp_DataNascimento.Enabled = False
        Tb_Cidade.ReadOnly = True
        Tb_Morada.ReadOnly = True
        Tb_CodigoPostal.ReadOnly = True
        Tb_Contacto.ReadOnly = True
        Tb_Email.ReadOnly = True

        If Lst_Utentes.SelectedIndices.Count >= 1 Then
            Btn_EditarUtente.Enabled = True
            Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("edituser")
            Dim utente As Utentes = ListaUtente.Find(Function(u) u.NUtenteSaude = Lst_Utentes.FocusedItem.SubItems.Item(1).Text)

            CodigoUtente = utente.KeyUtente
            Tb_NomeUtente.Text = utente.Nome
            Tb_NumeroUtente.Text = utente.NUtenteSaude
            Dtp_DataNascimento.Value = utente.DataNascimento.ToShortDateString
            Tb_Cidade.Text = utente.Cidade
            Tb_Morada.Text = utente.Morada
            Tb_CodigoPostal.Text = utente.CodigoPostal
            If utente.Contacto = 0 Then
                Tb_Contacto.Text = Nothing
            Else
                Tb_Contacto.Text = utente.Contacto
            End If
            Tb_Email.Text = utente.Email
        ElseIf Lst_Utentes.SelectedIndices.Count = 0 Then
            Btn_EditarUtente.Enabled = False
            Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
            Tb_NomeUtente.Text = Nothing
            Tb_NumeroUtente.Text = Nothing
            Dtp_DataNascimento.Value = Today
            Tb_Cidade.Text = Nothing
            Tb_Morada.Text = Nothing
            Tb_CodigoPostal.Text = Nothing
            Tb_Contacto.Text = Nothing
            Tb_Email.Text = Nothing
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
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarUtente.Enabled = False
        Btn_AdicionarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("addusergray")
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Lbl_SaveMethod.Text = "Inserir Utente"
        SwitchFields()
    End Sub

    Private Sub Btn_EditarUtente_Click(sender As Object, e As EventArgs) Handles Btn_EditarUtente.Click
        Lst_Utentes.Enabled = False
        CodigoUtente = ListaUtente.Find(Function(u) u.NUtenteSaude = Lst_Utentes.FocusedItem.SubItems.Item(1).Text).KeyUtente

        ButaoGuardar = False
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarUtente.Enabled = False
        Btn_AdicionarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("addusergray")
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Lbl_SaveMethod.Text = "Editar Utente"
        SwitchFields()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        ButaoGuardar = Nothing
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Tb_NomeUtente.Text = Nothing
        Tb_NumeroUtente.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Tb_NomeUtente.ReadOnly = True
        Tb_NumeroUtente.ReadOnly = True
        Dtp_DataNascimento.Enabled = False
        Tb_Cidade.ReadOnly = True
        Tb_Morada.ReadOnly = True
        Tb_CodigoPostal.ReadOnly = True
        Tb_Contacto.ReadOnly = True
        Tb_Email.ReadOnly = True
        Lbl_ErroNumero.Text = Nothing
        Lbl_ErroEmail.Text = Nothing
        Btn_AdicionarUtente.Enabled = True
        Btn_AdicionarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("adduser")
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Lst_Utentes.Enabled = True
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
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

    Sub Dados()
        Dim queryUtentes As SqlCommand = New SqlCommand("SELECT Key_Utente, Nome, NumeroUtente, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email FROM Utente")
        conexao.Open()

        queryUtentes.Connection = conexao

        reader = queryUtentes.ExecuteReader()

        Lst_Utentes.Items.Clear()
        ListaUtente.Clear()

        While reader.Read()
            ListaUtente.Add(New Utentes With {
                            .KeyUtente = reader("Key_Utente"),
                            .Nome = reader("Nome"),
                            .NUtenteSaude = reader("NumeroUtente"),
                            .DataNascimento = reader("DataNascimento"),
                            .Cidade = reader("Cidade"),
                            .Morada = reader("Morada"),
                            .CodigoPostal = reader("CodigoPostal"),
                            .Contacto = reader("NumeroContacto"),
                            .Email = reader("Email")
                            })

            Lst_Utentes.Items.Add(New ListViewItem({reader("Nome"), reader("NumeroUtente")}))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Sub Validar()
        If NomeValido = True AndAlso UtenteSaudeValido = True AndAlso CidadeValido = True AndAlso MoradaValido = True AndAlso CodigoPostalValido = True AndAlso ContactoValido = True AndAlso EmailValido = True Then
            Btn_Guardar.Enabled = True
            Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskette")
        Else
            Btn_Guardar.Enabled = False
            Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        End If
    End Sub

    Private Sub Tb_NomeUtente_TextChanged(sender As Object, e As EventArgs) Handles Tb_NomeUtente.TextChanged
        NomeValido = False

        Tb_NomeUtente.Text = Tb_NomeUtente.Text.TrimStart()
        Dim utente() As Char = Tb_NomeUtente.Text.ToCharArray()

        If Not String.IsNullOrEmpty(Tb_NomeUtente.Text.TrimStart()) AndAlso Not Char.IsUpper(utente(0)) Then
            utente(0) = Char.ToUpper(utente(0))
            Tb_NomeUtente.Text = New String(utente)
            Tb_NomeUtente.SelectionStart = Tb_NomeUtente.Text.Length
        End If

        For index = 0 To utente.Length - 1
            If index > 0 AndAlso Char.IsWhiteSpace(utente(index - 1)) AndAlso Char.IsLower(utente(index)) Then
                utente(index) = Char.ToUpper(utente(index))
                Tb_NomeUtente.Text = New String(utente)
                Tb_NomeUtente.SelectionStart = index + 1

                Exit For
            End If

            If index > 0 AndAlso Char.IsLetter(utente(index - 1)) AndAlso Char.IsUpper(utente(index)) Then
                utente(index) = Char.ToLower(utente(index))
                Tb_NomeUtente.Text = New String(utente)
                Tb_NomeUtente.SelectionStart = index + 1

                Exit For
            End If

            If Not ValidarNome.IsMatch(utente(index).ToString()) Or (index >= 1 AndAlso Char.IsWhiteSpace(utente(index)) AndAlso Char.IsWhiteSpace(utente(index - 1))) Then
                Tb_NomeUtente.Text = Tb_NomeUtente.Text.Remove(index, 1)
                Array.Clear(utente, 0, utente.Length)
                utente = Tb_NomeUtente.Text.TrimStart().ToCharArray()
                Tb_NomeUtente.SelectionStart = index + 1

                Exit For
            End If
        Next

        If utente.Length >= 6 Then
            NomeValido = True
        End If

        Validar()
    End Sub

    Private Sub Tb_NumeroUtente_TextChanged(sender As Object, e As EventArgs) Handles Tb_NumeroUtente.TextChanged
        UtenteSaudeValido = False

        Tb_NumeroUtente.Text = Tb_NumeroUtente.Text.Trim()
        Dim numero() As Char = Tb_NumeroUtente.Text.ToCharArray()

        For index = 0 To numero.Length - 1
            If Not Char.IsNumber(numero(index)) Then
                Tb_NumeroUtente.Text = Tb_NumeroUtente.Text.Remove(index, 1)
                Array.Clear(numero, 0, numero.Length)
                numero = Tb_NumeroUtente.Text.Trim().ToCharArray()
                Tb_NumeroUtente.SelectionStart = index + 1

                Exit For
            End If
        Next

        If numero.Length = 9 Then
            Dim queryValidar As SqlCommand = New SqlCommand("SELECT * FROM Utente WHERE NumeroUtente = @NumeroUtente")
            conexao.Open()
            queryValidar.Connection = conexao
            queryValidar.Parameters.AddWithValue("@NumeroUtente", Tb_NumeroUtente.Text)

            reader = queryValidar.ExecuteReader()
            If reader.HasRows Then
                reader.Read()

                If ButaoGuardar = False AndAlso CodigoUtente <> 0 Then
                    If CodigoUtente = reader("Key_Utente") And Tb_NumeroUtente.Text = reader("NumeroUtente") Then
                        UtenteSaudeValido = True
                        Lbl_ErroNumero.Text = Nothing
                    Else
                        UtenteSaudeValido = False
                        Lbl_ErroNumero.Text = "Numero de Utente de Saude já Registado"
                    End If
                Else
                    UtenteSaudeValido = False
                    Lbl_ErroNumero.Text = "Numero de Utente de Saude já Registado"
                End If
            Else
                UtenteSaudeValido = True
                Lbl_ErroNumero.Text = Nothing
            End If

            queryValidar.Parameters.Clear()
            conexao.Close()
        End If
        Validar()
    End Sub

    Private Sub Dtp_DataNascimento_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_DataNascimento.ValueChanged
        If Dtp_DataNascimento.Value.ToShortDateString > Today.ToShortDateString Then
            Dtp_DataNascimento.Value = Today.ToShortDateString
        End If
    End Sub

    Private Sub Tb_Cidade_TextChanged(sender As Object, e As EventArgs) Handles Tb_Cidade.TextChanged
        CidadeValido = False

        Tb_Cidade.Text = Tb_Cidade.Text.TrimStart()
        Dim cidade() As Char = Tb_Cidade.Text.ToCharArray()

        If Not String.IsNullOrEmpty(Tb_Cidade.Text.TrimStart()) AndAlso Not Char.IsUpper(cidade(0)) Then
            cidade(0) = Char.ToUpper(cidade(0))
            Tb_Cidade.Text = New String(cidade)
            Tb_Cidade.SelectionStart = Tb_Cidade.Text.Length
        End If

        For index = 0 To cidade.Length - 1
            If index >= 1 AndAlso Char.IsWhiteSpace(cidade(index)) AndAlso Char.IsWhiteSpace(cidade(index - 1)) Then
                Tb_Cidade.Text = Tb_Cidade.Text.Remove(index, 1)
                Array.Clear(cidade, 0, cidade.Length)
                cidade = Tb_Cidade.Text.Trim().ToCharArray()
                Tb_Cidade.SelectionStart = index + 1

                Exit For
            End If
        Next

        If cidade.Length >= 2 Or cidade.Length = 0 Then
            CidadeValido = True
        End If

        Validar()
    End Sub

    Private Sub Tb_Morada_TextChanged(sender As Object, e As EventArgs) Handles Tb_Morada.TextChanged
        MoradaValido = False

        Tb_Morada.Text = Tb_Morada.Text.TrimStart()
        Dim morada() As Char = Tb_Morada.Text.ToCharArray()

        If Not String.IsNullOrEmpty(Tb_Morada.Text.TrimStart()) AndAlso Not Char.IsUpper(morada(0)) Then
            morada(0) = Char.ToUpper(morada(0))
            Tb_Morada.Text = New String(morada)
            Tb_Morada.SelectionStart = Tb_Morada.Text.Length
        End If

        For index = 0 To morada.Length - 1
            If index >= 1 AndAlso Char.IsWhiteSpace(morada(index)) AndAlso Char.IsWhiteSpace(morada(index - 1)) Then
                Tb_Morada.Text = Tb_Morada.Text.Remove(index, 1)
                Array.Clear(morada, 0, morada.Length)
                morada = Tb_Morada.Text.Trim().ToCharArray()
                Tb_Morada.SelectionStart = index + 1

                Exit For
            End If
        Next

        If morada.Length >= 2 Or morada.Length = 0 Then
            MoradaValido = True
        End If

        Validar()
    End Sub

    Private Sub Tb_CodigoPostal_TextChanged(sender As Object, e As EventArgs) Handles Tb_CodigoPostal.TextChanged
        CodigoPostalValido = False

        Tb_CodigoPostal.Text = Tb_CodigoPostal.Text.TrimStart()
        Dim codpostal() As Char = Tb_CodigoPostal.Text.ToCharArray()

        For index = 0 To codpostal.Length - 1
            If Not index = 4 And Not Char.IsNumber(codpostal(index)) Then
                Tb_CodigoPostal.Text = Tb_CodigoPostal.Text.Remove(index, 1)
                Array.Clear(codpostal, 0, codpostal.Length)
                codpostal = Tb_CodigoPostal.Text.Trim().ToCharArray()
                Tb_CodigoPostal.SelectionStart = index + 1

                Exit For
            End If

            If index = 4 And Not codpostal(index) = "-" Then
                codpostal(index) = "-"
                Tb_CodigoPostal.Text = New String(codpostal)
                Tb_CodigoPostal.SelectionStart = index + 1

                Exit For
            End If
        Next

        If codpostal.Length >= 8 Or codpostal.Length = 0 Then
            CodigoPostalValido = True
        End If

        Validar()
    End Sub

    Private Sub Tb_Contacto_TextChanged(sender As Object, e As EventArgs) Handles Tb_Contacto.TextChanged
        ContactoValido = False

        Tb_Contacto.Text = Tb_Contacto.Text.TrimStart()
        Dim contacto() As Char = Tb_Contacto.Text.ToCharArray()

        For index = 0 To contacto.Length - 1
            If Not Char.IsNumber(contacto(index)) Then
                Tb_Contacto.Text = Tb_Contacto.Text.Remove(index, 1)
                Array.Clear(contacto, 0, contacto.Length)
                contacto = Tb_Contacto.Text.Trim().ToCharArray()
                Tb_Contacto.SelectionStart = index

                Exit For
            End If
        Next

        If contacto.Length >= 9 Or contacto.Length = 0 Then
            ContactoValido = True
        End If

        Validar()
    End Sub

    Private Sub Tb_Email_TextChanged(sender As Object, e As EventArgs) Handles Tb_Email.TextChanged
        EmailValido = False

        Tb_Email.Text = Tb_Email.Text.TrimStart()
        Dim email() As Char = Tb_Email.Text.ToCharArray()

        For index = 0 To email.Length - 1
            If Char.IsWhiteSpace(email(index)) Then
                Tb_Email.Text = Tb_Email.Text.Remove(index, 1)
                Array.Clear(email, 0, email.Length)
                email = Tb_Email.Text.Trim().ToCharArray()
                Tb_Email.SelectionStart = index + 1

                Exit For
            End If
        Next

        If email.Length > 0 Then
            Try
                Dim ver As MailAddress = New MailAddress(Tb_Email.Text)

                EmailValido = True
                Lbl_ErroEmail.Text = Nothing
            Catch ex As Exception
                EmailValido = False
                Lbl_ErroEmail.Text = "Email com Formato Invalido"
            End Try
        Else
            EmailValido = True
        End If

        Validar()
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If ButaoGuardar = True Then
            Dim queryInserir As SqlCommand = New SqlCommand("INSERT INTO Utente (Nome, NumeroUtente, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email) VALUES (@Nome, @NumeroUtente, @DataNascimento, @Cidade, @Morada, @CodigoPostal, @NumeroContacto, @Email)")
            conexao.Open()
            queryInserir.Connection = conexao
            queryInserir.Parameters.AddWithValue("@Nome", Tb_NomeUtente.Text.Trim())
            queryInserir.Parameters.AddWithValue("@NumeroUtente", Convert.ToInt64(Tb_NumeroUtente.Text.Trim()))
            queryInserir.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(Dtp_DataNascimento.Value.ToShortDateString))
            queryInserir.Parameters.AddWithValue("@Cidade", Tb_Cidade.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Morada", Tb_Morada.Text.Trim())
            queryInserir.Parameters.AddWithValue("@CodigoPostal", Tb_CodigoPostal.Text.Trim())
            queryInserir.Parameters.AddWithValue("@NumeroContacto", Tb_Contacto.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Email", Tb_Email.Text.Trim())

            queryInserir.ExecuteNonQuery()
            queryInserir.Parameters.Clear()
        Else
            Dim queryEditar As SqlCommand = New SqlCommand("UPDATE Utente SET Nome = @Nome, NumeroUtente = @NumeroUtente, DataNascimento = @DataNascimento, Cidade = @Cidade, Morada = @Morada, CodigoPostal = @CodigoPostal, NumeroContacto = @NumeroContacto, Email = @Email WHERE Key_Utente = @KeyUtente")
            conexao.Open()
            queryEditar.Connection = conexao
            queryEditar.Parameters.AddWithValue("@Nome", Tb_NomeUtente.Text.Trim())
            queryEditar.Parameters.AddWithValue("@NumeroUtente", Convert.ToInt64(Tb_NumeroUtente.Text.Trim()))
            queryEditar.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(Dtp_DataNascimento.Value.ToShortDateString))
            queryEditar.Parameters.AddWithValue("@Cidade", Tb_Cidade.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Morada", Tb_Morada.Text.Trim())
            queryEditar.Parameters.AddWithValue("@CodigoPostal", Tb_CodigoPostal.Text.Trim())
            queryEditar.Parameters.AddWithValue("@NumeroContacto", Tb_Contacto.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Email", Tb_Email.Text.Trim())
            queryEditar.Parameters.AddWithValue("@KeyUtente", CodigoUtente)

            queryEditar.ExecuteNonQuery()
            queryEditar.Parameters.Clear()
        End If

        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
        Btn_AdicionarUtente.Enabled = True
        Btn_AdicionarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("adduser")
        Btn_EditarUtente.Enabled = False
        Btn_EditarUtente.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Btn_Guardar.Enabled = False
        Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        Tb_NomeUtente.Text = Nothing
        Tb_NumeroUtente.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
        SwitchFields()
        Lst_Utentes.Enabled = True

        conexao.Close()
        Dados()
    End Sub
End Class