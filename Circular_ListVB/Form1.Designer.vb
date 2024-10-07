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
        ibtnAdd = New FontAwesome.Sharp.IconButton()
        ibtnRemove = New FontAwesome.Sharp.IconButton()
        ibtnContains = New FontAwesome.Sharp.IconButton()
        ibtnCount = New FontAwesome.Sharp.IconButton()
        lstNodes = New ListBox()
        txtValue = New TextBox()
        lblValue = New Label()
        SuspendLayout()
        ' 
        ' ibtnAdd
        ' 
        ibtnAdd.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ibtnAdd.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.Save
        ibtnAdd.IconColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnAdd.Location = New Point(282, 73)
        ibtnAdd.Name = "ibtnAdd"
        ibtnAdd.Size = New Size(78, 71)
        ibtnAdd.TabIndex = 8
        ibtnAdd.Text = "Add"
        ibtnAdd.TextAlign = ContentAlignment.BottomCenter
        ibtnAdd.UseVisualStyleBackColor = False
        ' 
        ' ibtnRemove
        ' 
        ibtnRemove.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ibtnRemove.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnRemove.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft
        ibtnRemove.IconColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnRemove.Location = New Point(282, 150)
        ibtnRemove.Name = "ibtnRemove"
        ibtnRemove.Size = New Size(78, 71)
        ibtnRemove.TabIndex = 9
        ibtnRemove.Text = "Remove"
        ibtnRemove.TextAlign = ContentAlignment.BottomCenter
        ibtnRemove.UseVisualStyleBackColor = False
        ' 
        ' ibtnContains
        ' 
        ibtnContains.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ibtnContains.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnContains.IconChar = FontAwesome.Sharp.IconChar.Search
        ibtnContains.IconColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnContains.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnContains.Location = New Point(282, 227)
        ibtnContains.Name = "ibtnContains"
        ibtnContains.Size = New Size(78, 71)
        ibtnContains.TabIndex = 11
        ibtnContains.Text = "Contains"
        ibtnContains.TextAlign = ContentAlignment.BottomCenter
        ibtnContains.UseVisualStyleBackColor = False
        ' 
        ' ibtnCount
        ' 
        ibtnCount.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ibtnCount.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnCount.IconChar = FontAwesome.Sharp.IconChar.Calculator
        ibtnCount.IconColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ibtnCount.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCount.Location = New Point(282, 310)
        ibtnCount.Name = "ibtnCount"
        ibtnCount.Size = New Size(78, 71)
        ibtnCount.TabIndex = 12
        ibtnCount.Text = "Count"
        ibtnCount.TextAlign = ContentAlignment.BottomCenter
        ibtnCount.UseVisualStyleBackColor = False
        ' 
        ' lstNodes
        ' 
        lstNodes.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lstNodes.Font = New Font("Agency FB", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lstNodes.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lstNodes.FormattingEnabled = True
        lstNodes.ItemHeight = 34
        lstNodes.Location = New Point(385, 73)
        lstNodes.Name = "lstNodes"
        lstNodes.Size = New Size(228, 276)
        lstNodes.TabIndex = 13
        ' 
        ' txtValue
        ' 
        txtValue.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtValue.Font = New Font("Agency FB", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtValue.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        txtValue.Location = New Point(97, 73)
        txtValue.Multiline = True
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(143, 38)
        txtValue.TabIndex = 14
        ' 
        ' lblValue
        ' 
        lblValue.AutoSize = True
        lblValue.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblValue.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lblValue.Location = New Point(1, 73)
        lblValue.Name = "lblValue"
        lblValue.Size = New Size(76, 31)
        lblValue.TabIndex = 15
        lblValue.Text = "Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(639, 450)
        Controls.Add(lblValue)
        Controls.Add(txtValue)
        Controls.Add(lstNodes)
        Controls.Add(ibtnCount)
        Controls.Add(ibtnContains)
        Controls.Add(ibtnRemove)
        Controls.Add(ibtnAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents ibtnAdd As FontAwesome.Sharp.IconButton
    Private WithEvents ibtnRemove As FontAwesome.Sharp.IconButton
    Private WithEvents ibtnContains As FontAwesome.Sharp.IconButton
    Private WithEvents ibtnCount As FontAwesome.Sharp.IconButton
    Private WithEvents lstNodes As ListBox
    Private WithEvents txtValue As TextBox
    Private WithEvents lblValue As Label

End Class
