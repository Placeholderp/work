Imports System.Speech.Synthesis
Public Class Help
    Private Sub BtnMap_Click(sender As Object, e As EventArgs) Handles BtnMap.Click
        Dim Form As New Storemap
        Form.Show()
        Me.Hide()
    End Sub
    Private Sub BtnStores_Click(sender As Object, e As EventArgs) Handles BtnStores.Click
        Dim Form As New Stores
        Form.Show()
        Me.Hide()
    End Sub
    Private Sub BtnTravel_Click(sender As Object, e As EventArgs) Handles BtnTravel.Click
        Dim Form As New Travel
        Form.Show()
        Me.Hide()
    End Sub
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

    Private Sub BtnSpeaker_Click(sender As Object, e As EventArgs) Handles BtnSpeaker.Click
        Dim synth As New SpeechSynthesizer
        synth.Speak(TxtStores.Text)
    End Sub
End Class