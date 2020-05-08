'--------------------------------------------------
' Name : Ruja Rajbhandari   
' Class: IT-102-001
' Abstract: Homework 5- Theatre Seating Reservation
'--------------------------------------------------

Public Class FMain

    'Checkbox Height and Width
    Private Const f_intCheckboxHeight As Integer = 15
    Private Const f_intCheckboxWidth As Integer = 15


    Private Const f_intSeatColumns As Integer = 10
    Private Const f_intSeatRows As Integer = 25

    'Variable to store Checkbox that is created
    Private chkTheaterSeats(,) As CheckBox

    'store the number of occupied and not occupied seats
    Private m_intTotalFilled As Integer
    Private m_intTotalEmpty As Integer

    ' pntCurrent is used to create a Point structure.
    Private pntCurrent As System.Drawing.Point

    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            BuildSeats()

        Catch ex As Exception

            'Error Message
            MessageBox.Show("Cannot load Seats")

        End Try

    End Sub



    Public Sub BuildSeats()

        ReDim chkTheaterSeats(f_intSeatColumns, f_intSeatRows)

        Dim pintCurrentColumn As Integer
        Dim pintCurrentRow As Integer

        ' Define the total number of seats.
        m_intTotalEmpty = f_intSeatColumns * f_intSeatRows

        txtSeatsTaken.Text = m_intTotalFilled.ToString()
        txtSeatsEmpty.Text = m_intTotalEmpty.ToString()

        'Columns
        For pintCurrentColumn = 0 To f_intSeatColumns - 1

            'Rows
            For pintCurrentRow = 0 To f_intSeatRows - 1

                pntCurrent = New Point((pintCurrentColumn + 1) * f_intCheckboxWidth, (pintCurrentRow + 1) * f_intCheckboxHeight)

                'Create Checkbox in that point/place
                CreateCheckBox(pintCurrentColumn, pintCurrentRow, pntCurrent)

                'Create row at the end of that row
                CreateRowLabel(pintCurrentRow, (pintCurrentRow + 1) * f_intCheckboxHeight)

            Next

        Next


    End Sub
    Private Sub CreateCheckBox(ByVal pintSeatCurrent As Integer, ByVal pintCurrentRow As Integer, ByVal pntCurrent As Point)


        ' Create an instance of Checkbox class
        chkTheaterSeats(pintSeatCurrent, pintCurrentRow) = New CheckBox()

        'Make it visible
        chkTheaterSeats(pintSeatCurrent, pintCurrentRow).Visible = True

        'Define the size of the checkbox
        chkTheaterSeats(pintSeatCurrent, pintCurrentRow).Size = New System.Drawing.Size(f_intCheckboxWidth, f_intCheckboxHeight)

        'Define the position
        chkTheaterSeats(pintSeatCurrent, pintCurrentRow).Location = pntCurrent

        'Add the event handler
        AddHandler chkTheaterSeats(pintSeatCurrent, pintCurrentRow).CheckedChanged, AddressOf CheckedChangedTheaterSeats

        Me.pnlSeats.Controls.Add(chkTheaterSeats(pintSeatCurrent, pintCurrentRow))

    End Sub



    Private Sub CreateRowLabel(ByVal pintCurrentRow As Integer, pintTop As Integer)

        Dim lblRows As Label = New Label()

        lblRows.Left = 165
        lblRows.Top = pintTop
        lblRows.Height = 15
        lblRows.Width = 25
        'Create a name for the row. Initialize with 1 
        lblRows.Text = (pintCurrentRow + 1).ToString()

        'Add control to the panel
        pnlSeats.Controls.Add(lblRows)

    End Sub


    Private Sub CheckedChangedTheaterSeats(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim chkCurrent As System.Windows.Forms.CheckBox

        '
        chkCurrent = CType(sender, System.Windows.Forms.CheckBox)

        Select Case chkCurrent.Checked

            Case True

                'yes?checked?
                m_intTotalFilled += 1
                m_intTotalEmpty -= 1

            Case False

                'Not checked?
                m_intTotalFilled -= 1
                m_intTotalEmpty += 1

        End Select

        'Display the result
        txtSeatsTaken.Text = m_intTotalFilled.ToString()
        txtSeatsEmpty.Text = m_intTotalEmpty.ToString()

    End Sub


    Private Sub msFileExit_Click(sender As Object, e As EventArgs) Handles msFileExit.Click

        Me.Close()

    End Sub

    Private Sub msSeatsClear_Click(sender As Object, e As EventArgs) Handles msSeatsClear.Click

        Dim ctlCurrent As Control
        Dim chkCurrent As CheckBox

        ' The For Each loop enumerates the Controls collection for the 
        ' Panel rather than the form.
        For Each ctlCurrent In pnlSeats.Controls

            'Check if it is a checkbox
            If TypeOf (ctlCurrent) Is System.Windows.Forms.CheckBox Then

                'Yes? Take the checkbox and clear the mark on it
                chkCurrent = CType(ctlCurrent, System.Windows.Forms.CheckBox)
                chkCurrent.Checked = False

            End If

        Next

        'Clear the textboxes
        txtSeatsTaken.Text = ""
        txtSeatsEmpty.Text = ""

    End Sub


End Class
