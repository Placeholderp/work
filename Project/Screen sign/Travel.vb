Imports System.Speech.Synthesis
Public Class Travel
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Form As New Form1
        Form.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Form As New Form1
        Form.Show()
        Me.Hide()
    End Sub
    Private Sub BtnMap_Click(sender As Object, e As EventArgs) Handles BtnMap.Click
        Dim Form As New Storemap
        Form.Show()
        Me.Hide()
    End Sub
    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Dim Form As New Help
        Form.Show()
        Me.Hide()
    End Sub

    Private Sub BtnStores_Click(sender As Object, e As EventArgs) Handles BtnStores.Click
        Dim Form As New Stores
        Form.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSpeaker_Click(sender As Object, e As EventArgs) Handles BtnSpeaker.Click
        Dim synth As New SpeechSynthesizer
        synth.Speak(TxtTravel.Text)
    End Sub
End Class