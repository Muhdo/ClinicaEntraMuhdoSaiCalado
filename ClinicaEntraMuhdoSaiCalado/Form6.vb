Imports System.Data.SqlClient

Public Class Form6
    Dim conexao As SqlConnection
    ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    Dim ListaUtente As List(Of Utentes) = New List(Of Utentes)()
    Dim ListaMedico As List(Of Medicos) = New List(Of Medicos)()
    Dim ListaEspecialidade As List(Of Especialidades) = New List(Of Especialidades)()
    Dim ListaConsulta As List(Of Consultas) = New List(Of Consultas)()


    Dim ButaoGuardar As Boolean 'True = Adicionar, False = Editar
    Dim ButaoClick As Boolean = False
    Dim CodigoConsulta As Integer = 0

    Dim NomeUtenteValido As Boolean = False
    Dim NUtenteSaudeValido As Boolean = False
    Dim NomeMedicoValido As Boolean = False
    Dim EspecialidadeValido As Boolean = False

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dtp_DataConsulta.Value = Now
        conexao = New SqlConnection(connectionString)

        Dados()
    End Sub

    Private Sub Lst_Consultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Consultas.SelectedIndexChanged
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Cb_NomeUtente.Text = Nothing
        Cb_UtenteSaude.Text = Nothing
        Cb_NomeMedico.Text = Nothing
        Cb_Especialidade.Text = Nothing
        Cb_NomeUtente.SelectedItem = -1
        Cb_UtenteSaude.SelectedItem = -1
        Cb_NomeMedico.SelectedItem = -1
        Cb_Especialidade.SelectedItem = -1
        Dtp_DataConsulta.Value = Today
        Tb_Detalhes.Text = Nothing
        Tb_Preco.Text = Nothing
        Cb_NomeUtente.Enabled = False
        Cb_UtenteSaude.Enabled = False
        Cb_NomeMedico.Enabled = False
        Cb_Especialidade.Enabled = False
        Dtp_DataConsulta.Enabled = False
        Tb_Detalhes.ReadOnly = True
        Tb_Preco.ReadOnly = True

        If Lst_Consultas.SelectedIndices.Count >= 1 Then
            Dim utente As Utentes = ListaUtente.Find(Function(u) u.Nome = Lst_Consultas.FocusedItem.SubItems.Item(0).Text)
            Dim medico As Medicos = ListaMedico.Find(Function(m) m.Nome = Lst_Consultas.FocusedItem.SubItems.Item(1).Text)
            Dim especialidade As Especialidades = ListaEspecialidade.Find(Function(es) es.KeyEspecialidade = medico.KeyEspecialidade)
            Dim consulta As Consultas = ListaConsulta.Find(Function(c) c.KeyUtente = utente.KeyUtente And c.KeyMedico = medico.KeyMedico And Format(c.Data, "dd-MM-yyyy HH:mm") = Lst_Consultas.FocusedItem.SubItems.Item(2).Text)

            Btn_EditarConsulta.Enabled = True
            Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpaper")
            CodigoConsulta = consulta.KeyConsulta
            Cb_NomeUtente.Text = utente.Nome
            Cb_UtenteSaude.Text = utente.NUtenteSaude
            Cb_NomeMedico.Text = medico.Nome
            Cb_Especialidade.Text = especialidade.Especialidade
            Dtp_DataConsulta.Value = consulta.Data
            Tb_Detalhes.Text = consulta.Descricao
            Tb_Preco.Text = consulta.Preco & "€"
        ElseIf Lst_Consultas.SelectedIndices.Count = 0 Then
            Btn_EditarConsulta.Enabled = False
            Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
            Cb_NomeUtente.Text = Nothing
            Cb_UtenteSaude.Text = Nothing
            Cb_NomeMedico.Text = Nothing
            Cb_Especialidade.Text = Nothing
            Cb_NomeUtente.SelectedItem = -1
            Cb_UtenteSaude.SelectedItem = -1
            Cb_NomeMedico.SelectedItem = -1
            Cb_Especialidade.SelectedItem = -1
            Dtp_DataConsulta.Value = Today
            Tb_Detalhes.Text = Nothing
            Tb_Preco.Text = Nothing
        End If
    End Sub

    Private Sub Btn_AdicionarConsulta_Click(sender As Object, e As EventArgs) Handles Btn_AdicionarConsulta.Click
        Cb_NomeUtente.Text = Nothing
        Cb_UtenteSaude.Text = Nothing
        Cb_NomeMedico.Text = Nothing
        Cb_Especialidade.Text = Nothing
        Cb_NomeUtente.SelectedItem = -1
        Cb_UtenteSaude.SelectedItem = -1
        Cb_NomeMedico.SelectedItem = -1
        Cb_Especialidade.SelectedItem = -1
        Dtp_DataConsulta.Value = Now
        Tb_Detalhes.Text = Nothing
        Tb_Preco.Text = Nothing
        Lst_Consultas.Enabled = False
        ButaoGuardar = True
        ButaoClick = True
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarConsulta.Enabled = False
        Btn_AdicionarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("addpapergray")
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Btn_ProcurarConsulta.Enabled = False
        Btn_ProcurarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("findpapergray")
        Lbl_SaveMethod.Text = "Inserir Consulta"
        SwitchFields()
    End Sub

    Private Sub Btn_EditarConsulta_Click(sender As Object, e As EventArgs) Handles Btn_EditarConsulta.Click
        Lst_Consultas.Enabled = False

        Dim utente As Utentes = ListaUtente.Find(Function(u) u.Nome = Lst_Consultas.FocusedItem.SubItems.Item(0).Text)
        Dim medico As Medicos = ListaMedico.Find(Function(m) m.Nome = Lst_Consultas.FocusedItem.SubItems.Item(1).Text)
        Dim especialidade As Especialidades = ListaEspecialidade.Find(Function(es) es.KeyEspecialidade = medico.KeyEspecialidade)
        Dim consulta As Consultas = ListaConsulta.Find(Function(c) c.KeyUtente = utente.KeyUtente And c.KeyMedico = medico.KeyMedico And c.Data = Lst_Consultas.FocusedItem.SubItems.Item(2).Text)
        CodigoConsulta = ListaConsulta.Find(Function(c) c.KeyUtente = utente.KeyUtente And c.KeyMedico = medico.KeyMedico And Format(c.Data, "dd-MM-yyyy HH:mm") = Lst_Consultas.FocusedItem.SubItems.Item(2).Text).KeyConsulta

        ButaoGuardar = False
        ButaoClick = True
        Btn_Cancel.Enabled = True
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancel")
        Btn_AdicionarConsulta.Enabled = False
        Btn_AdicionarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("addpapergray")
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Btn_ProcurarConsulta.Enabled = False
        Btn_ProcurarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("findpapergray")
        Lbl_SaveMethod.Text = "Editar Consulta"
        SwitchFields()
        Validar()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        ButaoGuardar = Nothing
        ButaoClick = False
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Cb_NomeUtente.Text = Nothing
        Cb_UtenteSaude.Text = Nothing
        Cb_NomeMedico.Text = Nothing
        Cb_Especialidade.Text = Nothing
        Cb_NomeUtente.SelectedItem = -1
        Cb_UtenteSaude.SelectedItem = -1
        Cb_NomeMedico.SelectedItem = -1
        Cb_Especialidade.SelectedItem = -1
        Dtp_DataConsulta.Value = Today
        Tb_Detalhes.Text = Nothing
        Tb_Preco.Text = Nothing
        Cb_NomeUtente.Enabled = False
        Cb_UtenteSaude.Enabled = False
        Cb_NomeMedico.Enabled = False
        Cb_Especialidade.Enabled = False
        Dtp_DataConsulta.Enabled = False
        Tb_Detalhes.ReadOnly = True
        Tb_Preco.ReadOnly = True
        Btn_AdicionarConsulta.Enabled = True
        Btn_AdicionarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("addpaper")
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Lst_Consultas.Enabled = True
        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
        Btn_ProcurarConsulta.Enabled = True
        Btn_ProcurarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("findpaper")
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
    End Sub

    Private Sub Cb_NomeUtente_DropDown(sender As Object, e As EventArgs) Handles Cb_NomeUtente.DropDown
        Dim queryNomeUtente As SqlCommand = New SqlCommand("SELECT Key_Utente, Nome FROM Utente WHERE Nome LIKE '%' + @Nome + '%' ORDER BY Nome, Key_Utente")
        conexao.Open()
        queryNomeUtente.Parameters.AddWithValue("@Nome", Cb_NomeUtente.Text.Trim())
        queryNomeUtente.Connection = conexao

        reader = queryNomeUtente.ExecuteReader()

        Cb_NomeUtente.Items.Clear()

        While reader.Read()
            Cb_NomeUtente.Items.Add(reader("Nome"))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Private Sub Cb_UtenteSaude_DropDown(sender As Object, e As EventArgs) Handles Cb_UtenteSaude.DropDown
        Dim queryUtenteSaude As SqlCommand = New SqlCommand("SELECT Key_Utente, NumeroUtente FROM Utente WHERE NumeroUtente LIKE '%' + @NumeroUtente + '%' ORDER BY NumeroUtente, Key_Utente")
        conexao.Open()
        queryUtenteSaude.Parameters.AddWithValue("@NumeroUtente", Cb_UtenteSaude.Text.Trim())
        queryUtenteSaude.Connection = conexao

        reader = queryUtenteSaude.ExecuteReader()

        Cb_UtenteSaude.Items.Clear()

        While reader.Read()
            Cb_UtenteSaude.Items.Add(reader("NumeroUtente"))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Private Sub Cb_NomeMedico_DropDown(sender As Object, e As EventArgs) Handles Cb_NomeMedico.DropDown
        Dim queryNomeMedico As SqlCommand

        If Cb_Especialidade.SelectedIndex >= 0 Then
            Dim key As Integer = ListaEspecialidade.Find(Function(es) es.Especialidade = Cb_Especialidade.SelectedItem).KeyEspecialidade
            queryNomeMedico = New SqlCommand("SELECT Key_Medico, Nome FROM Medico WHERE Nome LIKE '%' + @Nome + '%' AND Key_Especialidade = @Especialidade ORDER BY Nome, Key_Medico")
            queryNomeMedico.Parameters.AddWithValue("@Especialidade", key)
        Else
            queryNomeMedico = New SqlCommand("SELECT Key_Medico, Nome FROM Medico WHERE Nome LIKE '%' + @Nome + '%' ORDER BY Nome, Key_Medico")
        End If
        conexao.Open()
        queryNomeMedico.Parameters.AddWithValue("@Nome", Cb_NomeMedico.Text.Trim())
        queryNomeMedico.Connection = conexao

        reader = queryNomeMedico.ExecuteReader()

        Cb_NomeMedico.Items.Clear()

        While reader.Read()
            Cb_NomeMedico.Items.Add(reader("Nome"))
        End While

        reader.Close()
        conexao.Close()
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

    Private Sub Btn_ProcurarConsulta_Click(sender As Object, e As EventArgs) Handles Btn_ProcurarConsulta.Click
        Form2.Show()
        Me.Close()
    End Sub

    Sub SwitchFields()
        If Cb_NomeUtente.Enabled = True Then
            Cb_NomeUtente.Enabled = False
            Cb_UtenteSaude.Enabled = False
            Cb_NomeMedico.Enabled = False
            Cb_Especialidade.Enabled = False
            Dtp_DataConsulta.Enabled = False
            Tb_Detalhes.ReadOnly = True
            Tb_Preco.ReadOnly = True
        Else
            Cb_NomeUtente.Enabled = True
            Cb_UtenteSaude.Enabled = True
            Cb_NomeMedico.Enabled = True
            Cb_Especialidade.Enabled = True
            Dtp_DataConsulta.Enabled = True
            Tb_Detalhes.ReadOnly = False
            Tb_Preco.ReadOnly = False
        End If
    End Sub

    Sub Dados()
        Dim queryUtentes As SqlCommand = New SqlCommand("SELECT Key_Utente, Nome, NumeroUtente, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email FROM Utente ORDER BY Nome, NumeroUtente")
        conexao.Open()

        queryUtentes.Connection = conexao

        reader = queryUtentes.ExecuteReader()

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

            Cb_NomeUtente.Items.Add(reader("Nome"))
            Cb_UtenteSaude.Items.Add(reader("NumeroUtente"))
        End While

        reader.Close()

        Dim queryMedicos As SqlCommand = New SqlCommand("SELECT Key_Medico, Nome, CartaoCidadao, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email, Key_Especialidade FROM Medico ORDER BY Nome, CartaoCidadao")

        queryMedicos.Connection = conexao

        reader = queryMedicos.ExecuteReader()

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

            Cb_NomeMedico.Items.Add(reader("Nome"))
        End While

        reader.Close()

        Dim queryEspecialidade As SqlCommand = New SqlCommand("SELECT Key_Especialidade, Especialidade FROM Especialidade ORDER BY Especialidade, Key_Especialidade")

        queryEspecialidade.Connection = conexao

        reader = queryEspecialidade.ExecuteReader()

        ListaEspecialidade.Clear()

        While reader.Read()
            ListaEspecialidade.Add(New Especialidades With {
                            .KeyEspecialidade = reader("Key_Especialidade"),
                            .Especialidade = reader("Especialidade")
                            })

            Cb_Especialidade.Items.Add(reader("Especialidade"))
        End While

        reader.Close()

        Dim queryConsulta As SqlCommand = New SqlCommand("SELECT Key_Consulta, Key_Utente, Key_Medico, Data, Descricao, Preco FROM Consulta ORDER BY Data DESC")

        queryConsulta.Connection = conexao

        reader = queryConsulta.ExecuteReader()

        Lst_Consultas.Items.Clear()
        ListaConsulta.Clear()

        Dim utente As String
        Dim medico As String

        While reader.Read()
            ListaConsulta.Add(New Consultas With {
                            .KeyConsulta = reader("Key_Consulta"),
                            .KeyUtente = reader("Key_Utente"),
                            .KeyMedico = reader("Key_Medico"),
                            .Data = reader("Data"),
                            .Descricao = reader("Descricao"),
                            .Preco = reader("Preco")
                            })

            utente = ListaUtente.Find(Function(u) u.KeyUtente = reader("Key_Utente")).Nome
            medico = ListaMedico.Find(Function(m) m.KeyMedico = reader("Key_Medico")).Nome

            Lst_Consultas.Items.Add(New ListViewItem({utente, medico, Format(reader("Data"), "dd-MM-yyyy HH:mm")}))
        End While

        reader.Close()
        conexao.Close()
    End Sub

    Sub Validar()
        If NomeUtenteValido = True AndAlso NUtenteSaudeValido = True AndAlso NomeMedicoValido = True AndAlso EspecialidadeValido = True Then
            If ButaoClick = True Then
                Btn_Guardar.Enabled = True
                Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskette")
            End If
        Else
            Btn_Guardar.Enabled = False
            Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        End If
    End Sub

    Private Sub Cb_NomeUtente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_NomeUtente.SelectedIndexChanged
        Try
            Dim numeroutente As Integer = ListaUtente.Find(Function(u) u.Nome = Cb_NomeUtente.SelectedItem).NUtenteSaude
            Cb_UtenteSaude.SelectedItem = numeroutente
        Catch ex As Exception
        End Try

        If Cb_NomeUtente.SelectedIndex >= 0 Then
            NomeUtenteValido = True
        Else
            NomeUtenteValido = False
        End If

        Validar()
    End Sub

    Private Sub Cb_UtenteSaude_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_UtenteSaude.SelectedIndexChanged
        Try
            Dim nomeutente As String = ListaUtente.Find(Function(u) u.NUtenteSaude = Cb_UtenteSaude.SelectedItem).Nome
            Cb_NomeUtente.SelectedItem = nomeutente
        Catch ex As Exception
        End Try

        If Cb_UtenteSaude.SelectedIndex >= 0 Then
            NUtenteSaudeValido = True
        Else
            NUtenteSaudeValido = False
        End If

        Validar()
    End Sub

    Private Sub Cb_NomeMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_NomeMedico.SelectedIndexChanged
        Try
            Dim key As Integer = ListaMedico.Find(Function(m) m.Nome = Cb_NomeMedico.SelectedItem).KeyEspecialidade
            Dim especialidade As String = ListaEspecialidade.Find(Function(es) es.KeyEspecialidade = key).Especialidade

            If Not Cb_Especialidade.SelectedItem = especialidade Then
                Cb_Especialidade.SelectedItem = especialidade
            End If
        Catch ex As Exception
        End Try


        If Cb_NomeMedico.SelectedIndex >= 0 Then
            NomeMedicoValido = True
            EspecialidadeValido = True
        Else
            NomeMedicoValido = False
            EspecialidadeValido = False
        End If

        Validar()
    End Sub

    Private Sub Cb_Especialidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Especialidade.SelectedIndexChanged
        Try
            Dim key As Integer = ListaEspecialidade.Find(Function(es) es.Especialidade = Cb_Especialidade.SelectedItem).KeyEspecialidade
            Dim medic As Integer = 0

            If Cb_NomeMedico.SelectedIndex >= 0 Then
                medic = ListaMedico.Find(Function(m) m.Nome = Cb_NomeMedico.SelectedItem).KeyEspecialidade
            End If

            If Not medic = key Then
                Cb_NomeMedico.Items.Clear()

                For Each medico As Medicos In ListaMedico
                    If medico.KeyEspecialidade = key Then
                        Cb_NomeMedico.Items.Add(medico.Nome)
                    End If
                Next

                If Cb_Especialidade.SelectedIndex >= 0 Then
                    EspecialidadeValido = True
                Else
                    EspecialidadeValido = False
                End If
            End If
        Catch ex As Exception
        End Try

        Validar()
    End Sub

    Private Sub Dtp_DataConsulta_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_DataConsulta.ValueChanged
        If Dtp_DataConsulta.Value <= Now Then
            Dtp_DataConsulta.Value = Now.AddMinutes(5)
        ElseIf Dtp_DataConsulta.Value >= Now.AddYears(20) Then
            Dtp_DataConsulta.Value = Now.AddMinutes(5)
        End If
    End Sub

    Private Sub Tb_Preco_TextChanged(sender As Object, e As EventArgs) Handles Tb_Preco.TextChanged
        Tb_Preco.Text = Tb_Preco.Text.TrimStart()
        Dim preco() As Char = Tb_Preco.Text.ToCharArray()

        If preco.Length >= 1 AndAlso preco(0) = "," Then
            Tb_Preco.Text = Tb_Preco.Text.Remove(0, 1)
            Array.Clear(preco, 0, preco.Length)
            preco = Tb_Preco.Text.Trim().ToCharArray()
            Tb_Preco.SelectionStart = 1
        End If

        Dim comma As Boolean = False

        For index = 0 To preco.Length - 1
            If comma = False AndAlso preco(index) = "," Then
                comma = True
            ElseIf comma = True AndAlso preco(index) = "," Then
                Tb_Preco.Text = Tb_Preco.Text.Remove(index, 1)
                Array.Clear(preco, 0, preco.Length)
                preco = Tb_Preco.Text.Trim().ToCharArray()
                Tb_Preco.SelectionStart = index

                Exit For
            End If

            If Not Char.IsNumber(preco(index)) And Not preco(index) = "," Then
                Tb_Preco.Text = Tb_Preco.Text.Remove(index, 1)
                Array.Clear(preco, 0, preco.Length)
                preco = Tb_Preco.Text.Trim().ToCharArray()
                Tb_Preco.SelectionStart = index + 1

                Exit For
            End If
        Next
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim keyUtente As Integer = ListaUtente.Find(Function(u) u.Nome = Cb_NomeUtente.Text.Trim() And u.NUtenteSaude = Cb_UtenteSaude.Text.Trim()).KeyUtente
        Dim key As Integer = ListaEspecialidade.Find(Function(es) es.Especialidade = Cb_Especialidade.Text.Trim()).KeyEspecialidade
        Dim keyMedico As Integer = ListaMedico.Find(Function(m) m.Nome = Cb_NomeMedico.Text.Trim() And m.KeyEspecialidade = key).KeyMedico

        If ButaoGuardar = True Then
            Dim queryInserir As SqlCommand = New SqlCommand("INSERT INTO Consulta (Key_Utente, Key_Medico, Data, Descricao, Preco) VALUES (@Key_Utente, @Key_Medico, @Data, @Descricao, @Preco)")
            conexao.Open()
            queryInserir.Connection = conexao
            queryInserir.Parameters.AddWithValue("@Key_Utente", keyUtente)
            queryInserir.Parameters.AddWithValue("@Key_Medico", keyMedico)
            queryInserir.Parameters.AddWithValue("@Data", Convert.ToDateTime(Dtp_DataConsulta.Value))
            queryInserir.Parameters.AddWithValue("@Descricao", Tb_Detalhes.Text.Trim())
            queryInserir.Parameters.AddWithValue("@Preco", Tb_Preco.Text.Trim())

            queryInserir.ExecuteNonQuery()
            queryInserir.Parameters.Clear()
        Else
            Dim queryEditar As SqlCommand = New SqlCommand("UPDATE Consulta SET Key_Utente = @Key_Utente, Key_Medico = @Key_Medico, Data = @Data, Descricao = @Descricao, Preco = @Preco WHERE Key_Consulta = @Key_Consulta")
            conexao.Open()
            queryEditar.Connection = conexao
            queryEditar.Parameters.AddWithValue("@Key_Utente", keyUtente)
            queryEditar.Parameters.AddWithValue("@Key_Medico", keyMedico)
            queryEditar.Parameters.AddWithValue("@Data", Convert.ToDateTime(Dtp_DataConsulta.Value))
            queryEditar.Parameters.AddWithValue("@Descricao", Tb_Detalhes.Text.Trim())
            queryEditar.Parameters.AddWithValue("@Preco", Convert.ToDecimal(Tb_Preco.Text.Trim()))
            queryEditar.Parameters.AddWithValue("@Key_Consulta", CodigoConsulta)

            queryEditar.ExecuteNonQuery()
            queryEditar.Parameters.Clear()
        End If

        Btn_Cancel.Enabled = False
        Btn_Cancel.BackgroundImage = My.Resources.ResourceManager.GetObject("cancelgray")
        Btn_AdicionarConsulta.Enabled = True
        Btn_AdicionarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("addpaper")
        Btn_EditarConsulta.Enabled = False
        Btn_EditarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("editpapergray")
        Btn_ProcurarConsulta.Enabled = True
        Btn_ProcurarConsulta.BackgroundImage = My.Resources.ResourceManager.GetObject("findpaper")
        Btn_Guardar.Enabled = False
        Btn_Guardar.BackgroundImage = My.Resources.ResourceManager.GetObject("diskettegray")
        ButaoGuardar = Nothing
        ButaoClick = False
        Cb_NomeUtente.Text = Nothing
        Cb_UtenteSaude.Text = Nothing
        Cb_NomeMedico.Text = Nothing
        Cb_Especialidade.Text = Nothing
        Cb_NomeUtente.SelectedItem = -1
        Cb_UtenteSaude.SelectedItem = -1
        Cb_NomeMedico.SelectedItem = -1
        Cb_Especialidade.SelectedItem = -1
        Dtp_DataConsulta.Value = Today
        Tb_Detalhes.Text = Nothing
        Tb_Preco.Text = Nothing
        Lst_Consultas.Enabled = True
        Lbl_SaveMethod.Text = "Sem Metodo Definido"
        SwitchFields()

        conexao.Close()
        Dados()
    End Sub
End Class