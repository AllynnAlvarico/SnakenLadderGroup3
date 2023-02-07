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
        Me.lblBlock1 = New System.Windows.Forms.Label()
        Me.lblBlock2 = New System.Windows.Forms.Label()
        Me.lblBlock3 = New System.Windows.Forms.Label()
        Me.lblBlock4 = New System.Windows.Forms.Label()
        Me.lblBlock5 = New System.Windows.Forms.Label()
        Me.lblBlock6 = New System.Windows.Forms.Label()
        Me.lblBlock12 = New System.Windows.Forms.Label()
        Me.lblBlock11 = New System.Windows.Forms.Label()
        Me.lblBlock10 = New System.Windows.Forms.Label()
        Me.lblBlock9 = New System.Windows.Forms.Label()
        Me.lblBlock8 = New System.Windows.Forms.Label()
        Me.lblBlock7 = New System.Windows.Forms.Label()
        Me.lblBlock18 = New System.Windows.Forms.Label()
        Me.lblBlock17 = New System.Windows.Forms.Label()
        Me.lblBlock16 = New System.Windows.Forms.Label()
        Me.lblBlock15 = New System.Windows.Forms.Label()
        Me.lblBlock14 = New System.Windows.Forms.Label()
        Me.lblBlock13 = New System.Windows.Forms.Label()
        Me.lblBlock19 = New System.Windows.Forms.Label()
        Me.lblBlock30 = New System.Windows.Forms.Label()
        Me.lblBlock20 = New System.Windows.Forms.Label()
        Me.lblBlock21 = New System.Windows.Forms.Label()
        Me.lblBlock22 = New System.Windows.Forms.Label()
        Me.lblBlock23 = New System.Windows.Forms.Label()
        Me.lblBlock24 = New System.Windows.Forms.Label()
        Me.lblBlock29 = New System.Windows.Forms.Label()
        Me.lblBlock28 = New System.Windows.Forms.Label()
        Me.lblBlock27 = New System.Windows.Forms.Label()
        Me.lblBlock26 = New System.Windows.Forms.Label()
        Me.lblBlock25 = New System.Windows.Forms.Label()
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
        Me.TitleProgram.Location = New System.Drawing.Point(551, 9)
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
        'lblBlock1
        '
        Me.lblBlock1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock1.Location = New System.Drawing.Point(64, 408)
        Me.lblBlock1.Name = "lblBlock1"
        Me.lblBlock1.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock1.TabIndex = 4
        Me.lblBlock1.Visible = False
        '
        'lblBlock2
        '
        Me.lblBlock2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock2.Location = New System.Drawing.Point(140, 408)
        Me.lblBlock2.Name = "lblBlock2"
        Me.lblBlock2.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock2.TabIndex = 5
        Me.lblBlock2.Visible = False
        '
        'lblBlock3
        '
        Me.lblBlock3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock3.Location = New System.Drawing.Point(207, 408)
        Me.lblBlock3.Name = "lblBlock3"
        Me.lblBlock3.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock3.TabIndex = 6
        Me.lblBlock3.Visible = False
        '
        'lblBlock4
        '
        Me.lblBlock4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock4.Location = New System.Drawing.Point(286, 408)
        Me.lblBlock4.Name = "lblBlock4"
        Me.lblBlock4.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock4.TabIndex = 7
        Me.lblBlock4.Visible = False
        '
        'lblBlock5
        '
        Me.lblBlock5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock5.Location = New System.Drawing.Point(354, 408)
        Me.lblBlock5.Name = "lblBlock5"
        Me.lblBlock5.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock5.TabIndex = 8
        Me.lblBlock5.Visible = False
        '
        'lblBlock6
        '
        Me.lblBlock6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock6.Location = New System.Drawing.Point(432, 408)
        Me.lblBlock6.Name = "lblBlock6"
        Me.lblBlock6.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock6.TabIndex = 9
        Me.lblBlock6.Visible = False
        '
        'lblBlock12
        '
        Me.lblBlock12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock12.Location = New System.Drawing.Point(64, 332)
        Me.lblBlock12.Name = "lblBlock12"
        Me.lblBlock12.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock12.TabIndex = 10
        Me.lblBlock12.Visible = False
        '
        'lblBlock11
        '
        Me.lblBlock11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock11.Location = New System.Drawing.Point(140, 332)
        Me.lblBlock11.Name = "lblBlock11"
        Me.lblBlock11.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock11.TabIndex = 11
        Me.lblBlock11.Visible = False
        '
        'lblBlock10
        '
        Me.lblBlock10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock10.Location = New System.Drawing.Point(207, 332)
        Me.lblBlock10.Name = "lblBlock10"
        Me.lblBlock10.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock10.TabIndex = 12
        Me.lblBlock10.Visible = False
        '
        'lblBlock9
        '
        Me.lblBlock9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock9.Location = New System.Drawing.Point(286, 332)
        Me.lblBlock9.Name = "lblBlock9"
        Me.lblBlock9.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock9.TabIndex = 13
        Me.lblBlock9.Visible = False
        '
        'lblBlock8
        '
        Me.lblBlock8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock8.Location = New System.Drawing.Point(354, 332)
        Me.lblBlock8.Name = "lblBlock8"
        Me.lblBlock8.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock8.TabIndex = 14
        Me.lblBlock8.Visible = False
        '
        'lblBlock7
        '
        Me.lblBlock7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock7.Location = New System.Drawing.Point(432, 332)
        Me.lblBlock7.Name = "lblBlock7"
        Me.lblBlock7.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock7.TabIndex = 15
        Me.lblBlock7.Visible = False
        '
        'lblBlock18
        '
        Me.lblBlock18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock18.Location = New System.Drawing.Point(432, 248)
        Me.lblBlock18.Name = "lblBlock18"
        Me.lblBlock18.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock18.TabIndex = 16
        Me.lblBlock18.Visible = False
        '
        'lblBlock17
        '
        Me.lblBlock17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock17.Location = New System.Drawing.Point(354, 248)
        Me.lblBlock17.Name = "lblBlock17"
        Me.lblBlock17.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock17.TabIndex = 17
        Me.lblBlock17.Visible = False
        '
        'lblBlock16
        '
        Me.lblBlock16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock16.Location = New System.Drawing.Point(286, 248)
        Me.lblBlock16.Name = "lblBlock16"
        Me.lblBlock16.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock16.TabIndex = 18
        Me.lblBlock16.Visible = False
        '
        'lblBlock15
        '
        Me.lblBlock15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock15.Location = New System.Drawing.Point(207, 248)
        Me.lblBlock15.Name = "lblBlock15"
        Me.lblBlock15.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock15.TabIndex = 19
        Me.lblBlock15.Visible = False
        '
        'lblBlock14
        '
        Me.lblBlock14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock14.Location = New System.Drawing.Point(140, 248)
        Me.lblBlock14.Name = "lblBlock14"
        Me.lblBlock14.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock14.TabIndex = 20
        Me.lblBlock14.Visible = False
        '
        'lblBlock13
        '
        Me.lblBlock13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock13.Location = New System.Drawing.Point(64, 248)
        Me.lblBlock13.Name = "lblBlock13"
        Me.lblBlock13.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock13.TabIndex = 21
        Me.lblBlock13.Visible = False
        '
        'lblBlock19
        '
        Me.lblBlock19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock19.Location = New System.Drawing.Point(432, 162)
        Me.lblBlock19.Name = "lblBlock19"
        Me.lblBlock19.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock19.TabIndex = 22
        Me.lblBlock19.Visible = False
        '
        'lblBlock30
        '
        Me.lblBlock30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock30.Location = New System.Drawing.Point(432, 85)
        Me.lblBlock30.Name = "lblBlock30"
        Me.lblBlock30.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock30.TabIndex = 23
        Me.lblBlock30.Visible = False
        '
        'lblBlock20
        '
        Me.lblBlock20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock20.Location = New System.Drawing.Point(354, 162)
        Me.lblBlock20.Name = "lblBlock20"
        Me.lblBlock20.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock20.TabIndex = 24
        Me.lblBlock20.Visible = False
        '
        'lblBlock21
        '
        Me.lblBlock21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock21.Location = New System.Drawing.Point(286, 162)
        Me.lblBlock21.Name = "lblBlock21"
        Me.lblBlock21.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock21.TabIndex = 25
        Me.lblBlock21.Visible = False
        '
        'lblBlock22
        '
        Me.lblBlock22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock22.Location = New System.Drawing.Point(207, 162)
        Me.lblBlock22.Name = "lblBlock22"
        Me.lblBlock22.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock22.TabIndex = 26
        Me.lblBlock22.Visible = False
        '
        'lblBlock23
        '
        Me.lblBlock23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock23.Location = New System.Drawing.Point(140, 162)
        Me.lblBlock23.Name = "lblBlock23"
        Me.lblBlock23.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock23.TabIndex = 27
        Me.lblBlock23.Visible = False
        '
        'lblBlock24
        '
        Me.lblBlock24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock24.Location = New System.Drawing.Point(64, 162)
        Me.lblBlock24.Name = "lblBlock24"
        Me.lblBlock24.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock24.TabIndex = 28
        Me.lblBlock24.Visible = False
        '
        'lblBlock29
        '
        Me.lblBlock29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock29.Location = New System.Drawing.Point(354, 85)
        Me.lblBlock29.Name = "lblBlock29"
        Me.lblBlock29.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock29.TabIndex = 29
        Me.lblBlock29.Visible = False
        '
        'lblBlock28
        '
        Me.lblBlock28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock28.Location = New System.Drawing.Point(286, 85)
        Me.lblBlock28.Name = "lblBlock28"
        Me.lblBlock28.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock28.TabIndex = 30
        Me.lblBlock28.Visible = False
        '
        'lblBlock27
        '
        Me.lblBlock27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock27.Location = New System.Drawing.Point(207, 85)
        Me.lblBlock27.Name = "lblBlock27"
        Me.lblBlock27.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock27.TabIndex = 31
        Me.lblBlock27.Visible = False
        '
        'lblBlock26
        '
        Me.lblBlock26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock26.Location = New System.Drawing.Point(140, 85)
        Me.lblBlock26.Name = "lblBlock26"
        Me.lblBlock26.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock26.TabIndex = 32
        Me.lblBlock26.Visible = False
        '
        'lblBlock25
        '
        Me.lblBlock25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBlock25.Location = New System.Drawing.Point(64, 85)
        Me.lblBlock25.Name = "lblBlock25"
        Me.lblBlock25.Size = New System.Drawing.Size(30, 30)
        Me.lblBlock25.TabIndex = 33
        Me.lblBlock25.Visible = False
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
        Me.picMario.Location = New System.Drawing.Point(39, 426)
        Me.picMario.Name = "picMario"
        Me.picMario.Size = New System.Drawing.Size(36, 29)
        Me.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMario.TabIndex = 40
        Me.picMario.TabStop = False
        '
        'picYoshi
        '
        Me.picYoshi.BackColor = System.Drawing.Color.White
        Me.picYoshi.Image = Global.SnakenLadderGroup3.My.Resources.Resources.img_chara_04_low
        Me.picYoshi.Location = New System.Drawing.Point(39, 390)
        Me.picYoshi.Name = "picYoshi"
        Me.picYoshi.Size = New System.Drawing.Size(35, 30)
        Me.picYoshi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYoshi.TabIndex = 46
        Me.picYoshi.TabStop = False
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
        Me.Controls.Add(Me.lblBlock25)
        Me.Controls.Add(Me.lblBlock26)
        Me.Controls.Add(Me.lblBlock27)
        Me.Controls.Add(Me.lblBlock28)
        Me.Controls.Add(Me.lblBlock29)
        Me.Controls.Add(Me.lblBlock24)
        Me.Controls.Add(Me.lblBlock23)
        Me.Controls.Add(Me.lblBlock22)
        Me.Controls.Add(Me.lblBlock21)
        Me.Controls.Add(Me.lblBlock20)
        Me.Controls.Add(Me.lblBlock30)
        Me.Controls.Add(Me.lblBlock19)
        Me.Controls.Add(Me.lblBlock13)
        Me.Controls.Add(Me.lblBlock14)
        Me.Controls.Add(Me.lblBlock15)
        Me.Controls.Add(Me.lblBlock16)
        Me.Controls.Add(Me.lblBlock17)
        Me.Controls.Add(Me.lblBlock18)
        Me.Controls.Add(Me.lblBlock7)
        Me.Controls.Add(Me.lblBlock8)
        Me.Controls.Add(Me.lblBlock9)
        Me.Controls.Add(Me.lblBlock10)
        Me.Controls.Add(Me.lblBlock11)
        Me.Controls.Add(Me.lblBlock12)
        Me.Controls.Add(Me.lblBlock6)
        Me.Controls.Add(Me.lblBlock5)
        Me.Controls.Add(Me.lblBlock4)
        Me.Controls.Add(Me.lblBlock3)
        Me.Controls.Add(Me.lblBlock2)
        Me.Controls.Add(Me.lblBlock1)
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

    Friend WithEvents lblBlock1 As Label
    Friend WithEvents lblBlock2 As Label
    Friend WithEvents lblBlock3 As Label
    Friend WithEvents lblBlock4 As Label
    Friend WithEvents lblBlock5 As Label
    Friend WithEvents lblBlock6 As Label
    Friend WithEvents lblBlock12 As Label
    Friend WithEvents lblBlock11 As Label
    Friend WithEvents lblBlock10 As Label
    Friend WithEvents lblBlock9 As Label
    Friend WithEvents lblBlock8 As Label
    Friend WithEvents lblBlock7 As Label
    Friend WithEvents lblBlock18 As Label
    Friend WithEvents lblBlock17 As Label
    Friend WithEvents lblBlock16 As Label
    Friend WithEvents lblBlock15 As Label
    Friend WithEvents lblBlock14 As Label
    Friend WithEvents lblBlock13 As Label
    Friend WithEvents lblBlock19 As Label
    Friend WithEvents lblBlock30 As Label
    Friend WithEvents lblBlock20 As Label
    Friend WithEvents lblBlock21 As Label
    Friend WithEvents lblBlock22 As Label
    Friend WithEvents lblBlock23 As Label
    Friend WithEvents lblBlock24 As Label
    Friend WithEvents lblBlock29 As Label
    Friend WithEvents lblBlock28 As Label
    Friend WithEvents lblBlock27 As Label
    Friend WithEvents lblBlock26 As Label
    Friend WithEvents lblBlock25 As Label
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
