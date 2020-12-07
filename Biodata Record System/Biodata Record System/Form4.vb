Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Form4
    Dim sqlDataAdapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim bSource As New BindingSource
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=biodata;")

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            sql_connection.open()
            Dim query As String

            query = "SELECT idnum as ID,position as PositionDesired, fname as FirstName,mname as MiddleName,lname as LastName,bday as Birthday,address as Address,sex as Sex,height as HeightByCM, weight as Weight, nationality as Nationality, telno as Telnumber, f_name as FatherName, f_occu as FatherOccupation, m_name as MotherName, m_occu as MotherOccupation, language as Languages, p_contact as PersonToContact, p_num as PersonToContactNumber, p_address as PersonToContactAddress, elem as Elementary, yr_elem as ElementaryYearGraduated, hs as HighSchool, yr_hs as HighSchoolYearGraduated, voc as Vocational, yr_voc as VocationalYearGraduated, col as College, yr_col as CollegeYearGraduated, course as Course, special_skills as SpecialSkills FROM personal_data where lname like'" & TextBox1.Text & "%' or mname like'" & TextBox1.Text & "%' or fname like'" & TextBox1.Text & "%'; "

            sql_command = New MySqlCommand(query, sql_connection)
            sqlDataAdapter.SelectCommand = sql_command
            dt.Clear()

            sqlDataAdapter.Fill(dt)
            bSource.DataSource = dt
            DataGridView1.DataSource = bSource
            sqlDataAdapter.Update(dt)

            sql_connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Try
            sql_connection.open()
            Dim query As String

            query = "SELECT idnum as ID,position as PositionDesired, fname as FirstName,mname as MiddleName,lname as LastName,bday as Birthday,c_status as CivilStatus,religion as Religion,address as Address,sex as Sex,height as HeightByCM, weight as Weight, nationality as Nationality, telno as Telnumber, f_name as FatherName, f_occu as FatherOccupation, m_name as MotherName, m_occu as MotherOccupation, language as Languages, p_contact as PersonToContact, p_num as PersonToContactNumber, p_address as PersonToContactAddress, elem as Elementary, yr_elem as ElementaryYearGraduated, hs as HighSchool, yr_hs as HighSchoolYearGraduated, voc as Vocational, yr_voc as VocationalYearGraduated, col as College, yr_col as CollegeYearGraduated, course as Course, special_skills as SpecialSkills FROM personal_data;"
            sql_command = New MySqlCommand(query, sql_connection)
            sqlDataAdapter.SelectCommand = sql_command
            dt.Clear()
            sqlDataAdapter.Fill(dt)
            bSource.DataSource = dt
            DataGridView1.DataSource = bSource
            sqlDataAdapter.Update(dt)

            sql_connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox7.Text = Me.DataGridView1.SelectedCells(1).Value.ToString
        TextBox2.Text = Me.DataGridView1.SelectedCells(2).Value.ToString
        TextBox3.Text = Me.DataGridView1.SelectedCells(3).Value.ToString
        TextBox4.Text = Me.DataGridView1.SelectedCells(4).Value.ToString
        DateTimePicker1.Text = Me.DataGridView1.SelectedCells(5).Value.ToString
        ComboBox1.Text = Me.DataGridView1.SelectedCells(6).Value.ToString
        TextBox5.Text = Me.DataGridView1.SelectedCells(7).Value.ToString
        TextBox6.Text = Me.DataGridView1.SelectedCells(8).Value.ToString
        TextBox30.Text = Me.DataGridView1.SelectedCells(9).Value.ToString
        TextBox19.Text = Me.DataGridView1.SelectedCells(10).Value.ToString
        TextBox8.Text = Me.DataGridView1.SelectedCells(11).Value.ToString
        TextBox9.Text = Me.DataGridView1.SelectedCells(12).Value.ToString
        TextBox10.Text = Me.DataGridView1.SelectedCells(13).Value.ToString
        TextBox11.Text = Me.DataGridView1.SelectedCells(14).Value.ToString
        TextBox12.Text = Me.DataGridView1.SelectedCells(15).Value.ToString
        TextBox13.Text = Me.DataGridView1.SelectedCells(16).Value.ToString
        TextBox14.Text = Me.DataGridView1.SelectedCells(17).Value.ToString
        TextBox15.Text = Me.DataGridView1.SelectedCells(18).Value.ToString
        TextBox16.Text = Me.DataGridView1.SelectedCells(19).Value.ToString
        TextBox17.Text = Me.DataGridView1.SelectedCells(20).Value.ToString
        TextBox18.Text = Me.DataGridView1.SelectedCells(21).Value.ToString

        TextBox29.Text = Me.DataGridView1.SelectedCells(22).Value.ToString
        TextBox20.Text = Me.DataGridView1.SelectedCells(23).Value.ToString
        TextBox21.Text = Me.DataGridView1.SelectedCells(24).Value.ToString
        TextBox22.Text = Me.DataGridView1.SelectedCells(25).Value.ToString
        TextBox23.Text = Me.DataGridView1.SelectedCells(26).Value.ToString
        TextBox24.Text = Me.DataGridView1.SelectedCells(27).Value.ToString
        TextBox25.Text = Me.DataGridView1.SelectedCells(28).Value.ToString
        TextBox26.Text = Me.DataGridView1.SelectedCells(29).Value.ToString
        TextBox27.Text = Me.DataGridView1.SelectedCells(30).Value.ToString
        TextBox28.Text = Me.DataGridView1.SelectedCells(31).Value.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        Try
            sql_connection.open()
            sql = "update personal_data set position='" & TextBox7.Text & "', fname='" & TextBox2.Text & "', mname='" & TextBox3.Text & "', lname='" & TextBox4.Text & "', bday='" & DateTimePicker1.Text & "', c_status='" & ComboBox1.Text & "', religion='" & TextBox5.Text & "', address='" & TextBox6.Text & "', sex='" & TextBox30.Text & "', height='" & TextBox19.Text & "', weight='" & TextBox8.Text & "', nationality='" & TextBox9.Text & "', telno='" & TextBox10.Text & "', f_name='" & TextBox11.Text & "', f_occu='" & TextBox12.Text & "', m_name='" & TextBox13.Text & "', m_occu='" & TextBox14.Text & "', language='" & TextBox15.Text & "', p_contact='" & TextBox16.Text & "', p_num='" & TextBox17.Text & "', p_address='" & TextBox18.Text & "', elem='" & TextBox29.Text & "', yr_elem='" & TextBox20.Text & "', hs='" & TextBox21.Text & "', yr_hs='" & TextBox22.Text & "', voc='" & TextBox23.Text & "', yr_voc='" & TextBox24.Text & "', col='" & TextBox25.Text & "', yr_col='" & TextBox26.Text & "', course='" & TextBox27.Text & "'where special_skills='" & TextBox28.Text & "'"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

            sql_command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        MsgBox("Data has been saved.")

        dt.Clear()
        sqlDataAdapter.Fill(dt)
        bSource.DataSource = dt
        DataGridView1.DataSource = bSource


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class