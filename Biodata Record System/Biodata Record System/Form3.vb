Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Form3
    Dim sqlDataAdapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim bSource As New BindingSource
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;database=biodata;")
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            sql_connection.open()
            Dim query As String

            query = "SELECT idnum as ID,position as PositionDesired, fname as FirstName,mname as MiddleName,lname as LastName,bday as Birthday,c_status as CivilStatus,religion as Religion,address as Address,sex as Sex,height as HeightByCM, weight as Weight, nationality as Nationality, telno as Telnumber, f_name as FatherName, f_occu as FatherOccupation, m_name as MotherName, m_occu as MotherOccupation, language as Languages, p_contact as PersonToContact, p_num as PersonToContactNumber, p_address as PersonToContactAddress, elem as Elementary, yr_elem as ElementaryYearGraduated, hs as HighSchool, yr_hs as HighSchoolYearGraduated, voc as Vocational, yr_voc as VocationalYearGraduated, col as College, yr_col as CollegeYearGraduated, course as Course, special_skills as SpecialSkills FROM personal_data where lname like'" & TextBox1.Text & "%' or mname like'" & TextBox1.Text & "%' or fname like'" & TextBox1.Text & "%'"

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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Try
            sql_connection.open()
            Dim query As String

            query = "SELECT idnum as ID,position as PositionDesired, fname as FirstName,mname as MiddleName,lname as LastName,bday as Birthday,address as Address,sex as Sex,height as HeightByCM, weight as Weight, nationality as Nationality, telno as Telnumber, f_name as FatherName, f_occu as FatherOccupation, m_name as MotherName, m_occu as MotherOccupation, language as Languages, p_contact as PersonToContact, p_num as PersonToContactNumber, p_address as PersonToContactAddress, elem as Elementary, yr_elem as ElementaryYearGraduated, hs as HighSchool, yr_hs as HighSchoolYearGraduated, voc as Vocational, yr_voc as VocationalYearGraduated, col as College, yr_col as CollegeYearGraduated, course as Course, special_skills as SpecialSkills FROM personal_data;"
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
End Class