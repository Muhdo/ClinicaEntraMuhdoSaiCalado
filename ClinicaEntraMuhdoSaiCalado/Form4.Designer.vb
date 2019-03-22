<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_CartaoCidadao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Cidade = New System.Windows.Forms.TextBox()
        Me.Dtp_DataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.Tb_Morada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Email = New System.Windows.Forms.TextBox()
        Me.Tb_Contacto = New System.Windows.Forms.TextBox()
        Me.Lbl_SaveMethod = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cb_Especialidade = New System.Windows.Forms.ComboBox()
        Me.Lbl_ErroEmail = New System.Windows.Forms.Label()
        Me.Lbl_ErroNumero = New System.Windows.Forms.Label()
        Me.Tb_NomeMedico = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Especialidade = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_EditarMedico = New System.Windows.Forms.Button()
        Me.Btn_AdicionarMedico = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lst_Medicos = New System.Windows.Forms.ListView()
        Me.Medico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Especialidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Red
        Me.Btn_Close.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Close.FlatAppearance.BorderSize = 0
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
        'Tb_CartaoCidadao
        '
        Me.Tb_CartaoCidadao.BackColor = System.Drawing.Color.White
        Me.Tb_CartaoCidadao.Location = New System.Drawing.Point(148, 38)
        Me.Tb_CartaoCidadao.MaxLength = 8
        Me.Tb_CartaoCidadao.Name = "Tb_CartaoCidadao"
        Me.Tb_CartaoCidadao.ReadOnly = True
        Me.Tb_CartaoCidadao.Size = New System.Drawing.Size(200, 23)
        Me.Tb_CartaoCidadao.TabIndex = 21
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cartão Cidadão:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome Médico:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Lbl_SaveMethod
        '
        Me.Lbl_SaveMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SaveMethod.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SaveMethod.ForeColor = System.Drawing.Color.White
        Me.Lbl_SaveMethod.Location = New System.Drawing.Point(464, 0)
        Me.Lbl_SaveMethod.Name = "Lbl_SaveMethod"
        Me.Lbl_SaveMethod.Size = New System.Drawing.Size(400, 60)
        Me.Lbl_SaveMethod.TabIndex = 3
        Me.Lbl_SaveMethod.Text = "Sem Metodo Definido"
        Me.Lbl_SaveMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Cb_Especialidade)
        Me.Panel3.Controls.Add(Me.Lbl_ErroEmail)
        Me.Panel3.Controls.Add(Me.Lbl_ErroNumero)
        Me.Panel3.Controls.Add(Me.Tb_Email)
        Me.Panel3.Controls.Add(Me.Tb_Contacto)
        Me.Panel3.Controls.Add(Me.Tb_CodigoPostal)
        Me.Panel3.Controls.Add(Me.Tb_Morada)
        Me.Panel3.Controls.Add(Me.Tb_Cidade)
        Me.Panel3.Controls.Add(Me.Tb_CartaoCidadao)
        Me.Panel3.Controls.Add(Me.Tb_NomeMedico)
        Me.Panel3.Controls.Add(Me.Dtp_DataNascimento)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(360, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 685)
        Me.Panel3.TabIndex = 5
        '
        'Cb_Especialidade
        '
        Me.Cb_Especialidade.Enabled = False
        Me.Cb_Especialidade.FormattingEnabled = True
        Me.Cb_Especialidade.Location = New System.Drawing.Point(148, 269)
        Me.Cb_Especialidade.Name = "Cb_Especialidade"
        Me.Cb_Especialidade.Size = New System.Drawing.Size(200, 24)
        Me.Cb_Especialidade.TabIndex = 28
        '
        'Lbl_ErroEmail
        '
        Me.Lbl_ErroEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ErroEmail.ForeColor = System.Drawing.Color.White
        Me.Lbl_ErroEmail.Location = New System.Drawing.Point(354, 203)
        Me.Lbl_ErroEmail.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_ErroEmail.Name = "Lbl_ErroEmail"
        Me.Lbl_ErroEmail.Size = New System.Drawing.Size(573, 27)
        Me.Lbl_ErroEmail.TabIndex = 27
        Me.Lbl_ErroEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Tb_NomeMedico
        '
        Me.Tb_NomeMedico.BackColor = System.Drawing.Color.White
        Me.Tb_NomeMedico.Location = New System.Drawing.Point(148, 5)
        Me.Tb_NomeMedico.MaxLength = 60
        Me.Tb_NomeMedico.Name = "Tb_NomeMedico"
        Me.Tb_NomeMedico.ReadOnly = True
        Me.Tb_NomeMedico.Size = New System.Drawing.Size(779, 23)
        Me.Tb_NomeMedico.TabIndex = 20
        '
        'Panel5
        '
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Especialidade)
        Me.Panel4.Controls.Add(Me.Btn_Cancel)
        Me.Panel4.Controls.Add(Me.Lbl_SaveMethod)
        Me.Panel4.Controls.Add(Me.Btn_EditarMedico)
        Me.Panel4.Controls.Add(Me.Btn_AdicionarMedico)
        Me.Panel4.Controls.Add(Me.Btn_Guardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 625)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 60)
        Me.Panel4.TabIndex = 0
        '
        'Btn_Especialidade
        '
        Me.Btn_Especialidade.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Especialidade.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.area
        Me.Btn_Especialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Especialidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Especialidade.FlatAppearance.BorderSize = 0
        Me.Btn_Especialidade.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Especialidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Especialidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Especialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Especialidade.ForeColor = System.Drawing.Color.White
        Me.Btn_Especialidade.Location = New System.Drawing.Point(276, 0)
        Me.Btn_Especialidade.Name = "Btn_Especialidade"
        Me.Btn_Especialidade.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Especialidade.TabIndex = 5
        Me.Btn_Especialidade.UseVisualStyleBackColor = False
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
        Me.Btn_Cancel.Location = New System.Drawing.Point(342, 0)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_EditarMedico
        '
        Me.Btn_EditarMedico.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarMedico.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.editusergray
        Me.Btn_EditarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditarMedico.Enabled = False
        Me.Btn_EditarMedico.FlatAppearance.BorderSize = 0
        Me.Btn_EditarMedico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarMedico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_EditarMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_EditarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarMedico.ForeColor = System.Drawing.Color.White
        Me.Btn_EditarMedico.Location = New System.Drawing.Point(210, 0)
        Me.Btn_EditarMedico.Name = "Btn_EditarMedico"
        Me.Btn_EditarMedico.Size = New System.Drawing.Size(60, 60)
        Me.Btn_EditarMedico.TabIndex = 2
        Me.Btn_EditarMedico.UseVisualStyleBackColor = False
        '
        'Btn_AdicionarMedico
        '
        Me.Btn_AdicionarMedico.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarMedico.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.adduser
        Me.Btn_AdicionarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_AdicionarMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AdicionarMedico.FlatAppearance.BorderSize = 0
        Me.Btn_AdicionarMedico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarMedico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_AdicionarMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_AdicionarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AdicionarMedico.ForeColor = System.Drawing.Color.White
        Me.Btn_AdicionarMedico.Location = New System.Drawing.Point(144, 0)
        Me.Btn_AdicionarMedico.Name = "Btn_AdicionarMedico"
        Me.Btn_AdicionarMedico.Size = New System.Drawing.Size(60, 60)
        Me.Btn_AdicionarMedico.TabIndex = 1
        Me.Btn_AdicionarMedico.UseVisualStyleBackColor = False
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
        'Lst_Medicos
        '
        Me.Lst_Medicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Lst_Medicos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Medico, Me.Especialidade})
        Me.Lst_Medicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_Medicos.ForeColor = System.Drawing.Color.White
        Me.Lst_Medicos.FullRowSelect = True
        Me.Lst_Medicos.Location = New System.Drawing.Point(0, 0)
        Me.Lst_Medicos.MultiSelect = False
        Me.Lst_Medicos.Name = "Lst_Medicos"
        Me.Lst_Medicos.Size = New System.Drawing.Size(360, 685)
        Me.Lst_Medicos.TabIndex = 2
        Me.Lst_Medicos.UseCompatibleStateImageBehavior = False
        Me.Lst_Medicos.View = System.Windows.Forms.View.Details
        '
        'Medico
        '
        Me.Medico.Text = "Médico"
        Me.Medico.Width = 243
        '
        'Especialidade
        '
        Me.Especialidade.Text = "Especialidade"
        Me.Especialidade.Width = 113
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lst_Medicos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 685)
        Me.Panel2.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(348, 35)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Médicos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form4
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_CartaoCidadao As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Cidade As TextBox
    Friend WithEvents Dtp_DataNascimento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_CodigoPostal As TextBox
    Friend WithEvents Tb_Morada As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_Email As TextBox
    Friend WithEvents Tb_Contacto As TextBox
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Lbl_SaveMethod As Label
    Friend WithEvents Btn_EditarMedico As Button
    Friend WithEvents Btn_AdicionarMedico As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_ErroEmail As Label
    Friend WithEvents Lbl_ErroNumero As Label
    Friend WithEvents Tb_NomeMedico As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lst_Medicos As ListView
    Friend WithEvents Medico As ColumnHeader
    Friend WithEvents Especialidade As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Cb_Especialidade As ComboBox
    Friend WithEvents Btn_Especialidade As Button
    Friend WithEvents Label13 As Label
End Class
