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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PersonsTable = New System.Windows.Forms.DataGridView()
        Me.IDnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PersonsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PersonsTable, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 14)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(702, 500)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(572, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'AddressTextbox
        '
        Me.AddressTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddressTextbox.Location = New System.Drawing.Point(135, 172)
        Me.AddressTextbox.Name = "AddressTextbox"
        Me.AddressTextbox.ReadOnly = True
        Me.AddressTextbox.Size = New System.Drawing.Size(429, 29)
        Me.AddressTextbox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Address"
        '
        'MiddlenameTextbox
        '
        Me.MiddlenameTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiddlenameTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MiddlenameTextbox.Location = New System.Drawing.Point(135, 137)
        Me.MiddlenameTextbox.Name = "MiddlenameTextbox"
        Me.MiddlenameTextbox.ReadOnly = True
        Me.MiddlenameTextbox.Size = New System.Drawing.Size(429, 29)
        Me.MiddlenameTextbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Middle name"
        '
        'LastnameTextbox
        '
        Me.LastnameTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastnameTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LastnameTextbox.Location = New System.Drawing.Point(135, 102)
        Me.LastnameTextbox.Name = "LastnameTextbox"
        Me.LastnameTextbox.ReadOnly = True
        Me.LastnameTextbox.Size = New System.Drawing.Size(429, 29)
        Me.LastnameTextbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last name"
        '
        'FirstnameTextbox
        '
        Me.FirstnameTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstnameTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FirstnameTextbox.Location = New System.Drawing.Point(135, 67)
        Me.FirstnameTextbox.Name = "FirstnameTextbox"
        Me.FirstnameTextbox.ReadOnly = True
        Me.FirstnameTextbox.Size = New System.Drawing.Size(429, 29)
        Me.FirstnameTextbox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First name"
        '
        'IdNumberTextbox
        '
        Me.IdNumberTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdNumberTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IdNumberTextbox.Location = New System.Drawing.Point(135, 32)
        Me.IdNumberTextbox.Name = "IdNumberTextbox"
        Me.IdNumberTextbox.ReadOnly = True
        Me.IdNumberTextbox.Size = New System.Drawing.Size(429, 29)
        Me.IdNumberTextbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID no."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Editbtn)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(587, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(110, 211)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(8, 99)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 31)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Editbtn.Location = New System.Drawing.Point(8, 62)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(94, 31)
        Me.Editbtn.TabIndex = 0
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(8, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PersonsTable
        '
        Me.PersonsTable.AllowUserToAddRows = False
        Me.PersonsTable.AllowUserToDeleteRows = False
        Me.PersonsTable.AllowUserToResizeRows = False
        Me.PersonsTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonsTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDnumber, Me.Firstname, Me.Lastname, Me.Middlename, Me.Address})
        Me.TableLayoutPanel1.SetColumnSpan(Me.PersonsTable, 2)
        Me.PersonsTable.Location = New System.Drawing.Point(5, 223)
        Me.PersonsTable.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PersonsTable.MultiSelect = False
        Me.PersonsTable.Name = "PersonsTable"
        Me.PersonsTable.ReadOnly = True
        Me.PersonsTable.RowHeadersVisible = False
        Me.PersonsTable.RowTemplate.Height = 25
        Me.PersonsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PersonsTable.Size = New System.Drawing.Size(692, 273)
        Me.PersonsTable.TabIndex = 2
        '
        'IDnumber
        '
        Me.IDnumber.DataPropertyName = "IDnumber"
        Me.IDnumber.HeaderText = "ID no."
        Me.IDnumber.Name = "IDnumber"
        Me.IDnumber.ReadOnly = True
        Me.IDnumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Firstname
        '
        Me.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "First name"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        Me.Firstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Lastname
        '
        Me.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Last name"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Middlename
        '
        Me.Middlename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Middlename.HeaderText = "Middle name"
        Me.Middlename.Name = "Middlename"
        Me.Middlename.ReadOnly = True
        Me.Middlename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(728, 528)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(13, 14, 13, 14)
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PersonsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PersonsTable As DataGridView
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents IDnumber As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Middlename As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
End Class
