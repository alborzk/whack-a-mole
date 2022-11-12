<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.prgHealth = New System.Windows.Forms.ProgressBar()
        Me.picMoleyA1 = New System.Windows.Forms.PictureBox()
        Me.picMoleyA2 = New System.Windows.Forms.PictureBox()
        Me.picMoleyA3 = New System.Windows.Forms.PictureBox()
        Me.picMoleyB1 = New System.Windows.Forms.PictureBox()
        Me.picMoleyB2 = New System.Windows.Forms.PictureBox()
        Me.picMoleyB3 = New System.Windows.Forms.PictureBox()
        Me.picMoleyC1 = New System.Windows.Forms.PictureBox()
        Me.picMoleyC2 = New System.Windows.Forms.PictureBox()
        Me.picMoleyC3 = New System.Windows.Forms.PictureBox()
        Me.picMoleyD1 = New System.Windows.Forms.PictureBox()
        Me.picMoleyD2 = New System.Windows.Forms.PictureBox()
        Me.picMoleyD3 = New System.Windows.Forms.PictureBox()
        Me.tmrMole = New System.Windows.Forms.Timer(Me.components)
        Me.picTitleBG = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tmrHealth = New System.Windows.Forms.Timer(Me.components)
        Me.tmrControl = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoleyD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitleBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(960, 540)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBackground.TabIndex = 1
        Me.picBackground.TabStop = False
        Me.picBackground.Visible = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Linen
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblScore.Location = New System.Drawing.Point(134, 61)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 23)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblScore.Visible = False
        '
        'prgHealth
        '
        Me.prgHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.prgHealth.Location = New System.Drawing.Point(798, 62)
        Me.prgHealth.Maximum = 5
        Me.prgHealth.Name = "prgHealth"
        Me.prgHealth.Size = New System.Drawing.Size(91, 23)
        Me.prgHealth.Step = 1
        Me.prgHealth.TabIndex = 4
        Me.prgHealth.Value = 5
        Me.prgHealth.Visible = False
        '
        'picMoleyA1
        '
        Me.picMoleyA1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyA1.Image = CType(resources.GetObject("picMoleyA1.Image"), System.Drawing.Image)
        Me.picMoleyA1.Location = New System.Drawing.Point(320, 129)
        Me.picMoleyA1.Name = "picMoleyA1"
        Me.picMoleyA1.Size = New System.Drawing.Size(61, 52)
        Me.picMoleyA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyA1.TabIndex = 6
        Me.picMoleyA1.TabStop = False
        Me.picMoleyA1.Visible = False
        '
        'picMoleyA2
        '
        Me.picMoleyA2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyA2.Image = CType(resources.GetObject("picMoleyA2.Image"), System.Drawing.Image)
        Me.picMoleyA2.Location = New System.Drawing.Point(449, 128)
        Me.picMoleyA2.Name = "picMoleyA2"
        Me.picMoleyA2.Size = New System.Drawing.Size(61, 52)
        Me.picMoleyA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyA2.TabIndex = 7
        Me.picMoleyA2.TabStop = False
        Me.picMoleyA2.Visible = False
        '
        'picMoleyA3
        '
        Me.picMoleyA3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyA3.Image = CType(resources.GetObject("picMoleyA3.Image"), System.Drawing.Image)
        Me.picMoleyA3.Location = New System.Drawing.Point(584, 126)
        Me.picMoleyA3.Name = "picMoleyA3"
        Me.picMoleyA3.Size = New System.Drawing.Size(61, 52)
        Me.picMoleyA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyA3.TabIndex = 8
        Me.picMoleyA3.TabStop = False
        Me.picMoleyA3.Visible = False
        '
        'picMoleyB1
        '
        Me.picMoleyB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyB1.Image = CType(resources.GetObject("picMoleyB1.Image"), System.Drawing.Image)
        Me.picMoleyB1.Location = New System.Drawing.Point(255, 182)
        Me.picMoleyB1.Name = "picMoleyB1"
        Me.picMoleyB1.Size = New System.Drawing.Size(93, 70)
        Me.picMoleyB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyB1.TabIndex = 9
        Me.picMoleyB1.TabStop = False
        Me.picMoleyB1.Visible = False
        '
        'picMoleyB2
        '
        Me.picMoleyB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyB2.Image = CType(resources.GetObject("picMoleyB2.Image"), System.Drawing.Image)
        Me.picMoleyB2.Location = New System.Drawing.Point(423, 187)
        Me.picMoleyB2.Name = "picMoleyB2"
        Me.picMoleyB2.Size = New System.Drawing.Size(93, 70)
        Me.picMoleyB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyB2.TabIndex = 10
        Me.picMoleyB2.TabStop = False
        Me.picMoleyB2.Visible = False
        '
        'picMoleyB3
        '
        Me.picMoleyB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyB3.Image = CType(resources.GetObject("picMoleyB3.Image"), System.Drawing.Image)
        Me.picMoleyB3.Location = New System.Drawing.Point(609, 186)
        Me.picMoleyB3.Name = "picMoleyB3"
        Me.picMoleyB3.Size = New System.Drawing.Size(92, 60)
        Me.picMoleyB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoleyB3.TabIndex = 11
        Me.picMoleyB3.TabStop = False
        Me.picMoleyB3.Visible = False
        '
        'picMoleyC1
        '
        Me.picMoleyC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyC1.Image = CType(resources.GetObject("picMoleyC1.Image"), System.Drawing.Image)
        Me.picMoleyC1.Location = New System.Drawing.Point(161, 264)
        Me.picMoleyC1.Name = "picMoleyC1"
        Me.picMoleyC1.Size = New System.Drawing.Size(141, 94)
        Me.picMoleyC1.TabIndex = 12
        Me.picMoleyC1.TabStop = False
        Me.picMoleyC1.Visible = False
        '
        'picMoleyC2
        '
        Me.picMoleyC2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyC2.Image = CType(resources.GetObject("picMoleyC2.Image"), System.Drawing.Image)
        Me.picMoleyC2.Location = New System.Drawing.Point(384, 262)
        Me.picMoleyC2.Name = "picMoleyC2"
        Me.picMoleyC2.Size = New System.Drawing.Size(151, 94)
        Me.picMoleyC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyC2.TabIndex = 13
        Me.picMoleyC2.TabStop = False
        Me.picMoleyC2.Visible = False
        '
        'picMoleyC3
        '
        Me.picMoleyC3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyC3.Image = CType(resources.GetObject("picMoleyC3.Image"), System.Drawing.Image)
        Me.picMoleyC3.Location = New System.Drawing.Point(611, 257)
        Me.picMoleyC3.Name = "picMoleyC3"
        Me.picMoleyC3.Size = New System.Drawing.Size(151, 94)
        Me.picMoleyC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyC3.TabIndex = 14
        Me.picMoleyC3.TabStop = False
        Me.picMoleyC3.Visible = False
        '
        'picMoleyD1
        '
        Me.picMoleyD1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyD1.Image = CType(resources.GetObject("picMoleyD1.Image"), System.Drawing.Image)
        Me.picMoleyD1.Location = New System.Drawing.Point(94, 366)
        Me.picMoleyD1.Name = "picMoleyD1"
        Me.picMoleyD1.Size = New System.Drawing.Size(179, 108)
        Me.picMoleyD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyD1.TabIndex = 15
        Me.picMoleyD1.TabStop = False
        Me.picMoleyD1.Visible = False
        '
        'picMoleyD2
        '
        Me.picMoleyD2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyD2.Image = CType(resources.GetObject("picMoleyD2.Image"), System.Drawing.Image)
        Me.picMoleyD2.Location = New System.Drawing.Point(347, 370)
        Me.picMoleyD2.Name = "picMoleyD2"
        Me.picMoleyD2.Size = New System.Drawing.Size(179, 106)
        Me.picMoleyD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyD2.TabIndex = 16
        Me.picMoleyD2.TabStop = False
        Me.picMoleyD2.Visible = False
        '
        'picMoleyD3
        '
        Me.picMoleyD3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoleyD3.Image = CType(resources.GetObject("picMoleyD3.Image"), System.Drawing.Image)
        Me.picMoleyD3.Location = New System.Drawing.Point(640, 368)
        Me.picMoleyD3.Name = "picMoleyD3"
        Me.picMoleyD3.Size = New System.Drawing.Size(201, 111)
        Me.picMoleyD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoleyD3.TabIndex = 17
        Me.picMoleyD3.TabStop = False
        Me.picMoleyD3.Visible = False
        '
        'tmrMole
        '
        Me.tmrMole.Interval = 3000
        '
        'picTitleBG
        '
        Me.picTitleBG.Image = CType(resources.GetObject("picTitleBG.Image"), System.Drawing.Image)
        Me.picTitleBG.Location = New System.Drawing.Point(0, 0)
        Me.picTitleBG.Name = "picTitleBG"
        Me.picTitleBG.Size = New System.Drawing.Size(960, 526)
        Me.picTitleBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitleBG.TabIndex = 18
        Me.picTitleBG.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.BorderSize = 2
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(435, 362)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 29)
        Me.btnStart.TabIndex = 21
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewGame.FlatAppearance.BorderSize = 2
        Me.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGame.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(248, 348)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(100, 29)
        Me.btnNewGame.TabIndex = 22
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        Me.btnNewGame.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnQuit.FlatAppearance.BorderSize = 2
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(639, 348)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 29)
        Me.btnQuit.TabIndex = 23
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        Me.btnQuit.Visible = False
        '
        'tmrHealth
        '
        Me.tmrHealth.Interval = 1000
        '
        'tmrControl
        '
        Me.tmrControl.Enabled = True
        Me.tmrControl.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 538)
        Me.Controls.Add(Me.prgHealth)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picMoleyD3)
        Me.Controls.Add(Me.picMoleyD2)
        Me.Controls.Add(Me.picMoleyD1)
        Me.Controls.Add(Me.picMoleyC3)
        Me.Controls.Add(Me.picMoleyC2)
        Me.Controls.Add(Me.picMoleyC1)
        Me.Controls.Add(Me.picMoleyB3)
        Me.Controls.Add(Me.picMoleyB2)
        Me.Controls.Add(Me.picMoleyB1)
        Me.Controls.Add(Me.picMoleyA3)
        Me.Controls.Add(Me.picMoleyA2)
        Me.Controls.Add(Me.picMoleyA1)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.picTitleBG)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoleyD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitleBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents prgHealth As ProgressBar
    Friend WithEvents picMoleyA1 As PictureBox
    Friend WithEvents picMoleyA2 As PictureBox
    Friend WithEvents picMoleyA3 As PictureBox
    Friend WithEvents picMoleyB1 As PictureBox
    Friend WithEvents picMoleyB2 As PictureBox
    Friend WithEvents picMoleyB3 As PictureBox
    Friend WithEvents picMoleyC1 As PictureBox
    Friend WithEvents picMoleyC2 As PictureBox
    Friend WithEvents picMoleyC3 As PictureBox
    Friend WithEvents picMoleyD1 As PictureBox
    Friend WithEvents picMoleyD2 As PictureBox
    Friend WithEvents picMoleyD3 As PictureBox
    Friend WithEvents tmrMole As Timer
    Friend WithEvents picTitleBG As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents tmrHealth As Timer
    Friend WithEvents tmrControl As Timer
End Class
