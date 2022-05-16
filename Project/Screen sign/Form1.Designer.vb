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
        Me.TxtMessage = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.BtnStores = New System.Windows.Forms.Button()
        Me.BtnMap = New System.Windows.Forms.Button()
        Me.BtnTravel = New System.Windows.Forms.Button()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.BtnSpeaker = New System.Windows.Forms.PictureBox()
        Me.TxtRead = New System.Windows.Forms.Label()
        CType(Me.BtnSpeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMessage
        '
        Me.TxtMessage.BackColor = System.Drawing.Color.DarkGray
        Me.TxtMessage.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtMessage.ForeColor = System.Drawing.Color.White
        Me.TxtMessage.Location = New System.Drawing.Point(266, 391)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.Size = New System.Drawing.Size(270, 39)
        Me.TxtMessage.TabIndex = 7
        Me.TxtMessage.Text = "Shop with us"
        Me.TxtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTitle
        '
        Me.TxtTitle.BackColor = System.Drawing.Color.White
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.Location = New System.Drawing.Point(12, 38)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(776, 83)
        Me.TxtTitle.TabIndex = 0
        Me.TxtTitle.Text = "AMAP Shopping Centre"
        Me.TxtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnStores
        '
        Me.BtnStores.BackColor = System.Drawing.Color.White
        Me.BtnStores.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnStores.Location = New System.Drawing.Point(328, 174)
        Me.BtnStores.Name = "BtnStores"
        Me.BtnStores.Size = New System.Drawing.Size(133, 58)
        Me.BtnStores.TabIndex = 1
        Me.BtnStores.Text = "Stores"
        Me.BtnStores.UseVisualStyleBackColor = False
        '
        'BtnMap
        '
        Me.BtnMap.BackColor = System.Drawing.Color.White
        Me.BtnMap.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMap.Location = New System.Drawing.Point(148, 252)
        Me.BtnMap.Name = "BtnMap"
        Me.BtnMap.Size = New System.Drawing.Size(133, 58)
        Me.BtnMap.TabIndex = 2
        Me.BtnMap.Text = "Map"
        Me.BtnMap.UseVisualStyleBackColor = False
        '
        'BtnTravel
        '
        Me.BtnTravel.BackColor = System.Drawing.Color.White
        Me.BtnTravel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTravel.Location = New System.Drawing.Point(328, 252)
        Me.BtnTravel.Name = "BtnTravel"
        Me.BtnTravel.Size = New System.Drawing.Size(133, 58)
        Me.BtnTravel.TabIndex = 3
        Me.BtnTravel.Text = "Travel"
        Me.BtnTravel.UseVisualStyleBackColor = False
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.White
        Me.BtnHelp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHelp.Location = New System.Drawing.Point(504, 252)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(133, 58)
        Me.BtnHelp.TabIndex = 4
        Me.BtnHelp.Text = "Help"
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'BtnSpeaker
        '
        Me.BtnSpeaker.Image = Global.Screen_sign.My.Resources.Resources.icons8_speaker_100
        Me.BtnSpeaker.Location = New System.Drawing.Point(724, 380)
        Me.BtnSpeaker.Name = "BtnSpeaker"
        Me.BtnSpeaker.Size = New System.Drawing.Size(64, 61)
        Me.BtnSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSpeaker.TabIndex = 15
        Me.BtnSpeaker.TabStop = False
        '
        'TxtRead
        '
        Me.TxtRead.BackColor = System.Drawing.Color.Yellow
        Me.TxtRead.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtRead.Location = New System.Drawing.Point(590, 391)
        Me.TxtRead.Name = "TxtRead"
        Me.TxtRead.Size = New System.Drawing.Size(128, 37)
        Me.TxtRead.TabIndex = 14
        Me.TxtRead.Text = "Read aloud"
        Me.TxtRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSpeaker)
        Me.Controls.Add(Me.TxtRead)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnTravel)
        Me.Controls.Add(Me.BtnMap)
        Me.Controls.Add(Me.BtnStores)
        Me.Controls.Add(Me.TxtTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.BtnSpeaker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtMessage As Label
    Friend WithEvents TxtTitle As Label
    Friend WithEvents BtnStores As Button
    Friend WithEvents BtnMap As Button
    Friend WithEvents BtnTravel As Button
    Friend WithEvents BtnHelp As Button
    Friend WithEvents BtnSpeaker As PictureBox
    Friend WithEvents TxtRead As Label
End Class
