Public Class Form1

    Dim gameLoop As Boolean = True
    Dim moveRight As Boolean = False
    Dim moveLeft As Boolean = False
    Dim Jump As Boolean = False
    Dim Xspeed As Integer = 0
    Dim Yspeed As Integer = 0
    Dim Gravity As Integer = 1

    Dim jumpHB() As PictureBox
    Dim Floors() As PictureBox
    Dim floorsidesL() As PictureBox
    Dim floorsidesR() As PictureBox
    Dim Bottoms() As PictureBox
    Dim death() As PictureBox



    Public Sub Main()
        jumpHB = New PictureBox() {Jumphb1, Jumphb2, Jumphb3, Jumphb4, Jumphb5, Jumphb6}
        Floors = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        floorsidesL = New PictureBox() {Floor1L, Floor2L, Floor3L, Floor4L, Floor5L, Floor6L}
        floorsidesR = New PictureBox() {Floor1R, Floor2R, Floor3R, Floor4R, Floor5R, Floor6R}
        Bottoms = New PictureBox() {Bottom1, Bottom2, Bottom3, Bottom4, Bottom5, Bottom6}
        death = New PictureBox() {dead}
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New SolidBrush(Color.DarkOliveGreen), New Rectangle(0, 830, 10000, 1000))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()

        gameOver.Visible = False
        GameOverBack.Visible = False
        dead.Visible = False


        'jump hitboxes locations ontop of the floors 
        For i = 0 To Floors.Length - 1
            jumpHB(i).Location = Floors(i).Location
            jumpHB(i).Top -= 10
            jumpHB(i).Width = Floors(i).Width
        Next
        'for left siode
        For i = 0 To Floors.Length - 1
            floorsidesL(i).Location = Floors(i).Location
            floorsidesL(i).Left -= 10
            floorsidesL(i).Height = Floors(i).Height
        Next
        'for right side 
        For i = 0 To Floors.Length - 1
            floorsidesR(i).Location = Floors(i).Location
            floorsidesR(i).Left += Floors(i).Width
            floorsidesR(i).Height = Floors(i).Height
        Next
        'for the bottom hitboxes
        For i = 0 To Floors.Length - 1
            Bottoms(i).Location = Floors(i).Location
            Bottoms(i).Top += Floors(i).Height
            Bottoms(i).Width = Floors(i).Width
        Next

        For i = 0 To Floors.Length - 1
            Bottoms(i).Height = 20
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        For i = 0 To floorsidesL.Length - 1
            If Player.Bounds.IntersectsWith(floorsidesL(i).Bounds) Then
                Xspeed = 5
            Else
                If e.KeyCode = Keys.D Then
                    Xspeed = -5
                End If
            End If
        Next

        For i = 0 To floorsidesR.Length - 1
            If Player.Bounds.IntersectsWith(floorsidesR(i).Bounds) Then
                Xspeed = -5
            Else
                If e.KeyCode = Keys.A Then
                    Xspeed = 5
                End If
            End If
        Next

        For i = 0 To Floors.Length - 1                                  ' this checks to see if the player is colliding with and jump hit boxes in the jumpHB array
            If Player.Bounds.IntersectsWith(jumpHB(i).Bounds) Then
                If e.KeyCode = Keys.W Then
                    Yspeed = -20
                End If
            End If
        Next





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
        For i = 0 To Floors.Length - 1
            jumpHB(i).Left += Xspeed
            Floors(i).Left += Xspeed
            floorsidesL(i).Left += Xspeed
            floorsidesR(i).Left += Xspeed
            Bottoms(i).Left += Xspeed
        Next

        Cloud1.Left += Xspeed
    End Function

    Function jumpPlayer() As Nullable



    End Function

    Function collisionPlayer() As Nullable

        For i = 0 To Floors.Length - 1
            If Player.Bounds.IntersectsWith(Floors(i).Bounds) Then
                Player.Top = Floors(i).Location.Y - Player.Height
                Yspeed = 0
                Gravity = 0
            Else
                Gravity = 1
            End If
        Next

        For i = 0 To Floors.Length - 1      '' to help with the sticking 
            If Player.Bounds.IntersectsWith(Bottoms(i).Bounds) Then
                Yspeed = 0
                Player.Top += 3
            End If
        Next

        'For i = 0 To Floors.Length - 1
        '    If Player.Bounds.IntersectsWith(floorsidesL(i).Bounds) Then ''' the sides are fucked rn but ill fix them later
        '        Xspeed += 5
        '    Else
        '    End If
        'Next

        'For i = 0 To Floors.Length - 1
        '    If Player.Bounds.IntersectsWith(floorsidesR(i).Bounds) Then
        '        Xspeed += -5
        '    End If
        'Next
        For i = 0 To death.Length - 1
            If Player.Bounds.IntersectsWith(death(i).Bounds) Then
                gameOver.Visible = True
                GameOverBack.Visible = True
            End If
        Next


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