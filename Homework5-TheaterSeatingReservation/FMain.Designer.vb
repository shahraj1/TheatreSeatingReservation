<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSeats = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSeatsClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.pnlSeats = New System.Windows.Forms.Panel()
        Me.lblSeatsTaken = New System.Windows.Forms.Label()
        Me.lblSeatsEmpty = New System.Windows.Forms.Label()
        Me.txtSeatsTaken = New System.Windows.Forms.TextBox()
        Me.txtSeatsEmpty = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFile, Me.msSeats})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(406, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mnuMenuStrip"
        '
        'msFile
        '
        Me.msFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msFileExit})
        Me.msFile.Name = "msFile"
        Me.msFile.Size = New System.Drawing.Size(44, 24)
        Me.msFile.Text = "File"
        '
        'msFileExit
        '
        Me.msFileExit.Name = "msFileExit"
        Me.msFileExit.Size = New System.Drawing.Size(152, 24)
        Me.msFileExit.Text = "Exit"
        '
        'msSeats
        '
        Me.msSeats.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSeatsClear})
        Me.msSeats.Name = "msSeats"
        Me.msSeats.Size = New System.Drawing.Size(56, 24)
        Me.msSeats.Text = "Seats"
        '
        'msSeatsClear
        '
        Me.msSeatsClear.Name = "msSeatsClear"
        Me.msSeatsClear.Size = New System.Drawing.Size(152, 24)
        Me.msSeatsClear.Text = "Clear"
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(43, 56)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(204, 17)
        Me.lblNumbers.TabIndex = 14
        Me.lblNumbers.Text = "1   2   3   4   5   6   7   8   9   10"
        '
        'pnlSeats
        '
        Me.pnlSeats.AutoScroll = True
        Me.pnlSeats.Location = New System.Drawing.Point(23, 77)
        Me.pnlSeats.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSeats.Name = "pnlSeats"
        Me.pnlSeats.Size = New System.Drawing.Size(260, 587)
        Me.pnlSeats.TabIndex = 15
        '
        'lblSeatsTaken
        '
        Me.lblSeatsTaken.AutoSize = True
        Me.lblSeatsTaken.Location = New System.Drawing.Point(302, 107)
        Me.lblSeatsTaken.Name = "lblSeatsTaken"
        Me.lblSeatsTaken.Size = New System.Drawing.Size(92, 17)
        Me.lblSeatsTaken.TabIndex = 16
        Me.lblSeatsTaken.Text = "Seats Taken:"
        '
        'lblSeatsEmpty
        '
        Me.lblSeatsEmpty.AutoSize = True
        Me.lblSeatsEmpty.Location = New System.Drawing.Point(303, 167)
        Me.lblSeatsEmpty.Name = "lblSeatsEmpty"
        Me.lblSeatsEmpty.Size = New System.Drawing.Size(91, 17)
        Me.lblSeatsEmpty.TabIndex = 16
        Me.lblSeatsEmpty.Text = "Seats Empty:"
        '
        'txtSeatsTaken
        '
        Me.txtSeatsTaken.Enabled = False
        Me.txtSeatsTaken.Location = New System.Drawing.Point(305, 127)
        Me.txtSeatsTaken.Name = "txtSeatsTaken"
        Me.txtSeatsTaken.Size = New System.Drawing.Size(87, 22)
        Me.txtSeatsTaken.TabIndex = 17
        '
        'txtSeatsEmpty
        '
        Me.txtSeatsEmpty.Enabled = False
        Me.txtSeatsEmpty.Location = New System.Drawing.Point(306, 187)
        Me.txtSeatsEmpty.Name = "txtSeatsEmpty"
        Me.txtSeatsEmpty.Size = New System.Drawing.Size(87, 22)
        Me.txtSeatsEmpty.TabIndex = 17
        '
        'FMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 693)
        Me.Controls.Add(Me.txtSeatsEmpty)
        Me.Controls.Add(Me.txtSeatsTaken)
        Me.Controls.Add(Me.lblSeatsEmpty)
        Me.Controls.Add(Me.lblSeatsTaken)
        Me.Controls.Add(Me.pnlSeats)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents msFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msSeats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msSeatsClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents pnlSeats As System.Windows.Forms.Panel
    Friend WithEvents lblSeatsTaken As System.Windows.Forms.Label
    Friend WithEvents lblSeatsEmpty As System.Windows.Forms.Label
    Friend WithEvents txtSeatsTaken As System.Windows.Forms.TextBox
    Friend WithEvents txtSeatsEmpty As System.Windows.Forms.TextBox

End Class
