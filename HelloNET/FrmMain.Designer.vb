<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Splitter = New System.Windows.Forms.SplitContainer()
        Me.TInfo = New System.Windows.Forms.TextBox()
        Me.RegMain = New System.Windows.Forms.TabControl()
        Me.PgModal = New System.Windows.Forms.TabPage()
        Me.CmdOpenNonModal = New System.Windows.Forms.Button()
        Me.CmdOpenModal = New System.Windows.Forms.Button()
        Me.pgControl = New System.Windows.Forms.TabPage()
        Me.Redlight1 = New HelloLib.Redlight()
        Me.Redlight2 = New HelloLib.Redlight()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Splitter.Panel1.SuspendLayout()
        Me.Splitter.SuspendLayout()
        Me.RegMain.SuspendLayout()
        Me.PgModal.SuspendLayout()
        Me.pgControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter
        '
        Me.Splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Splitter.Location = New System.Drawing.Point(0, 0)
        Me.Splitter.Name = "Splitter"
        '
        'Splitter.Panel1
        '
        Me.Splitter.Panel1.Controls.Add(Me.TInfo)
        Me.Splitter.Panel1.Controls.Add(Me.RegMain)
        Me.Splitter.Size = New System.Drawing.Size(687, 372)
        Me.Splitter.SplitterDistance = 354
        Me.Splitter.TabIndex = 0
        '
        'TInfo
        '
        Me.TInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TInfo.Location = New System.Drawing.Point(16, 303)
        Me.TInfo.Multiline = True
        Me.TInfo.Name = "TInfo"
        Me.TInfo.Size = New System.Drawing.Size(331, 57)
        Me.TInfo.TabIndex = 1
        Me.TInfo.Text = "TInfo"
        '
        'RegMain
        '
        Me.RegMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegMain.Controls.Add(Me.PgModal)
        Me.RegMain.Controls.Add(Me.pgControl)
        Me.RegMain.Location = New System.Drawing.Point(12, 12)
        Me.RegMain.Name = "RegMain"
        Me.RegMain.SelectedIndex = 0
        Me.RegMain.Size = New System.Drawing.Size(339, 285)
        Me.RegMain.TabIndex = 0
        '
        'PgModal
        '
        Me.PgModal.Controls.Add(Me.CmdOpenNonModal)
        Me.PgModal.Controls.Add(Me.CmdOpenModal)
        Me.PgModal.Location = New System.Drawing.Point(4, 22)
        Me.PgModal.Name = "PgModal"
        Me.PgModal.Padding = New System.Windows.Forms.Padding(3)
        Me.PgModal.Size = New System.Drawing.Size(331, 259)
        Me.PgModal.TabIndex = 0
        Me.PgModal.Text = "PgModal"
        Me.PgModal.UseVisualStyleBackColor = True
        '
        'CmdOpenNonModal
        '
        Me.CmdOpenNonModal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOpenNonModal.Location = New System.Drawing.Point(6, 59)
        Me.CmdOpenNonModal.Name = "CmdOpenNonModal"
        Me.CmdOpenNonModal.Size = New System.Drawing.Size(319, 47)
        Me.CmdOpenNonModal.TabIndex = 1
        Me.CmdOpenNonModal.Text = "CmdOpenNonModal"
        Me.CmdOpenNonModal.UseVisualStyleBackColor = True
        '
        'CmdOpenModal
        '
        Me.CmdOpenModal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOpenModal.Location = New System.Drawing.Point(6, 6)
        Me.CmdOpenModal.Name = "CmdOpenModal"
        Me.CmdOpenModal.Size = New System.Drawing.Size(319, 47)
        Me.CmdOpenModal.TabIndex = 0
        Me.CmdOpenModal.Text = "CmdOpenModal"
        Me.CmdOpenModal.UseVisualStyleBackColor = True
        '
        'pgControl
        '
        Me.pgControl.Controls.Add(Me.Redlight2)
        Me.pgControl.Controls.Add(Me.Redlight1)
        Me.pgControl.Location = New System.Drawing.Point(4, 22)
        Me.pgControl.Name = "pgControl"
        Me.pgControl.Padding = New System.Windows.Forms.Padding(3)
        Me.pgControl.Size = New System.Drawing.Size(331, 259)
        Me.pgControl.TabIndex = 1
        Me.pgControl.Text = "pgControl"
        Me.pgControl.UseVisualStyleBackColor = True
        '
        'Redlight1
        '
        Me.Redlight1.Location = New System.Drawing.Point(6, 6)
        Me.Redlight1.Name = "Redlight1"
        Me.Redlight1.Size = New System.Drawing.Size(45, 135)
        Me.Redlight1.Status = HelloLib.Redlight.RedlightStatus.RedlightNone
        Me.Redlight1.TabIndex = 0
        Me.Redlight1.Text = "Redlight1"
        '
        'Redlight2
        '
        Me.Redlight2.Location = New System.Drawing.Point(94, 15)
        Me.Redlight2.Name = "Redlight2"
        Me.Redlight2.Size = New System.Drawing.Size(45, 126)
        Me.Redlight2.Status = HelloLib.Redlight.RedlightStatus.RedlightNone
        Me.Redlight2.TabIndex = 1
        Me.Redlight2.Text = "Redlight2"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 372)
        Me.Controls.Add(Me.Splitter)
        Me.MinimumSize = New System.Drawing.Size(450, 255)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.Splitter.Panel1.ResumeLayout(False)
        Me.Splitter.Panel1.PerformLayout()
        CType(Me.Splitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Splitter.ResumeLayout(False)
        Me.RegMain.ResumeLayout(False)
        Me.PgModal.ResumeLayout(False)
        Me.pgControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splitter As SplitContainer
    Friend WithEvents TInfo As TextBox
    Friend WithEvents RegMain As TabControl
    Friend WithEvents PgModal As TabPage
    Friend WithEvents pgControl As TabPage
    Friend WithEvents CmdOpenNonModal As Button
    Friend WithEvents CmdOpenModal As Button
    Friend WithEvents Redlight1 As Redlight
    Friend WithEvents Redlight2 As Redlight
End Class
