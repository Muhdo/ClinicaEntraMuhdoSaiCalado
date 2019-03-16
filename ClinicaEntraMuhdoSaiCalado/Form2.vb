Imports System.Data.SqlClient
Public Class Form2
    Dim conexao As SqlConnection
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\Clinica.mdf;Integrated Security=True;"
    Dim reader As SqlDataReader

    Dim ListaConsulta() As Consultas
    Dim ListaUtente() As Utentes
    Dim ListaMedico() As Medicos
    Dim ListaEspecialidade() As Especialidades

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form1.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        End While

        reader.Close()

        Dim queryMedicos As SqlCommand = New SqlCommand("SELECT Key_Medico, Nome, CartaoCidadao, DataNascimento, Cidade, Morada, CodigoPostal, NumeroContacto, Email, Key_Especialidade FROM Medico")

        queryMedicos.Connection = conexao

        reader = queryMedicos.ExecuteReader()

        i = -1

        While reader.Read()
            i += 1
            ReDim Preserve ListaMedico(i)

            ListaMedico(i).KeyMedico = reader("Key_Medico")
            ListaMedico(i).Nome = reader("Nome")
            ListaMedico(i).CartaoCidadao = reader("CartaoCidadao")
            ListaMedico(i).DataNascimento = reader("DataNascimento")
            ListaMedico(i).Cidade = reader("Cidade")
            ListaMedico(i).Morada = reader("Morada")
            ListaMedico(i).CodigoPostal = reader("CodigoPostal")
            ListaMedico(i).Contacto = reader("NumeroContacto")
            ListaMedico(i).Email = reader("Email")
            ListaMedico(i).KeyEspecialidade = reader("Key_Especialidade")
        End While

        reader.Close()

        Dim queryEspecialidade As SqlCommand = New SqlCommand("SELECT Key_Especialidade, Especialidade FROM Especialidade")

        queryEspecialidade.Connection = conexao

        reader = queryEspecialidade.ExecuteReader()

        i = -1

        While reader.Read()
            i += 1
            ReDim Preserve ListaEspecialidade(i)

            ListaEspecialidade(i).KeyEspecialidade = reader("Key_Especialidade")
            ListaEspecialidade(i).Especialidade = reader("Especialidade")
        End While

        reader.Close()

        reader.Close()

        Dim queryConsuta As SqlCommand = New SqlCommand("SELECT Key_Consulta, Key_Utente, Key_Medico, Data, Descricao, Preco FROM Consulta")

        queryConsuta.Connection = conexao

        reader = queryConsuta.ExecuteReader()

        i = -1

        While reader.Read()
            i += 1
            ReDim Preserve ListaConsulta(i)

            ListaConsulta(i).KeyConsulta = reader("Key_Consulta")
            ListaConsulta(i).KeyUtente = reader("Key_Utente")
            ListaConsulta(i).KeyMedico = reader("Key_Medico")
            ListaConsulta(i).Data = reader("Data")
            ListaConsulta(i).Descricao = reader("Descricao")
            ListaConsulta(i).Preco = reader("Preco")
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