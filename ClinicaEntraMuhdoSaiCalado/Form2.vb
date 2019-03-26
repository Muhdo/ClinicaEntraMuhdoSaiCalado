Imports System.Data.SqlClient
Public Class Form2
    Dim conexao As SqlConnection
    ReadOnly connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    Dim ListaConsulta As List(Of Consultas) = New List(Of Consultas)()
    Dim ListaUtente As List(Of Utentes) = New List(Of Utentes)()
    Dim ListaMedico As List(Of Medicos) = New List(Of Medicos)()
    Dim ListaEspecialidade As List(Of Especialidades) = New List(Of Especialidades)()

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao = New SqlConnection(connectionString)
        Dados()
    End Sub

    Private Sub Lst_Consultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Consultas.SelectedIndexChanged
        If Lst_Consultas.SelectedIndices.Count >= 1 Then
            Dim utente As Utentes = ListaUtente.Find(Function(u) u.Nome = Lst_Consultas.FocusedItem.SubItems.Item(0).Text)
            Dim medico As Medicos = ListaMedico.Find(Function(m) m.Nome = Lst_Consultas.FocusedItem.SubItems.Item(1).Text)
            Dim especialidade As Especialidades = ListaEspecialidade.Find(Function(es) es.KeyEspecialidade = medico.KeyEspecialidade)
            Dim consulta As Consultas = ListaConsulta.Find(Function(c) c.KeyUtente = utente.KeyUtente And c.KeyMedico = medico.KeyMedico And Format(c.Data, "dd-MM-yyyy HH:mm") = Lst_Consultas.FocusedItem.SubItems.Item(2).Text)

            Lbl_NomeUtente.Text = utente.Nome
            Lbl_NumeroUtente.Text = utente.NUtenteSaude
            Lbl_Cidade.Text = utente.Cidade
            Lbl_Morada.Text = utente.Morada
            Lbl_CodigoPostal.Text = utente.CodigoPostal
            Lbl_Contacto.Text = utente.Contacto
            Lbl_Email.Text = utente.Email
            Lbl_NomeMedico.Text = medico.Nome
            Lbl_Especialidade.Text = especialidade.Especialidade
            Lbl_Data.Text = Format(consulta.Data, "dd-MM-yyyy HH:mm")
            Lbl_Detalhes.Text = consulta.Descricao
            Lbl_Preco.Text = consulta.Preco & " €"
        ElseIf Lst_Consultas.SelectedIndices.Count = 0 Then
            Lbl_NomeUtente.Text = Nothing
            Lbl_NumeroUtente.Text = Nothing
            Lbl_Cidade.Text = Nothing
            Lbl_Morada.Text = Nothing
            Lbl_CodigoPostal.Text = Nothing
            Lbl_Contacto.Text = Nothing
            Lbl_Email.Text = Nothing
            Lbl_NomeMedico.Text = Nothing
            Lbl_Especialidade.Text = Nothing
            Lbl_Data.Text = Nothing
            Lbl_Detalhes.Text = Nothing
            Lbl_Preco.Text = Nothing
        End If
    End Sub

    Private Sub Dados()
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
        End While

        reader.Close()

        Dim queryConsulta As SqlCommand = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta ORDER BY Data")

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

    Private Sub Btn_Gerir_Click(sender As Object, e As EventArgs) Handles Btn_Gerir.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim queryPesquisa As SqlCommand

        Select Case Cb_Campo.SelectedIndex
            Case 0
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE Cidade LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 1
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE Contacto LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 2
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE CodigoPostal LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 3
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta WHERE Data LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 4
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta WHERE Descricao LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 5
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE Email LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 6
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Medico ON Consulta.Key_Medico = Medico.Key_Medico INNER JOIN Especialidade ON Medico.Key_Especialidade = Especialidade.Key_Especialidade WHERE Especialidade LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 7
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE Morada LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 8
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Medico ON Consulta.Key_Medico = Medico.Key_Medico WHERE Nome LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 9
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE Nome LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 10
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente WHERE NumeroUtente LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 11
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta WHERE Preco LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case 11
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta INNER JOIN Utente ON Consulta.Key_Utente = Utente.Key_Utente INNER JOIN Medico ON Consulta.Key_Medico = Medico.Key_Medico INNER JOIN Especialidade ON Medico.Key_Especialidade = Especialidade.Key_Especialidade WHERE Utente.Nome LIKE '%' + @Pesquisa + '%' OR NumeroUtente LIKE '%' + @Pesquisa + '%' OR Utente.DataNascimento LIKE '%' + @Pesquisa + '%' OR Utente.Cidade LIKE '%' + @Pesquisa + '%' OR Utente.Morada LIKE '%' + @Pesquisa + '%' OR Utente.CodigoPostal LIKE '%' + @Pesquisa + '%' OR Utente.NumeroContacto LIKE '%' + @Pesquisa + '%' OR Utente.Email LIKE '%' + @Pesquisa + '%' OR Medico.Nome LIKE '%' + @Pesquisa + '%' OR Especialidade LIKE '%' + @Pesquisa + '%' OR Data LIKE '%' + @Pesquisa + '%' OR Descricao LIKE '%' + @Pesquisa + '%' OR Preco LIKE '%' + @Pesquisa + '%' ORDER BY Data DESC")
            Case Else
                queryPesquisa = New SqlCommand("SELECT Key_Consulta, Consulta.Key_Utente, Consulta.Key_Medico, Data, Descricao, Preco FROM Consulta ORDER BY Data DESC")
        End Select

        conexao.Open()

        queryPesquisa.Parameters.AddWithValue("@Pesquisa", Tb_Conteudo.Text)
        queryPesquisa.Connection = conexao

        reader = queryPesquisa.ExecuteReader()

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
End Class