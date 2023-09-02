Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim coleccion As String
        Dim total As Integer

        coleccion = ""
        total = 0

        If CheckBox1.Checked Then
            coleccion = coleccion + CheckBox1.Text
            total = total + 1
        End If

        If CheckBox2.Checked Then
            coleccion = coleccion + "," + CheckBox2.Text
            total = total + 1
        End If

        If CheckBox3.Checked Then
            coleccion = coleccion + "," + CheckBox3.Text
            total = total + 1
        End If

        If CheckBox4.Checked Then
            coleccion = coleccion + "" + CheckBox4.Text
            total = total + 1
        End If

        MsgBox("Elegiste: " + CStr(total) + " , las preferencias son: " + coleccion)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Si eligió la primera opción

        If RadioButton1.Checked Then
            MsgBox("eligio viajar por " + RadioButton1.Text)
        End If

        If RadioButton2.Checked Then
            MsgBox("eligio viajar por " + RadioButton2.Text)
        End If

        If RadioButton3.Checked Then
            MsgBox("eligio viajar por " + RadioButton3.Text)
        End If



    End Sub
End Class
