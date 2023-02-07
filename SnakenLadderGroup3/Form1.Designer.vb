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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.TitleProgram = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRollDice2 = New System.Windows.Forms.Button()
        Me.picMario = New System.Windows.Forms.PictureBox()
        Me.picYoshi = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(490, 368)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(97, 56)
        Me.btnRollDice.TabIndex = 1
        Me.btnRollDice.Text = "Roll Dice (p.1)"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'TitleProgram
        '
        Me.TitleProgram.BackColor = System.Drawing.Color.Transparent
        Me.TitleProgram.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgram.Location = New System.Drawing.Point(20, 9)
        Me.TitleProgram.Name = "TitleProgram"
        Me.TitleProgram.Size = New System.Drawing.Size(248, 44)
        Me.TitleProgram.TabIndex = 1
        Me.TitleProgram.Text = "Snake and Ladder"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "dice1.JPG")
        Me.ImageList1.Images.SetKeyName(1, "dice2.JPG")
        Me.ImageList1.Images.SetKeyName(2, "dice3.JPG")
        Me.ImageList1.Images.SetKeyName(3, "dice4.JPG")
        Me.ImageList1.Images.SetKeyName(4, "dice5.JPG")
        Me.ImageList1.Images.SetKeyName(5, "dice6.JPG")
        '
        'btnRollDice2
        '
        Me.btnRollDice2.Location = New System.Drawing.Point(604, 368)
        Me.btnRollDice2.Name = "btnRollDice2"
        Me.btnRollDice2.Size = New System.Drawing.Size(97, 56)
        Me.btnRollDice2.TabIndex = 34
        Me.btnRollDice2.Text = "Roll Dice (p.2)"
        Me.btnRollDice2.UseVisualStyleBackColor = True
        '
        'picMario
        '
        Me.picMario.BackgroundImage = Global.SnakenLadderGroup3.My.Resources.Resources.small_super_mario_game_character_png_29
        Me.picMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMario.Location = New System.Drawing.Point(39, 390)
        Me.picMario.Name = "picMario"
        Me.picMario.Size = New System.Drawing.Size(30, 30)
        Me.picMario.TabIndex = 37
        Me.picMario.TabStop = False
        Me.picMario.Visible = False
        '
        'picYoshi
        '
        Me.picYoshi.BackgroundImage = Global.SnakenLadderGroup3.My.Resources.Resources.pngdb_yoshi_image_super_mario_world_2_yoshis_island_new_bros_u_story_png_NpgibXJyGzyzcUtH3QHZRbeZx_t
        Me.picYoshi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picYoshi.Location = New System.Drawing.Point(39, 426)
        Me.picYoshi.Name = "picYoshi"
        Me.picYoshi.Size = New System.Drawing.Size(30, 30)
        Me.picYoshi.TabIndex = 36
        Me.picYoshi.TabStop = False
        Me.picYoshi.Visible = False
        '
        'picDie2
        '
        Me.picDie2.BackColor = System.Drawing.Color.White
        Me.picDie2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDie2.Location = New System.Drawing.Point(604, 248)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(97, 97)
        Me.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDie2.TabIndex = 35
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.BackColor = System.Drawing.Color.White
        Me.picDie1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDie1.Location = New System.Drawing.Point(490, 248)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(97, 97)
        Me.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDie1.TabIndex = 2
        Me.picDie1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnakenLadderGroup3.My.Resources.Resources.snakes_and_ladders_board
        Me.PictureBox1.Location = New System.Drawing.Point(20, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(439, 368)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 661)
        Me.Controls.Add(Me.picMario)
        Me.Controls.Add(Me.picYoshi)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.btnRollDice2)
        Me.Controls.Add(Me.TitleProgram)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Snake and Ladder"
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox

    Friend WithEvents TitleProgram As Label

    Friend WithEvents btnRollDice As Button
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents btnRollDice2 As Button
    Friend WithEvents picYoshi As PictureBox
    Friend WithEvents picMario As PictureBox
End Class
