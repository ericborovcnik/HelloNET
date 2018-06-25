<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModal
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdOpenModal = New System.Windows.Forms.Button()
        Me.CmdOpenNonModal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdOpenModal
        '
        Me.CmdOpenModal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOpenModal.Location = New System.Drawing.Point(12, 12)
        Me.CmdOpenModal.Name = "CmdOpenModal"
        Me.CmdOpenModal.Size = New System.Drawing.Size(318, 43)
        Me.CmdOpenModal.TabIndex = 0
        Me.CmdOpenModal.Text = "CmdOpenModal"
        Me.CmdOpenModal.UseVisualStyleBackColor = True
        '
        'CmdOpenNonModal
        '
        Me.CmdOpenNonModal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOpenNonModal.Location = New System.Drawing.Point(12, 61)
        Me.CmdOpenNonModal.Name = "CmdOpenNonModal"
        Me.CmdOpenNonModal.Size = New System.Drawing.Size(318, 43)
        Me.CmdOpenNonModal.TabIndex = 1
        Me.CmdOpenNonModal.Text = "Button1"
        Me.CmdOpenNonModal.UseVisualStyleBackColor = True
        '
        'FrmModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 115)
        Me.Controls.Add(Me.CmdOpenNonModal)
        Me.Controls.Add(Me.CmdOpenModal)
        Me.MinimumSize = New System.Drawing.Size(350, 142)
        Me.Name = "FrmModal"
        Me.Text = "FrmModal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdOpenModal As Button
    Friend WithEvents CmdOpenNonModal As Button
End Class
