<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtApodoL = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtContraL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.boxJuego = New System.Windows.Forms.GroupBox()
        Me.btnJuego1 = New System.Windows.Forms.Button()
        Me.btnJuego2 = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.boxJuego.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.BackColor = System.Drawing.Color.Lime
        Me.lblConexion.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.Location = New System.Drawing.Point(654, 9)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(99, 25)
        Me.lblConexion.TabIndex = 8
        Me.lblConexion.Text = "Conexion"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.groupBox2.Controls.Add(Me.txtFecha)
        Me.groupBox2.Controls.Add(Me.Label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.txtApodo)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.txtNombre)
        Me.groupBox2.Controls.Add(Me.btnCrear)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.txtContra)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(481, 50)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(414, 503)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Crear Jugador"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(29, 131)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(107, 36)
        Me.label5.TabIndex = 6
        Me.label5.Text = "Apodo"
        '
        'txtApodo
        '
        Me.txtApodo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApodo.Location = New System.Drawing.Point(70, 179)
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(261, 29)
        Me.txtApodo.TabIndex = 7
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(29, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(128, 36)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(69, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 29)
        Me.txtNombre.TabIndex = 1
        '
        'btnCrear
        '
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Location = New System.Drawing.Point(126, 430)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(146, 48)
        Me.btnCrear.TabIndex = 5
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(29, 332)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(170, 36)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Contraseña"
        '
        'txtContra
        '
        Me.txtContra.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.Location = New System.Drawing.Point(70, 386)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(261, 29)
        Me.txtContra.TabIndex = 3
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtApodoL)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txtContraL)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(47, 50)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(332, 342)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Login"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(64, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(107, 36)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Apodo"
        '
        'txtApodoL
        '
        Me.txtApodoL.Cursor = System.Windows.Forms.Cursors.No
        Me.txtApodoL.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApodoL.Location = New System.Drawing.Point(70, 86)
        Me.txtApodoL.Name = "txtApodoL"
        Me.txtApodoL.Size = New System.Drawing.Size(202, 29)
        Me.txtApodoL.TabIndex = 1
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(97, 224)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(146, 48)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Acceder"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(64, 131)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(170, 36)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Contraseña"
        '
        'txtContraL
        '
        Me.txtContraL.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraL.Location = New System.Drawing.Point(70, 179)
        Me.txtContraL.Name = "txtContraL"
        Me.txtContraL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraL.Size = New System.Drawing.Size(202, 29)
        Me.txtContraL.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 36)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(70, 287)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(261, 29)
        Me.txtFecha.TabIndex = 9
        '
        'boxJuego
        '
        Me.boxJuego.BackColor = System.Drawing.Color.Green
        Me.boxJuego.Controls.Add(Me.btnJuego2)
        Me.boxJuego.Controls.Add(Me.btnJuego1)
        Me.boxJuego.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxJuego.Location = New System.Drawing.Point(47, 415)
        Me.boxJuego.Name = "boxJuego"
        Me.boxJuego.Size = New System.Drawing.Size(414, 138)
        Me.boxJuego.TabIndex = 11
        Me.boxJuego.TabStop = False
        Me.boxJuego.Text = "Seleccione Juego"
        Me.boxJuego.Visible = False
        '
        'btnJuego1
        '
        Me.btnJuego1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuego1.Location = New System.Drawing.Point(25, 49)
        Me.btnJuego1.Name = "btnJuego1"
        Me.btnJuego1.Size = New System.Drawing.Size(146, 48)
        Me.btnJuego1.TabIndex = 4
        Me.btnJuego1.Text = "Juego 1"
        Me.btnJuego1.UseVisualStyleBackColor = True
        '
        'btnJuego2
        '
        Me.btnJuego2.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuego2.Location = New System.Drawing.Point(225, 49)
        Me.btnJuego2.Name = "btnJuego2"
        Me.btnJuego2.Size = New System.Drawing.Size(146, 48)
        Me.btnJuego2.TabIndex = 5
        Me.btnJuego2.Text = "Juego 2"
        Me.btnJuego2.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 585)
        Me.Controls.Add(Me.boxJuego)
        Me.Controls.Add(Me.lblConexion)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "inicio"
        Me.Text = "Form1"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.boxJuego.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblConexion As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label5 As Label
    Private WithEvents txtApodo As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtNombre As TextBox
    Private WithEvents btnCrear As Button
    Private WithEvents label4 As Label
    Private WithEvents txtContra As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents txtApodoL As TextBox
    Private WithEvents button1 As Button
    Private WithEvents label2 As Label
    Private WithEvents txtContraL As TextBox
    Friend WithEvents txtFecha As DateTimePicker
    Private WithEvents Label6 As Label
    Private WithEvents boxJuego As GroupBox
    Private WithEvents btnJuego2 As Button
    Private WithEvents btnJuego1 As Button
End Class
