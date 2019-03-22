<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.LogindataDataSet = New bhargavi.logindataDataSet()
        Me.LoginTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableTableAdapter = New bhargavi.logindataDataSetTableAdapters.loginTableTableAdapter()
        Me.TableAdapterManager = New bhargavi.logindataDataSetTableAdapters.TableAdapterManager()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Homebt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumberRb = New System.Windows.Forms.RadioButton()
        Me.SmallRb = New System.Windows.Forms.RadioButton()
        Me.CapitalRb = New System.Windows.Forms.RadioButton()
        Me.DeleteBt = New System.Windows.Forms.Button()
        Me.ResetBt = New System.Windows.Forms.Button()
        Me.ShowPassword = New System.Windows.Forms.CheckBox()
        Me.KeyGen = New System.Windows.Forms.Button()
        Me.loginbt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C5 = New System.Windows.Forms.Button()
        Me.K1 = New System.Windows.Forms.Button()
        Me.K2 = New System.Windows.Forms.Button()
        Me.K3 = New System.Windows.Forms.Button()
        Me.K4 = New System.Windows.Forms.Button()
        Me.K5 = New System.Windows.Forms.Button()
        Me.K6 = New System.Windows.Forms.Button()
        Me.K7 = New System.Windows.Forms.Button()
        Me.K8 = New System.Windows.Forms.Button()
        Me.K9 = New System.Windows.Forms.Button()
        Me.K10 = New System.Windows.Forms.Button()
        Me.K11 = New System.Windows.Forms.Button()
        Me.K12 = New System.Windows.Forms.Button()
        Me.K13 = New System.Windows.Forms.Button()
        Me.K14 = New System.Windows.Forms.Button()
        Me.K15 = New System.Windows.Forms.Button()
        Me.K16 = New System.Windows.Forms.Button()
        Me.K17 = New System.Windows.Forms.Button()
        Me.K18 = New System.Windows.Forms.Button()
        Me.K19 = New System.Windows.Forms.Button()
        Me.K20 = New System.Windows.Forms.Button()
        Me.K21 = New System.Windows.Forms.Button()
        Me.K22 = New System.Windows.Forms.Button()
        Me.K23 = New System.Windows.Forms.Button()
        Me.K24 = New System.Windows.Forms.Button()
        Me.K25 = New System.Windows.Forms.Button()
        Me.K26 = New System.Windows.Forms.Button()
        Me.K27 = New System.Windows.Forms.Button()
        Me.K28 = New System.Windows.Forms.Button()
        Me.K29 = New System.Windows.Forms.Button()
        Me.K30 = New System.Windows.Forms.Button()
        Me.K31 = New System.Windows.Forms.Button()
        Me.K32 = New System.Windows.Forms.Button()
        Me.K33 = New System.Windows.Forms.Button()
        Me.K34 = New System.Windows.Forms.Button()
        Me.K35 = New System.Windows.Forms.Button()
        Me.K36 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.C6 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.LogindataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.Location = New System.Drawing.Point(217, 37)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(88, 18)
        UserNameLabel.TabIndex = 1
        UserNameLabel.Text = "User Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfBirthLabel.Location = New System.Drawing.Point(217, 61)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(97, 18)
        DateOfBirthLabel.TabIndex = 3
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(218, 84)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(79, 18)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'LogindataDataSet
        '
        Me.LogindataDataSet.DataSetName = "logindataDataSet"
        Me.LogindataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableBindingSource
        '
        Me.LoginTableBindingSource.DataMember = "loginTable"
        Me.LoginTableBindingSource.DataSource = Me.LogindataDataSet
        '
        'LoginTableTableAdapter
        '
        Me.LoginTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loginTableTableAdapter = Me.LoginTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = bhargavi.logindataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserName
        '
        Me.UserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginTableBindingSource, "UserName", True))
        Me.UserName.Location = New System.Drawing.Point(334, 37)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(200, 20)
        Me.UserName.TabIndex = 2
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LoginTableBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(334, 62)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 4
        '
        'Password
        '
        Me.Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginTableBindingSource, "Password", True))
        Me.Password.Location = New System.Drawing.Point(335, 87)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(200, 20)
        Me.Password.TabIndex = 6
        '
        'Homebt
        '
        Me.Homebt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Homebt.Location = New System.Drawing.Point(422, 367)
        Me.Homebt.Name = "Homebt"
        Me.Homebt.Size = New System.Drawing.Size(75, 23)
        Me.Homebt.TabIndex = 50
        Me.Homebt.Text = "HOME"
        Me.Homebt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(581, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "KeyBoards:"
        '
        'NumberRb
        '
        Me.NumberRb.AutoSize = True
        Me.NumberRb.Location = New System.Drawing.Point(592, 294)
        Me.NumberRb.Name = "NumberRb"
        Me.NumberRb.Size = New System.Drawing.Size(83, 17)
        Me.NumberRb.TabIndex = 40
        Me.NumberRb.Text = "Num/symbls"
        Me.NumberRb.UseVisualStyleBackColor = True
        '
        'SmallRb
        '
        Me.SmallRb.AutoSize = True
        Me.SmallRb.Location = New System.Drawing.Point(592, 268)
        Me.SmallRb.Name = "SmallRb"
        Me.SmallRb.Size = New System.Drawing.Size(43, 17)
        Me.SmallRb.TabIndex = 39
        Me.SmallRb.Text = "abc"
        Me.SmallRb.UseVisualStyleBackColor = True
        '
        'CapitalRb
        '
        Me.CapitalRb.AutoSize = True
        Me.CapitalRb.Location = New System.Drawing.Point(592, 245)
        Me.CapitalRb.Name = "CapitalRb"
        Me.CapitalRb.Size = New System.Drawing.Size(46, 17)
        Me.CapitalRb.TabIndex = 38
        Me.CapitalRb.Text = "ABC"
        Me.CapitalRb.UseVisualStyleBackColor = True
        '
        'DeleteBt
        '
        Me.DeleteBt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBt.Location = New System.Drawing.Point(620, 148)
        Me.DeleteBt.Name = "DeleteBt"
        Me.DeleteBt.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBt.TabIndex = 37
        Me.DeleteBt.Text = "Delete"
        Me.DeleteBt.UseVisualStyleBackColor = True
        '
        'ResetBt
        '
        Me.ResetBt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBt.Location = New System.Drawing.Point(620, 180)
        Me.ResetBt.Name = "ResetBt"
        Me.ResetBt.Size = New System.Drawing.Size(75, 23)
        Me.ResetBt.TabIndex = 36
        Me.ResetBt.Text = "Reset"
        Me.ResetBt.UseVisualStyleBackColor = True
        '
        'ShowPassword
        '
        Me.ShowPassword.AutoSize = True
        Me.ShowPassword.ForeColor = System.Drawing.Color.Silver
        Me.ShowPassword.Location = New System.Drawing.Point(541, 87)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(101, 17)
        Me.ShowPassword.TabIndex = 52
        Me.ShowPassword.Text = "Show password"
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'KeyGen
        '
        Me.KeyGen.BackgroundImage = Global.bhargavi.My.Resources.Resources.KEYBOARD_ICON_MINI1
        Me.KeyGen.Location = New System.Drawing.Point(500, 85)
        Me.KeyGen.Name = "KeyGen"
        Me.KeyGen.Size = New System.Drawing.Size(36, 22)
        Me.KeyGen.TabIndex = 51
        Me.KeyGen.UseVisualStyleBackColor = True
        '
        'loginbt
        '
        Me.loginbt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbt.Location = New System.Drawing.Point(322, 367)
        Me.loginbt.Name = "loginbt"
        Me.loginbt.Size = New System.Drawing.Size(75, 23)
        Me.loginbt.TabIndex = 7
        Me.loginbt.Text = "SIGN UP"
        Me.loginbt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Label3"
        '
        'C5
        '
        Me.C5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C5.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C5.Location = New System.Drawing.Point(422, 334)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(58, 23)
        Me.C5.TabIndex = 43
        Me.C5.UseVisualStyleBackColor = True
        '
        'K1
        '
        Me.K1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K1.Location = New System.Drawing.Point(6, 6)
        Me.K1.Name = "K1"
        Me.K1.Size = New System.Drawing.Size(47, 23)
        Me.K1.TabIndex = 0
        Me.K1.UseVisualStyleBackColor = True
        '
        'K2
        '
        Me.K2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K2.Location = New System.Drawing.Point(62, 6)
        Me.K2.Name = "K2"
        Me.K2.Size = New System.Drawing.Size(47, 23)
        Me.K2.TabIndex = 1
        Me.K2.UseVisualStyleBackColor = True
        '
        'K3
        '
        Me.K3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K3.Location = New System.Drawing.Point(118, 6)
        Me.K3.Name = "K3"
        Me.K3.Size = New System.Drawing.Size(47, 23)
        Me.K3.TabIndex = 2
        Me.K3.UseVisualStyleBackColor = True
        '
        'K4
        '
        Me.K4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K4.Location = New System.Drawing.Point(174, 6)
        Me.K4.Name = "K4"
        Me.K4.Size = New System.Drawing.Size(47, 23)
        Me.K4.TabIndex = 3
        Me.K4.UseVisualStyleBackColor = True
        '
        'K5
        '
        Me.K5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K5.Location = New System.Drawing.Point(230, 6)
        Me.K5.Name = "K5"
        Me.K5.Size = New System.Drawing.Size(47, 23)
        Me.K5.TabIndex = 4
        Me.K5.UseVisualStyleBackColor = True
        '
        'K6
        '
        Me.K6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K6.Location = New System.Drawing.Point(286, 6)
        Me.K6.Name = "K6"
        Me.K6.Size = New System.Drawing.Size(47, 23)
        Me.K6.TabIndex = 5
        Me.K6.UseVisualStyleBackColor = True
        '
        'K7
        '
        Me.K7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K7.Location = New System.Drawing.Point(6, 38)
        Me.K7.Name = "K7"
        Me.K7.Size = New System.Drawing.Size(47, 23)
        Me.K7.TabIndex = 6
        Me.K7.UseVisualStyleBackColor = True
        '
        'K8
        '
        Me.K8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K8.Location = New System.Drawing.Point(62, 38)
        Me.K8.Name = "K8"
        Me.K8.Size = New System.Drawing.Size(47, 23)
        Me.K8.TabIndex = 7
        Me.K8.UseVisualStyleBackColor = True
        '
        'K9
        '
        Me.K9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K9.Location = New System.Drawing.Point(118, 38)
        Me.K9.Name = "K9"
        Me.K9.Size = New System.Drawing.Size(47, 23)
        Me.K9.TabIndex = 8
        Me.K9.UseVisualStyleBackColor = True
        '
        'K10
        '
        Me.K10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K10.Location = New System.Drawing.Point(174, 38)
        Me.K10.Name = "K10"
        Me.K10.Size = New System.Drawing.Size(47, 23)
        Me.K10.TabIndex = 9
        Me.K10.UseVisualStyleBackColor = True
        '
        'K11
        '
        Me.K11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K11.Location = New System.Drawing.Point(230, 38)
        Me.K11.Name = "K11"
        Me.K11.Size = New System.Drawing.Size(47, 23)
        Me.K11.TabIndex = 10
        Me.K11.UseVisualStyleBackColor = True
        '
        'K12
        '
        Me.K12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K12.Location = New System.Drawing.Point(286, 38)
        Me.K12.Name = "K12"
        Me.K12.Size = New System.Drawing.Size(47, 23)
        Me.K12.TabIndex = 11
        Me.K12.UseVisualStyleBackColor = True
        '
        'K13
        '
        Me.K13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K13.Location = New System.Drawing.Point(6, 70)
        Me.K13.Name = "K13"
        Me.K13.Size = New System.Drawing.Size(47, 23)
        Me.K13.TabIndex = 12
        Me.K13.UseVisualStyleBackColor = True
        '
        'K14
        '
        Me.K14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K14.Location = New System.Drawing.Point(62, 70)
        Me.K14.Name = "K14"
        Me.K14.Size = New System.Drawing.Size(47, 23)
        Me.K14.TabIndex = 13
        Me.K14.UseVisualStyleBackColor = True
        '
        'K15
        '
        Me.K15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K15.Location = New System.Drawing.Point(118, 70)
        Me.K15.Name = "K15"
        Me.K15.Size = New System.Drawing.Size(47, 23)
        Me.K15.TabIndex = 14
        Me.K15.UseVisualStyleBackColor = True
        '
        'K16
        '
        Me.K16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K16.Location = New System.Drawing.Point(174, 70)
        Me.K16.Name = "K16"
        Me.K16.Size = New System.Drawing.Size(47, 23)
        Me.K16.TabIndex = 15
        Me.K16.UseVisualStyleBackColor = True
        '
        'K17
        '
        Me.K17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K17.Location = New System.Drawing.Point(230, 70)
        Me.K17.Name = "K17"
        Me.K17.Size = New System.Drawing.Size(47, 23)
        Me.K17.TabIndex = 16
        Me.K17.UseVisualStyleBackColor = True
        '
        'K18
        '
        Me.K18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K18.Location = New System.Drawing.Point(286, 70)
        Me.K18.Name = "K18"
        Me.K18.Size = New System.Drawing.Size(47, 23)
        Me.K18.TabIndex = 17
        Me.K18.UseVisualStyleBackColor = True
        '
        'K19
        '
        Me.K19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K19.Location = New System.Drawing.Point(6, 102)
        Me.K19.Name = "K19"
        Me.K19.Size = New System.Drawing.Size(47, 23)
        Me.K19.TabIndex = 18
        Me.K19.UseVisualStyleBackColor = True
        '
        'K20
        '
        Me.K20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K20.Location = New System.Drawing.Point(62, 102)
        Me.K20.Name = "K20"
        Me.K20.Size = New System.Drawing.Size(47, 23)
        Me.K20.TabIndex = 19
        Me.K20.UseVisualStyleBackColor = True
        '
        'K21
        '
        Me.K21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K21.Location = New System.Drawing.Point(118, 102)
        Me.K21.Name = "K21"
        Me.K21.Size = New System.Drawing.Size(47, 23)
        Me.K21.TabIndex = 20
        Me.K21.UseVisualStyleBackColor = True
        '
        'K22
        '
        Me.K22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K22.Location = New System.Drawing.Point(174, 102)
        Me.K22.Name = "K22"
        Me.K22.Size = New System.Drawing.Size(47, 23)
        Me.K22.TabIndex = 21
        Me.K22.UseVisualStyleBackColor = True
        '
        'K23
        '
        Me.K23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K23.Location = New System.Drawing.Point(230, 102)
        Me.K23.Name = "K23"
        Me.K23.Size = New System.Drawing.Size(47, 23)
        Me.K23.TabIndex = 22
        Me.K23.UseVisualStyleBackColor = True
        '
        'K24
        '
        Me.K24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K24.Location = New System.Drawing.Point(286, 102)
        Me.K24.Name = "K24"
        Me.K24.Size = New System.Drawing.Size(47, 23)
        Me.K24.TabIndex = 23
        Me.K24.UseVisualStyleBackColor = True
        '
        'K25
        '
        Me.K25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K25.Location = New System.Drawing.Point(6, 134)
        Me.K25.Name = "K25"
        Me.K25.Size = New System.Drawing.Size(47, 23)
        Me.K25.TabIndex = 24
        Me.K25.UseVisualStyleBackColor = True
        '
        'K26
        '
        Me.K26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K26.Location = New System.Drawing.Point(62, 134)
        Me.K26.Name = "K26"
        Me.K26.Size = New System.Drawing.Size(47, 23)
        Me.K26.TabIndex = 25
        Me.K26.UseVisualStyleBackColor = True
        '
        'K27
        '
        Me.K27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K27.Location = New System.Drawing.Point(118, 134)
        Me.K27.Name = "K27"
        Me.K27.Size = New System.Drawing.Size(47, 23)
        Me.K27.TabIndex = 26
        Me.K27.UseVisualStyleBackColor = True
        '
        'K28
        '
        Me.K28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K28.Location = New System.Drawing.Point(174, 134)
        Me.K28.Name = "K28"
        Me.K28.Size = New System.Drawing.Size(47, 23)
        Me.K28.TabIndex = 27
        Me.K28.UseVisualStyleBackColor = True
        '
        'K29
        '
        Me.K29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K29.Location = New System.Drawing.Point(230, 134)
        Me.K29.Name = "K29"
        Me.K29.Size = New System.Drawing.Size(47, 23)
        Me.K29.TabIndex = 28
        Me.K29.UseVisualStyleBackColor = True
        '
        'K30
        '
        Me.K30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K30.Location = New System.Drawing.Point(286, 134)
        Me.K30.Name = "K30"
        Me.K30.Size = New System.Drawing.Size(47, 23)
        Me.K30.TabIndex = 29
        Me.K30.UseVisualStyleBackColor = True
        '
        'K31
        '
        Me.K31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K31.Location = New System.Drawing.Point(6, 166)
        Me.K31.Name = "K31"
        Me.K31.Size = New System.Drawing.Size(47, 23)
        Me.K31.TabIndex = 30
        Me.K31.UseVisualStyleBackColor = True
        '
        'K32
        '
        Me.K32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K32.Location = New System.Drawing.Point(62, 166)
        Me.K32.Name = "K32"
        Me.K32.Size = New System.Drawing.Size(47, 23)
        Me.K32.TabIndex = 31
        Me.K32.UseVisualStyleBackColor = True
        '
        'K33
        '
        Me.K33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K33.Location = New System.Drawing.Point(118, 166)
        Me.K33.Name = "K33"
        Me.K33.Size = New System.Drawing.Size(47, 23)
        Me.K33.TabIndex = 32
        Me.K33.UseVisualStyleBackColor = True
        '
        'K34
        '
        Me.K34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K34.Location = New System.Drawing.Point(174, 166)
        Me.K34.Name = "K34"
        Me.K34.Size = New System.Drawing.Size(47, 23)
        Me.K34.TabIndex = 33
        Me.K34.UseVisualStyleBackColor = True
        '
        'K35
        '
        Me.K35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K35.Location = New System.Drawing.Point(230, 166)
        Me.K35.Name = "K35"
        Me.K35.Size = New System.Drawing.Size(47, 23)
        Me.K35.TabIndex = 34
        Me.K35.UseVisualStyleBackColor = True
        '
        'K36
        '
        Me.K36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K36.Location = New System.Drawing.Point(286, 166)
        Me.K36.Name = "K36"
        Me.K36.Size = New System.Drawing.Size(47, 23)
        Me.K36.TabIndex = 35
        Me.K36.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.K36, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K35, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K34, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K33, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K32, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K31, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.K30, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K29, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K28, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K27, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K26, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K25, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.K24, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K23, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K22, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K21, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K20, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K19, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.K18, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K17, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K16, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K15, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K14, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K13, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.K12, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K11, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K10, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.K6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.K5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.K4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.K3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.K2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.K1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(195, 135)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(345, 197)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'C6
        '
        Me.C6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C6.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C6.Location = New System.Drawing.Point(479, 334)
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(61, 23)
        Me.C6.TabIndex = 45
        Me.C6.UseVisualStyleBackColor = True
        '
        'C4
        '
        Me.C4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C4.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C4.Location = New System.Drawing.Point(365, 334)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(58, 23)
        Me.C4.TabIndex = 46
        Me.C4.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C3.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C3.Location = New System.Drawing.Point(308, 334)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(58, 23)
        Me.C3.TabIndex = 47
        Me.C3.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C2.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C2.Location = New System.Drawing.Point(251, 334)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(58, 23)
        Me.C2.TabIndex = 48
        Me.C2.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1.Image = Global.bhargavi.My.Resources.Resources.ARROW
        Me.C1.Location = New System.Drawing.Point(194, 334)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(58, 23)
        Me.C1.TabIndex = 49
        Me.C1.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 178
        Me.LineShape1.X2 = 709
        Me.LineShape1.Y1 = 121
        Me.LineShape1.Y2 = 121
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 178
        Me.LineShape2.X2 = 709
        Me.LineShape2.Y1 = 398
        Me.LineShape2.Y2 = 398
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 710
        Me.LineShape3.X2 = 709
        Me.LineShape3.Y1 = 122
        Me.LineShape3.Y2 = 399
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 178
        Me.LineShape4.X2 = 177
        Me.LineShape4.Y1 = 122
        Me.LineShape4.Y2 = 399
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(880, 411)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 18)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "REGISTRATION FORM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'registrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 411)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.KeyGen)
        Me.Controls.Add(Me.Homebt)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C6)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.C5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumberRb)
        Me.Controls.Add(Me.SmallRb)
        Me.Controls.Add(Me.CapitalRb)
        Me.Controls.Add(Me.DeleteBt)
        Me.Controls.Add(Me.ResetBt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginbt)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "registrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrationForm"
        CType(Me.LogindataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogindataDataSet As bhargavi.logindataDataSet
    Friend WithEvents LoginTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableTableAdapter As bhargavi.logindataDataSetTableAdapters.loginTableTableAdapter
    Friend WithEvents TableAdapterManager As bhargavi.logindataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Homebt As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumberRb As System.Windows.Forms.RadioButton
    Friend WithEvents SmallRb As System.Windows.Forms.RadioButton
    Friend WithEvents CapitalRb As System.Windows.Forms.RadioButton
    Friend WithEvents DeleteBt As System.Windows.Forms.Button
    Friend WithEvents ResetBt As System.Windows.Forms.Button
    Friend WithEvents ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents KeyGen As System.Windows.Forms.Button
    Friend WithEvents loginbt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C5 As System.Windows.Forms.Button
    Friend WithEvents K1 As System.Windows.Forms.Button
    Friend WithEvents K2 As System.Windows.Forms.Button
    Friend WithEvents K3 As System.Windows.Forms.Button
    Friend WithEvents K4 As System.Windows.Forms.Button
    Friend WithEvents K5 As System.Windows.Forms.Button
    Friend WithEvents K6 As System.Windows.Forms.Button
    Friend WithEvents K7 As System.Windows.Forms.Button
    Friend WithEvents K8 As System.Windows.Forms.Button
    Friend WithEvents K9 As System.Windows.Forms.Button
    Friend WithEvents K10 As System.Windows.Forms.Button
    Friend WithEvents K11 As System.Windows.Forms.Button
    Friend WithEvents K12 As System.Windows.Forms.Button
    Friend WithEvents K13 As System.Windows.Forms.Button
    Friend WithEvents K14 As System.Windows.Forms.Button
    Friend WithEvents K15 As System.Windows.Forms.Button
    Friend WithEvents K16 As System.Windows.Forms.Button
    Friend WithEvents K17 As System.Windows.Forms.Button
    Friend WithEvents K18 As System.Windows.Forms.Button
    Friend WithEvents K19 As System.Windows.Forms.Button
    Friend WithEvents K20 As System.Windows.Forms.Button
    Friend WithEvents K21 As System.Windows.Forms.Button
    Friend WithEvents K22 As System.Windows.Forms.Button
    Friend WithEvents K23 As System.Windows.Forms.Button
    Friend WithEvents K24 As System.Windows.Forms.Button
    Friend WithEvents K25 As System.Windows.Forms.Button
    Friend WithEvents K26 As System.Windows.Forms.Button
    Friend WithEvents K27 As System.Windows.Forms.Button
    Friend WithEvents K28 As System.Windows.Forms.Button
    Friend WithEvents K29 As System.Windows.Forms.Button
    Friend WithEvents K30 As System.Windows.Forms.Button
    Friend WithEvents K31 As System.Windows.Forms.Button
    Friend WithEvents K32 As System.Windows.Forms.Button
    Friend WithEvents K33 As System.Windows.Forms.Button
    Friend WithEvents K34 As System.Windows.Forms.Button
    Friend WithEvents K35 As System.Windows.Forms.Button
    Friend WithEvents K36 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents C6 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.Button
    Friend WithEvents C3 As System.Windows.Forms.Button
    Friend WithEvents C2 As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
