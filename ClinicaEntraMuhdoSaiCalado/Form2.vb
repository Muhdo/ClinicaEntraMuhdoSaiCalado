Imports System.Data.SqlClient
Public Class Form2
    Dim conexao As SqlConnection
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    Dim ListaConsulta As List(Of Consultas) = New List(Of Consultas)()
    Dim ListaUtente As List(Of Utentes) = New List(Of Utentes)()
    Dim ListaMedico As List(Of Medicos) = New List(Of Medicos)()
    Dim ListaEspecialidade As List(Of Especialidades) = New List(Of Especialidades)()

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form1.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexao = New SqlConnection(connectionString)

        Dim queryUtentes As SqlCommand = New SqlCommand("SELECT Key_Utente, Nome, NumeroUtente, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email FROM Utente")
        conexao.Open()

        queryUtentes.Connection = conexao

        reader = queryUtentes.ExecuteReader()

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

        Dim queryMedicos As SqlCommand = New SqlCommand("SELECT Key_Medico, Nome, CartaoCidadao, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email, Key_Especialidade FROM Medico")

        queryMedicos.Connection = conexao

        reader = queryMedicos.ExecuteReader()

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

        Dim queryEspecialidade As SqlCommand = New SqlCommand("SELECT Key_Especialidade, Especialidade FROM Especialidade")

        queryEspecialidade.Connection = conexao

        reader = queryEspecialidade.ExecuteReader()

        While reader.Read()
            ListaEspecialidade.Add(New Especialidades With {
                            .KeyEspecialidade = reader("Key_Especialidade"),
                            .Especialidade = reader("Especialidade")
                            })
        End While

        reader.Close()

        reader.Close()

        Dim queryConsuta As SqlCommand = New SqlCommand("SELECT Key_Consulta, Key_Utente, Key_Medico, Data, Descricao, Preco FROM Consulta")

        queryConsuta.Connection = conexao

        reader = queryConsuta.ExecuteReader()

        While reader.Read()
            ListaConsulta.Add(New Consultas With {
                                .KeyConsulta = reader("Key_Consulta"),
                                .KeyUtente = reader("Key_Utente"),
                                .KeyMedico = reader("Key_Medico"),
                                .Data = reader("Data"),
                                .Descricao = reader("Descricao"),
                                .Preco = reader("Preco")
                                })
        End While

        reader.Close()
        conexao.Close()

        PopulateListBox()
    End Sub

    Private Sub PopulateListBox()
        Dim Utente As String
        Dim Medico As String
        Dim Data As Date

        Lst_Consultas.Items.Clear()

        Try
            For Each consulta In ListaConsulta
                Utente = consulta.KeyUtente
                Medico = consulta.KeyMedico
                Data = consulta.Data

                Utente = ListaUtente.ElementAt(Utente).KeyUtente
                Utente = ListaUtente.ElementAt(Utente).Nome

                Medico = ListaMedico.ElementAt(Medico).KeyMedico
                Medico = ListaMedico.ElementAt(Medico).Nome

                Lst_Consultas.Items.Add(New ListViewItem({Utente, Medico, Data}))
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class