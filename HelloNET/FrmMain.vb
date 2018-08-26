#Disable Warning IDE1006
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
        '   Steuerelemente
        pgControl.Text = "Controls"
        '
        '   Protokoll
        AddHandler gLog.Changed, AddressOf Log

        pgLog.Text = "Log"
        cmdLogAdd.Text = "Add Log"
        '
        '   Collection
        pgCollection.Text = "Collection"

        SetRegister(3)
    End Sub

    Public Sub Log(pMessage As String)
        lstLog.Items.Add(pMessage)
        lstLog.SelectedIndex = lstLog.Items.Count - 1
    End Sub

    Private Sub RegMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegMain.SelectedIndexChanged
        SetRegister(sender.selectedindex)
    End Sub

    Private Sub SetRegister(pIndex As Integer)
        RegMain.SelectTab(pIndex)
        Select Case pIndex
            Case 0 : TInfo.Text = "Beispielhafte Anwendung 'Pseudo-Modaler' Forms"
            Case 1 : TInfo.Text = "Benutzerspezifische Steuerelemente"
            Case 2 : TInfo.Text = "Protokoll-Anwendung"
            Case 3 : TInfo.Text = "Collection mit Datenstrukturen"
            Case Else : TInfo.Text = ""
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

    Private Sub cmdLogAdd_Click(sender As Object, e As EventArgs) Handles cmdLogAdd.Click
        gLog.Add(gLog.Count & " - Entries")
    End Sub


End Class
