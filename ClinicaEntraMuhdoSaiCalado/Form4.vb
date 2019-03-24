Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class Form4
    Dim conexao As SqlConnection
    ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    ReadOnly ValidarNome As Regex = New Regex("^[a-záàâãäåæçèéêëìíîïðñòóôõøùúûüýþÿı ]*$", RegexOptions.IgnoreCase)

    Dim ListaMedico As List(Of Medicos) = New List(Of Medicos)()
    Dim ListaEspecialidade As List(Of Especialidades) = New List(Of Especialidades)()


    Dim ButaoGuardar As Boolean 'True = Adicionar, False = Editar
    Dim ButaoClick As Boolean = False
    Dim CodigoMedico As Integer = 0

    Dim NomeValido As Boolean = False
    Dim CartaoCidadaoValido As Boolean = False
    Dim CidadeValido As Boolean = True
    Dim MoradaValido As Boolean = True
    Dim CodigoPostalValido As Boolean = True
    Dim ContactoValido As Boolean = True
    Dim EmailValido As Boolean = True
    Dim EspecialidadeValido As Boolean = False

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dtp_DataNascimento.Value = Today
        conexao = New SqlConnection(connectionString)

        Dados()
    End Sub

    Private Sub Lst_Medicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Medicos.SelectedIndexChanged
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Tb_NomeMedico.Text = Nothing
        Tb_CartaoCidadao.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Cb_Especialidade.SelectedItem = -1
        Tb_NomeMedico.ReadOnly = True
        Tb_CartaoCidadao.ReadOnly = True
        Dtp_DataNascimento.Enabled = False
        Tb_Cidade.ReadOnly = True
        Tb_Morada.ReadOnly = True
        Tb_CodigoPostal.ReadOnly = True
        Tb_Contacto.ReadOnly = True
        Tb_Email.ReadOnly = True
        Cb_Especialidade.Enabled = True

        If Lst_Medicos.SelectedIndices.Count >= 1 Then
            Btn_EditarMedico.Enabled = True
            Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("edituser")

            Dim KeyEspecialidade = ListaEspecialidade.Find(Function(es) es.Especialidade = Lst_Medicos.FocusedItem.SubItems.Item(1).Text).KeyEspecialidade
            Dim medico As Medicos = ListaMedico.Find(Function(m) m.Nome = Lst_Medicos.FocusedItem.SubItems.Item(0).Text And m.KeyEspecialidade = KeyEspecialidade)

            CodigoMedico = medico.KeyMedico
            Tb_NomeMedico.Text = medico.Nome
            Tb_CartaoCidadao.Text = medico.CartaoCidadao
            Dtp_DataNascimento.Value = medico.DataNascimento.ToShortDateString
            Tb_Cidade.Text = medico.Cidade
            Tb_Morada.Text = medico.Morada
            Tb_CodigoPostal.Text = medico.CodigoPostal
            If medico.Contacto = 0 Then
                Tb_Contacto.Text = Nothing
            Else
                Tb_Contacto.Text = medico.Contacto
            End If
            Tb_Email.Text = medico.Email
            Cb_Especialidade.SelectedItem = Lst_Medicos.FocusedItem.SubItems.Item(1).Text
        ElseIf Lst_Medicos.SelectedIndices.Count = 0 Then
            Btn_EditarMedico.Enabled = False
            Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
            Tb_NomeMedico.Text = Nothing
            Tb_CartaoCidadao.Text = Nothing
            Dtp_DataNascimento.Value = Today
            Tb_Cidade.Text = Nothing
            Tb_Morada.Text = Nothing
            Tb_CodigoPostal.Text = Nothing
            Tb_Contacto.Text = Nothing
            Tb_Email.Text = Nothing
            Cb_Especialidade.SelectedItem = -1
        End If
    End Sub

    Private Sub Btn_AdicionarMedico_Click(sender As Object, e As EventArgs) Handles Btn_AdicionarMedico.Click
        Tb_NomeMedico.Text = Nothing
        Tb_CartaoCidadao.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Cb_Especialidade.SelectedItem = -1
        Lst_Medicos.Enabled = False
        ButaoGuardar = True
        ButaoClick = True
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarMedico.Enabled = False
        Btn_AdicionarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("addusergray")
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Btn_Especialidade.Enabled = False
        Btn_Especialidade.BackgroundImage = My.Resources.ResourceManager.GetObject("areagray")
        Lbl_SaveMethod.Text = "Inserir Medico"
        SwitchFields()
    End Sub

    Private Sub Btn_EditarMedico_Click(sender As Object, e As EventArgs) Handles Btn_EditarMedico.Click
        Lst_Medicos.Enabled = False

        Dim KeyEspecialidade = ListaEspecialidade.Find(Function(es) es.Especialidade = Lst_Medicos.FocusedItem.SubItems.Item(1).Text).KeyEspecialidade
        CodigoMedico = ListaMedico.Find(Function(m) m.Nome = Lst_Medicos.FocusedItem.SubItems.Item(0).Text And m.KeyEspecialidade = KeyEspecialidade).KeyMedico

        ButaoGuardar = False
        ButaoClick = True
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarMedico.Enabled = False
        Btn_AdicionarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("addusergray")
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Btn_Especialidade.Enabled = False
        Btn_Especialidade.BackgroundImage = My.Resources.ResourceManager.GetObject("areagray")
        Lbl_SaveMethod.Text = "Editar Medico"
        SwitchFields()
        Validar()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        ButaoGuardar = Nothing
        ButaoClick = False
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Tb_NomeMedico.Text = Nothing
        Tb_CartaoCidadao.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Tb_NomeMedico.ReadOnly = True
        Tb_CartaoCidadao.ReadOnly = True
        Dtp_DataNascimento.Enabled = False
        Tb_Cidade.ReadOnly = True
        Tb_Morada.ReadOnly = True
        Tb_CodigoPostal.ReadOnly = True
        Tb_Contacto.ReadOnly = True
        Tb_Email.ReadOnly = True
        Cb_Especialidade.Enabled = False
        Lbl_ErroNumero.Text = Nothing
        Lbl_ErroEmail.Text = Nothing
        Btn_AdicionarMedico.Enabled = True
        Btn_AdicionarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("adduser")
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Lst_Medicos.Enabled = True
        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
        Btn_Especialidade.Enabled = True
        Btn_Especialidade.BackgroundImage = My.Resources.ResourceManager.GetObject("area")
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
    End Sub

    Private Sub Cb_Especialidade_DropDown(sender As Object, e As EventArgs) Handles Cb_Especialidade.DropDown
        Dim queryEspecialidades As SqlCommand = New SqlCommand("SELECT Key_Especialidade, Especialidade FROM Especialidade WHERE Especialidade LIKE '%' + @Especialidade + '%' ORDER BY Especialidade, Key_Especialidade")
        conexao.Open()
        queryEspecialidades.Parameters.AddWithValue("@Especialidade", Cb_Especialidade.Text.Trim())
        queryEspecialidades.Connection = conexao

        reader = queryEspecialidades.ExecuteReader()

        Cb_Especialidade.Items.Clear()

        While reader.Read()
            Cb_Especialidade.Items.Add(reader("Especialidade"))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Private Sub Btn_Especialidade_Click(sender As Object, e As EventArgs) Handles Btn_Especialidade.Click
        Form5.Show()
        Me.Close()
        LastForm = 2
    End Sub

    Sub SwitchFields()
        If Tb_NomeMedico.ReadOnly = True Then
            Tb_NomeMedico.ReadOnly = False
            Tb_CartaoCidadao.ReadOnly = False
            Dtp_DataNascimento.Enabled = True
            Tb_Cidade.ReadOnly = False
            Tb_Morada.ReadOnly = False
            Tb_CodigoPostal.ReadOnly = False
            Tb_Contacto.ReadOnly = False
            Tb_Email.ReadOnly = False
            Cb_Especialidade.Enabled = True
        Else
            Tb_NomeMedico.ReadOnly = True
            Tb_CartaoCidadao.ReadOnly = True
            Dtp_DataNascimento.Enabled = False
            Tb_Cidade.ReadOnly = True
            Tb_Morada.ReadOnly = True
            Tb_CodigoPostal.ReadOnly = True
            Tb_Contacto.ReadOnly = True
            Tb_Email.ReadOnly = True
            Cb_Especialidade.Enabled = False
        End If
    End Sub

    Sub Dados()
        Dim queryEspecialidades As SqlCommand = New SqlCommand("SELECT Key_Especialidade, Especialidade FROM Especialidade ORDER BY Especialidade, Key_Especialidade")
        conexao.Open()

        queryEspecialidades.Connection = conexao

        reader = queryEspecialidades.ExecuteReader()

        ListaEspecialidade.Clear()

        While reader.Read()
            ListaEspecialidade.Add(New Especialidades With {
                            .KeyEspecialidade = reader("Key_Especialidade"),
                            .Especialidade = reader("Especialidade")
                            })

            Cb_Especialidade.Items.Add(reader("Especialidade"))
        End While

        reader.Close()

        Dim queryMedicos As SqlCommand = New SqlCommand("SELECT Key_Medico, Nome, CartaoCidadao, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email, Key_Especialidade FROM Medico ORDER BY Nome, CartaoCidadao")

        queryMedicos.Connection = conexao

        reader = queryMedicos.ExecuteReader()

        Lst_Medicos.Items.Clear()
        ListaMedico.Clear()

        While reader.Read()
            ListaMedico.Add(New Medicos With {
                            .KeyMedico = reader("Key_Medico"),
                            .Nome = reader("Nome"),
                            .CartaoCidadao = reader("CartaoCidadao"),
                            .DataNascimento = reader("DataNascimento"),
                            .Cidade = reader("Cidade"),
                            .Morada = reader("Morada"),
                            .CodigoPostal = reader("CodigoPostal"),
                            .Contacto = reader("NumeroContacto"),
                            .Email = reader("Email"),
                            .KeyEspecialidade = reader("Key_Especialidade")
                            })

            Lst_Medicos.Items.Add(New ListViewItem({reader("Nome"), ListaEspecialidade.Find(Function(es) es.KeyEspecialidade = reader("Key_Especialidade")).Especialidade}))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Sub Validar()
        If NomeValido = True AndAlso CartaoCidadaoValido = True AndAlso CidadeValido = True AndAlso MoradaValido = True AndAlso CodigoPostalValido = True AndAlso ContactoValido = True AndAlso EmailValido = True AndAlso EspecialidadeValido Then
            If ButaoClick = True Then
                Btn_Guardar.Enabled = True
                Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskette")
            End If
        Else
            Btn_Guardar.Enabled = False
            Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        End If
    End Sub

    Private Sub Tb_NomeMedico_TextChanged(sender As Object, e As EventArgs) Handles Tb_NomeMedico.TextChanged
        NomeValido = False

        Tb_NomeMedico.Text = Tb_NomeMedico.Text.TrimStart()
        Dim medico() As Char = Tb_NomeMedico.Text.ToCharArray()

        If Not String.IsNullOrEmpty(Tb_NomeMedico.Text.TrimStart()) AndAlso Not Char.IsUpper(medico(0)) Then
            medico(0) = Char.ToUpper(medico(0))
            Tb_NomeMedico.Text = New String(medico)
            Tb_NomeMedico.SelectionStart = Tb_NomeMedico.Text.Length
        End If

        For index = 0 To medico.Length - 1
            If index > 0 AndAlso Char.IsWhiteSpace(medico(index - 1)) AndAlso Char.IsLower(medico(index)) Then
                medico(index) = Char.ToUpper(medico(index))
                Tb_NomeMedico.Text = New String(medico)
                Tb_NomeMedico.SelectionStart = index + 1

                Exit For
            End If

            If index > 0 AndAlso Char.IsLetter(medico(index - 1)) AndAlso Char.IsUpper(medico(index)) Then
                medico(index) = Char.ToLower(medico(index))
                Tb_NomeMedico.Text = New String(medico)
                Tb_NomeMedico.SelectionStart = index + 1

                Exit For
            End If

            If Not ValidarNome.IsMatch(medico(index).ToString()) Or (index >= 1 AndAlso Char.IsWhiteSpace(medico(index)) AndAlso Char.IsWhiteSpace(medico(index - 1))) Then
                Tb_NomeMedico.Text = Tb_NomeMedico.Text.Remove(index, 1)
                Array.Clear(medico, 0, medico.Length)
                medico = Tb_NomeMedico.Text.TrimStart().ToCharArray()
                Tb_NomeMedico.SelectionStart = index + 1

                Exit For
            End If
        Next

        If medico.Length >= 6 Then
            Dim queryValidar As SqlCommand = New SqlCommand("SELECT * FROM Medico WHERE Nome = @Nome")
            conexao.Open()
            queryValidar.Connection = conexao
            queryValidar.Parameters.AddWithValue("@Nome", Tb_NomeMedico.Text.Trim())

            reader = queryValidar.ExecuteReader()
            If reader.HasRows Then
                reader.Read()

                If ButaoGuardar = False AndAlso CodigoMedico <> 0 Then
                    If CodigoMedico = reader("Key_Medico") And Tb_CartaoCidadao.Text = reader("Nome") Then
                        NomeValido = True
                        Lbl_ErroNumero.Text = Nothing
                    Else
                        NomeValido = False
                        Lbl_ErroNumero.Text = "Nome de Médico já Registado"
                    End If
                Else
                    NomeValido = False
                    Lbl_ErroNumero.Text = "Nome de Médico já Registado"
                End If
            Else
                NomeValido = True
                Lbl_ErroNumero.Text = Nothing
            End If

            queryValidar.Parameters.Clear()
            conexao.Close()
        End If

        Validar()
    End Sub

    Private Sub Tb_CartaoCidadao_TextChanged(sender As Object, e As EventArgs) Handles Tb_CartaoCidadao.TextChanged
        CartaoCidadaoValido = False

        Tb_CartaoCidadao.Text = Tb_CartaoCidadao.Text.Trim()
        Dim numero() As Char = Tb_CartaoCidadao.Text.ToCharArray()

        For index = 0 To numero.Length - 1
            If Not Char.IsNumber(numero(index)) Then
                Tb_CartaoCidadao.Text = Tb_CartaoCidadao.Text.Remove(index, 1)
                Array.Clear(numero, 0, numero.Length)
                numero = Tb_CartaoCidadao.Text.Trim().ToCharArray()
                Tb_CartaoCidadao.SelectionStart = index + 1

                Exit For
            End If
        Next

        If numero.Length = 8 Then
            Dim queryValidar As SqlCommand = New SqlCommand("SELECT * FROM Medico WHERE CartaoCidadao = @CartaoCidadao")
            conexao.Open()
            queryValidar.Connection = conexao
            queryValidar.Parameters.AddWithValue("@CartaoCidadao", Tb_CartaoCidadao.Text.Trim())

            reader = queryValidar.ExecuteReader()
            If reader.HasRows Then
                reader.Read()

                If ButaoGuardar = False AndAlso CodigoMedico <> 0 Then
                    If CodigoMedico = reader("Key_Medico") And Tb_CartaoCidadao.Text = reader("CartaoCidadao") Then
                        CartaoCidadaoValido = True
                        Lbl_ErroNumero.Text = Nothing
                    Else
                        CartaoCidadaoValido = False
                        Lbl_ErroNumero.Text = "Numero de Cartão de Cidadão já Registado"
                    End If
                Else
                    CartaoCidadaoValido = False
                    Lbl_ErroNumero.Text = "Numero de Cartão de Cidadão já Registado"
                End If
            Else
                CartaoCidadaoValido = True
                Lbl_ErroNumero.Text = Nothing
            End If

            queryValidar.Parameters.Clear()
            conexao.Close()
        End If
        Validar()
    End Sub

    Private Sub Dtp_DataNascimento_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_DataNascimento.ValueChanged
        If Dtp_DataNascimento.Value > Today Then
            Dtp_DataNascimento.Value = Today
        ElseIf Dtp_DataNascimento.Value <= Today.AddYears(-125) Then
            Dtp_DataNascimento.Value = Today
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

    Private Sub Cb_Especialidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Especialidade.SelectedIndexChanged
        Dim KeyEspecialidade As Integer = ListaEspecialidade.Find(Function(es) es.Especialidade = Cb_Especialidade.SelectedItem).KeyEspecialidade

        If KeyEspecialidade > 0 Then
            EspecialidadeValido = True
        Else
            EspecialidadeValido = False
        End If

        Validar()
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim key As Integer = ListaEspecialidade.Find(Function(es) es.Especialidade = Cb_Especialidade.Text.Trim()).KeyEspecialidade
        If ButaoGuardar = True Then
            Dim queryInserir As SqlCommand = New SqlCommand("INSERT INTO Medico (Nome, CartaoCidadao, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email, Key_Especialidade) VALUES (@Nome, @CartaoCidadao, @DataNascimento, @Cidade, @Morada, @CodigoPostal, @NumeroContacto, @Email, @Especialidade)")
            conexao.Open()
            queryInserir.Connection = conexao
            queryInserir.Parameters.AddWithValue("@Nome", Tb_NomeMedico.Text.Trim())
            queryInserir.Parameters.AddWithValue("@CartaoCidadao", Convert.ToInt64(Tb_CartaoCidadao.Text.Trim()))
            queryInserir.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(Dtp_DataNascimento.Value.ToShortDateString))
            queryInserir.Parameters.AddWithValue("@Cidade", Tb_Cidade.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Morada", Tb_Morada.Text.Trim())
            queryInserir.Parameters.AddWithValue("@CodigoPostal", Tb_CodigoPostal.Text.Trim())
            queryInserir.Parameters.AddWithValue("@NumeroContacto", Tb_Contacto.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Email", Tb_Email.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Especialidade", key)

            queryInserir.ExecuteNonQuery()
            queryInserir.Parameters.Clear()
        Else
            Dim queryEditar As SqlCommand = New SqlCommand("UPDATE Medico SET Nome = @Nome, CartaoCidadao = @CartaoCidadao, DataNascimento = @DataNascimento, Cidade = @Cidade, Morada = @Morada, CodigoPostal = @CodigoPostal, NumeroContacto = @NumeroContacto, Email = @Email, Key_Especialidade = @Especialidade WHERE Key_Medico = @KeyMedico")
            conexao.Open()
            queryEditar.Connection = conexao
            queryEditar.Parameters.AddWithValue("@Nome", Tb_NomeMedico.Text.Trim())
            queryEditar.Parameters.AddWithValue("@CartaoCidadao", Convert.ToInt64(Tb_CartaoCidadao.Text.Trim()))
            queryEditar.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(Dtp_DataNascimento.Value.ToShortDateString))
            queryEditar.Parameters.AddWithValue("@Cidade", Tb_Cidade.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Morada", Tb_Morada.Text.Trim())
            queryEditar.Parameters.AddWithValue("@CodigoPostal", Tb_CodigoPostal.Text.Trim())
            queryEditar.Parameters.AddWithValue("@NumeroContacto", Tb_Contacto.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Email", Tb_Email.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Especialidade", key)
            queryEditar.Parameters.AddWithValue("@KeyMedico", CodigoMedico)

            queryEditar.ExecuteNonQuery()
            queryEditar.Parameters.Clear()
        End If

        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
        Btn_AdicionarMedico.Enabled = True
        Btn_AdicionarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("adduser")
        Btn_EditarMedico.Enabled = False
        Btn_EditarMedico.BackgroundImage = My.Resources.ResourceManager.GetObject("editusergray")
        Btn_Especialidade.Enabled = True
        Btn_Especialidade.BackgroundImage = My.Resources.ResourceManager.GetObject("area")
        Btn_Guardar.Enabled = False
        Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        ButaoGuardar = Nothing
        ButaoClick = False
        Tb_NomeMedico.Text = Nothing
        Tb_CartaoCidadao.Text = Nothing
        Dtp_DataNascimento.Value = Today
        Tb_Cidade.Text = Nothing
        Tb_Morada.Text = Nothing
        Tb_CodigoPostal.Text = Nothing
        Tb_Contacto.Text = Nothing
        Tb_Email.Text = Nothing
        Lst_Medicos.Enabled = True
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
        SwitchFields()

        conexao.Close()
        Dados()
    End Sub
End Class