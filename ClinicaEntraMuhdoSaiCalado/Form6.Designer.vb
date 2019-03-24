<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.Tb_Preco = New System.Windows.Forms.TextBox()
        Me.Dtp_DataConsulta = New System.Windows.Forms.DateTimePicker()
        Me.Tb_Detalhes = New System.Windows.Forms.TextBox()
        Me.Lbl_SaveMethod = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cb_NomeMedico = New System.Windows.Forms.ComboBox()
        Me.Cb_UtenteSaude = New System.Windows.Forms.ComboBox()
        Me.Cb_NomeUtente = New System.Windows.Forms.ComboBox()
        Me.Cb_Especialidade = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_ProcurarConsulta = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_EditarConsulta = New System.Windows.Forms.Button()
        Me.Btn_AdicionarConsulta = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lst_Consultas = New System.Windows.Forms.ListView()
        Me.Utente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Medico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(348, 35)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Consultas"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Tb_Preco
        '
        Me.Tb_Preco.BackColor = System.Drawing.Color.White
        Me.Tb_Preco.Location = New System.Drawing.Point(148, 432)
        Me.Tb_Preco.MaxLength = 9
        Me.Tb_Preco.Name = "Tb_Preco"
        Me.Tb_Preco.ReadOnly = True
        Me.Tb_Preco.Size = New System.Drawing.Size(122, 23)
        Me.Tb_Preco.TabIndex = 22
        '
        'Dtp_DataConsulta
        '
        Me.Dtp_DataConsulta.CustomFormat = "dd-MM-yyyy HH:mm"
        Me.Dtp_DataConsulta.Enabled = False
        Me.Dtp_DataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_DataConsulta.Location = New System.Drawing.Point(148, 135)
        Me.Dtp_DataConsulta.Name = "Dtp_DataConsulta"
        Me.Dtp_DataConsulta.Size = New System.Drawing.Size(200, 23)
        Me.Dtp_DataConsulta.TabIndex = 19
        Me.Dtp_DataConsulta.Value = New Date(2019, 3, 12, 12, 2, 35, 0)
        '
        'Tb_Detalhes
        '
        Me.Tb_Detalhes.BackColor = System.Drawing.Color.White
        Me.Tb_Detalhes.Location = New System.Drawing.Point(148, 168)
        Me.Tb_Detalhes.MaxLength = 8000
        Me.Tb_Detalhes.Multiline = True
        Me.Tb_Detalhes.Name = "Tb_Detalhes"
        Me.Tb_Detalhes.ReadOnly = True
        Me.Tb_Detalhes.Size = New System.Drawing.Size(779, 256)
        Me.Tb_Detalhes.TabIndex = 26
        Me.Tb_Detalhes.WordWrap = False
        '
        'Lbl_SaveMethod
        '
        Me.Lbl_SaveMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_SaveMethod.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SaveMethod.ForeColor = System.Drawing.Color.White
        Me.Lbl_SaveMethod.Location = New System.Drawing.Point(408, 0)
        Me.Lbl_SaveMethod.Name = "Lbl_SaveMethod"
        Me.Lbl_SaveMethod.Size = New System.Drawing.Size(456, 60)
        Me.Lbl_SaveMethod.TabIndex = 3
        Me.Lbl_SaveMethod.Text = "Sem Metodo Definido"
        Me.Lbl_SaveMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Cb_NomeMedico)
        Me.Panel3.Controls.Add(Me.Cb_UtenteSaude)
        Me.Panel3.Controls.Add(Me.Cb_NomeUtente)
        Me.Panel3.Controls.Add(Me.Cb_Especialidade)
        Me.Panel3.Controls.Add(Me.Tb_Detalhes)
        Me.Panel3.Controls.Add(Me.Tb_Preco)
        Me.Panel3.Controls.Add(Me.Dtp_DataConsulta)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(360, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 685)
        Me.Panel3.TabIndex = 5
        '
        'Cb_NomeMedico
        '
        Me.Cb_NomeMedico.Enabled = False
        Me.Cb_NomeMedico.FormattingEnabled = True
        Me.Cb_NomeMedico.Location = New System.Drawing.Point(148, 71)
        Me.Cb_NomeMedico.Name = "Cb_NomeMedico"
        Me.Cb_NomeMedico.Size = New System.Drawing.Size(779, 24)
        Me.Cb_NomeMedico.TabIndex = 31
        '
        'Cb_UtenteSaude
        '
        Me.Cb_UtenteSaude.Enabled = False
        Me.Cb_UtenteSaude.FormattingEnabled = True
        Me.Cb_UtenteSaude.Location = New System.Drawing.Point(148, 38)
        Me.Cb_UtenteSaude.Name = "Cb_UtenteSaude"
        Me.Cb_UtenteSaude.Size = New System.Drawing.Size(200, 24)
        Me.Cb_UtenteSaude.TabIndex = 30
        '
        'Cb_NomeUtente
        '
        Me.Cb_NomeUtente.Enabled = False
        Me.Cb_NomeUtente.FormattingEnabled = True
        Me.Cb_NomeUtente.Location = New System.Drawing.Point(148, 5)
        Me.Cb_NomeUtente.Name = "Cb_NomeUtente"
        Me.Cb_NomeUtente.Size = New System.Drawing.Size(779, 24)
        Me.Cb_NomeUtente.TabIndex = 29
        '
        'Cb_Especialidade
        '
        Me.Cb_Especialidade.Enabled = False
        Me.Cb_Especialidade.FormattingEnabled = True
        Me.Cb_Especialidade.Location = New System.Drawing.Point(148, 104)
        Me.Cb_Especialidade.Name = "Cb_Especialidade"
        Me.Cb_Especialidade.Size = New System.Drawing.Size(200, 24)
        Me.Cb_Especialidade.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label8)
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
        Me.Label12.Location = New System.Drawing.Point(3, 430)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 27)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Valor a Pagar:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 168)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 256)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Detalhes:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 135)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 27)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Data Consulta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 27)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Especialidade:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 27)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Nome Médico:"
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
        Me.Label2.TabIndex = 13
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
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nome Utente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_ProcurarConsulta)
        Me.Panel4.Controls.Add(Me.Btn_Cancel)
        Me.Panel4.Controls.Add(Me.Lbl_SaveMethod)
        Me.Panel4.Controls.Add(Me.Btn_EditarConsulta)
        Me.Panel4.Controls.Add(Me.Btn_AdicionarConsulta)
        Me.Panel4.Controls.Add(Me.Btn_Guardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 625)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 60)
        Me.Panel4.TabIndex = 0
        '
        'Btn_ProcurarConsulta
        '
        Me.Btn_ProcurarConsulta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ProcurarConsulta.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.findpaper
        Me.Btn_ProcurarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_ProcurarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ProcurarConsulta.FlatAppearance.BorderSize = 0
        Me.Btn_ProcurarConsulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_ProcurarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_ProcurarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_ProcurarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ProcurarConsulta.ForeColor = System.Drawing.Color.White
        Me.Btn_ProcurarConsulta.Location = New System.Drawing.Point(276, 0)
        Me.Btn_ProcurarConsulta.Name = "Btn_ProcurarConsulta"
        Me.Btn_ProcurarConsulta.Size = New System.Drawing.Size(60, 60)
        Me.Btn_ProcurarConsulta.TabIndex = 5
        Me.Btn_ProcurarConsulta.UseVisualStyleBackColor = False
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
        'Btn_EditarConsulta
        '
        Me.Btn_EditarConsulta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarConsulta.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.editpapergray
        Me.Btn_EditarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditarConsulta.Enabled = False
        Me.Btn_EditarConsulta.FlatAppearance.BorderSize = 0
        Me.Btn_EditarConsulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_EditarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_EditarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarConsulta.ForeColor = System.Drawing.Color.White
        Me.Btn_EditarConsulta.Location = New System.Drawing.Point(210, 0)
        Me.Btn_EditarConsulta.Name = "Btn_EditarConsulta"
        Me.Btn_EditarConsulta.Size = New System.Drawing.Size(60, 60)
        Me.Btn_EditarConsulta.TabIndex = 2
        Me.Btn_EditarConsulta.UseVisualStyleBackColor = False
        '
        'Btn_AdicionarConsulta
        '
        Me.Btn_AdicionarConsulta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarConsulta.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.addpaper
        Me.Btn_AdicionarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_AdicionarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AdicionarConsulta.FlatAppearance.BorderSize = 0
        Me.Btn_AdicionarConsulta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_AdicionarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_AdicionarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AdicionarConsulta.ForeColor = System.Drawing.Color.White
        Me.Btn_AdicionarConsulta.Location = New System.Drawing.Point(144, 0)
        Me.Btn_AdicionarConsulta.Name = "Btn_AdicionarConsulta"
        Me.Btn_AdicionarConsulta.Size = New System.Drawing.Size(60, 60)
        Me.Btn_AdicionarConsulta.TabIndex = 1
        Me.Btn_AdicionarConsulta.UseVisualStyleBackColor = False
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
        Me.Lst_Consultas.TabIndex = 2
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
        Me.Medico.Text = "Médico"
        Me.Medico.Width = 120
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.Width = 115
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lst_Consultas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 685)
        Me.Panel2.TabIndex = 4
        '
        'Form6
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
        Me.Name = "Form6"
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
    Friend WithEvents Tb_Preco As TextBox
    Friend WithEvents Dtp_DataConsulta As DateTimePicker
    Friend WithEvents Tb_Detalhes As TextBox
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Lbl_SaveMethod As Label
    Friend WithEvents Btn_EditarConsulta As Button
    Friend WithEvents Btn_AdicionarConsulta As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lst_Consultas As ListView
    Friend WithEvents Medico As ColumnHeader
    Friend WithEvents Data As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cb_Especialidade As ComboBox
    Friend WithEvents Btn_ProcurarConsulta As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_NomeMedico As ComboBox
    Friend WithEvents Cb_UtenteSaude As ComboBox
    Friend WithEvents Cb_NomeUtente As ComboBox
    Friend WithEvents Utente As ColumnHeader
End Class
