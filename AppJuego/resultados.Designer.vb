<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultados
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cuadro = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.cuadro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cuadro
        '
        ChartArea1.Name = "ChartArea1"
        Me.cuadro.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.cuadro.Legends.Add(Legend1)
        Me.cuadro.Location = New System.Drawing.Point(12, 0)
        Me.cuadro.Name = "cuadro"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "3R"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Trivia"
        Me.cuadro.Series.Add(Series1)
        Me.cuadro.Series.Add(Series2)
        Me.cuadro.Size = New System.Drawing.Size(776, 438)
        Me.cuadro.TabIndex = 0
        Me.cuadro.Text = "Puntaje"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(600, 398)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(188, 40)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Inicio"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cuadro)
        Me.Name = "resultados"
        Me.Text = "Form1"
        CType(Me.cuadro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cuadro As DataVisualization.Charting.Chart
    Private WithEvents btnAceptar As Button
End Class
