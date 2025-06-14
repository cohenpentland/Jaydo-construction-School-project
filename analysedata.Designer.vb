<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class analysedata
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
        Me.lstrawdata = New System.Windows.Forms.ListBox()
        Me.btnsort = New System.Windows.Forms.Button()
        Me.cmbsortype = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Jaydo_construction.My.Resources.Resources.ChatGPT_Image_May_23__2025__12_52_58_PM_modified
        Me.PictureBox1.Location = New System.Drawing.Point(-109, -57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(685, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lstrawdata
        '
        Me.lstrawdata.FormattingEnabled = True
        Me.lstrawdata.ItemHeight = 25
        Me.lstrawdata.Location = New System.Drawing.Point(7, 258)
        Me.lstrawdata.Name = "lstrawdata"
        Me.lstrawdata.Size = New System.Drawing.Size(435, 404)
        Me.lstrawdata.TabIndex = 3
        '
        'btnsort
        '
        Me.btnsort.Location = New System.Drawing.Point(248, 195)
        Me.btnsort.Name = "btnsort"
        Me.btnsort.Size = New System.Drawing.Size(194, 33)
        Me.btnsort.TabIndex = 7
        Me.btnsort.Text = "Sort"
        Me.btnsort.UseVisualStyleBackColor = True
        '
        'cmbsortype
        '
        Me.cmbsortype.FormattingEnabled = True
        Me.cmbsortype.Location = New System.Drawing.Point(7, 195)
        Me.cmbsortype.Name = "cmbsortype"
        Me.cmbsortype.Size = New System.Drawing.Size(221, 33)
        Me.cmbsortype.TabIndex = 6
        '
        'analysedata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(447, 686)
        Me.Controls.Add(Me.btnsort)
        Me.Controls.Add(Me.cmbsortype)
        Me.Controls.Add(Me.lstrawdata)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "analysedata"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstrawdata As ListBox
    Friend WithEvents btnsort As Button
    Friend WithEvents cmbsortype As ComboBox
End Class
