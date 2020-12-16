﻿Public Class Form1

    '   Dim gameLoop As Boolean = True '
    '  Dim moveRight As Boolean = False
    '  Dim moveLeft As Boolean = False
    ' Dim Jump As Boolean = False       'these 4 boolean vars arent being used, could get rid of them but just wanna make sure everything is still good
    Dim Xspeed As Integer = 0   ' used to move everything except the player in the x axes
    Dim Yspeed As Integer = 0   ' used to move the player in the y axis
    Dim Gravity As Integer = 1
    Dim total As Integer = 0

    Dim jumpHB() As PictureBox  'these are the array declerations for the jump hit boxes which are the grey boxes above each platform, will be invisible in final game
    Dim Floors() As PictureBox  'used for all the surfaces that the player can stand on
    Dim Bottoms() As PictureBox 'used to stop the player from going through the bottom of the floors
    'Dim death() As PictureBox   ' used for anything that kills the player

    Dim forwardsprite As Boolean = False
    Dim forward As Boolean = False
    Dim back As Boolean = False
    Dim backsprite As Boolean = False
    Dim hurt() As PictureBox
    Dim point() As PictureBox ' array for coins 


    Public Sub Main()   'dont know why this works but it does, but fill the arrays in here with pictureboxes
        jumpHB = New PictureBox() {Jumphb1, Jumphb2, Jumphb3, Jumphb4, Jumphb5, Jumphb6, Jumphb7, jumphb8, jumphb9, jumphb10}
        Floors = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10}
        Bottoms = New PictureBox() {Bottom1, Bottom2, Bottom3, Bottom4, Bottom5, Bottom6, Bottom7, Bottom8, bottom9, bottom10}
        ' death = New PictureBox() {dead}
        hurt = New PictureBox() {spike1, spike2, dead}
        point = New PictureBox() {Coin1, Coin2, Coin3, Coin4, Coin5, Coin6, Coin7}
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.FillRectangle(New SolidBrush(Color.DarkOliveGreen), New Rectangle(0, 730, 10000, 1000))  ' paints the background  on the bottom green for the grass 
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()  'allows the load to use the arrays i guess, idk

        For i = 0 To Bottoms.Length - 1  'sets a uniforms height for all the bottoms hitboxes in the bottoms array
            Bottoms(i).Height = 20
        Next

        Timer3.Enabled = False
        player1.Hide()
        player2.Hide()
        player3.Hide()
        player4.Hide()


        gameOver.Visible = False        'these three lines are for the game over sign. on load it makes them invisible
        GameOverBack.Visible = False
        dead.Visible = False        'makes the hitbox invisible to, only visible for testing. if you need to see it just comment this line out

        'jump hitboxes locations ontop of the floors 
        For i = 0 To jumpHB.Length - 1  'loops for every picture box in the floors array and sets the jump hit boxes to the same x - 10 (slightly above the floor) and sets the width as long as the floor
            jumpHB(i).Location = Floors(i).Location
            jumpHB(i).Top -= 10
            jumpHB(i).Width = Floors(i).Width
        Next
        'for the bottom hitboxes
        For i = 0 To Bottoms.Length - 1  ' same idea as the loop above but for the bottoms hitboxes
            Bottoms(i).Location = Floors(i).Location
            Bottoms(i).Top += Floors(i).Height
            Bottoms(i).Width = Floors(i).Width
        Next


    End Sub





    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If e.KeyCode = Keys.D Then  ' if D is pressed then the x speed = -5 so that means that the floors and everything attatched to the floors (jump and bottom hitboxes) will move to the left
            Xspeed = -5
            back = True
            forward = False
            Timer3.Enabled = True
        End If

        If e.KeyCode = Keys.A Then  ' if A is pressed then the x speed = 5 so that means that the floors and everything attatched to the floors (jump and bottom hitboxes) will move to the Right
            Xspeed = 5
            back = False
            forward = True
            Timer4.Enabled = True
        End If

        For i = 0 To Floors.Length - 1                                  ' this checks to see if the player is colliding with and jump hit boxes in the jumpHB array
            If Player.Bounds.IntersectsWith(jumpHB(i).Bounds) Then
                If e.KeyCode = Keys.W Then                              ' if the player is intersecting with a jump hitbox then it checks to see if the user is pressing W to jump
                    Player.Top -= 5
                    Yspeed = -20                                        ' sets the y speed to - 20 which is the jump
                End If
            End If
        Next

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.D Then      ' if a keys is released then the x speed = 0
            Xspeed = 0
            Timer3.Enabled = False
        End If
        If e.KeyCode = Keys.A Then      ' if a keys is released then the x speed = 0
            Xspeed = 0
            Timer4.Enabled = False
        End If
    End Sub

    Function coins() As Nullable ' handles interactions with coins 
        For i = 0 To point.Length - 1
            If Player.Bounds.IntersectsWith(point(i).Bounds) Then
                total += 1
                point(i).Hide()
                TextBox1.Text = “Total points: “ + CStr(total)
            End If

            If (point(i).Visible = False) Then
                point(i).Location = TextBox1.Location
            End If
        Next
        If total = 7 Then
            Gate.Top -= 10
        End If
    End Function
    Function MoveLR() As Nullable
        'add all picture boxes to be moved here
        For i = 0 To Floors.Length - 1  'so everything that needs to move with the floors needs to be made into an array and added here
            jumpHB(i).Left += Xspeed    ' you set the location in the form_load function and then this moves them all as one 
            Floors(i).Left += Xspeed
            Bottoms(i).Left += Xspeed
        Next
        For i = 0 To hurt.Length - 2
            hurt(i).Left += Xspeed
        Next
        For i = 0 To point.Length - 1
            point(i).Left += Xspeed
        Next
        Gate.Left += Xspeed
        Cloud1.Left += Xspeed       ' just an experiment for to see if we could add clouds
    End Function


    Function collisionPlayer() As Nullable      ' function that deals with all the collisions 

        For i = 0 To Floors.Length - 1                                  'if the player intersects with the floors then it is just pushed up to the y location of that floor - the player height and turns off gravity and makes the y velocity 0
            If Player.Bounds.IntersectsWith(Floors(i).Bounds) Then
                Player.Top = Floors(i).Location.Y - Player.Height
                Yspeed = 0
                Gravity = 0
            Else
                Gravity = 1                                             ' if not intersecting with floor then gravity is on
            End If
        Next

        For i = 0 To Floors.Length - 1      ' to help with the sticking 
            If Player.Bounds.IntersectsWith(Bottoms(i).Bounds) Then 'checks all hitboxes in the bottoms array to see if they are intersecting. if they are then the player y +3 to push the player oput of the hit box and y speed = 0 so the player stops miving upwards
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

        'For i = 0 To death.Length - 1                                   'checks to see if the polayer is colliding with any death hitboxes, if the player is then the game over things become visible
        '    If Player.Bounds.IntersectsWith(death(i).Bounds) Then
        '        gameOver.Visible = True
        '        GameOverBack.Visible = True
        '    End If
        'Next


        If Player.Bounds.IntersectsWith(Gate.Bounds) Then   'detects of the player is hitting a keyed gate
            Xspeed = 6
        End If

        For i = 0 To hurt.Length - 1            'spkie detection
            If Player.Bounds.IntersectsWith(hurt(i).Bounds) Then
                gameOver.Visible = True
                GameOverBack.Visible = True
                Player.Hide()
            End If
        Next

    End Function

    Function Jump() As Nullable ' used to make the player jump
        Yspeed += Gravity       'y speed is always getting accellerated downward by 1 every tick
        Player.Top += Yspeed    'y speed is always being added to played y locaiton every tick
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick   ' every timer tick all collisions are checked and the objects are moved 
        MoveLR()
        collisionPlayer()
        coins()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick   'slightly slower tick to make the gravity a little bit slower. cant use deciaml values for x and y locations as far as i know
        Jump()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If back = True Then
            If forwardsprite = True Then
                Player.Image = player1.Image
                forwardsprite = False

            ElseIf forwardsprite = False Then

                Player.Image = player4.Image
                forwardsprite = True
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If forward = True Then
            If backsprite = True Then
                Player.Image = player3.Image
                backsprite = False

            ElseIf backsprite = False Then
                Player.Image = player2.Image
                backsprite = True
            End If
        End If
    End Sub
End Class