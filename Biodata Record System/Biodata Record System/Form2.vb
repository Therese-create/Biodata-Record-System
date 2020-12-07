Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql_connection As MySqlClient.MySqlConnection
        Dim sql_command As MySqlClient.MySqlCommand
        Dim sql As String
        Dim sex As String

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Or TextBox16.Text = "" Or TextBox17.Text = "" Or TextBox18.Text = "" Or TextBox19.Text = "" Or TextBox20.Text = "" Or TextBox21.Text = "" Or TextBox22.Text = "" Or TextBox23.Text = "" Or TextBox24.Text = "" Or TextBox25.Text = "" Or TextBox26.Text = "" Or TextBox27.Text = "" Or TextBox28.Text = "" Then
            MsgBox("Please fill up the necessary fields")

        Else
            If RadioButton1.Checked = True Then
                sex = RadioButton1.Text
            Else
                sex = RadioButton2.Text
            End If

            sql_connection = New MySqlClient.MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=biodata;")
            Try
                sql_connection.Open()
            Catch ex As Exception
                MsgBox("Error Creating DB connection")

            End Try

            Try
                sql = "INSERT INTO personal_data (position,fname,mname,lname,bday,c_status,religion,address,sex,height,weight,nationality,telno,f_name,f_occu,m_name,m_occu,language,p_contact,p_num,p_address,elem,yr_elem,hs,yr_hs,voc,yr_voc,col,yr_col,course,special_skills) VALUES(@position,@fname,@mname,@lname,@bday,@c_status,@religion,@address,@sex,@height,@weight,@nationality,@telno,@f_name,@f_occu,@m_name,@m_occu,@language,@p_contact,@p_num,@p_address,@elem,@yr_elem,@hs,@yr_hs,@voc,@yr_voc,@col,@yr_col,@course,@special_skills)"
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.Parameters.AddWithValue("@position", TextBox1.Text)
                sql_command.Parameters.AddWithValue("@fname", TextBox2.Text)
                sql_command.Parameters.AddWithValue("@mname", TextBox3.Text)
                sql_command.Parameters.AddWithValue("@lname", TextBox4.Text)
                sql_command.Parameters.AddWithValue("@bday", DateTimePicker1.Text)
                sql_command.Parameters.AddWithValue("@c_status", ComboBox1.Text)
                sql_command.Parameters.AddWithValue("@religion", TextBox5.Text)
                sql_command.Parameters.AddWithValue("@address", TextBox6.Text)
                sql_command.Parameters.AddWithValue("@sex", sex)
                sql_command.Parameters.AddWithValue("@height", TextBox7.Text)
                sql_command.Parameters.AddWithValue("@weight", TextBox8.Text)
                sql_command.Parameters.AddWithValue("@nationality", TextBox9.Text)
                sql_command.Parameters.AddWithValue("@telno", TextBox10.Text)
                sql_command.Parameters.AddWithValue("@f_name", TextBox11.Text)
                sql_command.Parameters.AddWithValue("@f_occu", TextBox12.Text)
                sql_command.Parameters.AddWithValue("@m_name", TextBox13.Text)
                sql_command.Parameters.AddWithValue("@m_occu", TextBox14.Text)
                sql_command.Parameters.AddWithValue("@language", TextBox15.Text)
                sql_command.Parameters.AddWithValue("@p_contact", TextBox16.Text)
                sql_command.Parameters.AddWithValue("@p_num", TextBox17.Text)
                sql_command.Parameters.AddWithValue("@p_address", TextBox18.Text)
                sql_command.Parameters.AddWithValue("@elem", TextBox19.Text)
                sql_command.Parameters.AddWithValue("@yr_elem", TextBox20.Text)
                sql_command.Parameters.AddWithValue("@hs", TextBox21.Text)
                sql_command.Parameters.AddWithValue("@yr_hs", TextBox22.Text)
                sql_command.Parameters.AddWithValue("@voc", TextBox23.Text)
                sql_command.Parameters.AddWithValue("@yr_voc", TextBox24.Text)
                sql_command.Parameters.AddWithValue("@col", TextBox25.Text)
                sql_command.Parameters.AddWithValue("@yr_col", TextBox26.Text)
                sql_command.Parameters.AddWithValue("@course", TextBox27.Text)
                sql_command.Parameters.AddWithValue("@special_skills", TextBox28.Text)

                sql_command.ExecuteNonQuery()



            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try
            MsgBox("Data has been saved.")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
            TextBox14.Clear()
            TextBox15.Clear()
            TextBox16.Clear()
            TextBox17.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
            TextBox20.Clear()
            TextBox21.Clear()
            TextBox22.Clear()
            TextBox23.Clear()
            TextBox24.Clear()
            TextBox25.Clear()
            TextBox26.Clear()
            TextBox27.Clear()
            TextBox28.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()

    End Sub
End Class