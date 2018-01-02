Public Class BatchGUI

    Public funi As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDub.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles EpFrom.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles EpTo.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Layers.SelectedIndexChanged

    End Sub

    Private Sub LabelEpTo_Click(sender As Object, e As EventArgs) Handles LabelEpTo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelShowTitleOveride.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ButtonCreateBatch_Click(sender As Object, e As EventArgs) Handles ButtonCreateBatch.Click

        If EpFrom.Text = "" Then
            EpFrom.Focus()
            MessageBox.Show(text:="No Episode From Entered!", caption:="Data Entry Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Stop
        End If

        If EpTo.Text = "" Then
            EpTo.Focus()
            MessageBox.Show(text:="No Episode To Entered!", caption:="Data Entry Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Stop
        End If

        If SeriesId.Text = "" Then
            SeriesId.Focus()
            MessageBox.Show(text:="No Series ID Entered!", caption:="Data Entry Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Stop
        End If

        If Layers.Text = "" Then
            Layers.Focus()
            MessageBox.Show(text:="No Layer Selected!", caption:="Data Entry Error", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Stop
        End If

        If EpFrom.Text <> "" And EpTo.Text <> "" And SeriesId.Text <> "" And Layers.Text <> "" Then

            TextBoxOutput.Clear()
            funi = $"@echo off{vbNewLine}{vbNewLine}"

            'Dim AllEps As IEnumerable(Of Integer) = Enumerable.Range(Convert.ToInt32(EpFrom.Text), Convert.ToInt32(EpTo.Text))

            Dim TempFuni

            TempFuni = $"""node"" ""%~dp0.\scripts\funi.js"" -s ""{SeriesId.Text}"" --sel ""PLACEHOLDEREPISODENUMBER"" -q ""{Layers.Text}"""

            If RadioProxySocks.Checked And TextBoxProxyAddr.Text <> "" Then
                TempFuni = $"{TempFuni} --socks ""{TextBoxProxyAddr.Text}"""
            ElseIf RadioProxyHttp.Checked And TextBoxProxyAddr.Text <> "" Then
                TempFuni = $"{TempFuni} --proxy ""{TextBoxProxyAddr.Text}"""
            End If

            If TextBoxReleaseGroup.Text <> "" Then
                TempFuni = $"{TempFuni} -a ""{TextBoxReleaseGroup.Text}"""
            End If

            If TextBoxShowOveride.Text <> "" Then
                TempFuni = $"{TempFuni} -t ""{TextBoxShowOveride.Text}"""
            End If

            If TextBoxSuffixOveride.Text <> "" Then
                TempFuni = $"{TempFuni} --suffix ""{TextBoxSuffixOveride.Text}"""
            End If

            If CheckBoxMkv.Checked Then
                TempFuni = $"{TempFuni} --mkv"
            End If

            If CheckBoxMks.Checked Then
                TempFuni = $"{TempFuni} --mks"
            End If

            If CheckBoxDub.Checked Then
                TempFuni = $"{TempFuni} --sub"
            End If

            If CheckBoxSubs.Checked Then
                TempFuni = $"{TempFuni} --nosubs"
            End If

            If CheckBoxAlt.Checked Then
                TempFuni = $"{TempFuni} --alt"
            End If

            Dim AllEps As New ArrayList
            Dim CurrentEp = Convert.ToInt32(EpFrom.Text)
            While CurrentEp <= Convert.ToInt32(EpTo.Text)
                AllEps.Add(value:=CurrentEp)
                CurrentEp += 1
            End While


            Dim TempFuniLoop
            For Each num As Integer In AllEps
                TempFuniLoop = TempFuni
                TempFuniLoop = TempFuniLoop.Replace("PLACEHOLDEREPISODENUMBER", Convert.ToString(num))
                funi = $"{funi}{TempFuniLoop}{vbNewLine}"
            Next


            funi = $"{funi}{vbNewLine}Pause"
            TextBoxOutput.AppendText(text:=funi)
        End If
    End Sub

    Private Sub ButtonCreateBat_Click(sender As Object, e As EventArgs) Handles ButtonCreateBat.Click
        If funi <> "" Then

            Try
                Dim savefile As New SaveFileDialog
                savefile.ShowDialog()
                My.Computer.FileSystem.WriteAllText(savefile.FileName & ".bat", funi, False)
                MsgBox("Saved .bat file!")
            Catch ex As Exception

            End Try

        Else
            MessageBox.Show(text:="Nothing to write, generate batch script first.", caption:="Cannot Save File", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Stop
        End If
    End Sub

    Private Sub EpFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EpFrom.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EpTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EpTo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SeriesId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SeriesId.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
