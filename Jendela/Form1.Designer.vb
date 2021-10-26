<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PILIHANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAINLAINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(496, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ini adalah testing"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(532, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tekan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(559, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.PILIHANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1086, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DToolStripMenuItem})
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AToolStripMenuItem.Text = "MENU"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DToolStripMenuItem.Text = "FORMULIR"
        '
        'PILIHANToolStripMenuItem
        '
        Me.PILIHANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LAINLAINToolStripMenuItem})
        Me.PILIHANToolStripMenuItem.Name = "PILIHANToolStripMenuItem"
        Me.PILIHANToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.PILIHANToolStripMenuItem.Text = "PILIHAN"
        '
        'LAINLAINToolStripMenuItem
        '
        Me.LAINLAINToolStripMenuItem.Name = "LAINLAINToolStripMenuItem"
        Me.LAINLAINToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LAINLAINToolStripMenuItem.Text = "LAIN LAIN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Jendela.My.Resources.Resources._1085721
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1086, 595)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PILIHANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAINLAINToolStripMenuItem As ToolStripMenuItem
End Class
