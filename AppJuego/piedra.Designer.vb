<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class piedra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSistema = New System.Windows.Forms.Button()
        Me.btnTijera = New System.Windows.Forms.Button()
        Me.btnPapel = New System.Windows.Forms.Button()
        Me.btnPiedra = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSistema
        '
        Me.btnSistema.Image = Global.AppJuego.My.Resources.Resources.load
        Me.btnSistema.Location = New System.Drawing.Point(12, 302)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Size = New System.Drawing.Size(229, 184)
        Me.btnSistema.TabIndex = 3
        Me.btnSistema.UseVisualStyleBackColor = True
        '
        'btnTijera
        '
        Me.btnTijera.Image = Global.AppJuego.My.Resources.Resources.tijera
        Me.btnTijera.Location = New System.Drawing.Point(563, 50)
        Me.btnTijera.Name = "btnTijera"
        Me.btnTijera.Size = New System.Drawing.Size(185, 175)
        Me.btnTijera.TabIndex = 2
        Me.btnTijera.UseVisualStyleBackColor = True
        '
        'btnPapel
        '
        Me.btnPapel.Image = Global.AppJuego.My.Resources.Resources.papel
        Me.btnPapel.Location = New System.Drawing.Point(304, 50)
        Me.btnPapel.Name = "btnPapel"
        Me.btnPapel.Size = New System.Drawing.Size(185, 175)
        Me.btnPapel.TabIndex = 1
        Me.btnPapel.UseVisualStyleBackColor = True
        '
        'btnPiedra
        '
        Me.btnPiedra.Image = Global.AppJuego.My.Resources.Resources.piedra
        Me.btnPiedra.Location = New System.Drawing.Point(73, 50)
        Me.btnPiedra.Name = "btnPiedra"
        Me.btnPiedra.Size = New System.Drawing.Size(185, 175)
        Me.btnPiedra.TabIndex = 0
        Me.btnPiedra.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(308, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(127, 36)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Jugador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sistema"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.groupBox1.Controls.Add(Me.lblResultado)
        Me.groupBox1.Controls.Add(Me.lblSistema)
        Me.groupBox1.Controls.Add(Me.lblJugador)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(247, 302)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(567, 184)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Resultados"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(6, 25)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(179, 36)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "Respuesta..."
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.Location = New System.Drawing.Point(389, 127)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(32, 36)
        Me.lblSistema.TabIndex = 4
        Me.lblSistema.Text = "0"
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador.Location = New System.Drawing.Point(389, 81)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(32, 36)
        Me.lblJugador.TabIndex = 3
        Me.lblJugador.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jugador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 36)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sistema"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(616, 256)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(188, 40)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        Me.btnAceptar.Visible = False
        '
        'piedra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 489)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnSistema)
        Me.Controls.Add(Me.btnTijera)
        Me.Controls.Add(Me.btnPapel)
        Me.Controls.Add(Me.btnPiedra)
        Me.Name = "piedra"
        Me.Text = "piedra"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPiedra As Button
    Friend WithEvents btnPapel As Button
    Friend WithEvents btnTijera As Button
    Friend WithEvents btnSistema As Button
    Private WithEvents label3 As Label
    Private WithEvents Label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblSistema As Label
    Private WithEvents lblJugador As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label4 As Label
    Private WithEvents lblResultado As Label
    Private WithEvents btnAceptar As Button
End Class
