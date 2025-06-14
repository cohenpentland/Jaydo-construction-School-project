<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lstnotifications = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btndatainput = New System.Windows.Forms.Button()
        Me.btnsortandalysedata = New System.Windows.Forms.Button()
        Me.btnformcreation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncontacts = New System.Windows.Forms.Button()
        Me.btntodolist = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstnotifications
        '
        Me.lstnotifications.FormattingEnabled = True
        Me.lstnotifications.ItemHeight = 25
        Me.lstnotifications.Location = New System.Drawing.Point(869, 165)
        Me.lstnotifications.Name = "lstnotifications"
        Me.lstnotifications.Size = New System.Drawing.Size(242, 429)
        Me.lstnotifications.TabIndex = 2
        '
        'btndatainput
        '
        Me.btndatainput.Location = New System.Drawing.Point(12, 165)
        Me.btndatainput.Name = "btndatainput"
        Me.btndatainput.Size = New System.Drawing.Size(243, 431)
        Me.btndatainput.TabIndex = 3
        Me.btndatainput.Text = "btndatainput"
        Me.btndatainput.UseVisualStyleBackColor = True
        '
        'btnsortandalysedata
        '
        Me.btnsortandalysedata.Location = New System.Drawing.Point(284, 165)
        Me.btnsortandalysedata.Name = "btnsortandalysedata"
        Me.btnsortandalysedata.Size = New System.Drawing.Size(243, 431)
        Me.btnsortandalysedata.TabIndex = 4
        Me.btnsortandalysedata.Text = "btnsortandalysedata"
        Me.btnsortandalysedata.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnsortandalysedata.UseVisualStyleBackColor = True
        '
        'btnformcreation
        '
        Me.btnformcreation.Location = New System.Drawing.Point(553, 165)
        Me.btnformcreation.Name = "btnformcreation"
        Me.btnformcreation.Size = New System.Drawing.Size(243, 431)
        Me.btnformcreation.TabIndex = 5
        Me.btnformcreation.Text = "btnformcreation"
        Me.btnformcreation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(878, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Notification center"
        '
        'btncontacts
        '
        Me.btncontacts.Location = New System.Drawing.Point(12, 628)
        Me.btncontacts.Name = "btncontacts"
        Me.btncontacts.Size = New System.Drawing.Size(375, 72)
        Me.btncontacts.TabIndex = 8
        Me.btncontacts.Text = "btncontacts"
        Me.btncontacts.UseVisualStyleBackColor = True
        '
        'btntodolist
        '
        Me.btntodolist.Location = New System.Drawing.Point(428, 628)
        Me.btntodolist.Name = "btntodolist"
        Me.btntodolist.Size = New System.Drawing.Size(368, 72)
        Me.btntodolist.TabIndex = 9
        Me.btntodolist.Text = "Btntodolist"
        Me.btntodolist.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "6:15pm thursday"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(869, 628)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(242, 72)
        Me.btnlogout.TabIndex = 11
        Me.btnlogout.Text = "btnLogout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(479, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Jaydo_construction.My.Resources.Resources.ChatGPT_Image_May_23__2025__12_52_58_PM_modified
        Me.PictureBox1.Location = New System.Drawing.Point(-139, -33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1119, 746)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btntodolist)
        Me.Controls.Add(Me.btncontacts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnformcreation)
        Me.Controls.Add(Me.btnsortandalysedata)
        Me.Controls.Add(Me.btndatainput)
        Me.Controls.Add(Me.lstnotifications)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstnotifications As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btndatainput As Button
    Friend WithEvents btnsortandalysedata As Button
    Friend WithEvents btnformcreation As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btncontacts As Button
    Friend WithEvents btntodolist As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label1 As Label
End Class
