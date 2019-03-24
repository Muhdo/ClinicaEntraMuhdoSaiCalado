<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lst_Consultas = New System.Windows.Forms.ListView()
        Me.Utente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Medico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_Preco = New System.Windows.Forms.Label()
        Me.Lbl_Detalhes = New System.Windows.Forms.Label()
        Me.Lbl_Data = New System.Windows.Forms.Label()
        Me.Lbl_Especialidade = New System.Windows.Forms.Label()
        Me.Lbl_NomeMedico = New System.Windows.Forms.Label()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Lbl_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.Lbl_Morada = New System.Windows.Forms.Label()
        Me.Lbl_Cidade = New System.Windows.Forms.Label()
        Me.Lbl_NumeroUtente = New System.Windows.Forms.Label()
        Me.Lbl_NomeUtente = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Gerir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(348, 35)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Página Inicial"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Red
        Me.Btn_Close.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Location = New System.Drawing.Point(1255, 0)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 0
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lst_Consultas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 685)
        Me.Panel2.TabIndex = 1
        '
        'Lst_Consultas
        '
        Me.Lst_Consultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Lst_Consultas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Utente, Me.Medico, Me.Data})
        Me.Lst_Consultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_Consultas.ForeColor = System.Drawing.Color.White
        Me.Lst_Consultas.FullRowSelect = True
        Me.Lst_Consultas.Location = New System.Drawing.Point(0, 0)
        Me.Lst_Consultas.MultiSelect = False
        Me.Lst_Consultas.Name = "Lst_Consultas"
        Me.Lst_Consultas.Size = New System.Drawing.Size(360, 685)
        Me.Lst_Consultas.TabIndex = 1
        Me.Lst_Consultas.UseCompatibleStateImageBehavior = False
        Me.Lst_Consultas.View = System.Windows.Forms.View.Details
        '
        'Utente
        '
        Me.Utente.Text = "Utente"
        Me.Utente.Width = 120
        '
        'Medico
        '
        Me.Medico.Text = "Medico"
        Me.Medico.Width = 120
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 116
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbl_Preco)
        Me.Panel3.Controls.Add(Me.Lbl_Detalhes)
        Me.Panel3.Controls.Add(Me.Lbl_Data)
        Me.Panel3.Controls.Add(Me.Lbl_Especialidade)
        Me.Panel3.Controls.Add(Me.Lbl_NomeMedico)
        Me.Panel3.Controls.Add(Me.Lbl_Email)
        Me.Panel3.Controls.Add(Me.Lbl_Contacto)
        Me.Panel3.Controls.Add(Me.Lbl_CodigoPostal)
        Me.Panel3.Controls.Add(Me.Lbl_Morada)
        Me.Panel3.Controls.Add(Me.Lbl_Cidade)
        Me.Panel3.Controls.Add(Me.Lbl_NumeroUtente)
        Me.Panel3.Controls.Add(Me.Lbl_NomeUtente)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(360, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 685)
        Me.Panel3.TabIndex = 0
        '
        'Lbl_Preco
        '
        Me.Lbl_Preco.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Preco.ForeColor = System.Drawing.Color.White
        Me.Lbl_Preco.Location = New System.Drawing.Point(148, 595)
        Me.Lbl_Preco.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Preco.Name = "Lbl_Preco"
        Me.Lbl_Preco.Size = New System.Drawing.Size(113, 27)
        Me.Lbl_Preco.TabIndex = 23
        Me.Lbl_Preco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Detalhes
        '
        Me.Lbl_Detalhes.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Detalhes.ForeColor = System.Drawing.Color.White
        Me.Lbl_Detalhes.Location = New System.Drawing.Point(148, 333)
        Me.Lbl_Detalhes.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Detalhes.Name = "Lbl_Detalhes"
        Me.Lbl_Detalhes.Size = New System.Drawing.Size(779, 256)
        Me.Lbl_Detalhes.TabIndex = 22
        Me.Lbl_Detalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Data
        '
        Me.Lbl_Data.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Data.ForeColor = System.Drawing.Color.White
        Me.Lbl_Data.Location = New System.Drawing.Point(148, 300)
        Me.Lbl_Data.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Data.Name = "Lbl_Data"
        Me.Lbl_Data.Size = New System.Drawing.Size(215, 27)
        Me.Lbl_Data.TabIndex = 21
        Me.Lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Especialidade
        '
        Me.Lbl_Especialidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Especialidade.ForeColor = System.Drawing.Color.White
        Me.Lbl_Especialidade.Location = New System.Drawing.Point(148, 267)
        Me.Lbl_Especialidade.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Especialidade.Name = "Lbl_Especialidade"
        Me.Lbl_Especialidade.Size = New System.Drawing.Size(779, 27)
        Me.Lbl_Especialidade.TabIndex = 20
        Me.Lbl_Especialidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_NomeMedico
        '
        Me.Lbl_NomeMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_NomeMedico.ForeColor = System.Drawing.Color.White
        Me.Lbl_NomeMedico.Location = New System.Drawing.Point(148, 234)
        Me.Lbl_NomeMedico.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_NomeMedico.Name = "Lbl_NomeMedico"
        Me.Lbl_NomeMedico.Size = New System.Drawing.Size(779, 27)
        Me.Lbl_NomeMedico.TabIndex = 19
        Me.Lbl_NomeMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Email
        '
        Me.Lbl_Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Email.ForeColor = System.Drawing.Color.White
        Me.Lbl_Email.Location = New System.Drawing.Point(148, 201)
        Me.Lbl_Email.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(779, 27)
        Me.Lbl_Email.TabIndex = 18
        Me.Lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Contacto
        '
        Me.Lbl_Contacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Contacto.ForeColor = System.Drawing.Color.White
        Me.Lbl_Contacto.Location = New System.Drawing.Point(148, 168)
        Me.Lbl_Contacto.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Contacto.Name = "Lbl_Contacto"
        Me.Lbl_Contacto.Size = New System.Drawing.Size(215, 27)
        Me.Lbl_Contacto.TabIndex = 17
        Me.Lbl_Contacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_CodigoPostal
        '
        Me.Lbl_CodigoPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_CodigoPostal.ForeColor = System.Drawing.Color.White
        Me.Lbl_CodigoPostal.Location = New System.Drawing.Point(148, 135)
        Me.Lbl_CodigoPostal.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_CodigoPostal.Name = "Lbl_CodigoPostal"
        Me.Lbl_CodigoPostal.Size = New System.Drawing.Size(215, 27)
        Me.Lbl_CodigoPostal.TabIndex = 16
        Me.Lbl_CodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Morada
        '
        Me.Lbl_Morada.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Morada.ForeColor = System.Drawing.Color.White
        Me.Lbl_Morada.Location = New System.Drawing.Point(148, 102)
        Me.Lbl_Morada.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Morada.Name = "Lbl_Morada"
        Me.Lbl_Morada.Size = New System.Drawing.Size(779, 27)
        Me.Lbl_Morada.TabIndex = 15
        Me.Lbl_Morada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Cidade
        '
        Me.Lbl_Cidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_Cidade.ForeColor = System.Drawing.Color.White
        Me.Lbl_Cidade.Location = New System.Drawing.Point(148, 69)
        Me.Lbl_Cidade.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Cidade.Name = "Lbl_Cidade"
        Me.Lbl_Cidade.Size = New System.Drawing.Size(319, 27)
        Me.Lbl_Cidade.TabIndex = 14
        Me.Lbl_Cidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_NumeroUtente
        '
        Me.Lbl_NumeroUtente.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_NumeroUtente.ForeColor = System.Drawing.Color.White
        Me.Lbl_NumeroUtente.Location = New System.Drawing.Point(148, 36)
        Me.Lbl_NumeroUtente.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_NumeroUtente.Name = "Lbl_NumeroUtente"
        Me.Lbl_NumeroUtente.Size = New System.Drawing.Size(215, 27)
        Me.Lbl_NumeroUtente.TabIndex = 13
        Me.Lbl_NumeroUtente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_NomeUtente
        '
        Me.Lbl_NomeUtente.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_NomeUtente.ForeColor = System.Drawing.Color.White
        Me.Lbl_NomeUtente.Location = New System.Drawing.Point(148, 3)
        Me.Lbl_NomeUtente.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_NomeUtente.Name = "Lbl_NomeUtente"
        Me.Lbl_NomeUtente.Size = New System.Drawing.Size(779, 27)
        Me.Lbl_NomeUtente.TabIndex = 12
        Me.Lbl_NomeUtente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(145, 625)
        Me.Panel5.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 595)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 27)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Valor a Pagar:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 333)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 256)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Detalhes:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 300)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 27)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Data Consulta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Especialidade:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 234)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nome Médico:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 27)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contacto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código-Postal:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Morada:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cidade:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº Utente de Saude:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Utente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Gerir)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 625)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 60)
        Me.Panel4.TabIndex = 0
        '
        'Btn_Gerir
        '
        Me.Btn_Gerir.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Gerir.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.management
        Me.Btn_Gerir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Gerir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Gerir.FlatAppearance.BorderSize = 0
        Me.Btn_Gerir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Gerir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Gerir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Gerir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Gerir.ForeColor = System.Drawing.Color.White
        Me.Btn_Gerir.Location = New System.Drawing.Point(870, 0)
        Me.Btn_Gerir.Name = "Btn_Gerir"
        Me.Btn_Gerir.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Gerir.TabIndex = 0
        Me.Btn_Gerir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1290, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Cidade As Label
    Friend WithEvents Lbl_NumeroUtente As Label
    Friend WithEvents Lbl_NomeUtente As Label
    Friend WithEvents Lbl_CodigoPostal As Label
    Friend WithEvents Lbl_Morada As Label
    Friend WithEvents Lbl_NomeMedico As Label
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Lbl_Contacto As Label
    Friend WithEvents Lbl_Preco As Label
    Friend WithEvents Lbl_Detalhes As Label
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Lbl_Especialidade As Label
    Friend WithEvents Btn_Gerir As Button
    Friend WithEvents Lst_Consultas As ListView
    Friend WithEvents Utente As ColumnHeader
    Friend WithEvents Medico As ColumnHeader
    Friend WithEvents Data As ColumnHeader
    Friend WithEvents Label13 As Label
End Class
