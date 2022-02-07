<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finestra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GeneraPersone = New System.Windows.Forms.Button()
        Me.SpazioStampa = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MediaNormale = New System.Windows.Forms.Button()
        Me.MediaOnline = New System.Windows.Forms.Button()
        Me.Frequenza = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GeneraPersone
        '
        Me.GeneraPersone.Location = New System.Drawing.Point(13, 13)
        Me.GeneraPersone.Name = "GeneraPersone"
        Me.GeneraPersone.Size = New System.Drawing.Size(107, 23)
        Me.GeneraPersone.TabIndex = 0
        Me.GeneraPersone.Text = "Genera Persone"
        Me.GeneraPersone.UseVisualStyleBackColor = True
        '
        'SpazioStampa
        '
        Me.SpazioStampa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpazioStampa.Location = New System.Drawing.Point(138, 13)
        Me.SpazioStampa.Name = "SpazioStampa"
        Me.SpazioStampa.Size = New System.Drawing.Size(366, 425)
        Me.SpazioStampa.TabIndex = 1
        Me.SpazioStampa.Text = ""
        '
        'MediaNormale
        '
        Me.MediaNormale.Location = New System.Drawing.Point(13, 43)
        Me.MediaNormale.Name = "MediaNormale"
        Me.MediaNormale.Size = New System.Drawing.Size(107, 23)
        Me.MediaNormale.TabIndex = 2
        Me.MediaNormale.Text = "Media Normale"
        Me.MediaNormale.UseVisualStyleBackColor = True
        '
        'MediaOnline
        '
        Me.MediaOnline.Location = New System.Drawing.Point(13, 73)
        Me.MediaOnline.Name = "MediaOnline"
        Me.MediaOnline.Size = New System.Drawing.Size(107, 23)
        Me.MediaOnline.TabIndex = 3
        Me.MediaOnline.Text = "Media Online"
        Me.MediaOnline.UseVisualStyleBackColor = True
        '
        'Frequenza
        '
        Me.Frequenza.Location = New System.Drawing.Point(13, 103)
        Me.Frequenza.Name = "Frequenza"
        Me.Frequenza.Size = New System.Drawing.Size(107, 23)
        Me.Frequenza.TabIndex = 4
        Me.Frequenza.Text = "Frequenza"
        Me.Frequenza.UseVisualStyleBackColor = True
        '
        'Finestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 450)
        Me.Controls.Add(Me.Frequenza)
        Me.Controls.Add(Me.MediaOnline)
        Me.Controls.Add(Me.MediaNormale)
        Me.Controls.Add(Me.SpazioStampa)
        Me.Controls.Add(Me.GeneraPersone)
        Me.Name = "Finestra"
        Me.Text = "Calcola Media"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneraPersone As Button
    Friend WithEvents SpazioStampa As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MediaNormale As Button
    Friend WithEvents MediaOnline As Button
    Friend WithEvents Frequenza As Button
End Class
