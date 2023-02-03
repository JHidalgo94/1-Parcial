<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CalcularButton1 = New System.Windows.Forms.Button()
        Me.CalcularTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalcularButton1
        '
        Me.CalcularButton1.Location = New System.Drawing.Point(385, 196)
        Me.CalcularButton1.Name = "CalcularButton1"
        Me.CalcularButton1.Size = New System.Drawing.Size(75, 23)
        Me.CalcularButton1.TabIndex = 0
        Me.CalcularButton1.Text = "Calcular"
        Me.CalcularButton1.UseVisualStyleBackColor = True
        '
        'CalcularTextBox1
        '
        Me.CalcularTextBox1.Location = New System.Drawing.Point(373, 144)
        Me.CalcularTextBox1.Name = "CalcularTextBox1"
        Me.CalcularTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.CalcularTextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(308, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese en este cuadro el numero"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CalcularTextBox1)
        Me.Controls.Add(Me.CalcularButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcularButton1 As Button
    Friend WithEvents CalcularTextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
