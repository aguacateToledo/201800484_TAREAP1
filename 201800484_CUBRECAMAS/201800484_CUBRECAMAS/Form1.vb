Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            txtLino.Visible = True
            txtLino.Focus()
        Else
            txtLino.Clear()
            txtLino.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            txtAlgodon.Visible = True
            txtAlgodon.Focus()
        Else
            txtAlgodon.Clear()
            txtAlgodon.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            txtSeda.Visible = True
            txtSeda.Focus()
        Else
            txtSeda.Clear()
            txtSeda.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked) Then
            txtHiloCrudo.Visible = True
            txtHiloCrudo.Focus()
        Else
            txtHiloCrudo.Clear()
            txtHiloCrudo.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantLino As Double = 0
        Dim cantAlgodon As Double = 0
        Dim cantSeda As Double = 0
        Dim cantHiloCrudo As Double = 0
        Dim cantTotalYarda As Double = 0

        Dim necYardas As Double = 3
        Dim necMatrimonial As Double = 5
        Dim necQueen As Double = 6
        Dim necKing As Double = 7

        If RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Or RadioButton4.Checked Then

        Else
            MsgBox("Seleccione una mano de obra")
            Return
        End If

        If ((CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox4.Checked) Or (CheckBox3.Checked)) Then
            If (CheckBox1.Checked) Then
                If (IsNumeric(txtLino.Text) And Val(txtLino.Text) > 0) Then
                    cantLino = Val(txtLino.Text)

                Else
                    MsgBox("ERROR, DATO DE LINO NO VÁLIDO")
                    txtLino.Focus()
                    Exit Sub
                End If
            Else
                cantLino = 0
            End If

            If (CheckBox2.Checked) Then
                If (IsNumeric(txtAlgodon.Text) And Val(txtAlgodon.Text) > 0) Then
                    cantAlgodon = Val(txtAlgodon.Text)

                Else
                    MsgBox("ERROR, DATO DE ALGODON NO VÁLIDO")
                    txtAlgodon.Focus()
                    Exit Sub
                End If
            Else
                cantAlgodon = 0
            End If

            If (CheckBox3.Checked) Then
                If (IsNumeric(txtSeda.Text) And Val(txtSeda.Text) > 0) Then
                    cantSeda = Val(txtSeda.Text)

                Else
                    MsgBox("ERROR, DATO DE SEDA NO VÁLIDO")
                    txtSeda.Focus()
                    Exit Sub
                End If
            Else
                cantSeda = 0
            End If

            If (CheckBox4.Checked) Then
                If (IsNumeric(txtHiloCrudo.Text) And Val(txtHiloCrudo.Text) > 0) Then
                    cantHiloCrudo = Val(txtHiloCrudo.Text)
                Else
                    MsgBox("ERROR, DATO DE HILO CRUDO NO VÁLIDO")
                    txtHiloCrudo.Focus()
                    Exit Sub
                End If
            Else
                cantHiloCrudo = 0
            End If

            cantTotalYarda = cantAlgodon + cantHiloCrudo + cantLino + cantSeda

            If RadioButton1.Checked Then
                If cantTotalYarda <= 3 Then
                Else
                    MsgBox("la cantidad de yardas para la imperial sobre pasa la cantidad para elaborarla ")
                End If
            End If

            If RadioButton2.Checked Then
                If cantTotalYarda <= 5 Then
                Else
                    MsgBox("la cantidad de yardas para la matrimonial sobre pasa la cantidad para elaborarla ")
                End If
            End If

            If RadioButton3.Checked Then
                If cantTotalYarda <= 6 Then
                Else
                    MsgBox("la cantidad de yardas para la Queen sobre pasa la cantidad para elaborarla ")
                End If
            End If

            If RadioButton4.Checked Then
                If cantTotalYarda <= 7 Then
                Else
                    MsgBox("la cantidad de yardas para la King sobre pasa la cantidad para elaborarla ")
                End If
            End If
        Else
            MsgBox("Seleccione un material")
        End If
    End Sub
End Class
