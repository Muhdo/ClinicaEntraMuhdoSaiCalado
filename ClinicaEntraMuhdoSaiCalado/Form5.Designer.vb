<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.Tb_Especialidade = New System.Windows.Forms.TextBox()
        Me.Lbl_SaveMethod = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_ErroEspecialidade = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lst_Especialidades = New System.Windows.Forms.ListView()
        Me.Especialidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_ApagarEspecialidade = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_EditarEspecialidade = New System.Windows.Forms.Button()
        Me.Btn_AdicionarEspecialidade = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Erro = New System.Windows.Forms.Label()
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
        Me.Label13.Text = "Especialidade"
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
        'Tb_Especialidade
        '
        Me.Tb_Especialidade.BackColor = System.Drawing.Color.White
        Me.Tb_Especialidade.Location = New System.Drawing.Point(148, 7)
        Me.Tb_Especialidade.MaxLength = 50
        Me.Tb_Especialidade.Name = "Tb_Especialidade"
        Me.Tb_Especialidade.ReadOnly = True
        Me.Tb_Especialidade.Size = New System.Drawing.Size(200, 23)
        Me.Tb_Especialidade.TabIndex = 24
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
        Me.Panel3.Controls.Add(Me.Lbl_Erro)
        Me.Panel3.Controls.Add(Me.Lbl_ErroEspecialidade)
        Me.Panel3.Controls.Add(Me.Tb_Especialidade)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(360, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 685)
        Me.Panel3.TabIndex = 5
        '
        'Lbl_ErroEspecialidade
        '
        Me.Lbl_ErroEspecialidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ErroEspecialidade.ForeColor = System.Drawing.Color.White
        Me.Lbl_ErroEspecialidade.Location = New System.Drawing.Point(354, 5)
        Me.Lbl_ErroEspecialidade.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_ErroEspecialidade.Name = "Lbl_ErroEspecialidade"
        Me.Lbl_ErroEspecialidade.Size = New System.Drawing.Size(573, 27)
        Me.Lbl_ErroEspecialidade.TabIndex = 8
        Me.Lbl_ErroEspecialidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(145, 625)
        Me.Panel5.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 5)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Especialidade:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_ApagarEspecialidade)
        Me.Panel4.Controls.Add(Me.Btn_Cancel)
        Me.Panel4.Controls.Add(Me.Lbl_SaveMethod)
        Me.Panel4.Controls.Add(Me.Btn_EditarEspecialidade)
        Me.Panel4.Controls.Add(Me.Btn_AdicionarEspecialidade)
        Me.Panel4.Controls.Add(Me.Btn_Guardar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 625)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(930, 60)
        Me.Panel4.TabIndex = 0
        '
        'Lst_Especialidades
        '
        Me.Lst_Especialidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Lst_Especialidades.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Especialidade})
        Me.Lst_Especialidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_Especialidades.ForeColor = System.Drawing.Color.White
        Me.Lst_Especialidades.FullRowSelect = True
        Me.Lst_Especialidades.Location = New System.Drawing.Point(0, 0)
        Me.Lst_Especialidades.MultiSelect = False
        Me.Lst_Especialidades.Name = "Lst_Especialidades"
        Me.Lst_Especialidades.Size = New System.Drawing.Size(360, 685)
        Me.Lst_Especialidades.TabIndex = 2
        Me.Lst_Especialidades.UseCompatibleStateImageBehavior = False
        Me.Lst_Especialidades.View = System.Windows.Forms.View.Details
        '
        'Especialidade
        '
        Me.Especialidade.Text = "Especialidade"
        Me.Especialidade.Width = 356
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lst_Especialidades)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 685)
        Me.Panel2.TabIndex = 4
        '
        'Btn_ApagarEspecialidade
        '
        Me.Btn_ApagarEspecialidade.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ApagarEspecialidade.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.deletegray
        Me.Btn_ApagarEspecialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_ApagarEspecialidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ApagarEspecialidade.Enabled = False
        Me.Btn_ApagarEspecialidade.FlatAppearance.BorderSize = 0
        Me.Btn_ApagarEspecialidade.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_ApagarEspecialidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_ApagarEspecialidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_ApagarEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ApagarEspecialidade.ForeColor = System.Drawing.Color.White
        Me.Btn_ApagarEspecialidade.Location = New System.Drawing.Point(276, 0)
        Me.Btn_ApagarEspecialidade.Name = "Btn_ApagarEspecialidade"
        Me.Btn_ApagarEspecialidade.Size = New System.Drawing.Size(60, 60)
        Me.Btn_ApagarEspecialidade.TabIndex = 5
        Me.Btn_ApagarEspecialidade.UseVisualStyleBackColor = False
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
        'Btn_EditarEspecialidade
        '
        Me.Btn_EditarEspecialidade.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarEspecialidade.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.editgray
        Me.Btn_EditarEspecialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EditarEspecialidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditarEspecialidade.Enabled = False
        Me.Btn_EditarEspecialidade.FlatAppearance.BorderSize = 0
        Me.Btn_EditarEspecialidade.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_EditarEspecialidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_EditarEspecialidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_EditarEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EditarEspecialidade.ForeColor = System.Drawing.Color.White
        Me.Btn_EditarEspecialidade.Location = New System.Drawing.Point(210, 0)
        Me.Btn_EditarEspecialidade.Name = "Btn_EditarEspecialidade"
        Me.Btn_EditarEspecialidade.Size = New System.Drawing.Size(60, 60)
        Me.Btn_EditarEspecialidade.TabIndex = 2
        Me.Btn_EditarEspecialidade.UseVisualStyleBackColor = False
        '
        'Btn_AdicionarEspecialidade
        '
        Me.Btn_AdicionarEspecialidade.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarEspecialidade.BackgroundImage = Global.ClinicaEntraMuhdoSaiCalado.My.Resources.Resources.add
        Me.Btn_AdicionarEspecialidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_AdicionarEspecialidade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AdicionarEspecialidade.FlatAppearance.BorderSize = 0
        Me.Btn_AdicionarEspecialidade.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_AdicionarEspecialidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_AdicionarEspecialidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_AdicionarEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AdicionarEspecialidade.ForeColor = System.Drawing.Color.White
        Me.Btn_AdicionarEspecialidade.Location = New System.Drawing.Point(144, 0)
        Me.Btn_AdicionarEspecialidade.Name = "Btn_AdicionarEspecialidade"
        Me.Btn_AdicionarEspecialidade.Size = New System.Drawing.Size(60, 60)
        Me.Btn_AdicionarEspecialidade.TabIndex = 1
        Me.Btn_AdicionarEspecialidade.UseVisualStyleBackColor = False
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
        'Lbl_Erro
        '
        Me.Lbl_Erro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Erro.ForeColor = System.Drawing.Color.White
        Me.Lbl_Erro.Location = New System.Drawing.Point(151, 559)
        Me.Lbl_Erro.Margin = New System.Windows.Forms.Padding(3)
        Me.Lbl_Erro.Name = "Lbl_Erro"
        Me.Lbl_Erro.Size = New System.Drawing.Size(330, 63)
        Me.Lbl_Erro.TabIndex = 25
        Me.Lbl_Erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form5
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
        Me.Name = "Form5"
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
    Friend WithEvents Tb_Especialidade As TextBox
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Lbl_SaveMethod As Label
    Friend WithEvents Btn_EditarEspecialidade As Button
    Friend WithEvents Btn_AdicionarEspecialidade As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_ErroEspecialidade As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lst_Especialidades As ListView
    Friend WithEvents Especialidade As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Btn_ApagarEspecialidade As Button
    Friend WithEvents Lbl_Erro As Label
End Class
