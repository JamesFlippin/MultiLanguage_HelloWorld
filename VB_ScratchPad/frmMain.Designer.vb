<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblSayName = New System.Windows.Forms.Label()
        Me.lblSayHello = New System.Windows.Forms.Label()
        Me.btnGoodbye = New System.Windows.Forms.Button()
        Me.btnSayHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSayName
        '
        Me.lblSayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSayName.Location = New System.Drawing.Point(43, 171)
        Me.lblSayName.Name = "lblSayName"
        Me.lblSayName.Size = New System.Drawing.Size(322, 32)
        Me.lblSayName.TabIndex = 5
        Me.lblSayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSayHello
        '
        Me.lblSayHello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSayHello.Location = New System.Drawing.Point(43, 116)
        Me.lblSayHello.Name = "lblSayHello"
        Me.lblSayHello.Size = New System.Drawing.Size(322, 32)
        Me.lblSayHello.TabIndex = 6
        Me.lblSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoodbye
        '
        Me.btnGoodbye.Location = New System.Drawing.Point(135, 232)
        Me.btnGoodbye.Name = "btnGoodbye"
        Me.btnGoodbye.Size = New System.Drawing.Size(139, 38)
        Me.btnGoodbye.TabIndex = 3
        Me.btnGoodbye.Text = "&Goodbye"
        Me.btnGoodbye.UseVisualStyleBackColor = True
        '
        'btnSayHello
        '
        Me.btnSayHello.Location = New System.Drawing.Point(135, 53)
        Me.btnSayHello.Name = "btnSayHello"
        Me.btnSayHello.Size = New System.Drawing.Size(139, 38)
        Me.btnSayHello.TabIndex = 4
        Me.btnSayHello.Text = "&Hello!"
        Me.btnSayHello.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 323)
        Me.Controls.Add(Me.lblSayName)
        Me.Controls.Add(Me.lblSayHello)
        Me.Controls.Add(Me.btnGoodbye)
        Me.Controls.Add(Me.btnSayHello)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB: Hello World"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblSayName As Label
    Private WithEvents lblSayHello As Label
    Private WithEvents btnGoodbye As Button
    Private WithEvents btnSayHello As Button
End Class
