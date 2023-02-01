Public Class Form2
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LittleRPG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Engine: Visual Basic 2003"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Created by:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " Feryandi Nurdiantoro / 13 / XD"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(26, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Friska Tanubrata / 14 / XD"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " Jessica Maretha / 19 / XD"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(26, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Maria Angelina / 24 / XD"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(26, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Morini Suryanata / 26 / XD"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cool!"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Cheat"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(32, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Money - Combo ""cccccc"" dalam 1 turn"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(32, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Level - Combo ""zzzzzz"" dalam 1 turn"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(32, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(240, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Potion - Combo ""xxxxxx"" dalam 1 turn"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Help me!"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(264, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 32)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "All Loading Pictures, Sounds and Monster Illustrations are copyrighted. I do not " & _
        "own that."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Location = New System.Drawing.Point(264, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(288, 120)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Program ini dibuat dari nol (0) bukan dengan men-jiplak atau men-copy program lai" & _
        "n yang sudah jadi. Beberapa script yang belum diajarkan didapatkan dari internet" & _
        " dalam bentuk script yang belum jadi (bukan program)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(336, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Copyrights"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(554, 344)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "About this LittleRPG"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Gunakan Tombol Atas,bawah,kanan,kiri untuk bergerak", MsgBoxStyle.OKOnly)
        MsgBox("Penyerangan dilakukan otomatis saat anda bergerak di area terbuka (bukan kota)", MsgBoxStyle.OKOnly)
        MsgBox("Gunakan tombol z,x,c,v untuk menambah hit dan melakukan combo!", MsgBoxStyle.OKOnly)
        MsgBox("Gunakan shortcut A untuk menggunakan potion (jika ada)", MsgBoxStyle.OKOnly)
        MsgBox("Sword hanya menambah attack", MsgBoxStyle.OKOnly)
    End Sub

End Class
