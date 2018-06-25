Public Class FrmModal

    Private oNr As String
    Private oCount As Integer

    Public Sub OpenDialog(pNr As String, Optional pParent As Form = Nothing)
        oNr = pNr
        Me.Text = oNr
        If pParent Is Nothing Then
            ShowForm(Me)
        Else
            ShowForm(Me, pParent)
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        CmdOpenModal.Text = "New Modal"
        CmdOpenNonModal.Text = "New Non Modal"
    End Sub

    Private Sub CmdOpenModal_Click(sender As Object, e As EventArgs) Handles CmdOpenModal.Click
        Dim lFrm As New FrmModal
        oCount = oCount + 1
        lFrm.OpenDialog(oNr & ".Modal." & oCount, Me)
    End Sub

    Private Sub CmdOpenNonModal_Click(sender As Object, e As EventArgs) Handles CmdOpenNonModal.Click
        Dim lFrm As New FrmModal
        oCount = oCount + 1
        lFrm.OpenDialog(oNr & ".NonModal." & oCount)
    End Sub

    Private Sub FrmModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class