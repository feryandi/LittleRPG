Public Class Form1
    Inherits System.Windows.Forms.Form
    Public form2 As form2 = New form2

    'Basic and battle
    Dim a, steps, myHPc, enemyHPc, enemyNum, mapNum, mapType, turn, hit, transt, loadingPr As Integer
    Dim result As String
    Dim loadingPicNum As Integer

    'SpaceHit Mode
    Dim spaceHit As Double
    Dim spaceCombo As String

    'Shop
    Dim price As Integer

    'Status
    Dim money, swordNum, exp, level, potHP1, getExp, getMoney, att As Integer

    'Warp
    Dim warpDest1, warpDest2, warpDest3, warpDest4 As Integer
    Dim warpCoorX1, warpCoorY1, warpCoorX2, warpCoorY2 As Integer

    'Mapping
    Dim maxUp, maxDown, maxRight, maxLeft As Integer

    'NPCs
    Dim npc1T, npc2T, npc3T, npcType, npcTalk As Integer

    'Quest
    Dim selectedQuest, quest1, quest2, quest3, plot_quest As Integer

    'Monster Mover
    Dim moveRand, moveY, moveX As Integer

    Dim isMoveAllowed As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Map As System.Windows.Forms.PictureBox
    Friend WithEvents Warp1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BattleTimer As System.Windows.Forms.Timer
    Friend WithEvents warp2 As System.Windows.Forms.PictureBox
    Friend WithEvents warp3 As System.Windows.Forms.PictureBox
    Friend WithEvents ArmoryDialog As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NPC1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_2_quit As System.Windows.Forms.Button
    Friend WithEvents btn_2_buy As System.Windows.Forms.Button
    Friend WithEvents lblmoney As System.Windows.Forms.Label
    Friend WithEvents lblexp As System.Windows.Forms.Label
    Friend WithEvents lbllevel As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pic_sa As System.Windows.Forms.PictureBox
    Friend WithEvents pic_armor As System.Windows.Forms.PictureBox
    Friend WithEvents armorynum As System.Windows.Forms.NumericUpDown
    Friend WithEvents armorycbx As System.Windows.Forms.ComboBox
    Friend WithEvents armoryprice As System.Windows.Forms.Label
    Friend WithEvents lblsat As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHPval As System.Windows.Forms.Label
    Friend WithEvents NPC2 As System.Windows.Forms.PictureBox
    Friend WithEvents Trans As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents warp4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Loading As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SFXPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NPC3 As System.Windows.Forms.PictureBox
    Friend WithEvents NPC5 As System.Windows.Forms.PictureBox
    Friend WithEvents NPC4 As System.Windows.Forms.PictureBox
    Friend WithEvents Mons1 As System.Windows.Forms.PictureBox
    Friend WithEvents MiniMons As System.Windows.Forms.Timer
    Friend WithEvents mons2 As System.Windows.Forms.PictureBox
    Friend WithEvents mons3 As System.Windows.Forms.PictureBox
    Friend WithEvents mons5 As System.Windows.Forms.PictureBox
    Friend WithEvents mons4 As System.Windows.Forms.PictureBox
    Friend WithEvents BattleBox As System.Windows.Forms.GroupBox
    Friend WithEvents SpaceHitter As System.Windows.Forms.Label
    Friend WithEvents txtBattle As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EnemyHP As System.Windows.Forms.ProgressBar
    Friend WithEvents MyHP As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents enemypic As System.Windows.Forms.PictureBox
    Friend WithEvents mypic As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyDef As System.Windows.Forms.ListBox
    Friend WithEvents EnemyAtt As System.Windows.Forms.ListBox
    Friend WithEvents QuestDialog As System.Windows.Forms.Panel
    Friend WithEvents QuestA5 As System.Windows.Forms.Label
    Friend WithEvents QuestA4 As System.Windows.Forms.Label
    Friend WithEvents QuestA3 As System.Windows.Forms.Label
    Friend WithEvents QuestA2 As System.Windows.Forms.Label
    Friend WithEvents QuestA1 As System.Windows.Forms.Label
    Friend WithEvents btn_3_quit As System.Windows.Forms.Button
    Friend WithEvents QuestIntro As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents loadingPic As System.Windows.Forms.PictureBox
    Friend WithEvents loadback As System.Windows.Forms.Label
    Friend WithEvents loadpros As System.Windows.Forms.Label
    Friend WithEvents Labele As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Map = New System.Windows.Forms.PictureBox
        Me.Warp1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BattleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.warp2 = New System.Windows.Forms.PictureBox
        Me.warp3 = New System.Windows.Forms.PictureBox
        Me.ArmoryDialog = New System.Windows.Forms.Panel
        Me.armoryprice = New System.Windows.Forms.Label
        Me.btn_2_quit = New System.Windows.Forms.Button
        Me.btn_2_buy = New System.Windows.Forms.Button
        Me.armorynum = New System.Windows.Forms.NumericUpDown
        Me.armorycbx = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.NPC1 = New System.Windows.Forms.PictureBox
        Me.lblmoney = New System.Windows.Forms.Label
        Me.lblexp = New System.Windows.Forms.Label
        Me.lbllevel = New System.Windows.Forms.Label
        Me.pic_armor = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblsat = New System.Windows.Forms.Label
        Me.pic_sa = New System.Windows.Forms.PictureBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblHPval = New System.Windows.Forms.Label
        Me.NPC2 = New System.Windows.Forms.PictureBox
        Me.Trans = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.warp4 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Loading = New System.Windows.Forms.Timer(Me.components)
        Me.SFXPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.Label19 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NPC3 = New System.Windows.Forms.PictureBox
        Me.NPC5 = New System.Windows.Forms.PictureBox
        Me.NPC4 = New System.Windows.Forms.PictureBox
        Me.Mons1 = New System.Windows.Forms.PictureBox
        Me.MiniMons = New System.Windows.Forms.Timer(Me.components)
        Me.mons2 = New System.Windows.Forms.PictureBox
        Me.mons3 = New System.Windows.Forms.PictureBox
        Me.mons5 = New System.Windows.Forms.PictureBox
        Me.mons4 = New System.Windows.Forms.PictureBox
        Me.BattleBox = New System.Windows.Forms.GroupBox
        Me.SpaceHitter = New System.Windows.Forms.Label
        Me.txtBattle = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.EnemyHP = New System.Windows.Forms.ProgressBar
        Me.MyHP = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.enemypic = New System.Windows.Forms.PictureBox
        Me.mypic = New System.Windows.Forms.PictureBox
        Me.EnemyDef = New System.Windows.Forms.ListBox
        Me.EnemyAtt = New System.Windows.Forms.ListBox
        Me.QuestDialog = New System.Windows.Forms.Panel
        Me.QuestA5 = New System.Windows.Forms.Label
        Me.QuestA4 = New System.Windows.Forms.Label
        Me.QuestA3 = New System.Windows.Forms.Label
        Me.QuestA2 = New System.Windows.Forms.Label
        Me.QuestA1 = New System.Windows.Forms.Label
        Me.btn_3_quit = New System.Windows.Forms.Button
        Me.QuestIntro = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.loadingPic = New System.Windows.Forms.PictureBox
        Me.loadback = New System.Windows.Forms.Label
        Me.loadpros = New System.Windows.Forms.Label
        Me.Labele = New System.Windows.Forms.Label
        Me.ArmoryDialog.SuspendLayout()
        CType(Me.armorynum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFXPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BattleBox.SuspendLayout()
        Me.QuestDialog.SuspendLayout()
        Me.SuspendLayout()
        '
        'Map
        '
        Me.Map.Image = CType(resources.GetObject("Map.Image"), System.Drawing.Image)
        Me.Map.Location = New System.Drawing.Point(136, 8)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(360, 360)
        Me.Map.TabIndex = 104
        Me.Map.TabStop = False
        '
        'Warp1
        '
        Me.Warp1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Warp1.BackgroundImage = CType(resources.GetObject("Warp1.BackgroundImage"), System.Drawing.Image)
        Me.Warp1.Location = New System.Drawing.Point(464, 376)
        Me.Warp1.Name = "Warp1"
        Me.Warp1.Size = New System.Drawing.Size(30, 30)
        Me.Warp1.TabIndex = 106
        Me.Warp1.TabStop = False
        Me.Warp1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(64, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "No Data"
        '
        'BattleTimer
        '
        Me.BattleTimer.Interval = 1250
        '
        'warp2
        '
        Me.warp2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.warp2.BackgroundImage = CType(resources.GetObject("warp2.BackgroundImage"), System.Drawing.Image)
        Me.warp2.Location = New System.Drawing.Point(464, 376)
        Me.warp2.Name = "warp2"
        Me.warp2.Size = New System.Drawing.Size(30, 30)
        Me.warp2.TabIndex = 113
        Me.warp2.TabStop = False
        Me.warp2.Visible = False
        '
        'warp3
        '
        Me.warp3.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.warp3.BackgroundImage = CType(resources.GetObject("warp3.BackgroundImage"), System.Drawing.Image)
        Me.warp3.Location = New System.Drawing.Point(464, 376)
        Me.warp3.Name = "warp3"
        Me.warp3.Size = New System.Drawing.Size(30, 30)
        Me.warp3.TabIndex = 114
        Me.warp3.TabStop = False
        Me.warp3.Visible = False
        '
        'ArmoryDialog
        '
        Me.ArmoryDialog.Controls.Add(Me.armoryprice)
        Me.ArmoryDialog.Controls.Add(Me.btn_2_quit)
        Me.ArmoryDialog.Controls.Add(Me.btn_2_buy)
        Me.ArmoryDialog.Controls.Add(Me.armorynum)
        Me.ArmoryDialog.Controls.Add(Me.armorycbx)
        Me.ArmoryDialog.Controls.Add(Me.Label10)
        Me.ArmoryDialog.Controls.Add(Me.Label9)
        Me.ArmoryDialog.Controls.Add(Me.Label8)
        Me.ArmoryDialog.Controls.Add(Me.Label7)
        Me.ArmoryDialog.Location = New System.Drawing.Point(200, 24)
        Me.ArmoryDialog.Name = "ArmoryDialog"
        Me.ArmoryDialog.Size = New System.Drawing.Size(248, 192)
        Me.ArmoryDialog.TabIndex = 7
        Me.ArmoryDialog.Visible = False
        '
        'armoryprice
        '
        Me.armoryprice.Location = New System.Drawing.Point(56, 128)
        Me.armoryprice.Name = "armoryprice"
        Me.armoryprice.Size = New System.Drawing.Size(136, 16)
        Me.armoryprice.TabIndex = 8
        Me.armoryprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_2_quit
        '
        Me.btn_2_quit.Location = New System.Drawing.Point(136, 152)
        Me.btn_2_quit.Name = "btn_2_quit"
        Me.btn_2_quit.TabIndex = 7
        Me.btn_2_quit.Text = "Keluar"
        '
        'btn_2_buy
        '
        Me.btn_2_buy.Location = New System.Drawing.Point(40, 152)
        Me.btn_2_buy.Name = "btn_2_buy"
        Me.btn_2_buy.TabIndex = 6
        Me.btn_2_buy.Text = "Beli"
        '
        'armorynum
        '
        Me.armorynum.Location = New System.Drawing.Point(160, 96)
        Me.armorynum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.armorynum.Name = "armorynum"
        Me.armorynum.Size = New System.Drawing.Size(72, 20)
        Me.armorynum.TabIndex = 5
        Me.armorynum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'armorycbx
        '
        Me.armorycbx.Items.AddRange(New Object() {"Wooden Sword", "HP Potion", "Metalic Sword", "Sword of Ares"})
        Me.armorycbx.Location = New System.Drawing.Point(16, 96)
        Me.armorycbx.Name = "armorycbx"
        Me.armorycbx.Size = New System.Drawing.Size(128, 21)
        Me.armorycbx.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(160, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Jumlah"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Barang yang dibeli"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 48)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Hai! Selamat datang di toko senjata! Disini anda dapat menemukan senjata yang and" & _
        "a perlukan!"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dialog"
        '
        'NPC1
        '
        Me.NPC1.Location = New System.Drawing.Point(432, 376)
        Me.NPC1.Name = "NPC1"
        Me.NPC1.Size = New System.Drawing.Size(30, 30)
        Me.NPC1.TabIndex = 118
        Me.NPC1.TabStop = False
        Me.NPC1.Visible = False
        '
        'lblmoney
        '
        Me.lblmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmoney.Location = New System.Drawing.Point(48, 96)
        Me.lblmoney.Name = "lblmoney"
        Me.lblmoney.Size = New System.Drawing.Size(64, 16)
        Me.lblmoney.TabIndex = 0
        Me.lblmoney.Text = "0"
        Me.lblmoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblexp
        '
        Me.lblexp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.Location = New System.Drawing.Point(48, 120)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(64, 16)
        Me.lblexp.TabIndex = 1
        Me.lblexp.Text = "0"
        Me.lblexp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbllevel
        '
        Me.lbllevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllevel.Location = New System.Drawing.Point(48, 136)
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(64, 16)
        Me.lbllevel.TabIndex = 1
        Me.lbllevel.Text = "0"
        Me.lbllevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pic_armor
        '
        Me.pic_armor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pic_armor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_armor.Location = New System.Drawing.Point(48, 56)
        Me.pic_armor.Name = "pic_armor"
        Me.pic_armor.Size = New System.Drawing.Size(30, 30)
        Me.pic_armor.TabIndex = 0
        Me.pic_armor.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblsat)
        Me.GroupBox4.Controls.Add(Me.pic_sa)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(8, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 64)
        Me.GroupBox4.TabIndex = 124
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Shortcuts"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.RosyBrown
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 10)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "A"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsat
        '
        Me.lblsat.BackColor = System.Drawing.Color.RosyBrown
        Me.lblsat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsat.Location = New System.Drawing.Point(48, 48)
        Me.lblsat.Name = "lblsat"
        Me.lblsat.Size = New System.Drawing.Size(30, 10)
        Me.lblsat.TabIndex = 1
        Me.lblsat.Text = "0"
        Me.lblsat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_sa
        '
        Me.pic_sa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pic_sa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_sa.Location = New System.Drawing.Point(48, 24)
        Me.pic_sa.Name = "pic_sa"
        Me.pic_sa.Size = New System.Drawing.Size(30, 30)
        Me.pic_sa.TabIndex = 0
        Me.pic_sa.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.lblHPval)
        Me.GroupBox5.Controls.Add(Me.pic_armor)
        Me.GroupBox5.Controls.Add(Me.lblmoney)
        Me.GroupBox5.Controls.Add(Me.lblexp)
        Me.GroupBox5.Controls.Add(Me.lbllevel)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(120, 160)
        Me.GroupBox5.TabIndex = 125
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Level"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Exp"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Money"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 23)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "HP"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHPval
        '
        Me.lblHPval.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPval.Location = New System.Drawing.Point(40, 24)
        Me.lblHPval.Name = "lblHPval"
        Me.lblHPval.Size = New System.Drawing.Size(56, 24)
        Me.lblHPval.TabIndex = 0
        Me.lblHPval.Text = "0"
        Me.lblHPval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NPC2
        '
        Me.NPC2.BackColor = System.Drawing.Color.Transparent
        Me.NPC2.Location = New System.Drawing.Point(432, 376)
        Me.NPC2.Name = "NPC2"
        Me.NPC2.Size = New System.Drawing.Size(30, 30)
        Me.NPC2.TabIndex = 128
        Me.NPC2.TabStop = False
        Me.NPC2.Visible = False
        '
        'Trans
        '
        Me.Trans.Enabled = True
        Me.Trans.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(136, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(472, 376)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(8, 32)
        Me.AxWindowsMediaPlayer1.TabIndex = 130
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'warp4
        '
        Me.warp4.BackColor = System.Drawing.Color.Transparent
        Me.warp4.BackgroundImage = CType(resources.GetObject("warp4.BackgroundImage"), System.Drawing.Image)
        Me.warp4.Location = New System.Drawing.Point(464, 376)
        Me.warp4.Name = "warp4"
        Me.warp4.Size = New System.Drawing.Size(30, 30)
        Me.warp4.TabIndex = 131
        Me.warp4.TabStop = False
        Me.warp4.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(24, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 24)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Coord"
        '
        'Loading
        '
        Me.Loading.Interval = 1000
        '
        'SFXPlayer
        '
        Me.SFXPlayer.Enabled = True
        Me.SFXPlayer.Location = New System.Drawing.Point(472, 408)
        Me.SFXPlayer.Name = "SFXPlayer"
        Me.SFXPlayer.OcxState = CType(resources.GetObject("SFXPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SFXPlayer.Size = New System.Drawing.Size(8, 23)
        Me.SFXPlayer.TabIndex = 144
        Me.SFXPlayer.Visible = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(0, 368)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 145
        Me.Label19.Text = "v. 0.1.1 beta"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.DimGray
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(16, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 32)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "More &Info and Help"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NPC3
        '
        Me.NPC3.BackColor = System.Drawing.Color.Transparent
        Me.NPC3.Location = New System.Drawing.Point(424, 376)
        Me.NPC3.Name = "NPC3"
        Me.NPC3.Size = New System.Drawing.Size(30, 30)
        Me.NPC3.TabIndex = 148
        Me.NPC3.TabStop = False
        Me.NPC3.Visible = False
        '
        'NPC5
        '
        Me.NPC5.Location = New System.Drawing.Point(416, 376)
        Me.NPC5.Name = "NPC5"
        Me.NPC5.Size = New System.Drawing.Size(30, 30)
        Me.NPC5.TabIndex = 149
        Me.NPC5.TabStop = False
        Me.NPC5.Visible = False
        '
        'NPC4
        '
        Me.NPC4.BackColor = System.Drawing.Color.Transparent
        Me.NPC4.Location = New System.Drawing.Point(416, 376)
        Me.NPC4.Name = "NPC4"
        Me.NPC4.Size = New System.Drawing.Size(30, 30)
        Me.NPC4.TabIndex = 150
        Me.NPC4.TabStop = False
        Me.NPC4.Visible = False
        '
        'Mons1
        '
        Me.Mons1.BackColor = System.Drawing.Color.Transparent
        Me.Mons1.BackgroundImage = CType(resources.GetObject("Mons1.BackgroundImage"), System.Drawing.Image)
        Me.Mons1.Location = New System.Drawing.Point(432, 376)
        Me.Mons1.Name = "Mons1"
        Me.Mons1.Size = New System.Drawing.Size(30, 30)
        Me.Mons1.TabIndex = 157
        Me.Mons1.TabStop = False
        Me.Mons1.Visible = False
        '
        'MiniMons
        '
        Me.MiniMons.Enabled = True
        Me.MiniMons.Interval = 1000
        '
        'mons2
        '
        Me.mons2.BackColor = System.Drawing.Color.Transparent
        Me.mons2.BackgroundImage = CType(resources.GetObject("mons2.BackgroundImage"), System.Drawing.Image)
        Me.mons2.Location = New System.Drawing.Point(408, 376)
        Me.mons2.Name = "mons2"
        Me.mons2.Size = New System.Drawing.Size(30, 30)
        Me.mons2.TabIndex = 158
        Me.mons2.TabStop = False
        Me.mons2.Visible = False
        '
        'mons3
        '
        Me.mons3.BackColor = System.Drawing.Color.Transparent
        Me.mons3.BackgroundImage = CType(resources.GetObject("mons3.BackgroundImage"), System.Drawing.Image)
        Me.mons3.Location = New System.Drawing.Point(384, 376)
        Me.mons3.Name = "mons3"
        Me.mons3.Size = New System.Drawing.Size(30, 30)
        Me.mons3.TabIndex = 159
        Me.mons3.TabStop = False
        Me.mons3.Visible = False
        '
        'mons5
        '
        Me.mons5.BackColor = System.Drawing.Color.Transparent
        Me.mons5.BackgroundImage = CType(resources.GetObject("mons5.BackgroundImage"), System.Drawing.Image)
        Me.mons5.Location = New System.Drawing.Point(320, 376)
        Me.mons5.Name = "mons5"
        Me.mons5.Size = New System.Drawing.Size(30, 30)
        Me.mons5.TabIndex = 161
        Me.mons5.TabStop = False
        Me.mons5.Visible = False
        '
        'mons4
        '
        Me.mons4.BackColor = System.Drawing.Color.Transparent
        Me.mons4.BackgroundImage = CType(resources.GetObject("mons4.BackgroundImage"), System.Drawing.Image)
        Me.mons4.Location = New System.Drawing.Point(352, 376)
        Me.mons4.Name = "mons4"
        Me.mons4.Size = New System.Drawing.Size(30, 30)
        Me.mons4.TabIndex = 160
        Me.mons4.TabStop = False
        Me.mons4.Visible = False
        '
        'BattleBox
        '
        Me.BattleBox.Controls.Add(Me.SpaceHitter)
        Me.BattleBox.Controls.Add(Me.txtBattle)
        Me.BattleBox.Controls.Add(Me.Label5)
        Me.BattleBox.Controls.Add(Me.Label4)
        Me.BattleBox.Controls.Add(Me.EnemyHP)
        Me.BattleBox.Controls.Add(Me.MyHP)
        Me.BattleBox.Controls.Add(Me.Label3)
        Me.BattleBox.Controls.Add(Me.Label2)
        Me.BattleBox.Controls.Add(Me.enemypic)
        Me.BattleBox.Controls.Add(Me.mypic)
        Me.BattleBox.Controls.Add(Me.EnemyDef)
        Me.BattleBox.Controls.Add(Me.EnemyAtt)
        Me.BattleBox.Location = New System.Drawing.Point(136, 208)
        Me.BattleBox.Name = "BattleBox"
        Me.BattleBox.Size = New System.Drawing.Size(360, 160)
        Me.BattleBox.TabIndex = 162
        Me.BattleBox.TabStop = False
        Me.BattleBox.Text = "Battle"
        Me.BattleBox.Visible = False
        '
        'SpaceHitter
        '
        Me.SpaceHitter.BackColor = System.Drawing.Color.Red
        Me.SpaceHitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpaceHitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SpaceHitter.Location = New System.Drawing.Point(232, 72)
        Me.SpaceHitter.Name = "SpaceHitter"
        Me.SpaceHitter.Size = New System.Drawing.Size(64, 16)
        Me.SpaceHitter.TabIndex = 115
        Me.SpaceHitter.Text = "SpaceHit"
        Me.SpaceHitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SpaceHitter.Visible = False
        '
        'txtBattle
        '
        Me.txtBattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBattle.Location = New System.Drawing.Point(16, 128)
        Me.txtBattle.Name = "txtBattle"
        Me.txtBattle.Size = New System.Drawing.Size(336, 24)
        Me.txtBattle.TabIndex = 114
        Me.txtBattle.Text = "Battle Narrator"
        Me.txtBattle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(304, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Enemy"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "You"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EnemyHP
        '
        Me.EnemyHP.Location = New System.Drawing.Point(192, 96)
        Me.EnemyHP.Name = "EnemyHP"
        Me.EnemyHP.Size = New System.Drawing.Size(112, 16)
        Me.EnemyHP.Step = 1
        Me.EnemyHP.TabIndex = 7
        '
        'MyHP
        '
        Me.MyHP.Location = New System.Drawing.Point(56, 96)
        Me.MyHP.Name = "MyHP"
        Me.MyHP.Size = New System.Drawing.Size(112, 16)
        Me.MyHP.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HP"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HP"
        '
        'enemypic
        '
        Me.enemypic.Location = New System.Drawing.Point(232, 24)
        Me.enemypic.Name = "enemypic"
        Me.enemypic.Size = New System.Drawing.Size(64, 64)
        Me.enemypic.TabIndex = 1
        Me.enemypic.TabStop = False
        '
        'mypic
        '
        Me.mypic.Location = New System.Drawing.Point(72, 24)
        Me.mypic.Name = "mypic"
        Me.mypic.Size = New System.Drawing.Size(64, 64)
        Me.mypic.TabIndex = 0
        Me.mypic.TabStop = False
        '
        'EnemyDef
        '
        Me.EnemyDef.Location = New System.Drawing.Point(304, 56)
        Me.EnemyDef.Name = "EnemyDef"
        Me.EnemyDef.Size = New System.Drawing.Size(8, 30)
        Me.EnemyDef.TabIndex = 110
        Me.EnemyDef.Visible = False
        '
        'EnemyAtt
        '
        Me.EnemyAtt.Location = New System.Drawing.Point(320, 64)
        Me.EnemyAtt.Name = "EnemyAtt"
        Me.EnemyAtt.Size = New System.Drawing.Size(24, 4)
        Me.EnemyAtt.TabIndex = 111
        Me.EnemyAtt.Visible = False
        '
        'QuestDialog
        '
        Me.QuestDialog.Controls.Add(Me.QuestA5)
        Me.QuestDialog.Controls.Add(Me.QuestA4)
        Me.QuestDialog.Controls.Add(Me.QuestA3)
        Me.QuestDialog.Controls.Add(Me.QuestA2)
        Me.QuestDialog.Controls.Add(Me.QuestA1)
        Me.QuestDialog.Controls.Add(Me.btn_3_quit)
        Me.QuestDialog.Controls.Add(Me.QuestIntro)
        Me.QuestDialog.Controls.Add(Me.Label16)
        Me.QuestDialog.Location = New System.Drawing.Point(200, 24)
        Me.QuestDialog.Name = "QuestDialog"
        Me.QuestDialog.Size = New System.Drawing.Size(248, 288)
        Me.QuestDialog.TabIndex = 163
        Me.QuestDialog.Visible = False
        '
        'QuestA5
        '
        Me.QuestA5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QuestA5.ForeColor = System.Drawing.Color.White
        Me.QuestA5.Location = New System.Drawing.Point(8, 232)
        Me.QuestA5.Name = "QuestA5"
        Me.QuestA5.Size = New System.Drawing.Size(232, 16)
        Me.QuestA5.TabIndex = 12
        '
        'QuestA4
        '
        Me.QuestA4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QuestA4.ForeColor = System.Drawing.Color.White
        Me.QuestA4.Location = New System.Drawing.Point(8, 216)
        Me.QuestA4.Name = "QuestA4"
        Me.QuestA4.Size = New System.Drawing.Size(232, 16)
        Me.QuestA4.TabIndex = 11
        '
        'QuestA3
        '
        Me.QuestA3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QuestA3.ForeColor = System.Drawing.Color.White
        Me.QuestA3.Location = New System.Drawing.Point(8, 200)
        Me.QuestA3.Name = "QuestA3"
        Me.QuestA3.Size = New System.Drawing.Size(232, 16)
        Me.QuestA3.TabIndex = 10
        '
        'QuestA2
        '
        Me.QuestA2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QuestA2.ForeColor = System.Drawing.Color.White
        Me.QuestA2.Location = New System.Drawing.Point(8, 184)
        Me.QuestA2.Name = "QuestA2"
        Me.QuestA2.Size = New System.Drawing.Size(232, 16)
        Me.QuestA2.TabIndex = 9
        '
        'QuestA1
        '
        Me.QuestA1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.QuestA1.ForeColor = System.Drawing.Color.White
        Me.QuestA1.Location = New System.Drawing.Point(8, 168)
        Me.QuestA1.Name = "QuestA1"
        Me.QuestA1.Size = New System.Drawing.Size(232, 16)
        Me.QuestA1.TabIndex = 8
        '
        'btn_3_quit
        '
        Me.btn_3_quit.Location = New System.Drawing.Point(168, 256)
        Me.btn_3_quit.Name = "btn_3_quit"
        Me.btn_3_quit.TabIndex = 7
        Me.btn_3_quit.Text = "Keluar"
        '
        'QuestIntro
        '
        Me.QuestIntro.Location = New System.Drawing.Point(8, 32)
        Me.QuestIntro.Name = "QuestIntro"
        Me.QuestIntro.Size = New System.Drawing.Size(232, 128)
        Me.QuestIntro.TabIndex = 1
        Me.QuestIntro.Text = "Hai!"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(232, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Dialog"
        '
        'loadingPic
        '
        Me.loadingPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loadingPic.Image = CType(resources.GetObject("loadingPic.Image"), System.Drawing.Image)
        Me.loadingPic.Location = New System.Drawing.Point(136, 8)
        Me.loadingPic.Name = "loadingPic"
        Me.loadingPic.Size = New System.Drawing.Size(360, 360)
        Me.loadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loadingPic.TabIndex = 164
        Me.loadingPic.TabStop = False
        Me.loadingPic.Visible = False
        '
        'loadback
        '
        Me.loadback.BackColor = System.Drawing.SystemColors.Control
        Me.loadback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loadback.Location = New System.Drawing.Point(216, 216)
        Me.loadback.Name = "loadback"
        Me.loadback.Size = New System.Drawing.Size(200, 16)
        Me.loadback.TabIndex = 165
        '
        'loadpros
        '
        Me.loadpros.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.loadpros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loadpros.Location = New System.Drawing.Point(216, 216)
        Me.loadpros.Name = "loadpros"
        Me.loadpros.Size = New System.Drawing.Size(200, 16)
        Me.loadpros.TabIndex = 166
        '
        'Labele
        '
        Me.Labele.BackColor = System.Drawing.Color.FromArgb(CType(146, Byte), CType(96, Byte), CType(2, Byte))
        Me.Labele.Location = New System.Drawing.Point(168, 376)
        Me.Labele.Name = "Labele"
        Me.Labele.Size = New System.Drawing.Size(360, 24)
        Me.Labele.TabIndex = 167
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(506, 384)
        Me.Controls.Add(Me.Labele)
        Me.Controls.Add(Me.loadpros)
        Me.Controls.Add(Me.loadback)
        Me.Controls.Add(Me.loadingPic)
        Me.Controls.Add(Me.QuestDialog)
        Me.Controls.Add(Me.BattleBox)
        Me.Controls.Add(Me.mons5)
        Me.Controls.Add(Me.mons4)
        Me.Controls.Add(Me.mons3)
        Me.Controls.Add(Me.mons2)
        Me.Controls.Add(Me.Mons1)
        Me.Controls.Add(Me.NPC4)
        Me.Controls.Add(Me.NPC5)
        Me.Controls.Add(Me.NPC3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SFXPlayer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.warp4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NPC2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.NPC1)
        Me.Controls.Add(Me.ArmoryDialog)
        Me.Controls.Add(Me.warp3)
        Me.Controls.Add(Me.warp2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Warp1)
        Me.Controls.Add(Me.Map)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "6"
        Me.ArmoryDialog.ResumeLayout(False)
        CType(Me.armorynum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFXPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BattleBox.ResumeLayout(False)
        Me.QuestDialog.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Starting Game di map code 1 dengan tipe open area, uang awal 50, exp 1, hp 100 dan attack 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Focus()
        mapNum = 1
        mapType = 1
        myHPc = 100
        att = 0
        money = 99999999
        exp = 1
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/images/main/chm-front.png")
        isMoveAllowed = True
        createMap()
        calcStat()
        AxWindowsMediaPlayer1.URL = Application.StartupPath & "/images/Theme of Prontera.mp3"
    End Sub

    'Tombol "More info"
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form2.ShowDialog()
    End Sub

    'Melakukan Loading, char tidak bisa jalan, picbox loading dan progressbar muncul
    Private Sub doLoading()
        isMoveAllowed = False
        Loading.Enabled = True
        loadingPicNum = Now.Second / 10
        loadingPic.Image = Image.FromFile(Application.StartupPath & "/images/loading/loading" & loadingPicNum & ".bmp")
        loadingPic.Visible = True
        loadpros.Visible = True
        loadback.Visible = True
        loadpros.Size = New Size(0, loadpros.Size.Height)
    End Sub

    Private Sub Loading_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loading.Tick
        Dim increase As Integer
        increase = (loadpros.Size.Width + 10 + (Rnd() * Now.Millisecond / 15)) * 2
        If increase >= 200 Then
            increase = 200
        End If
        loadpros.Size = New Size(increase, loadpros.Size.Height)
        If loadpros.Size.Width >= 200 Then
            Loading.Enabled = False
            isMoveAllowed = True
            loadpros.Visible = False
            loadback.Visible = False
            loadingPic.Visible = False
        End If
    End Sub

    'Melakukan penghitungan exp dll
    Public Sub calcStat()
        If exp < 1 Then
            level = 1
        ElseIf exp > 40 And exp < 65 Then
            level = 2
        ElseIf exp > 64 And exp < 90 Then
            level = 3
        ElseIf exp > 129 And exp < 170 Then
            level = 4
        ElseIf exp > 169 And exp < 250 Then
            level = 5
        End If

        lblmoney.Text = money
        lblexp.Text = exp
        lbllevel.Text = level
        lblHPval.Text = myHPc
        lblsat.Text = potHP1

        If potHP1 > 0 Then
            pic_sa.Image = Image.FromFile(Application.StartupPath & "/images/pothp1.bmp")
        End If

        Select Case swordNum
            Case 1
                pic_armor.Image = Image.FromFile(Application.StartupPath & "/images/sword1.bmp")
            Case 2
                pic_armor.Image = Image.FromFile(Application.StartupPath & "/images/sword2.bmp")
            Case 3
                pic_armor.Image = Image.FromFile(Application.StartupPath & "/images/sword3.bmp")
        End Select
        loadingPr = loadingPr + 20
    End Sub

    'Mengganti Map
    Public Sub changeMap()
        isMoveAllowed = True
        doLoading()
        Warp1.Visible = False
        Warp1.Location = New Point(316, 368)
        warp2.Visible = False
        warp2.Location = New Point(316, 368)
        warp3.Visible = False
        warp3.Location = New Point(316, 368)
        warp4.Visible = False
        warp4.Location = New Point(316, 368)
        NPC1.Visible = False
        NPC1.Location = New Point(316, 368)
        NPC2.Visible = False
        NPC2.Location = New Point(316, 368)
        NPC3.Visible = False
        NPC3.Location = New Point(316, 368)
        NPC4.Visible = False
        NPC4.Location = New Point(316, 368)
        NPC5.Visible = False
        NPC5.Location = New Point(316, 368)
        maxUp = 8
        maxDown = 338
        maxLeft = 136
        maxRight = 466
        loadingPr = loadingPr + 30
    End Sub

    'Data Map
    Public Sub createMap()
        changeMap()
        Select Case mapNum
            Case 1
                maxUp = 8
                maxDown = 338
                maxLeft = 136
                maxRight = 466
                mapType = 1
                Map.Image = Image.FromFile(Application.StartupPath & "/images/maps/map1.bmp")
                Warp1.Location = New Point(136, 128)
                Warp1.Visible = True
                warpDest1 = 2
                warpCoorX1 = 406
                warpCoorY1 = 158
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "/images/main/grass.bmp")

                'NPC
                NPC1.Location = New Point(316, 308)
                NPC1.Visible = False
                npc1T = 3021

                'Monsters
                EnemyDef.Items.Add("2")
                EnemyDef.Items.Add("4")
                EnemyDef.Items.Add("5")
                EnemyDef.Items.Add("10")
                EnemyDef.Items.Add("16")

                EnemyAtt.Items.Add("3")
                EnemyAtt.Items.Add("3")
                EnemyAtt.Items.Add("5")
                EnemyAtt.Items.Add("5")
                EnemyAtt.Items.Add("6")
            Case 2
                'SETTINGS
                mapType = 2
                maxUp = 98
                maxDown = 248
                maxLeft = 196
                maxRight = 406
                Map.Image = Image.FromFile(Application.StartupPath & "/images/maps/map2.bmp")
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "/images/main/town.bmp")

                'WARP
                Warp1.Location = New Point(406, 158)
                Warp1.Visible = True
                warpDest1 = 1
                warpCoorX1 = 136
                warpCoorY1 = 128
                warp2.Location = New Point(196, 158)
                warp2.Visible = True
                warpDest2 = 3
                warpCoorX2 = 466
                warpCoorY2 = 188

                'NPC
                NPC1.Location = New Point(406, 218)
                NPC1.Image = Image.FromFile(Application.StartupPath & "/images/npc1.bmp")
                NPC1.Visible = True
                npc1T = 2

                NPC2.Location = New Point(196, 98)
                NPC2.Image = Image.FromFile(Application.StartupPath & "/images/npc2.bmp")
                NPC2.Visible = True
                npc2T = 301

                NPC3.Location = New Point(256, 218)
                NPC3.Image = Image.FromFile(Application.StartupPath & "/images/npc3.bmp")
                NPC3.Visible = True
                npc3T = 302
            Case 3
                maxUp = 8
                maxDown = 338
                maxLeft = 376
                maxRight = 466
                mapType = 1
                Map.Image = Image.FromFile(Application.StartupPath & "/images/maps/map3.bmp")
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "/images/main/grass.bmp")

                'warp
                Warp1.Location = New Point(466, 188)
                Warp1.Visible = True
                warpDest1 = 2
                warpCoorX1 = 196
                warpCoorY1 = 158
                warp2.Location = New Point(376, 188)
                warp2.Visible = True
                warpDest2 = 4
                warpCoorX2 = 466
                warpCoorY2 = 188

                'Monsters
                EnemyDef.Items.Add("2")
                EnemyDef.Items.Add("11")
                EnemyDef.Items.Add("12")
                EnemyDef.Items.Add("8")
                EnemyDef.Items.Add("9")

                EnemyAtt.Items.Add("3")
                EnemyAtt.Items.Add("6")
                EnemyAtt.Items.Add("7")
                EnemyAtt.Items.Add("5")
                EnemyAtt.Items.Add("7")

            Case 4
                maxUp = 38
                maxDown = 308
                maxLeft = 166
                maxRight = 466
                mapType = 1
                Map.Image = Image.FromFile(Application.StartupPath & "/images/maps/map4.bmp")
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "/images/main/dungeon.bmp")

                Warp1.Location = New Point(466, 188)
                Warp1.Visible = True
                warpDest1 = 3
                warpCoorX1 = 376
                warpCoorY1 = 188

                'Monsters
                EnemyDef.Items.Add("14")
                EnemyDef.Items.Add("16")
                EnemyDef.Items.Add("22")
                EnemyDef.Items.Add("24")
                EnemyDef.Items.Add("21")

                EnemyAtt.Items.Add("16")
                EnemyAtt.Items.Add("17")
                EnemyAtt.Items.Add("19")
                EnemyAtt.Items.Add("21")
                EnemyAtt.Items.Add("27")
        End Select
        loadingPr = loadingPr + 50
        'showMons()
    End Sub

    'Looping lagu
    Private Sub Trans_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Trans.Tick
        transt = transt + 1
        If transt = 275 Then
            AxWindowsMediaPlayer1.URL = Application.StartupPath & "/images/Theme of Prontera.mp3"
            transt = -2
        End If
    End Sub

    'Men-cek apakah ada tombol yang ditekan.. berfungsi jika tombol up,down,right,left,a,z,x,c,v ditekan
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            If potHP1 > 0 And myHPc > 0 Then
                myHPc = myHPc + 10
                If myHPc > 100 Then
                    myHPc = 100
                End If
                potHP1 = potHP1 - 1
                MyHP.Value = myHPc
                calcStat()
            End If
        ElseIf e.KeyCode = Keys.Z Or e.KeyCode = Keys.X Or e.KeyCode = Keys.C Or e.KeyCode = Keys.V Then
            If e.KeyCode = Keys.V Then
                spaceCombo = ""
                spaceHit = spaceHit + 0.1
            ElseIf turn > 0 And isMoveAllowed = False Then
                If turn = 1 Then
                    SFXPlayer.URL = Application.StartupPath & "/images/sword.wav"
                End If
                spaceHit = spaceHit + 0.2

                If e.KeyCode = Keys.Z Then
                    spaceCombo = spaceCombo & "z"
                ElseIf e.KeyCode = Keys.X Then
                    spaceCombo = spaceCombo & "x"
                ElseIf e.KeyCode = Keys.C Then
                    spaceCombo = spaceCombo & "c"
                End If

                Select Case spaceCombo
                    Case "xxcczz"
                        spaceHit = spaceHit + 6
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "xxxxzzzzcccc"
                        spaceHit = spaceHit + 20
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "zxczxczxc"
                        spaceHit = spaceHit + 5
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "cccczzzz"
                        spaceHit = spaceHit + 7
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "cccccc"
                        spaceHit = 100
                        money = 100000
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "zzzzzz"
                        spaceHit = 100
                        exp = 200
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                    Case "xxxxxx"
                        spaceHit = 100
                        potHP1 = 1000
                        SFXPlayer.URL = Application.StartupPath & "/images/swords.wav"
                End Select
            End If
        Else
            If isMoveAllowed <> False Then
                If e.KeyCode = Keys.Up Then
                    If PictureBox1.Location.Y <> maxUp Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/images/main/chm-back.png")
                        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 30)
                    End If

                ElseIf e.KeyCode = Keys.Down Then
                    If PictureBox1.Location.Y <> maxDown Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/images/main/chm-front.png")
                        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 30)
                    End If

                ElseIf e.KeyCode = Keys.Right Then
                    If PictureBox1.Location.X <> maxRight Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/images/main/chm-right.png")
                        PictureBox1.Location = New Point(PictureBox1.Location.X + 30, PictureBox1.Location.Y)
                    End If

                ElseIf e.KeyCode = Keys.Left Then
                    If PictureBox1.Location.X <> maxLeft Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/images/main/chm-left.png")
                        PictureBox1.Location = New Point(PictureBox1.Location.X - 30, PictureBox1.Location.Y)
                    End If
                End If

                steps = steps + 1
                Label1.Text = steps

                watchStep()
                Label1.Text = PictureBox1.Location.X & "," & PictureBox1.Location.Y
            End If
        End If
    End Sub

    Private Sub showMons()
        If mapType = 1 Then
            Mons1.BackgroundImage = PictureBox1.BackgroundImage
            mons2.BackgroundImage = PictureBox1.BackgroundImage
            mons3.BackgroundImage = PictureBox1.BackgroundImage
            mons4.BackgroundImage = PictureBox1.BackgroundImage
            mons5.BackgroundImage = PictureBox1.BackgroundImage

            Mons1.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mini0.png")
            mons3.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mini0.png")
            mons5.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mini0.png")
            mons2.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mini1.png")
            mons4.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mini1.png")

            If mapNum <> 3 Then
                Mons1.Visible = True
                Mons1.Location = New Point(286, 38)
                mons2.Visible = True
                mons2.Location = New Point(346, 68)
                mons3.Visible = True
                mons3.Location = New Point(226, 338)
                mons4.Visible = True
                mons4.Location = New Point(226, 218)
                mons5.Visible = True
                mons5.Location = New Point(466, 308)
            End If
        Else
            Mons1.Visible = False
            mons2.Visible = False
            mons3.Visible = False
            mons4.Visible = False
            mons5.Visible = False
        End If
    End Sub

    Private Sub MiniMons_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MiniMons.Tick
        Dim a As Integer
        For a = 1 To 5 Step 1
            moveRand = (Rnd() * 10) + (Rnd() * 2) + Rnd() * Now.Millisecond / 100
            Select Case moveRand
                Case 0, 4, 8
                    moveY = -30
                    moveX = 0
                Case 1, 9, 5, 12
                    moveX = -30
                    moveY = 0
                Case 2, 6, 7
                    moveY = 30
                    moveX = 0
                Case 3, 11, 10
                    moveX = 30
                    moveY = 0
            End Select

            Select Case a
                Case 1
                    If Mons1.Location.X + moveX <= maxLeft Or Mons1.Location.X + moveX >= maxRight Then
                        moveX = 0
                    End If
                    If Mons1.Location.Y + moveY <= maxUp Or Mons1.Location.Y + moveY >= maxDown Then
                        moveY = 0
                    End If
                    Mons1.Location = New Point(Mons1.Location.X + moveX, Mons1.Location.Y + moveY)
                Case 2
                    If mons2.Location.X + moveX <= maxLeft Or mons2.Location.X + moveX >= maxRight Then
                        moveX = 0
                    End If
                    If mons2.Location.Y + moveY <= maxUp Or mons2.Location.Y + moveY >= maxDown Then
                        moveY = 0
                    End If
                    mons2.Location = New Point(mons2.Location.X + moveX, mons2.Location.Y + moveY)
                Case 3
                    If mons3.Location.X + moveX <= maxLeft Or mons3.Location.X + moveX >= maxRight Then
                        moveX = 0
                    End If
                    If mons3.Location.Y + moveY <= maxUp Or mons3.Location.Y + moveY >= maxDown Then
                        moveY = 0
                    End If
                    mons3.Location = New Point(mons3.Location.X + moveX, mons3.Location.Y + moveY)
                Case 4
                    If mons4.Location.X + moveX <= maxLeft Or mons4.Location.X + moveX >= maxRight Then
                        moveX = 0
                    End If
                    If mons4.Location.Y + moveY <= maxUp Or mons4.Location.Y + moveY >= maxDown Then
                        moveY = 0
                    End If
                    mons4.Location = New Point(mons4.Location.X + moveX, mons4.Location.Y + moveY)
                Case 5
                    If mons5.Location.X + moveX <= maxLeft Or mons5.Location.X + moveX >= maxRight Then
                        moveX = 0
                    End If
                    If mons5.Location.Y + moveY <= maxUp Or mons5.Location.Y + moveY >= maxDown Then
                        moveY = 0
                    End If
                    mons5.Location = New Point(mons5.Location.X + moveX, mons5.Location.Y + moveY)
            End Select
            moveX = 0
            moveY = 0
        Next
    End Sub

    'Untuk men-cek letak karakter digunakan untuk summon monster dan warping
    Private Sub watchStep()
        'WARP
        If PictureBox1.Location.X = Warp1.Location.X And PictureBox1.Location.Y = Warp1.Location.Y Then
            mapNum = warpDest1
            PictureBox1.Location = New Point(warpCoorX1, warpCoorY1)
            createMap()
        ElseIf PictureBox1.Location.X = warp2.Location.X And PictureBox1.Location.Y = warp2.Location.Y Then
            mapNum = warpDest2
            PictureBox1.Location = New Point(warpCoorX2, warpCoorY2)
            createMap()
        ElseIf PictureBox1.Location.X = warp3.Location.X And PictureBox1.Location.Y = warp3.Location.Y Then
            mapNum = warpDest3
            PictureBox1.Location = warp3.Location
            createMap()
        ElseIf PictureBox1.Location.X = warp4.Location.X And PictureBox1.Location.Y = warp4.Location.Y Then
            mapNum = warpDest4
            PictureBox1.Location = warp4.Location
            createMap()
            'NPC
        ElseIf PictureBox1.Location.X = NPC1.Location.X And PictureBox1.Location.Y = NPC1.Location.Y Then
            npcType = npc1T
            createDialog()
        ElseIf PictureBox1.Location.X = NPC2.Location.X And PictureBox1.Location.Y = NPC2.Location.Y Then
            npcType = npc2T
            createDialog()
        ElseIf PictureBox1.Location.X = NPC3.Location.X And PictureBox1.Location.Y = NPC3.Location.Y Then
            npcType = npc3T
            createDialog()
            'MONSTER
        ElseIf PictureBox1.Location.X = Mons1.Location.X And PictureBox1.Location.Y = Mons1.Location.Y Then
            steps = 0
            battleOn()
        ElseIf PictureBox1.Location.X = mons2.Location.X And PictureBox1.Location.Y = mons2.Location.Y Then
            steps = 0
            battleOn()
        ElseIf PictureBox1.Location.X = mons3.Location.X And PictureBox1.Location.Y = mons3.Location.Y Then
            steps = 0
            battleOn()
        ElseIf PictureBox1.Location.X = mons4.Location.X And PictureBox1.Location.Y = mons4.Location.Y Then
            steps = 0
            battleOn()
        ElseIf PictureBox1.Location.X = mons5.Location.X And PictureBox1.Location.Y = mons5.Location.Y Then
            steps = 0
            battleOn()
        ElseIf steps > 4 And mapType = 1 Then
            steps = 0
            battleOn()
        End If
    End Sub

    'Segala hal untuk mempersiapkan penampilan dialog
    Public Sub createDialog()
        isMoveAllowed = False
        PictureBox1.Visible = False
        NPC1.Visible = False
        NPC2.Visible = False
        NPC3.Visible = False
        NPC4.Visible = False
        NPC5.Visible = False
        Select Case npcType
            Case 2
                ArmoryDialog.Visible = True
            Case 301
                QuestDialog.Visible = True
                QuestIntro.Text = "Hai! Selamat datang di pusat Misi! Silahkan pilih misi yang ada dibawah ini"
                npcTalk = 301
                makeQuest()
            Case 302
                QuestDialog.Visible = True
                Select Case plot_quest
                    Case Is < 1
                        QuestIntro.Text = "Halo petualang muda! Bisakah anda membantu saya? "
                    Case 2
                        QuestIntro.Text = "Terima kasih anak muda! Mari kita lihat, disini tertulis bahwa untuk menyegel para monster, kita harus menemukan Crystal of Athena, Sword of Zeus dan Spirit of Ares lalu menyatukannya di Kuil Freyr... Ketiga benda tersebut terpencar di benua utama..."
                End Select
                npcTalk = 302
                makeQuest()
            Case 3021
                QuestDialog.Visible = True
                Select Case plot_quest
                    Case Is < 1
                        QuestIntro.Text = "Anda menginjak sesuatu didaerah sini... Sebuah lembaran kertas, berisi tulisan asing! Sepertinya orang sudah tidak peduli lagi dengan lingkungan!"
                    Case 1
                        QuestIntro.Text = "Anda menginjak sesuatu didaerah sini... Sebuah lembaran kertas, berisi tulisan asing! Sepertinya dari buku yang memuat petunjuk untuk menyelamatkan dunia! Kirimkan kertas ini ke perempuan dikota agar bisa diterjemahkan!!"
                End Select
                npcTalk = 3021
                makeQuest()
        End Select
    End Sub

    'Menutup dialog
    Public Sub closeDialog()
        isMoveAllowed = True
        PictureBox1.Visible = True
        NPC1.Visible = True
        NPC2.Visible = True
        NPC3.Visible = True
        NPC4.Visible = True
        NPC5.Visible = True
        Select Case npcTalk
            Case 3021
                NPC1.Visible = False
        End Select
        npcTalk = 0
    End Sub

    'Mempersiapkan battle
    Public Sub battleOn()
        enemyHPc = 100
        MyHP.Value = myHPc
        EnemyHP.Value = enemyHPc
        turn = 2
        spaceHit = 0
        spaceCombo = ""

        enemyNum = Int(Rnd() * (Now.Millisecond / 80))
        If enemyNum > 4 Then
            enemyNum = 2
        End If

        Select Case enemyNum
            Case 0
                enemypic.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mons" & mapNum & "0.bmp")
            Case 1
                enemypic.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mons" & mapNum & "1.bmp")
            Case 2
                enemypic.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mons" & mapNum & "2.bmp")
            Case 3
                enemypic.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mons" & mapNum & "3.bmp")
            Case 4
                enemypic.Image = Image.FromFile(Application.StartupPath & "/images/monsters/" & mapNum & "/mons" & mapNum & "4.bmp")
        End Select

        mypic.Image = Image.FromFile(Application.StartupPath & "/images/chara-m.bmp")

        isMoveAllowed = False
        PictureBox1.Visible = False
        spaceHit = 0
        SpaceHitter.Visible = False

        BattleTimer.Enabled = True
        BattleBox.Visible = True
    End Sub

    'Turn-based battle yang diatur lewat timer
    Private Sub BattleTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BattleTimer.Tick
        If turn = 1 Then
            SpaceHitter.Visible = False
            hit = ((Rnd() * 15) + EnemyAtt.Items.Item(enemyNum))
            If hit < 0 Then
                hit = 1
            End If
            myHPc = myHPc - hit
            turn = turn + 1
            txtBattle.Text = "Enemy hit " & hit & " to player!"
        ElseIf turn = 2 Then
            hit = ((Rnd() * 25) - (EnemyDef.Items.Item(enemyNum)) / 3) + att
            If hit < 0 Then
                hit = 1
            End If
            enemyHPc = enemyHPc - hit - spaceHit

            If spaceHit <> 0 Then
                SpaceHitter.Visible = True
                SpaceHitter.Text = "-" & spaceHit
                spaceHit = 0
                spaceCombo = ""
            End If

            turn = turn - 1
            txtBattle.Text = "Player hit " & hit & " to enemy!"
        End If

        If myHPc <= 0 Then
            BattleTimer.Enabled = False
            myHPc = 0
            deadChoice()
            battleFin()
        ElseIf enemyHPc <= 0 Then
            BattleTimer.Enabled = False
            enemyHPc = 0
            getExp = EnemyAtt.Items.Item(enemyNum) * 2
            getMoney = EnemyAtt.Items.Item(enemyNum) * 5
            exp = exp + getExp
            money = money + getMoney
            MsgBox("You win! You got " & getExp & " EXP and " & getMoney & " G")
            battleFin()
        End If

        If myHPc < 101 Or enemyHPc < 101 Or myHPc > 0 Or enemyHPc > 0 Then
            MyHP.Value = myHPc
            EnemyHP.Value = enemyHPc
        End If
    End Sub

    'Pilihan ketika mati
    Public Sub deadChoice()
        result = MsgBox("You lose! Ingin main lagi?", MsgBoxStyle.YesNo, "Confirmation")
        If result = MsgBoxResult.No Then
            Me.Close()
        Else
            mapNum = 1
            mapType = 1
            myHPc = 100
            att = 0
            swordNum = 0
            potHP1 = 0
            money = 50
            exp = 1
            PictureBox1.Location = New Point(136, 8)
            isMoveAllowed = True
            createMap()
            calcStat()
        End If
    End Sub

    'Jika battle selesai, ini dijalankan
    Public Sub battleFin()
        BattleTimer.Enabled = False
        isMoveAllowed = True
        PictureBox1.Visible = True
        enemyNum = 1
        turn = 0
        spaceHit = 0
        spaceCombo = ""
        enemyHPc = 0

        BattleBox.Visible = False
        calcStat()
        Focus()
    End Sub

    'Dialog
    'ARMORY DIALOG - START HERE
    Private Sub btn_2_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2_quit.Click
        closeDialog()
        ArmoryDialog.Visible = False
        Focus()
    End Sub

    Public Sub armoryCalc()
        Select Case armorycbx.SelectedIndex
            Case 0
                price = 400
                armorynum.Enabled = False
            Case 1
                price = 5 * armorynum.Value
                armorynum.Enabled = True
            Case 2
                price = 2000
                armorynum.Enabled = False
            Case 3
                price = 5000
                armorynum.Enabled = False
        End Select
        armoryprice.Text = price & " G"
    End Sub

    Private Sub armorycbx_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles armorycbx.SelectedIndexChanged
        armoryCalc()
    End Sub

    Private Sub armorynum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles armorynum.ValueChanged
        armoryCalc()
    End Sub

    Private Sub btn_2_buy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2_buy.Click
        armoryCalc()
        If money >= price Then
            Select Case armorycbx.SelectedIndex
                Case 0
                    doPayBack()
                    swordNum = 1
                    att = att + 5
                Case 1
                    potHP1 = potHP1 + armorynum.Value
                    money = money - price
                Case 2
                    doPayBack()
                    swordNum = 2
                    att = att + 15
                Case 3
                    doPayBack()
                    swordNum = 3
                    att = att + 30
            End Select
            calcStat()
        End If
        armorycbx.SelectedIndex = 0
    End Sub

    Public Sub doPayBack()
        Select Case swordNum
            Case 1
                att = att - 5
                money = money + 200
            Case 2
                att = att - 15
                money = money + 700
            Case 3
                att = att - 30
                money = money + 1700
        End Select
        money = money - price
    End Sub
    'ARMORY DIALOG - END HERE

    'QUEST DIALOG - START HERE
    Public Sub clearDialog()
        QuestA1.Text = ""
        QuestA2.Text = ""
        QuestA3.Text = ""
        QuestA4.Text = ""
        QuestA5.Text = ""
    End Sub

    Public Sub makeQuest()
        Select Case npcTalk
            Case 301
                Select Case quest1
                    Case Is < 1
                        QuestA1.Text = "Misi: Naik ke level 5"
                    Case 1
                        QuestA1.Text = "Menyelesaikan misi naik level 5!"
                End Select
                Select Case quest2
                    Case Is < 1
                        QuestA2.Text = "Misi: Miliki 1500 HP Potion"
                    Case 1
                        QuestA2.Text = "Menyelesaikan misi 1500 potion!"
                End Select
                Select Case quest3
                    Case Is < 1
                        QuestA3.Text = "Misi: Miliki Sword of Ares"
                    Case 1
                        QuestA3.Text = "Menyelesaikan misi Sword of Ares!"
                End Select
            Case 302
                Select Case plot_quest
                    Case Is < 1
                        QuestA1.Text = "Tentu saja!"
                        QuestA2.Text = "Apa yang terjadi?"
                End Select
            Case 3021
                If plot_quest = 1 Then
                    plot_quest = 2
                End If
        End Select
    End Sub

    Public Sub getQuest()
        Select Case selectedQuest
            Case 1
                If QuestA1.Text = "Misi: Naik ke level 5" Then
                    quest1 = 1
                    clearDialog()
                    QuestIntro.Text = "Misimu adalah naik hingga level 5 dan kembali lagi kesini untuk memberitahukan ku! Selamat Berjuang!"
                ElseIf QuestA1.Text = "Menyelesaikan misi naik level 5!" Then
                    If level >= 5 Then
                        quest1 = 2
                        QuestA1.Text = ""
                        MsgBox("Selamat Anda telah menyelesaikan misi ini!", MsgBoxStyle.Information, "Congratulations!")
                    End If
                ElseIf QuestA1.Text = "Tentu saja!" And npcTalk = 302 Then
                    plot_quest = 1
                    clearDialog()
                    QuestIntro.Text = "Terima kasih nak! Misimu adalah mencari potongan halaman yang hilang di hutan sana..."
                End If
            Case 2
                If QuestA2.Text = "Misi: Miliki 1500 HP Potion" Then
                    quest2 = 1
                    clearDialog()
                    QuestIntro.Text = "Misimu adalah membeli 1500 Potion dan kembali lagi kesini untuk memberitahukan ku! Selamat Berjuang!"
                ElseIf QuestA2.Text = "Menyelesaikan misi 1500 potion!" Then
                    If potHP1 >= 1500 Then
                        quest2 = 2
                        QuestA2.Text = ""
                        MsgBox("Selamat Anda telah menyelesaikan misi ini!", MsgBoxStyle.Information, "Congratulations!")
                    End If
                ElseIf QuestA2.Text = "Apa yang terjadi?" And npcTalk = 302 Then
                    clearDialog()
                    QuestIntro.Text = "Saya telah menemukan sebuah buku yang berisi rahasia untuk mengembalikan kedamaian dunia ini lagi, namun ada satu halaman penting yang hilang! Sehingga saya tidak tau apa yang harus dilakukan..."
                End If
            Case 3
                If QuestA3.Text = "Misi: Miliki Sword of Ares" Then
                    quest3 = 1
                    clearDialog()
                    QuestIntro.Text = "Misimu adalah membeli Sword of Ares dan kembali lagi kesini untuk memberitahukan ku! Selamat Berjuang!"
                ElseIf QuestA3.Text = "Menyelesaikan misi Sword of Ares!" Then
                    If swordNum = 3 Then
                        quest3 = 2
                        QuestA3.Text = ""
                        MsgBox("Selamat Anda telah menyelesaikan misi ini!", MsgBoxStyle.Information, "Congratulations!")
                    End If
                End If
        End Select
        If quest1 = 2 And quest2 = 2 And quest3 = 2 Then
            MsgBox("Selamat Anda telah menyelesaikan permainan ini!", MsgBoxStyle.Information, "Congratulations!")
            Me.Close()
        End If
    End Sub

    Private Sub QuestA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestA1.Click
        If QuestA1.Text <> "" Then
            selectedQuest = 1
            getQuest()
        End If
    End Sub

    Private Sub QuestA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestA2.Click
        If QuestA2.Text <> "" Then
            selectedQuest = 2
            getQuest()
        End If
    End Sub

    Private Sub QuestA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestA3.Click
        If QuestA3.Text <> "" Then
            selectedQuest = 3
            getQuest()
        End If
    End Sub

    Private Sub QuestA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestA4.Click
        If QuestA4.Text <> "" Then
            selectedQuest = 4
            getQuest()
        End If
    End Sub

    Private Sub QuestA5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestA5.Click
        If QuestA5.Text <> "" Then
            selectedQuest = 5
            getQuest()
        End If
    End Sub

    Private Sub btn_3_quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3_quit.Click
        closeDialog()
        QuestDialog.Visible = False
        Focus()
    End Sub

    Private Sub Label12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        form2.ShowDialog()
    End Sub
    'END OF QUEST DIALOG


    'FIXED BUGS:
    '4/6/2012 - Major Fix: Quest Dialog 
End Class
'This thing is resource killer! I can't make a game with this... =(( --catatan penulis :)v