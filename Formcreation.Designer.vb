<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formcreation
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbdataset = New System.Windows.Forms.ComboBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.lstrawdatapreview = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstformpreview = New System.Windows.Forms.ListBox()
        Me.btngeneratereport = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsendemail = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Jaydo_construction.My.Resources.Resources.ChatGPT_Image_May_23__2025__12_52_58_PM_modified
        Me.PictureBox1.Location = New System.Drawing.Point(-125, -20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmbdataset
        '
        Me.cmbdataset.FormattingEnabled = True
        Me.cmbdataset.Location = New System.Drawing.Point(12, 581)
        Me.cmbdataset.Name = "cmbdataset"
        Me.cmbdataset.Size = New System.Drawing.Size(256, 33)
        Me.cmbdataset.TabIndex = 2
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(12, 620)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(126, 45)
        Me.btnload.TabIndex = 3
        Me.btnload.Text = "btnload"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(144, 620)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(126, 45)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "btnclear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'lstrawdatapreview
        '
        Me.lstrawdatapreview.FormattingEnabled = True
        Me.lstrawdatapreview.ItemHeight = 25
        Me.lstrawdatapreview.Location = New System.Drawing.Point(12, 178)
        Me.lstrawdatapreview.Name = "lstrawdatapreview"
        Me.lstrawdatapreview.Size = New System.Drawing.Size(258, 379)
        Me.lstrawdatapreview.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(22, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "6:15pm thursday"
        '
        'lstformpreview
        '
        Me.lstformpreview.FormattingEnabled = True
        Me.lstformpreview.ItemHeight = 25
        Me.lstformpreview.Location = New System.Drawing.Point(310, 178)
        Me.lstformpreview.Name = "lstformpreview"
        Me.lstformpreview.Size = New System.Drawing.Size(774, 379)
        Me.lstformpreview.TabIndex = 12
        '
        'btngeneratereport
        '
        Me.btngeneratereport.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btngeneratereport.Location = New System.Drawing.Point(310, 581)
        Me.btngeneratereport.Name = "btngeneratereport"
        Me.btngeneratereport.Size = New System.Drawing.Size(774, 45)
        Me.btngeneratereport.TabIndex = 13
        Me.btngeneratereport.Text = "btnGeneratereport"
        Me.btngeneratereport.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(310, 639)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(390, 31)
        Me.TextBox1.TabIndex = 14
        '
        'btnsendemail
        '
        Me.btnsendemail.Location = New System.Drawing.Point(728, 632)
        Me.btnsendemail.Name = "btnsendemail"
        Me.btnsendemail.Size = New System.Drawing.Size(354, 38)
        Me.btnsendemail.TabIndex = 15
        Me.btnsendemail.Text = "btnsendemail"
        Me.btnsendemail.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(853, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(229, 56)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "btnmainmenu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'formcreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1096, 729)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnsendemail)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btngeneratereport)
        Me.Controls.Add(Me.lstformpreview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstrawdatapreview)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.cmbdataset)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "formcreation"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbdataset As ComboBox
    Friend WithEvents btnload As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents lstrawdatapreview As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstformpreview As ListBox
    Friend WithEvents btngeneratereport As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnsendemail As Button
    Friend WithEvents Button5 As Button
End Class
