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
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picMario = New System.Windows.Forms.PictureBox()
        Me.picYoshi = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.picBoard = New System.Windows.Forms.PictureBox()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRollDice
        '
        Me.btnRollDice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollDice.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnRollDice.Location = New System.Drawing.Point(541, 302)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(97, 56)
        Me.btnRollDice.TabIndex = 1
        Me.btnRollDice.Text = "Roll Dice (p.1)"
        Me.btnRollDice.UseVisualStyleBackColor = False
        '
        'TitleProgram
        '
        Me.TitleProgram.BackColor = System.Drawing.Color.Transparent
        Me.TitleProgram.Font = New System.Drawing.Font("Snap ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TitleProgram.Location = New System.Drawing.Point(314, 10)
        Me.TitleProgram.Name = "TitleProgram"
        Me.TitleProgram.Size = New System.Drawing.Size(579, 80)
        Me.TitleProgram.TabIndex = 1
        Me.TitleProgram.Text = "Snakes and Ladders"
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
        Me.btnRollDice2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRollDice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRollDice2.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnRollDice2.Location = New System.Drawing.Point(714, 302)
        Me.btnRollDice2.Name = "btnRollDice2"
        Me.btnRollDice2.Size = New System.Drawing.Size(97, 56)
        Me.btnRollDice2.TabIndex = 34
        Me.btnRollDice2.Text = "Roll Dice (p.2)"
        Me.btnRollDice2.UseVisualStyleBackColor = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnRestart.Location = New System.Drawing.Point(541, 393)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(97, 56)
        Me.btnRestart.TabIndex = 38
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Plum
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnExit.Location = New System.Drawing.Point(714, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 56)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picMario
        '
        Me.picMario.BackgroundImage = Global.SnakenLadderGroup3.My.Resources.Resources.small_super_mario_game_character_png_29
        Me.picMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMario.Location = New System.Drawing.Point(39, 393)
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
        Me.picYoshi.Location = New System.Drawing.Point(39, 424)
        Me.picYoshi.Name = "picYoshi"
        Me.picYoshi.Size = New System.Drawing.Size(30, 30)
        Me.picYoshi.TabIndex = 36
        Me.picYoshi.TabStop = False
        Me.picYoshi.Visible = False
        '
        'picDie2
        '
        Me.picDie2.BackColor = System.Drawing.Color.Cornsilk
        Me.picDie2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDie2.Location = New System.Drawing.Point(714, 173)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(97, 97)
        Me.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDie2.TabIndex = 35
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.BackColor = System.Drawing.Color.Cornsilk
        Me.picDie1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDie1.Location = New System.Drawing.Point(541, 173)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(97, 97)
        Me.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDie1.TabIndex = 2
        Me.picDie1.TabStop = False
        '
        'picBoard
        '
        Me.picBoard.Image = Global.SnakenLadderGroup3.My.Resources.Resources.snakes_and_ladders_board
        Me.picBoard.Location = New System.Drawing.Point(20, 93)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(439, 368)
        Me.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoard.TabIndex = 0
        Me.picBoard.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(896, 486)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.picMario)
        Me.Controls.Add(Me.picYoshi)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.btnRollDice2)
        Me.Controls.Add(Me.TitleProgram)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.picBoard)
        Me.Name = "Form1"
        Me.Text = "Snake and Ladder"
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBoard As PictureBox

    Friend WithEvents TitleProgram As Label

    Friend WithEvents btnRollDice As Button
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents btnRollDice2 As Button
    Friend WithEvents picYoshi As PictureBox
    Friend WithEvents picMario As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
End Class
