Module Module1
    Public LastForm As Byte

    Public Class Consultas
        Public KeyConsulta As Integer
        Public KeyUtente As Integer
        Public KeyMedico As Integer
        Public Data As Date
        Public Descricao As String
        Public Preco As Decimal
    End Class

    Public Class Utentes
        Public KeyUtente As Integer
        Public Nome As String
        Public NUtenteSaude As Integer
        Public DataNascimento As Date
        Public Cidade As String
        Public Morada As String
        Public CodigoPostal As String
        Public Contacto As Integer
        Public Email As String
    End Class

    Public Class Medicos
        Public KeyMedico As Integer
        Public Nome As String
        Public CartaoCidadao As Integer
        Public DataNascimento As Date
        Public Cidade As String
        Public Morada As String
        Public CodigoPostal As String
        Public Contacto As Integer
        Public Email As String
        Public KeyEspecialidade As Integer
    End Class

    Public Class Especialidades
        Public KeyEspecialidade As Integer
        Public Especialidade As String
    End Class
End Module
