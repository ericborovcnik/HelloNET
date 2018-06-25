Public Class FrmMain

    Public Sub New()
        InitializeComponent()
        Me.Text = "helloNET - Testumgebung"
        '
        '   Modale Fenster
        PgModal.Text = "Modale Fenster"
        CmdOpenModal.Text = "New Modal"
        CmdOpenNonModal.Text = "New Non-Modal"
        '
        '   Steuerelemetne
        pgControl.Text = "Controls"
        RegMain.SelectTab(0)
        TInfo.Text = ""
    End Sub

    Private Sub RegMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegMain.SelectedIndexChanged
        Select Case sender.SelectedIndex
            Case 0 : TInfo.Text = "Beispielhafte Anwendung 'Pseudo-Modaler' Forms"
            Case 1 : TInfo.Text = "Benutzerspezifische Steuerelemente"
        End Select
    End Sub

    Private Sub CmdOpenModal_Click(sender As Object, e As EventArgs) Handles CmdOpenModal.Click
        Dim lFrm As New FrmModal
        Static sCount As Integer
        sCount += 1
        lFrm.OpenDialog("Modal." & sCount, Me)
    End Sub

    Private Sub CmdOpenNonModal_Click(sender As Object, e As EventArgs) Handles CmdOpenNonModal.Click
        Dim lFrm As New FrmModal
        Static sCount As Integer
        sCount += 1
        lFrm.OpenDialog("Non-Modal." & sCount)
    End Sub

End Class