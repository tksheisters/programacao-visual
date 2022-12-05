<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TituloJogo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.BtnJogar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.ImagemResultado = New System.Windows.Forms.PictureBox()
        Me.TotalPontos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ImagemResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloJogo
        '
        Me.TituloJogo.AutoSize = True
        Me.TituloJogo.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloJogo.ForeColor = System.Drawing.Color.IndianRed
        Me.TituloJogo.Location = New System.Drawing.Point(261, 40)
        Me.TituloJogo.Name = "TituloJogo"
        Me.TituloJogo.Size = New System.Drawing.Size(209, 32)
        Me.TituloJogo.TabIndex = 0
        Me.TituloJogo.Text = "Jogo da sorte"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Num1)
        Me.Panel1.Location = New System.Drawing.Point(151, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Num2)
        Me.Panel2.Location = New System.Drawing.Point(303, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Num3)
        Me.Panel3.Location = New System.Drawing.Point(459, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 3
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Num1.Location = New System.Drawing.Point(28, 25)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(42, 47)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Num2.Location = New System.Drawing.Point(29, 25)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(42, 47)
        Me.Num2.TabIndex = 0
        Me.Num2.Text = "0"
        '
        'Num3
        '
        Me.Num3.AutoSize = True
        Me.Num3.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.ForeColor = System.Drawing.Color.LimeGreen
        Me.Num3.Location = New System.Drawing.Point(28, 25)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(42, 47)
        Me.Num3.TabIndex = 0
        Me.Num3.Text = "0"
        '
        'BtnJogar
        '
        Me.BtnJogar.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogar.Location = New System.Drawing.Point(55, 267)
        Me.BtnJogar.Name = "BtnJogar"
        Me.BtnJogar.Size = New System.Drawing.Size(75, 37)
        Me.BtnJogar.TabIndex = 4
        Me.BtnJogar.Text = "Jogar"
        Me.BtnJogar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.Font = New System.Drawing.Font("Consolas", 15.0!)
        Me.BtnFechar.Location = New System.Drawing.Point(590, 267)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(92, 37)
        Me.BtnFechar.TabIndex = 5
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'ImagemResultado
        '
        Me.ImagemResultado.Location = New System.Drawing.Point(151, 224)
        Me.ImagemResultado.Name = "ImagemResultado"
        Me.ImagemResultado.Size = New System.Drawing.Size(408, 113)
        Me.ImagemResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagemResultado.TabIndex = 6
        Me.ImagemResultado.TabStop = False
        '
        'TotalPontos
        '
        Me.TotalPontos.AutoSize = True
        Me.TotalPontos.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TotalPontos.Location = New System.Drawing.Point(642, 59)
        Me.TotalPontos.Name = "TotalPontos"
        Me.TotalPontos.Size = New System.Drawing.Size(18, 19)
        Me.TotalPontos.TabIndex = 7
        Me.TotalPontos.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(560, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pontos:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotalPontos)
        Me.Controls.Add(Me.ImagemResultado)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnJogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TituloJogo)
        Me.Name = "Form1"
        Me.Text = "Jogo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ImagemResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TituloJogo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Num3 As Label
    Friend WithEvents BtnJogar As Button
    Friend WithEvents BtnFechar As Button
    Friend WithEvents ImagemResultado As PictureBox
    Friend WithEvents TotalPontos As Label
    Friend WithEvents Label2 As Label
End Class
