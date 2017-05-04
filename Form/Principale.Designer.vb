<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principale))
        Me.txtMac = New System.Windows.Forms.TextBox()
        Me.cmdRicerca = New System.Windows.Forms.Button()
        Me.cmdCopia = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.lblMessaggio = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtMac
        '
        Me.txtMac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMac.Location = New System.Drawing.Point(12, 261)
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(162, 23)
        Me.txtMac.TabIndex = 0
        '
        'cmdRicerca
        '
        Me.cmdRicerca.Image = Global.MAC_Finder.My.Resources.Resources.system_search_3
        Me.cmdRicerca.Location = New System.Drawing.Point(179, 261)
        Me.cmdRicerca.Name = "cmdRicerca"
        Me.cmdRicerca.Size = New System.Drawing.Size(50, 30)
        Me.cmdRicerca.TabIndex = 1
        Me.cmdRicerca.Text = "Button1"
        Me.cmdRicerca.UseVisualStyleBackColor = True
        '
        'cmdCopia
        '
        Me.cmdCopia.Image = Global.MAC_Finder.My.Resources.Resources.edit_copy_7
        Me.cmdCopia.Location = New System.Drawing.Point(235, 261)
        Me.cmdCopia.Name = "cmdCopia"
        Me.cmdCopia.Size = New System.Drawing.Size(50, 30)
        Me.cmdCopia.TabIndex = 2
        Me.cmdCopia.Text = "Button2"
        Me.cmdCopia.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Image = Global.MAC_Finder.My.Resources.Resources.help_browser_4
        Me.cmdInfo.Location = New System.Drawing.Point(291, 261)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(50, 30)
        Me.cmdInfo.TabIndex = 3
        Me.cmdInfo.Text = "Button3"
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'lblMessaggio
        '
        Me.lblMessaggio.AutoSize = True
        Me.lblMessaggio.Location = New System.Drawing.Point(12, 245)
        Me.lblMessaggio.Name = "lblMessaggio"
        Me.lblMessaggio.Size = New System.Drawing.Size(39, 13)
        Me.lblMessaggio.TabIndex = 4
        Me.lblMessaggio.Text = "Label1"
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(348, 296)
        Me.Controls.Add(Me.lblMessaggio)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.cmdCopia)
        Me.Controls.Add(Me.cmdRicerca)
        Me.Controls.Add(Me.txtMac)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principale"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMac As System.Windows.Forms.TextBox
    Friend WithEvents cmdRicerca As System.Windows.Forms.Button
    Friend WithEvents cmdCopia As System.Windows.Forms.Button
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents lblMessaggio As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
