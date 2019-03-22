<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lst_Utentes = New System.Windows.Forms.ListView()
        Me.Utente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UtenteSaude = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_ErroEmail = New System.Windows.Forms.Label()
        Me.Lbl_ErroNumero = New System.Windows.Forms.Label()
        Me.Tb_Email = New System.Windows.Forms.TextBox()
        Me.Tb_Contacto = New System.Windows.Forms.TextBox()
        Me.Tb_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.Tb_Morada = New System.Windows.Forms.TextBox()
        Me.Tb_Cidade = New System.Windows.Forms.TextBox()
        Me.Tb_NumeroUtente = New System.Windows.Forms.TextBox()
        Me.Tb_NomeUtente = New System.Windows.Forms.TextBox()
        Me.Dtp_DataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_SaveMethod = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_EditarUtente = New System.Windows.Forms.Button()
        Me.Btn_AdicionarUtente = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 35)
        Me.Panel1.TabIndex = 1
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
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(35, 35)
        Me.Btn_Close.TabIndex = 0
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lst_Utentes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 685)
        Me.Panel2.TabIndex = 2
        '
        'Lst_Utentes
        '
        Me.Lst_Utentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Lst_Utentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Utente, Me.UtenteSaude})
        Me.Lst_Utentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_Utentes.ForeColor = System.Drawing.Color.White
        Me.Lst_Utentes.FullRowSelect = True
        Me.Lst_Utentes.Location = New System.Drawing.Point(0, 0)
        Me.Lst_Utentes.MultiSelect = False
        Me.Lst_Utentes.Name = "Lst_Utentes"
        Me.Lst_Utentes.Size = New System.Drawing.Size(360, 685)
        Me.Lst_Utentes.TabIndex = 2
        Me.Lst_Utentes.UseCompatibleStateImageBehavior = False
        Me.Lst_Utentes.View = System.Windows.Forms.View.Details
        '
        'Utente
        '
        Me.Utente.Text = "Utente"
        Me.Utente.Width = 243
        '
        'UtenteSaude
        '
        Me.UtenteSaude.Text = "Utente de Saude"
        Me.UtenteSaude.Width = 113
        '
        'Panel5
        '
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
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Data Nascimento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 234)
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
        Me.Label6.Location = New System.Drawing.Point(3, 201)
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
        Me.Label5.Location = New System.Drawing.Point(3, 168)
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
        Me.Label4.Location = New System.Drawing.Point(3, 135)
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
        Me.Label3.Location = New System.Drawing.Point(3, 102)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbl_ErroEmail)
        Me.Panel3.Controls.Add(Me.Lbl_ErroNumero)
        Me.Panel3.Controls.Add(Me.Tb_Email)
        Me.Panel3.Controls.Add(Me.Tb_Contacto)
        Me.Panel3.Controls.Add(Me.Tb_CodigoPostal)
        Me.Panel3.Controls.Add(Me.Tb_Morada)
        Me.Panel3.Controls.Add(Me.Tb_Cidade)
        Me.Panel3.Controls.Add(Me.Tb_NumeroUtente)
        Me.Panel3.Controls.Add(Me.Tb_NomeUtente)
        Me.Panel3.Controls.Add(Me.Dtp_DataNascimento)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(360, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 685)
        Me.Panel3.TabIndex = 3
        '
        'Lbl_ErroEmail
        '
        Me.Lbl_ErroEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ErroEmail.ForeColor = System.Drawing.Color.White
        Me.Lbl_ErroEmail.Location = New System.Drawing.Point(145, 265)
        Me.Lbl_ErroEmail.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_ErroEmail.Name = "Lbl_ErroEmail"
        Me.Lbl_ErroEmail.Size = New System.Drawing.Size(782, 27)
        Me.Lbl_ErroEmail.TabIndex = 27
        Me.Lbl_ErroEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_ErroNumero
        '
        Me.Lbl_ErroNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ErroNumero.ForeColor = System.Drawing.Color.White
        Me.Lbl_ErroNumero.Location = New System.Drawing.Point(354, 36)
        Me.Lbl_ErroNumero.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_ErroNumero.Name = "Lbl_ErroNumero"
        Me.Lbl_ErroNumero.Size = New System.Drawing.Size(570, 27)
        Me.Lbl_ErroNumero.TabIndex = 8
        Me.Lbl_ErroNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tb_Email
        '
        Me.Tb_Email.BackColor = System.Drawing.Color.White
        Me.Tb_Email.Location = New System.Drawing.Point(148, 236)
        Me.Tb_Email.MaxLength = 256
        Me.Tb_Email.Name = "Tb_Email"
        Me.Tb_Email.ReadOnly = True
        Me.Tb_Email.Size = New System.Drawing.Size(779, 23)
        Me.Tb_Email.TabIndex = 26
        '
        'Tb_Contacto
        '
        Me.Tb_Contacto.BackColor = System.Drawing.Color.White
        Me.Tb_Contacto.Location = New System.Drawing.Point(148, 203)
        Me.Tb_Contacto.MaxLength = 9
        Me.Tb_Contacto.Name = "Tb_Contacto"
        Me.Tb_Contacto.ReadOnly = True
        Me.Tb_Contacto.Size = New System.Drawing.Size(200, 23)
        Me.Tb_Contacto.TabIndex = 25
        '
        'Tb_CodigoPostal
        '
        Me.Tb_CodigoPostal.BackColor = System.Drawing.Color.White
        Me.Tb_CodigoPostal.Location = New System.Drawing.Point(148, 170)
        Me.Tb_CodigoPostal.MaxLength = 8
        Me.Tb_CodigoPostal.Name = "Tb_CodigoPostal"
        Me.Tb_CodigoPostal.ReadOnly = True
        Me.Tb_CodigoPostal.Size = New System.Drawing.Size(200, 23)
        Me.Tb_CodigoPostal.TabIndex = 24
        '
        'Tb_Morada
        '
        Me.Tb_Morada.BackColor = System.Drawing.Color.White
        Me.Tb_Morada.Location = New System.Drawing.Point(148, 137)
        Me.Tb_Morada.MaxLength = 60
        Me.Tb_Morada.Name = "Tb_Morada"
        Me.Tb_Morada.ReadOnly = True
        Me.Tb_Morada.Size = New System.Drawing.Size(779, 23)
        Me.Tb_Morada.TabIndex = 23
        '
        'Tb_Cidade
        '
        Me.Tb_Cidade.BackColor = System.Drawing.Color.White
        Me.Tb_Cidade.Location = New System.Drawing.Point(148, 104)
        Me.Tb_Cidade.MaxLength = 40
        Me.Tb_Cidade.Name = "Tb_Cidade"
        Me.Tb_Cidade.ReadOnly = True
        Me.Tb_Cidade.Size = New System.Drawing.Size(336, 23)
        Me.Tb_Cidade.TabIndex = 22
        '
        'Tb_NumeroUtente
        '
        Me.Tb_NumeroUtente.BackColor = System.Drawing.Color.White
        Me.Tb_NumeroUtente.Location = New System.Drawing.Point(148, 38)
        Me.Tb_NumeroUtente.MaxLength = 9
        Me.Tb_NumeroUtente.Name = "Tb_NumeroUtente"
        Me.Tb_NumeroUtente.ReadOnly = True
        Me.Tb_NumeroUtente.Size = New System.Drawing.Size(200, 23)
        Me.Tb_NumeroUtente.TabIndex = 21
        '
        'Tb_NomeUtente
        '
        Me.Tb_NomeUtente.BackColor = System.Drawing.Color.White
        Me.Tb_NomeUtente.Location = New System.Drawing.Point(148, 5)
        Me.Tb_NomeUtente.MaxLength = 60
        Me.Tb_NomeUtente.Name = "Tb_NomeUtente"
        Me.Tb_NomeUtente.ReadOnly = True
        Me.Tb_NomeUtente.Size = New System.Drawing.Size(779, 23)
        Me.Tb_NomeUtente.TabIndex = 20
        '
        'Dtp_DataNascimento
        '
        Me.Dtp_DataNascimento.CustomFormat = "dd-MM-yyyy"
        Me.Dtp_DataNascimento.Enabled = False
        Me.Dtp_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_DataNascimento.Location = New System.Drawing.Point(148, 69)
        Me.Dtp_DataNascimento.Name = "Dtp_DataNascimento"
        Me.Dtp_DataNascimento.Size = New System.Drawing.Size(200, 23)
        Me.Dtp_DataNascimento.TabIndex = 19
        Me.Dtp_DataNascimento.Value = New Date(2019, 3, 12, 12, 2, 35, 0)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Cancel)
        Me.Panel4.Controls.Add(Me.Lbl_SaveMethod)
        Me.Panel4.Controls.Add(Me.Btn_EditarUtente)
        Me.Panel4.Controls.Add(Me.Btn_AdicionarUtente)
        Me.Panel4.Controls.Add(Me.Btn_Guardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 625)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 60)
        Me.Panel4.TabIndex = 0
        '
        'Lbl_SaveMethod
        '
        Me.Lbl_SaveMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SaveMethod.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SaveMethod.ForeColor = System.Drawing.Color.White
        Me.Lbl_SaveMethod.Location = New System.Drawing.Point(342, 0)
        Me.Lbl_SaveMethod.Name = "Lbl_SaveMethod"
        Me.Lbl_SaveMethod.Size = New System.Drawing.Size(522, 60)
        Me.Lbl_SaveMethod.TabIndex = 3
        Me.Lbl_SaveMethod.Text = "Sem Metodo Definido"
        Me.Lbl_SaveMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.cancelgray
        Me.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancel.Enabled = False
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancel.Location = New System.Drawing.Point(276, 0)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_EditarUtente
        '
        Me.Btn_EditarUtente.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarUtente.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.editusergray
        Me.Btn_EditarUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditarUtente.Enabled = False
        Me.Btn_EditarUtente.FlatAppearance.BorderSize = 0
        Me.Btn_EditarUtente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarUtente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_EditarUtente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_EditarUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarUtente.ForeColor = System.Drawing.Color.White
        Me.Btn_EditarUtente.Location = New System.Drawing.Point(210, 0)
        Me.Btn_EditarUtente.Name = "Btn_EditarUtente"
        Me.Btn_EditarUtente.Size = New System.Drawing.Size(60, 60)
        Me.Btn_EditarUtente.TabIndex = 2
        Me.Btn_EditarUtente.UseVisualStyleBackColor = False
        '
        'Btn_AdicionarUtente
        '
        Me.Btn_AdicionarUtente.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarUtente.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.adduser
        Me.Btn_AdicionarUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_AdicionarUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AdicionarUtente.FlatAppearance.BorderSize = 0
        Me.Btn_AdicionarUtente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarUtente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_AdicionarUtente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_AdicionarUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AdicionarUtente.ForeColor = System.Drawing.Color.White
        Me.Btn_AdicionarUtente.Location = New System.Drawing.Point(144, 0)
        Me.Btn_AdicionarUtente.Name = "Btn_AdicionarUtente"
        Me.Btn_AdicionarUtente.Size = New System.Drawing.Size(60, 60)
        Me.Btn_AdicionarUtente.TabIndex = 1
        Me.Btn_AdicionarUtente.UseVisualStyleBackColor = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.diskettegray
        Me.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Guardar.Enabled = False
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(870, 0)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Guardar.TabIndex = 0
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(348, 35)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Utentes"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1290, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lst_Utentes As ListView
    Friend WithEvents Utente As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_AdicionarUtente As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Dtp_DataNascimento As DateTimePicker
    Friend WithEvents Tb_NomeUtente As TextBox
    Friend WithEvents Tb_NumeroUtente As TextBox
    Friend WithEvents Tb_Email As TextBox
    Friend WithEvents Tb_Contacto As TextBox
    Friend WithEvents Tb_CodigoPostal As TextBox
    Friend WithEvents Tb_Morada As TextBox
    Friend WithEvents Tb_Cidade As TextBox
    Friend WithEvents Btn_EditarUtente As Button
    Friend WithEvents UtenteSaude As ColumnHeader
    Friend WithEvents Lbl_SaveMethod As Label
    Friend WithEvents Lbl_ErroEmail As Label
    Friend WithEvents Lbl_ErroNumero As Label
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Label13 As Label
End Class
