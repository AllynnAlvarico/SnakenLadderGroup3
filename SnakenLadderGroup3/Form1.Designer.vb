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
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.TitleProgram = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picMario = New System.Windows.Forms.PictureBox()
        Me.picYoshi = New System.Windows.Forms.PictureBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayer1
        '
        Me.btnPlayer1.BackColor = System.Drawing.Color.Khaki
        Me.btnPlayer1.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlayer1.Location = New System.Drawing.Point(604, 332)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(97, 56)
        Me.btnPlayer1.TabIndex = 1
        Me.btnPlayer1.Text = "Roll Dice"
        Me.btnPlayer1.UseVisualStyleBackColor = False
        '
        'TitleProgram
        '
        Me.TitleProgram.BackColor = System.Drawing.Color.Transparent
        Me.TitleProgram.Font = New System.Drawing.Font("Mistral", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TitleProgram.Location = New System.Drawing.Point(572, 9)
        Me.TitleProgram.Name = "TitleProgram"
        Me.TitleProgram.Size = New System.Drawing.Size(324, 58)
        Me.TitleProgram.TabIndex = 1
        Me.TitleProgram.Text = "Snake and Ladder"
        Me.TitleProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btnPlayer2
        '
        Me.btnPlayer2.BackColor = System.Drawing.Color.Khaki
        Me.btnPlayer2.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlayer2.Location = New System.Drawing.Point(734, 332)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(97, 56)
        Me.btnPlayer2.TabIndex = 34
        Me.btnPlayer2.Text = "Roll Dice"
        Me.btnPlayer2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mistral", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(600, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "- Player 1 -"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Mistral", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(734, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "- Player 2 -"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPlayer2
        '
        Me.picPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer2.Image = Global.SnakenLadderGroup3.My.Resources.Resources.img_chara_04_low
        Me.picPlayer2.Location = New System.Drawing.Point(738, 408)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(80, 64)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer2.TabIndex = 39
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1.Image = Global.SnakenLadderGroup3.My.Resources.Resources.small_super_mario_game_character_png_29
        Me.picPlayer1.Location = New System.Drawing.Point(624, 408)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(66, 64)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer1.TabIndex = 38
        Me.picPlayer1.TabStop = False
        '
        'picDie2
        '
        Me.picDie2.BackColor = System.Drawing.Color.White
        Me.picDie2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDie2.Location = New System.Drawing.Point(734, 181)
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
        Me.picDie1.Location = New System.Drawing.Point(603, 181)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(97, 97)
        Me.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDie1.TabIndex = 2
        Me.picDie1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnakenLadderGroup3.My.Resources.Resources.snakes_and_ladders_board
        Me.PictureBox1.Location = New System.Drawing.Point(20, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'picMario
        '
        Me.picMario.BackColor = System.Drawing.Color.White
        Me.picMario.Image = Global.SnakenLadderGroup3.My.Resources.Resources.small_super_mario_game_character_png_29
        Me.picMario.Location = New System.Drawing.Point(39, 427)
        Me.picMario.Name = "picMario"
        Me.picMario.Size = New System.Drawing.Size(36, 29)
        Me.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMario.TabIndex = 40
        Me.picMario.TabStop = False
        Me.picMario.Visible = False
        '
        'picYoshi
        '
        Me.picYoshi.BackColor = System.Drawing.Color.White
        Me.picYoshi.Image = Global.SnakenLadderGroup3.My.Resources.Resources.img_chara_04_low
        Me.picYoshi.Location = New System.Drawing.Point(39, 391)
        Me.picYoshi.Name = "picYoshi"
        Me.picYoshi.Size = New System.Drawing.Size(35, 30)
        Me.picYoshi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYoshi.TabIndex = 46
        Me.picYoshi.TabStop = False
        Me.picYoshi.Visible = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Player1 Counter")
        Me.ImageList2.Images.SetKeyName(1, "Player2 counter")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(908, 661)
        Me.Controls.Add(Me.picYoshi)
        Me.Controls.Add(Me.picMario)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.TitleProgram)
        Me.Controls.Add(Me.picDie1)
        Me.Controls.Add(Me.btnPlayer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Snakes and Ladders"
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYoshi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox

    Friend WithEvents TitleProgram As Label

    Friend WithEvents btnPlayer1 As Button
    Friend WithEvents picDie1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents picDie2 As PictureBox
    Friend WithEvents btnPlayer2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picMario As PictureBox
    Friend WithEvents picYoshi As PictureBox
    Friend WithEvents ImageList2 As ImageList
End Class
