<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trivia
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPreguntas = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.opcbox = New System.Windows.Forms.ComboBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.groupBox1.Controls.Add(Me.opcbox)
        Me.groupBox1.Controls.Add(Me.lblPreguntas)
        Me.groupBox1.Controls.Add(Me.btnNext)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(751, 560)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Trivia"
        '
        'lblPreguntas
        '
        Me.lblPreguntas.AutoSize = True
        Me.lblPreguntas.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntas.Location = New System.Drawing.Point(6, 35)
        Me.lblPreguntas.Name = "lblPreguntas"
        Me.lblPreguntas.Size = New System.Drawing.Size(181, 36)
        Me.lblPreguntas.TabIndex = 0
        Me.lblPreguntas.Text = "Pregunta....."
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(478, 82)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(188, 40)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Siguiente"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'opcbox
        '
        Me.opcbox.FormattingEnabled = True
        Me.opcbox.Items.AddRange(New Object() {"a", "b", "c"})
        Me.opcbox.Location = New System.Drawing.Point(36, 82)
        Me.opcbox.Name = "opcbox"
        Me.opcbox.Size = New System.Drawing.Size(364, 32)
        Me.opcbox.TabIndex = 5
        '
        'trivia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 584)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "trivia"
        Me.Text = "trivia"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblPreguntas As Label
    Private WithEvents btnNext As Button
    Friend WithEvents opcbox As ComboBox
End Class
