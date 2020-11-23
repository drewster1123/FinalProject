Public Class Form1

    Dim gameLoop As Boolean = True
    Dim moveRight As Boolean = False
    Dim moveLeft As Boolean = False
    Dim Jump As Boolean = False
    Dim Xspeed As Integer = 0
    Dim Yspeed As Integer = 0
    Dim Gravity As Integer = 1



    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New SolidBrush(Color.DarkOliveGreen), New Rectangle(0, 830, 10000, 1000))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Jumphb1.Location = PictureBox1.Location
        Jumphb1.Top -= 10
        Jumphb1.Width = PictureBox1.Width


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            Xspeed = -5
        End If
        If e.KeyCode = Keys.A Then
            Xspeed = 5
        End If

        If Player.Bounds.IntersectsWith(Jumphb1.Bounds) Then
            If e.KeyCode = Keys.W Then
                Yspeed = -20
            End If

        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.D Then
            Xspeed = 0
        End If
        If e.KeyCode = Keys.A Then
            Xspeed = 0
        End If



    End Sub


    Function MoveLR() As Nullable
        'add all picture boxes to be moved here
        PictureBox1.Left += Xspeed
        Jumphb1.Left += Xspeed
        PictureBox2.Left += Xspeed
        PictureBox3.Left += Xspeed
        PictureBox4.Left += Xspeed
        PictureBox5.Left += Xspeed
        PictureBox6.Left += Xspeed
        Cloud1.Left += Xspeed
    End Function

    Function jumpPlayer() As Nullable



    End Function

    Function collisionPlayer() As Nullable
        If Player.Bounds.IntersectsWith(PictureBox1.Bounds) Or Player.Bounds.IntersectsWith(PictureBox2.Bounds) Or Player.Bounds.IntersectsWith(PictureBox3.Bounds) Or Player.Bounds.IntersectsWith(PictureBox4.Bounds) Or Player.Bounds.IntersectsWith(PictureBox5.Bounds) Or Player.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Player.Top += -1
            Yspeed = 0
            Gravity = 0
        Else
            Gravity = 1
        End If

    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveLR()
        collisionPlayer()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Yspeed += Gravity
        Player.Top += Yspeed
    End Sub


End Class