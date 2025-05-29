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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.grpOut = New System.Windows.Forms.GroupBox()
        Me.txtGWA = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblGWA = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpInput.SuspendLayout()
        Me.grpOut.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnCompute)
        Me.grpInput.Controls.Add(Me.lblUnits)
        Me.grpInput.Controls.Add(Me.lblGrade)
        Me.grpInput.Controls.Add(Me.BtnInput)
        Me.grpInput.Controls.Add(Me.txtUnits)
        Me.grpInput.Controls.Add(Me.txtGrade)
        Me.grpInput.Location = New System.Drawing.Point(40, 31)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(263, 83)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(182, 54)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 29)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(6, 49)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(40, 16)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Units:"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(6, 24)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(48, 16)
        Me.lblGrade.TabIndex = 4
        Me.lblGrade.Text = "Grade:"
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(182, 21)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 28)
        Me.BtnInput.TabIndex = 2
        Me.BtnInput.Text = "&Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(60, 49)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 22)
        Me.txtUnits.TabIndex = 1
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(60, 21)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade.TabIndex = 0
        '
        'grpOut
        '
        Me.grpOut.Controls.Add(Me.txtGWA)
        Me.grpOut.Controls.Add(Me.btnReset)
        Me.grpOut.Controls.Add(Me.lblGWA)
        Me.grpOut.Location = New System.Drawing.Point(40, 120)
        Me.grpOut.Name = "grpOut"
        Me.grpOut.Size = New System.Drawing.Size(263, 100)
        Me.grpOut.TabIndex = 1
        Me.grpOut.TabStop = False
        Me.grpOut.Text = "Output"
        '
        'txtGWA
        '
        Me.txtGWA.Location = New System.Drawing.Point(116, 18)
        Me.txtGWA.Multiline = True
        Me.txtGWA.Name = "txtGWA"
        Me.txtGWA.ReadOnly = True
        Me.txtGWA.Size = New System.Drawing.Size(141, 76)
        Me.txtGWA.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(9, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 42)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblGWA
        '
        Me.lblGWA.AutoSize = True
        Me.lblGWA.Location = New System.Drawing.Point(6, 18)
        Me.lblGWA.Name = "lblGWA"
        Me.lblGWA.Size = New System.Drawing.Size(42, 16)
        Me.lblGWA.TabIndex = 2
        Me.lblGWA.Text = "GWA:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(339, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(339, 236)
        Me.Controls.Add(Me.grpOut)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GWA Calculator"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOut.ResumeLayout(False)
        Me.grpOut.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents BtnInput As Button
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents grpOut As GroupBox
    Friend WithEvents txtGWA As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblGWA As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
