<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGuardarWord = New System.Windows.Forms.Button()
        Me.BtnGuardarExcel = New System.Windows.Forms.Button()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardarWord
        '
        Me.btnGuardarWord.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarWord.BackgroundImage = CType(resources.GetObject("btnGuardarWord.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardarWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarWord.Location = New System.Drawing.Point(12, 106)
        Me.btnGuardarWord.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnGuardarWord.Name = "btnGuardarWord"
        Me.btnGuardarWord.Size = New System.Drawing.Size(95, 63)
        Me.btnGuardarWord.TabIndex = 0
        Me.btnGuardarWord.UseVisualStyleBackColor = False
        '
        'BtnGuardarExcel
        '
        Me.BtnGuardarExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardarExcel.BackgroundImage = CType(resources.GetObject("BtnGuardarExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardarExcel.Location = New System.Drawing.Point(127, 106)
        Me.BtnGuardarExcel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnGuardarExcel.Name = "BtnGuardarExcel"
        Me.BtnGuardarExcel.Size = New System.Drawing.Size(88, 63)
        Me.BtnGuardarExcel.TabIndex = 1
        Me.BtnGuardarExcel.UseVisualStyleBackColor = False
        '
        'TxtTexto
        '
        Me.TxtTexto.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTexto.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTexto.Location = New System.Drawing.Point(44, 54)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(140, 32)
        Me.TxtTexto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresa tu texto:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(228, 187)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTexto)
        Me.Controls.Add(Me.BtnGuardarExcel)
        Me.Controls.Add(Me.btnGuardarWord)
        Me.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "InteropTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarWord As Button
    Friend WithEvents BtnGuardarExcel As Button
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents Label1 As Label
End Class
