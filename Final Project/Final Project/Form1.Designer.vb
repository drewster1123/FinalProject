﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Cloud1 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Jumphb1 = New System.Windows.Forms.PictureBox()
        Me.Jumphb2 = New System.Windows.Forms.PictureBox()
        Me.Jumphb3 = New System.Windows.Forms.PictureBox()
        Me.Jumphb4 = New System.Windows.Forms.PictureBox()
        Me.Jumphb5 = New System.Windows.Forms.PictureBox()
        Me.Jumphb6 = New System.Windows.Forms.PictureBox()
        Me.Floor1L = New System.Windows.Forms.PictureBox()
        Me.Floor1R = New System.Windows.Forms.PictureBox()
        Me.Floor2L = New System.Windows.Forms.PictureBox()
        Me.Floor2R = New System.Windows.Forms.PictureBox()
        Me.Floor6L = New System.Windows.Forms.PictureBox()
        Me.Floor6R = New System.Windows.Forms.PictureBox()
        Me.Floor5L = New System.Windows.Forms.PictureBox()
        Me.Floor5R = New System.Windows.Forms.PictureBox()
        Me.Floor4L = New System.Windows.Forms.PictureBox()
        Me.Floor4R = New System.Windows.Forms.PictureBox()
        Me.Floor3R = New System.Windows.Forms.PictureBox()
        Me.Floor3L = New System.Windows.Forms.PictureBox()
        Me.Bottom1 = New System.Windows.Forms.PictureBox()
        Me.Bottom2 = New System.Windows.Forms.PictureBox()
        Me.Bottom3 = New System.Windows.Forms.PictureBox()
        Me.Bottom4 = New System.Windows.Forms.PictureBox()
        Me.Bottom5 = New System.Windows.Forms.PictureBox()
        Me.Bottom6 = New System.Windows.Forms.PictureBox()
        Me.dead = New System.Windows.Forms.PictureBox()
        Me.GameOverBack = New System.Windows.Forms.PictureBox()
        Me.gameOver = New System.Windows.Forms.Label()
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jumphb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor1L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor1R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor2L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor2R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor6L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor6R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor5L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor5R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor4L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor4R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor3R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor3L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameOverBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 25
        '
        'Cloud1
        '
        Me.Cloud1.Image = Global.Final_Project.My.Resources.Resources.Cloud_PNG_4
        Me.Cloud1.Location = New System.Drawing.Point(68, 33)
        Me.Cloud1.Name = "Cloud1"
        Me.Cloud1.Size = New System.Drawing.Size(203, 111)
        Me.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cloud1.TabIndex = 7
        Me.Cloud1.TabStop = False
        '
        'Player
        '
        Me.Player.Image = Global.Final_Project.My.Resources.Resources.Project_Brick
        Me.Player.Location = New System.Drawing.Point(417, 449)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(71, 100)
        Me.Player.TabIndex = 6
        Me.Player.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox6.Location = New System.Drawing.Point(670, 222)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(202, 60)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox5.Location = New System.Drawing.Point(1137, 314)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(281, 60)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox4.Location = New System.Drawing.Point(1590, 454)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(286, 60)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox3.Location = New System.Drawing.Point(1246, 589)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(281, 60)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox2.Location = New System.Drawing.Point(821, 693)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(337, 60)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Project.My.Resources.Resources.Project_Floor_just_bricks
        Me.PictureBox1.Location = New System.Drawing.Point(28, 695)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(559, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Jumphb1
        '
        Me.Jumphb1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb1.Location = New System.Drawing.Point(89, 656)
        Me.Jumphb1.Name = "Jumphb1"
        Me.Jumphb1.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb1.TabIndex = 8
        Me.Jumphb1.TabStop = False
        '
        'Jumphb2
        '
        Me.Jumphb2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb2.Location = New System.Drawing.Point(866, 656)
        Me.Jumphb2.Name = "Jumphb2"
        Me.Jumphb2.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb2.TabIndex = 9
        Me.Jumphb2.TabStop = False
        '
        'Jumphb3
        '
        Me.Jumphb3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb3.Location = New System.Drawing.Point(1263, 569)
        Me.Jumphb3.Name = "Jumphb3"
        Me.Jumphb3.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb3.TabIndex = 10
        Me.Jumphb3.TabStop = False
        '
        'Jumphb4
        '
        Me.Jumphb4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb4.Location = New System.Drawing.Point(1640, 401)
        Me.Jumphb4.Name = "Jumphb4"
        Me.Jumphb4.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb4.TabIndex = 11
        Me.Jumphb4.TabStop = False
        '
        'Jumphb5
        '
        Me.Jumphb5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb5.Location = New System.Drawing.Point(1148, 296)
        Me.Jumphb5.Name = "Jumphb5"
        Me.Jumphb5.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb5.TabIndex = 12
        Me.Jumphb5.TabStop = False
        '
        'Jumphb6
        '
        Me.Jumphb6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Jumphb6.Location = New System.Drawing.Point(659, 204)
        Me.Jumphb6.Name = "Jumphb6"
        Me.Jumphb6.Size = New System.Drawing.Size(259, 10)
        Me.Jumphb6.TabIndex = 13
        Me.Jumphb6.TabStop = False
        '
        'Floor1L
        '
        Me.Floor1L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor1L.Location = New System.Drawing.Point(12, 695)
        Me.Floor1L.Name = "Floor1L"
        Me.Floor1L.Size = New System.Drawing.Size(10, 60)
        Me.Floor1L.TabIndex = 14
        Me.Floor1L.TabStop = False
        '
        'Floor1R
        '
        Me.Floor1R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor1R.Location = New System.Drawing.Point(593, 693)
        Me.Floor1R.Name = "Floor1R"
        Me.Floor1R.Size = New System.Drawing.Size(10, 60)
        Me.Floor1R.TabIndex = 15
        Me.Floor1R.TabStop = False
        '
        'Floor2L
        '
        Me.Floor2L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor2L.Location = New System.Drawing.Point(821, 627)
        Me.Floor2L.Name = "Floor2L"
        Me.Floor2L.Size = New System.Drawing.Size(10, 60)
        Me.Floor2L.TabIndex = 16
        Me.Floor2L.TabStop = False
        '
        'Floor2R
        '
        Me.Floor2R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor2R.Location = New System.Drawing.Point(1148, 627)
        Me.Floor2R.Name = "Floor2R"
        Me.Floor2R.Size = New System.Drawing.Size(10, 60)
        Me.Floor2R.TabIndex = 17
        Me.Floor2R.TabStop = False
        '
        'Floor6L
        '
        Me.Floor6L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor6L.Location = New System.Drawing.Point(634, 220)
        Me.Floor6L.Name = "Floor6L"
        Me.Floor6L.Size = New System.Drawing.Size(10, 60)
        Me.Floor6L.TabIndex = 18
        Me.Floor6L.TabStop = False
        '
        'Floor6R
        '
        Me.Floor6R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor6R.Location = New System.Drawing.Point(924, 220)
        Me.Floor6R.Name = "Floor6R"
        Me.Floor6R.Size = New System.Drawing.Size(10, 60)
        Me.Floor6R.TabIndex = 19
        Me.Floor6R.TabStop = False
        '
        'Floor5L
        '
        Me.Floor5L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor5L.Location = New System.Drawing.Point(1126, 303)
        Me.Floor5L.Name = "Floor5L"
        Me.Floor5L.Size = New System.Drawing.Size(10, 60)
        Me.Floor5L.TabIndex = 20
        Me.Floor5L.TabStop = False
        '
        'Floor5R
        '
        Me.Floor5R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor5R.Location = New System.Drawing.Point(1439, 312)
        Me.Floor5R.Name = "Floor5R"
        Me.Floor5R.Size = New System.Drawing.Size(10, 60)
        Me.Floor5R.TabIndex = 21
        Me.Floor5R.TabStop = False
        '
        'Floor4L
        '
        Me.Floor4L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor4L.Location = New System.Drawing.Point(1613, 386)
        Me.Floor4L.Name = "Floor4L"
        Me.Floor4L.Size = New System.Drawing.Size(10, 60)
        Me.Floor4L.TabIndex = 22
        Me.Floor4L.TabStop = False
        '
        'Floor4R
        '
        Me.Floor4R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor4R.Location = New System.Drawing.Point(1872, 493)
        Me.Floor4R.Name = "Floor4R"
        Me.Floor4R.Size = New System.Drawing.Size(10, 60)
        Me.Floor4R.TabIndex = 23
        Me.Floor4R.TabStop = False
        '
        'Floor3R
        '
        Me.Floor3R.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor3R.Location = New System.Drawing.Point(1538, 587)
        Me.Floor3R.Name = "Floor3R"
        Me.Floor3R.Size = New System.Drawing.Size(10, 60)
        Me.Floor3R.TabIndex = 24
        Me.Floor3R.TabStop = False
        '
        'Floor3L
        '
        Me.Floor3L.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Floor3L.Location = New System.Drawing.Point(1218, 569)
        Me.Floor3L.Name = "Floor3L"
        Me.Floor3L.Size = New System.Drawing.Size(10, 60)
        Me.Floor3L.TabIndex = 25
        Me.Floor3L.TabStop = False
        '
        'Bottom1
        '
        Me.Bottom1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom1.Location = New System.Drawing.Point(89, 759)
        Me.Bottom1.Name = "Bottom1"
        Me.Bottom1.Size = New System.Drawing.Size(259, 10)
        Me.Bottom1.TabIndex = 26
        Me.Bottom1.TabStop = False
        '
        'Bottom2
        '
        Me.Bottom2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom2.Location = New System.Drawing.Point(849, 759)
        Me.Bottom2.Name = "Bottom2"
        Me.Bottom2.Size = New System.Drawing.Size(259, 10)
        Me.Bottom2.TabIndex = 27
        Me.Bottom2.TabStop = False
        '
        'Bottom3
        '
        Me.Bottom3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom3.Location = New System.Drawing.Point(1263, 656)
        Me.Bottom3.Name = "Bottom3"
        Me.Bottom3.Size = New System.Drawing.Size(259, 10)
        Me.Bottom3.TabIndex = 28
        Me.Bottom3.TabStop = False
        '
        'Bottom4
        '
        Me.Bottom4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom4.Location = New System.Drawing.Point(1622, 539)
        Me.Bottom4.Name = "Bottom4"
        Me.Bottom4.Size = New System.Drawing.Size(259, 10)
        Me.Bottom4.TabIndex = 29
        Me.Bottom4.TabStop = False
        '
        'Bottom5
        '
        Me.Bottom5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom5.Location = New System.Drawing.Point(1148, 386)
        Me.Bottom5.Name = "Bottom5"
        Me.Bottom5.Size = New System.Drawing.Size(259, 10)
        Me.Bottom5.TabIndex = 30
        Me.Bottom5.TabStop = False
        '
        'Bottom6
        '
        Me.Bottom6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bottom6.Location = New System.Drawing.Point(675, 312)
        Me.Bottom6.Name = "Bottom6"
        Me.Bottom6.Size = New System.Drawing.Size(259, 10)
        Me.Bottom6.TabIndex = 31
        Me.Bottom6.TabStop = False
        '
        'dead
        '
        Me.dead.BackColor = System.Drawing.SystemColors.Desktop
        Me.dead.Location = New System.Drawing.Point(79, 832)
        Me.dead.Name = "dead"
        Me.dead.Size = New System.Drawing.Size(803, 54)
        Me.dead.TabIndex = 32
        Me.dead.TabStop = False
        '
        'GameOverBack
        '
        Me.GameOverBack.BackColor = System.Drawing.SystemColors.Desktop
        Me.GameOverBack.Location = New System.Drawing.Point(310, 33)
        Me.GameOverBack.Name = "GameOverBack"
        Me.GameOverBack.Size = New System.Drawing.Size(1380, 157)
        Me.GameOverBack.TabIndex = 33
        Me.GameOverBack.TabStop = False
        '
        'gameOver
        '
        Me.gameOver.AutoSize = True
        Me.gameOver.BackColor = System.Drawing.SystemColors.Desktop
        Me.gameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameOver.ForeColor = System.Drawing.Color.DarkRed
        Me.gameOver.Location = New System.Drawing.Point(729, 57)
        Me.gameOver.Name = "gameOver"
        Me.gameOver.Size = New System.Drawing.Size(540, 108)
        Me.gameOver.TabIndex = 34
        Me.gameOver.Text = "Game Over"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(2014, 908)
        Me.Controls.Add(Me.gameOver)
        Me.Controls.Add(Me.GameOverBack)
        Me.Controls.Add(Me.dead)
        Me.Controls.Add(Me.Bottom6)
        Me.Controls.Add(Me.Bottom5)
        Me.Controls.Add(Me.Bottom4)
        Me.Controls.Add(Me.Bottom3)
        Me.Controls.Add(Me.Bottom2)
        Me.Controls.Add(Me.Bottom1)
        Me.Controls.Add(Me.Floor3L)
        Me.Controls.Add(Me.Floor3R)
        Me.Controls.Add(Me.Floor4R)
        Me.Controls.Add(Me.Floor4L)
        Me.Controls.Add(Me.Floor5R)
        Me.Controls.Add(Me.Floor5L)
        Me.Controls.Add(Me.Floor6R)
        Me.Controls.Add(Me.Floor6L)
        Me.Controls.Add(Me.Floor2R)
        Me.Controls.Add(Me.Floor2L)
        Me.Controls.Add(Me.Floor1R)
        Me.Controls.Add(Me.Floor1L)
        Me.Controls.Add(Me.Jumphb6)
        Me.Controls.Add(Me.Jumphb5)
        Me.Controls.Add(Me.Jumphb4)
        Me.Controls.Add(Me.Jumphb3)
        Me.Controls.Add(Me.Jumphb2)
        Me.Controls.Add(Me.Jumphb1)
        Me.Controls.Add(Me.Cloud1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Cloud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jumphb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor1L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor1R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor2L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor2R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor6L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor6R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor5L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor5R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor4L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor4R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor3R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor3L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameOverBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Cloud1 As PictureBox
    Friend WithEvents Jumphb1 As PictureBox
    Friend WithEvents Jumphb2 As PictureBox
    Friend WithEvents Jumphb3 As PictureBox
    Friend WithEvents Jumphb4 As PictureBox
    Friend WithEvents Jumphb5 As PictureBox
    Friend WithEvents Jumphb6 As PictureBox
    Friend WithEvents Floor1L As PictureBox
    Friend WithEvents Floor1R As PictureBox
    Friend WithEvents Floor2L As PictureBox
    Friend WithEvents Floor2R As PictureBox
    Friend WithEvents Floor6L As PictureBox
    Friend WithEvents Floor6R As PictureBox
    Friend WithEvents Floor5L As PictureBox
    Friend WithEvents Floor5R As PictureBox
    Friend WithEvents Floor4L As PictureBox
    Friend WithEvents Floor4R As PictureBox
    Friend WithEvents Floor3R As PictureBox
    Friend WithEvents Floor3L As PictureBox
    Friend WithEvents Bottom1 As PictureBox
    Friend WithEvents Bottom2 As PictureBox
    Friend WithEvents Bottom3 As PictureBox
    Friend WithEvents Bottom4 As PictureBox
    Friend WithEvents Bottom5 As PictureBox
    Friend WithEvents Bottom6 As PictureBox
    Friend WithEvents dead As PictureBox
    Friend WithEvents GameOverBack As PictureBox
    Friend WithEvents gameOver As Label
End Class
