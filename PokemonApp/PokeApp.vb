Option Strict On
Public Class PokeApp

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            Try

                Dim strSelect As String = ""
                Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
                Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
                Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

                ' loop through the textboxes and clear them in case they have data in them after a delete
                For Each cntrl As Control In Controls
                    If TypeOf cntrl Is TextBox Then
                        cntrl.Text = String.Empty
                    End If
                Next

                ' open the DB
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

            ' Build the select statement
            strSelect = "SELECT id, name FROM card_series"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                ' load table from data reader
                dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboSeries.ValueMember = "id"
            cboSeries.DisplayMember = "name"
            cboSeries.DataSource = dt

            ' Select the first item in the list by default
            If cboSeries.Items.Count > 0 Then cboSeries.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

                ' close the database connection
                CloseDatabaseConnection()

            Catch ex As Exception

                ' Log and display error message
                MessageBox.Show(ex.Message)

            End Try

        End Sub
        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strSelect As String = ""
        Dim intCount As Integer
        Dim intRowsAffected As Integer

        Try



            ' thie will hold our Update statement
            Dim cmdUpdate As OleDb.OleDbCommand

            ' check to make sure all text boxes have data. No data no update!
            If Validation() = True Then
                ' open database
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                ' after you validate there is data put values into variables
                If Validation() = True Then

                    intCount = CInt(txtCount.Text)


                    ' Build the select statement using PK from name selected
                    strSelect = "Update cards Set intCount = '" & intCount & "' ""Where id = " & cboCards.SelectedValue.ToString

                    ' uncomment out the following message box line to use as a tool to check your sql statement
                    ' remember anything not a numeric value going into SQL Server must have single quotes '
                    ' around it, including dates.

                    'MessageBox.Show(strSelect)


                    ' make the connection
                    cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                    ' IUpdate the row with execute the statement
                    intRowsAffected = cmdUpdate.ExecuteNonQuery()

                    ' have to let the user know what happened 
                    If intRowsAffected = 1 Then
                        MessageBox.Show("Update successful")
                    Else
                        MessageBox.Show("Update failed")
                    End If

                    ' close the database connection
                    CloseDatabaseConnection()

                    ' call the Form Load sub to refresh the combo box data after a delete
                    Form1_Load(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function Validation() As Boolean

        ' loop through the textboxes and check to make sure there is data in them
        For Each cntrl As Control In Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.BackColor = Color.White
                If cntrl.Text = String.Empty Then
                    cntrl.BackColor = Color.Yellow
                    cntrl.Focus()
                    Return False
                End If
            End If
        Next

        'every this is good so return true
        Return True

    End Function
    'Private Sub cboCards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCards.SelectedIndexChanged

    '    Dim strSelect As String = ""
    '    Dim strName As String = ""
    '    Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
    '    Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
    '    Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

    '    Try



    '        ' open the database
    '        If OpenDatabaseConnectionSQLServer() = False Then

    '            ' No, warn the user ...
    '            MessageBox.Show(Me, "Database connection error." & vbNewLine &
    '                                "The application will now close.",
    '                                Me.Text + " Error",
    '                                MessageBoxButtons.OK, MessageBoxIcon.Error)

    '            ' and close the form/application
    '            Me.Close()

    '        End If

    '        ' Build the select statement using PK from name selected
    '        strSelect = "SELECT strFirstName, strLastName, strAddress, strCity, strState, strZip FROM TPlayers Where intPlayerID = " & cboSeries.SelectedValue.ToString

    '        ' Retrieve all the records 
    '        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
    '        drSourceTable = cmdSelect.ExecuteReader

    '        ' load the data table from the reader
    '        dt.Load(drSourceTable)

    '        ' populate the text boxes with the data
    '        'lbl.Text = dt.Rows(0).Item(0).ToString
    '        ' txtLastName.Text = dt.Rows(0).Item(1).ToString
    '        'txtAddress.Text = dt.Rows(0).Item(2).ToString
    '        'txtCity.Text = dt.Rows(0).Item(3).ToString
    '        'txtState.Text = dt.Rows(0).Item(4).ToString
    '        'txtZip.Text = dt.Rows(0).Item(5).ToString

    '        ' close the database connection
    '        CloseDatabaseConnection()


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub cboSeries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeries.SelectedIndexChanged

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT id, name FROM card_sets WHERE series_id = " & cboSeries.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboSets.ValueMember = "id"
            cboSets.DisplayMember = "name"
            cboSets.DataSource = dt

            ' Select the first item in the list by default
            If cboSets.Items.Count > 0 Then cboSets.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub cboSets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSets.SelectedIndexChanged

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT id, name, image FROM cards WHERE set_id = " & cboSets.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboCards.ValueMember = "id"
            cboCards.DisplayMember = "name"
            cboCards.DataSource = dt

            'MessageBox.Show(dt.Rows(0).Item(2).ToString)
            webImage.Navigate(dt.Rows(0).Item(2).ToString)

            ' Select the first item in the list by default
            If cboCards.Items.Count > 0 Then cboCards.SelectedIndex = 0

            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub cboCards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCards.SelectedIndexChanged

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT image FROM cards WHERE id = " & cboCards.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            'MessageBox.Show(dt.Rows(0).Item(0).ToString)
            webImage.Navigate(dt.Rows(0).Item(0).ToString)

            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
