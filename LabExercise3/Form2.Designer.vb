<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.AddressTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MiddlenameTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastnameTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstnameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdNumberTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.CancelBtn)
        Me.GroupBox1.Controls.Add(Me.AddBtn)
        Me.GroupBox1.Controls.Add(Me.AddressTextbox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.MiddlenameTextbox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LastnameTextbox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FirstnameTextbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IdNumberTextbox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(271, 197)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(94, 31)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(171, 197)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(94, 31)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'AddressTextbox
        '
        Me.AddressTextbox.Location = New System.Drawing.Point(123, 162)
        Me.AddressTextbox.Name = "AddressTextbox"
        Me.AddressTextbox.Size = New System.Drawing.Size(242, 29)
        Me.AddressTextbox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address"
        '
        'MiddlenameTextbox
        '
        Me.MiddlenameTextbox.Location = New System.Drawing.Point(123, 127)
        Me.MiddlenameTextbox.Name = "MiddlenameTextbox"
        Me.MiddlenameTextbox.Size = New System.Drawing.Size(242, 29)
        Me.MiddlenameTextbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Middle name"
        '
        'LastnameTextbox
        '
        Me.LastnameTextbox.Location = New System.Drawing.Point(123, 92)
        Me.LastnameTextbox.Name = "LastnameTextbox"
        Me.LastnameTextbox.Size = New System.Drawing.Size(242, 29)
        Me.LastnameTextbox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last name"
        '
        'FirstnameTextbox
        '
        Me.FirstnameTextbox.Location = New System.Drawing.Point(123, 57)
        Me.FirstnameTextbox.Name = "FirstnameTextbox"
        Me.FirstnameTextbox.Size = New System.Drawing.Size(242, 29)
        Me.FirstnameTextbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First name"
        '
        'IdNumberTextbox
        '
        Me.IdNumberTextbox.Location = New System.Drawing.Point(123, 22)
        Me.IdNumberTextbox.Name = "IdNumberTextbox"
        Me.IdNumberTextbox.ReadOnly = True
        Me.IdNumberTextbox.Size = New System.Drawing.Size(242, 29)
        Me.IdNumberTextbox.TabIndex = 7
        Me.IdNumberTextbox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID no."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(431, 300)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add person"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddressTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MiddlenameTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LastnameTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstnameTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdNumberTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents AddBtn As Button
End Class
