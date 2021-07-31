<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBanking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBanking))
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.tosFileOperations = New System.Windows.Forms.ToolStrip()
        Me.tosbtnNewFile = New System.Windows.Forms.ToolStripButton()
        Me.tosbtnOpenFile = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tosbtnSaveFile = New System.Windows.Forms.ToolStripButton()
        Me.tosbtnSaveAs = New System.Windows.Forms.ToolStripButton()
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.tpgContact = New System.Windows.Forms.TabPage()
        Me.pnlContact = New System.Windows.Forms.Panel()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mtbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.hdrZip = New System.Windows.Forms.Label()
        Me.hdrState = New System.Windows.Forms.Label()
        Me.hdrCity = New System.Windows.Forms.Label()
        Me.hdrAddress = New System.Windows.Forms.Label()
        Me.hdrEmail = New System.Windows.Forms.Label()
        Me.hdrPhoneNumber = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.ddlState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.tpgCard = New System.Windows.Forms.TabPage()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.hdrCVV = New System.Windows.Forms.Label()
        Me.hdrExpirationDate = New System.Windows.Forms.Label()
        Me.hdrCardNumber = New System.Windows.Forms.Label()
        Me.hdrCardType = New System.Windows.Forms.Label()
        Me.hdrType = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.mtbCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.ddlCardType = New System.Windows.Forms.ComboBox()
        Me.radDebit = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.tpgAccount = New System.Windows.Forms.TabPage()
        Me.pnlAccount = New System.Windows.Forms.Panel()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblAccountPIN = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblRoutingNumber = New System.Windows.Forms.Label()
        Me.lblOpenDate = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lstAccountType = New System.Windows.Forms.ListBox()
        Me.txtRoutingNumber = New System.Windows.Forms.TextBox()
        Me.mtbBalance = New System.Windows.Forms.MaskedTextBox()
        Me.dtpOpenDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAccountPIN = New System.Windows.Forms.TextBox()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.hdrAccountPIN = New System.Windows.Forms.Label()
        Me.hdrRoutingNumber = New System.Windows.Forms.Label()
        Me.hdrBalance = New System.Windows.Forms.Label()
        Me.hdrOpenDate = New System.Windows.Forms.Label()
        Me.hdrAccountType = New System.Windows.Forms.Label()
        Me.hdrAccountNumber = New System.Windows.Forms.Label()
        Me.tpgPersonal = New System.Windows.Forms.TabPage()
        Me.pnlPersonal = New System.Windows.Forms.Panel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.hdrGender = New System.Windows.Forms.Label()
        Me.hdrSSN = New System.Windows.Forms.Label()
        Me.hdrDateOfBirth = New System.Windows.Forms.Label()
        Me.hdrLastName = New System.Windows.Forms.Label()
        Me.hdrMiddleName = New System.Windows.Forms.Label()
        Me.hdrFirstName = New System.Windows.Forms.Label()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.mtbSSN = New System.Windows.Forms.MaskedTextBox()
        Me.tosCustomerOperations = New System.Windows.Forms.ToolStrip()
        Me.tosbtnAddCustomer = New System.Windows.Forms.ToolStripButton()
        Me.tosbtnDeleteCustomer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.erpMain = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tosFileOperations.SuspendLayout()
        Me.tpgContact.SuspendLayout()
        Me.pnlContact.SuspendLayout()
        Me.tpgCard.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.tpgAccount.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        Me.tpgPersonal.SuspendLayout()
        Me.pnlPersonal.SuspendLayout()
        Me.tosCustomerOperations.SuspendLayout()
        Me.tbcMain.SuspendLayout()
        CType(Me.erpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCustomer
        '
        Me.lstCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.ItemHeight = 16
        Me.lstCustomer.Location = New System.Drawing.Point(12, 67)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCustomer.Size = New System.Drawing.Size(283, 500)
        Me.lstCustomer.TabIndex = 0
        Me.ttpMain.SetToolTip(Me.lstCustomer, "List of customers")
        '
        'tosFileOperations
        '
        Me.tosFileOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tosFileOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tosbtnNewFile, Me.tosbtnOpenFile, Me.ToolStripSeparator1, Me.tosbtnSaveFile, Me.tosbtnSaveAs})
        Me.tosFileOperations.Location = New System.Drawing.Point(0, 0)
        Me.tosFileOperations.Name = "tosFileOperations"
        Me.tosFileOperations.Size = New System.Drawing.Size(972, 27)
        Me.tosFileOperations.TabIndex = 1
        Me.tosFileOperations.Text = "File Operations"
        '
        'tosbtnNewFile
        '
        Me.tosbtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnNewFile.Image = CType(resources.GetObject("tosbtnNewFile.Image"), System.Drawing.Image)
        Me.tosbtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnNewFile.Name = "tosbtnNewFile"
        Me.tosbtnNewFile.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnNewFile.Text = "Create a new file"
        Me.tosbtnNewFile.ToolTipText = "Create a new customer file"
        '
        'tosbtnOpenFile
        '
        Me.tosbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnOpenFile.Image = CType(resources.GetObject("tosbtnOpenFile.Image"), System.Drawing.Image)
        Me.tosbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnOpenFile.Name = "tosbtnOpenFile"
        Me.tosbtnOpenFile.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnOpenFile.Text = "Open File"
        Me.tosbtnOpenFile.ToolTipText = "Open a new customer file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tosbtnSaveFile
        '
        Me.tosbtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnSaveFile.Image = CType(resources.GetObject("tosbtnSaveFile.Image"), System.Drawing.Image)
        Me.tosbtnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnSaveFile.Name = "tosbtnSaveFile"
        Me.tosbtnSaveFile.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnSaveFile.Text = "Save File"
        Me.tosbtnSaveFile.ToolTipText = "Save changes to a customer file"
        '
        'tosbtnSaveAs
        '
        Me.tosbtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnSaveAs.Image = CType(resources.GetObject("tosbtnSaveAs.Image"), System.Drawing.Image)
        Me.tosbtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnSaveAs.Name = "tosbtnSaveAs"
        Me.tosbtnSaveAs.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnSaveAs.Text = "Save As"
        Me.tosbtnSaveAs.ToolTipText = "Save a new customer file"
        '
        'tpgContact
        '
        Me.tpgContact.Controls.Add(Me.pnlContact)
        Me.tpgContact.Controls.Add(Me.txtEmail)
        Me.tpgContact.Controls.Add(Me.mtbPhoneNumber)
        Me.tpgContact.Controls.Add(Me.hdrZip)
        Me.tpgContact.Controls.Add(Me.hdrState)
        Me.tpgContact.Controls.Add(Me.hdrCity)
        Me.tpgContact.Controls.Add(Me.hdrAddress)
        Me.tpgContact.Controls.Add(Me.hdrEmail)
        Me.tpgContact.Controls.Add(Me.hdrPhoneNumber)
        Me.tpgContact.Controls.Add(Me.txtZip)
        Me.tpgContact.Controls.Add(Me.ddlState)
        Me.tpgContact.Controls.Add(Me.txtCity)
        Me.tpgContact.Controls.Add(Me.txtAddress)
        Me.tpgContact.Location = New System.Drawing.Point(4, 25)
        Me.tpgContact.Name = "tpgContact"
        Me.tpgContact.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgContact.Size = New System.Drawing.Size(635, 419)
        Me.tpgContact.TabIndex = 3
        Me.tpgContact.Text = "Contact"
        Me.ttpMain.SetToolTip(Me.tpgContact, "Contact Details")
        Me.tpgContact.UseVisualStyleBackColor = True
        '
        'pnlContact
        '
        Me.pnlContact.Controls.Add(Me.lblPhoneNumber)
        Me.pnlContact.Controls.Add(Me.lblZip)
        Me.pnlContact.Controls.Add(Me.lblEmail)
        Me.pnlContact.Controls.Add(Me.lblState)
        Me.pnlContact.Controls.Add(Me.lblAddress)
        Me.pnlContact.Controls.Add(Me.lblCity)
        Me.pnlContact.Location = New System.Drawing.Point(145, 26)
        Me.pnlContact.Name = "pnlContact"
        Me.pnlContact.Size = New System.Drawing.Size(484, 387)
        Me.pnlContact.TabIndex = 40
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(3, 3)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(110, 17)
        Me.lblPhoneNumber.TabIndex = 34
        Me.lblPhoneNumber.Text = "999-999-9999"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(3, 243)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(53, 17)
        Me.lblZip.TabIndex = 39
        Me.lblZip.Text = "99999"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(3, 51)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 17)
        Me.lblEmail.TabIndex = 35
        Me.lblEmail.Text = "Email"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(3, 195)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 17)
        Me.lblState.TabIndex = 38
        Me.lblState.Text = "State"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(3, 99)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 17)
        Me.lblAddress.TabIndex = 36
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(3, 147)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(35, 17)
        Me.lblCity.TabIndex = 37
        Me.lblCity.Text = "City"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(145, 74)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(154, 22)
        Me.txtEmail.TabIndex = 22
        '
        'mtbPhoneNumber
        '
        Me.mtbPhoneNumber.Location = New System.Drawing.Point(145, 26)
        Me.mtbPhoneNumber.Mask = "(999) 000-0000"
        Me.mtbPhoneNumber.Name = "mtbPhoneNumber"
        Me.mtbPhoneNumber.Size = New System.Drawing.Size(105, 22)
        Me.mtbPhoneNumber.TabIndex = 21
        '
        'hdrZip
        '
        Me.hdrZip.AutoSize = True
        Me.hdrZip.Location = New System.Drawing.Point(23, 269)
        Me.hdrZip.Name = "hdrZip"
        Me.hdrZip.Size = New System.Drawing.Size(73, 17)
        Me.hdrZip.TabIndex = 50
        Me.hdrZip.Text = "Zip Code: "
        '
        'hdrState
        '
        Me.hdrState.AutoSize = True
        Me.hdrState.Location = New System.Drawing.Point(23, 221)
        Me.hdrState.Name = "hdrState"
        Me.hdrState.Size = New System.Drawing.Size(45, 17)
        Me.hdrState.TabIndex = 49
        Me.hdrState.Text = "State:"
        '
        'hdrCity
        '
        Me.hdrCity.AutoSize = True
        Me.hdrCity.Location = New System.Drawing.Point(23, 173)
        Me.hdrCity.Name = "hdrCity"
        Me.hdrCity.Size = New System.Drawing.Size(35, 17)
        Me.hdrCity.TabIndex = 48
        Me.hdrCity.Text = "City:"
        '
        'hdrAddress
        '
        Me.hdrAddress.AutoSize = True
        Me.hdrAddress.Location = New System.Drawing.Point(23, 125)
        Me.hdrAddress.Name = "hdrAddress"
        Me.hdrAddress.Size = New System.Drawing.Size(64, 17)
        Me.hdrAddress.TabIndex = 47
        Me.hdrAddress.Text = "Address:"
        '
        'hdrEmail
        '
        Me.hdrEmail.AutoSize = True
        Me.hdrEmail.Location = New System.Drawing.Point(23, 77)
        Me.hdrEmail.Name = "hdrEmail"
        Me.hdrEmail.Size = New System.Drawing.Size(46, 17)
        Me.hdrEmail.TabIndex = 46
        Me.hdrEmail.Text = "Email:"
        '
        'hdrPhoneNumber
        '
        Me.hdrPhoneNumber.AutoSize = True
        Me.hdrPhoneNumber.Location = New System.Drawing.Point(23, 29)
        Me.hdrPhoneNumber.Name = "hdrPhoneNumber"
        Me.hdrPhoneNumber.Size = New System.Drawing.Size(107, 17)
        Me.hdrPhoneNumber.TabIndex = 45
        Me.hdrPhoneNumber.Text = "Phone Number:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(145, 266)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 22)
        Me.txtZip.TabIndex = 26
        '
        'ddlState
        '
        Me.ddlState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlState.FormattingEnabled = True
        Me.ddlState.Location = New System.Drawing.Point(145, 218)
        Me.ddlState.Name = "ddlState"
        Me.ddlState.Size = New System.Drawing.Size(132, 24)
        Me.ddlState.TabIndex = 25
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(145, 170)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 22)
        Me.txtCity.TabIndex = 24
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(145, 122)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(188, 22)
        Me.txtAddress.TabIndex = 23
        '
        'tpgCard
        '
        Me.tpgCard.Controls.Add(Me.pnlCard)
        Me.tpgCard.Controls.Add(Me.hdrCVV)
        Me.tpgCard.Controls.Add(Me.hdrExpirationDate)
        Me.tpgCard.Controls.Add(Me.hdrCardNumber)
        Me.tpgCard.Controls.Add(Me.hdrCardType)
        Me.tpgCard.Controls.Add(Me.hdrType)
        Me.tpgCard.Controls.Add(Me.txtCVV)
        Me.tpgCard.Controls.Add(Me.dtpExpirationDate)
        Me.tpgCard.Controls.Add(Me.mtbCardNumber)
        Me.tpgCard.Controls.Add(Me.ddlCardType)
        Me.tpgCard.Controls.Add(Me.radDebit)
        Me.tpgCard.Controls.Add(Me.radCredit)
        Me.tpgCard.Location = New System.Drawing.Point(4, 25)
        Me.tpgCard.Name = "tpgCard"
        Me.tpgCard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgCard.Size = New System.Drawing.Size(635, 419)
        Me.tpgCard.TabIndex = 2
        Me.tpgCard.Text = "Card"
        Me.ttpMain.SetToolTip(Me.tpgCard, "Card Detailsl")
        Me.tpgCard.UseVisualStyleBackColor = True
        '
        'pnlCard
        '
        Me.pnlCard.Controls.Add(Me.lblType)
        Me.pnlCard.Controls.Add(Me.lblCVV)
        Me.pnlCard.Controls.Add(Me.lblCardType)
        Me.pnlCard.Controls.Add(Me.lblExpirationDate)
        Me.pnlCard.Controls.Add(Me.lblCardNumber)
        Me.pnlCard.Location = New System.Drawing.Point(145, 26)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(484, 390)
        Me.pnlCard.TabIndex = 28
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(3, 3)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(44, 17)
        Me.lblType.TabIndex = 23
        Me.lblType.Text = "Type"
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.Location = New System.Drawing.Point(3, 195)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(35, 17)
        Me.lblCVV.TabIndex = 27
        Me.lblCVV.Text = "999"
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardType.Location = New System.Drawing.Point(3, 51)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(83, 17)
        Me.lblCardType.TabIndex = 24
        Me.lblCardType.Text = "Card Type"
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpirationDate.Location = New System.Drawing.Point(3, 147)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(81, 17)
        Me.lblExpirationDate.TabIndex = 26
        Me.lblExpirationDate.Text = "9/99/9999"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(3, 99)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(170, 17)
        Me.lblCardNumber.TabIndex = 25
        Me.lblCardNumber.Text = "9999-9999-9999-9999"
        '
        'hdrCVV
        '
        Me.hdrCVV.AutoSize = True
        Me.hdrCVV.Location = New System.Drawing.Point(23, 221)
        Me.hdrCVV.Name = "hdrCVV"
        Me.hdrCVV.Size = New System.Drawing.Size(39, 17)
        Me.hdrCVV.TabIndex = 22
        Me.hdrCVV.Text = "CVV:"
        '
        'hdrExpirationDate
        '
        Me.hdrExpirationDate.AutoSize = True
        Me.hdrExpirationDate.Location = New System.Drawing.Point(23, 173)
        Me.hdrExpirationDate.Name = "hdrExpirationDate"
        Me.hdrExpirationDate.Size = New System.Drawing.Size(108, 17)
        Me.hdrExpirationDate.TabIndex = 21
        Me.hdrExpirationDate.Text = "Expiration Date:"
        '
        'hdrCardNumber
        '
        Me.hdrCardNumber.AutoSize = True
        Me.hdrCardNumber.Location = New System.Drawing.Point(23, 125)
        Me.hdrCardNumber.Name = "hdrCardNumber"
        Me.hdrCardNumber.Size = New System.Drawing.Size(96, 17)
        Me.hdrCardNumber.TabIndex = 20
        Me.hdrCardNumber.Text = "Card Number:"
        '
        'hdrCardType
        '
        Me.hdrCardType.AutoSize = True
        Me.hdrCardType.Location = New System.Drawing.Point(23, 77)
        Me.hdrCardType.Name = "hdrCardType"
        Me.hdrCardType.Size = New System.Drawing.Size(82, 17)
        Me.hdrCardType.TabIndex = 88
        Me.hdrCardType.Text = "Card Type: "
        '
        'hdrType
        '
        Me.hdrType.AutoSize = True
        Me.hdrType.Location = New System.Drawing.Point(23, 29)
        Me.hdrType.Name = "hdrType"
        Me.hdrType.Size = New System.Drawing.Size(48, 17)
        Me.hdrType.TabIndex = 87
        Me.hdrType.Text = "Type: "
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(145, 218)
        Me.txtCVV.MaxLength = 3
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(69, 22)
        Me.txtCVV.TabIndex = 19
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpirationDate.Location = New System.Drawing.Point(145, 168)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(111, 22)
        Me.dtpExpirationDate.TabIndex = 18
        '
        'mtbCardNumber
        '
        Me.mtbCardNumber.Location = New System.Drawing.Point(145, 122)
        Me.mtbCardNumber.Mask = "0000-0000-0000-0000"
        Me.mtbCardNumber.Name = "mtbCardNumber"
        Me.mtbCardNumber.Size = New System.Drawing.Size(180, 22)
        Me.mtbCardNumber.TabIndex = 17
        '
        'ddlCardType
        '
        Me.ddlCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCardType.FormattingEnabled = True
        Me.ddlCardType.Location = New System.Drawing.Point(145, 74)
        Me.ddlCardType.Name = "ddlCardType"
        Me.ddlCardType.Size = New System.Drawing.Size(290, 24)
        Me.ddlCardType.TabIndex = 16
        '
        'radDebit
        '
        Me.radDebit.AutoSize = True
        Me.radDebit.Location = New System.Drawing.Point(220, 29)
        Me.radDebit.Name = "radDebit"
        Me.radDebit.Size = New System.Drawing.Size(62, 21)
        Me.radDebit.TabIndex = 15
        Me.radDebit.Text = "Debit"
        Me.radDebit.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Checked = True
        Me.radCredit.Location = New System.Drawing.Point(148, 29)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(66, 21)
        Me.radCredit.TabIndex = 15
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "Credit"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'tpgAccount
        '
        Me.tpgAccount.Controls.Add(Me.pnlAccount)
        Me.tpgAccount.Controls.Add(Me.lstAccountType)
        Me.tpgAccount.Controls.Add(Me.txtRoutingNumber)
        Me.tpgAccount.Controls.Add(Me.mtbBalance)
        Me.tpgAccount.Controls.Add(Me.dtpOpenDate)
        Me.tpgAccount.Controls.Add(Me.txtAccountPIN)
        Me.tpgAccount.Controls.Add(Me.txtAccountNumber)
        Me.tpgAccount.Controls.Add(Me.hdrAccountPIN)
        Me.tpgAccount.Controls.Add(Me.hdrRoutingNumber)
        Me.tpgAccount.Controls.Add(Me.hdrBalance)
        Me.tpgAccount.Controls.Add(Me.hdrOpenDate)
        Me.tpgAccount.Controls.Add(Me.hdrAccountType)
        Me.tpgAccount.Controls.Add(Me.hdrAccountNumber)
        Me.tpgAccount.Location = New System.Drawing.Point(4, 25)
        Me.tpgAccount.Name = "tpgAccount"
        Me.tpgAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgAccount.Size = New System.Drawing.Size(635, 419)
        Me.tpgAccount.TabIndex = 1
        Me.tpgAccount.Text = "Account"
        Me.ttpMain.SetToolTip(Me.tpgAccount, "Account Details")
        Me.tpgAccount.UseVisualStyleBackColor = True
        '
        'pnlAccount
        '
        Me.pnlAccount.Controls.Add(Me.lblAccountNumber)
        Me.pnlAccount.Controls.Add(Me.lblAccountPIN)
        Me.pnlAccount.Controls.Add(Me.lblAccountType)
        Me.pnlAccount.Controls.Add(Me.lblRoutingNumber)
        Me.pnlAccount.Controls.Add(Me.lblOpenDate)
        Me.pnlAccount.Controls.Add(Me.lblBalance)
        Me.pnlAccount.Location = New System.Drawing.Point(145, 26)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Size = New System.Drawing.Size(484, 393)
        Me.pnlAccount.TabIndex = 18
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.Location = New System.Drawing.Point(3, 3)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(89, 17)
        Me.lblAccountNumber.TabIndex = 12
        Me.lblAccountNumber.Text = "999999999"
        '
        'lblAccountPIN
        '
        Me.lblAccountPIN.AutoSize = True
        Me.lblAccountPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountPIN.Location = New System.Drawing.Point(3, 51)
        Me.lblAccountPIN.Name = "lblAccountPIN"
        Me.lblAccountPIN.Size = New System.Drawing.Size(44, 17)
        Me.lblAccountPIN.TabIndex = 17
        Me.lblAccountPIN.Text = "9999"
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.Location = New System.Drawing.Point(3, 243)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(107, 17)
        Me.lblAccountType.TabIndex = 13
        Me.lblAccountType.Text = "Account Type"
        '
        'lblRoutingNumber
        '
        Me.lblRoutingNumber.AutoSize = True
        Me.lblRoutingNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoutingNumber.Location = New System.Drawing.Point(3, 195)
        Me.lblRoutingNumber.Name = "lblRoutingNumber"
        Me.lblRoutingNumber.Size = New System.Drawing.Size(80, 17)
        Me.lblRoutingNumber.TabIndex = 16
        Me.lblRoutingNumber.Text = "01234567"
        '
        'lblOpenDate
        '
        Me.lblOpenDate.AutoSize = True
        Me.lblOpenDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenDate.Location = New System.Drawing.Point(3, 99)
        Me.lblOpenDate.Name = "lblOpenDate"
        Me.lblOpenDate.Size = New System.Drawing.Size(81, 17)
        Me.lblOpenDate.TabIndex = 14
        Me.lblOpenDate.Text = "9/99/9999"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(3, 147)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(80, 17)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.Text = "$9999999"
        '
        'lstAccountType
        '
        Me.lstAccountType.FormattingEnabled = True
        Me.lstAccountType.ItemHeight = 16
        Me.lstAccountType.Location = New System.Drawing.Point(145, 269)
        Me.lstAccountType.Name = "lstAccountType"
        Me.lstAccountType.Size = New System.Drawing.Size(278, 132)
        Me.lstAccountType.TabIndex = 13
        '
        'txtRoutingNumber
        '
        Me.txtRoutingNumber.Location = New System.Drawing.Point(145, 218)
        Me.txtRoutingNumber.MaxLength = 9
        Me.txtRoutingNumber.Name = "txtRoutingNumber"
        Me.txtRoutingNumber.Size = New System.Drawing.Size(104, 22)
        Me.txtRoutingNumber.TabIndex = 12
        '
        'mtbBalance
        '
        Me.mtbBalance.Location = New System.Drawing.Point(145, 170)
        Me.mtbBalance.Name = "mtbBalance"
        Me.mtbBalance.Size = New System.Drawing.Size(104, 22)
        Me.mtbBalance.TabIndex = 11
        Me.mtbBalance.ValidatingType = GetType(Integer)
        '
        'dtpOpenDate
        '
        Me.dtpOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOpenDate.Location = New System.Drawing.Point(145, 120)
        Me.dtpOpenDate.Name = "dtpOpenDate"
        Me.dtpOpenDate.Size = New System.Drawing.Size(111, 22)
        Me.dtpOpenDate.TabIndex = 10
        '
        'txtAccountPIN
        '
        Me.txtAccountPIN.Location = New System.Drawing.Point(145, 74)
        Me.txtAccountPIN.MaxLength = 4
        Me.txtAccountPIN.Name = "txtAccountPIN"
        Me.txtAccountPIN.Size = New System.Drawing.Size(74, 22)
        Me.txtAccountPIN.TabIndex = 9
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(145, 26)
        Me.txtAccountNumber.MaxLength = 15
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(154, 22)
        Me.txtAccountNumber.TabIndex = 8
        '
        'hdrAccountPIN
        '
        Me.hdrAccountPIN.AutoSize = True
        Me.hdrAccountPIN.Location = New System.Drawing.Point(23, 77)
        Me.hdrAccountPIN.Name = "hdrAccountPIN"
        Me.hdrAccountPIN.Size = New System.Drawing.Size(38, 17)
        Me.hdrAccountPIN.TabIndex = 71
        Me.hdrAccountPIN.Text = "PIN: "
        '
        'hdrRoutingNumber
        '
        Me.hdrRoutingNumber.AutoSize = True
        Me.hdrRoutingNumber.Location = New System.Drawing.Point(23, 221)
        Me.hdrRoutingNumber.Name = "hdrRoutingNumber"
        Me.hdrRoutingNumber.Size = New System.Drawing.Size(115, 17)
        Me.hdrRoutingNumber.TabIndex = 77
        Me.hdrRoutingNumber.Text = "Routing Number:"
        '
        'hdrBalance
        '
        Me.hdrBalance.AutoSize = True
        Me.hdrBalance.Location = New System.Drawing.Point(23, 173)
        Me.hdrBalance.Name = "hdrBalance"
        Me.hdrBalance.Size = New System.Drawing.Size(67, 17)
        Me.hdrBalance.TabIndex = 73
        Me.hdrBalance.Text = "Balance: "
        '
        'hdrOpenDate
        '
        Me.hdrOpenDate.AutoSize = True
        Me.hdrOpenDate.Location = New System.Drawing.Point(23, 125)
        Me.hdrOpenDate.Name = "hdrOpenDate"
        Me.hdrOpenDate.Size = New System.Drawing.Size(85, 17)
        Me.hdrOpenDate.TabIndex = 72
        Me.hdrOpenDate.Text = "Open Date: "
        '
        'hdrAccountType
        '
        Me.hdrAccountType.AutoSize = True
        Me.hdrAccountType.Location = New System.Drawing.Point(23, 269)
        Me.hdrAccountType.Name = "hdrAccountType"
        Me.hdrAccountType.Size = New System.Drawing.Size(103, 17)
        Me.hdrAccountType.TabIndex = 75
        Me.hdrAccountType.Text = "Account Type: "
        '
        'hdrAccountNumber
        '
        Me.hdrAccountNumber.AutoSize = True
        Me.hdrAccountNumber.Location = New System.Drawing.Point(23, 29)
        Me.hdrAccountNumber.Name = "hdrAccountNumber"
        Me.hdrAccountNumber.Size = New System.Drawing.Size(117, 17)
        Me.hdrAccountNumber.TabIndex = 70
        Me.hdrAccountNumber.Text = "Account Number:"
        '
        'tpgPersonal
        '
        Me.tpgPersonal.Controls.Add(Me.pnlPersonal)
        Me.tpgPersonal.Controls.Add(Me.hdrGender)
        Me.tpgPersonal.Controls.Add(Me.hdrSSN)
        Me.tpgPersonal.Controls.Add(Me.hdrDateOfBirth)
        Me.tpgPersonal.Controls.Add(Me.hdrLastName)
        Me.tpgPersonal.Controls.Add(Me.hdrMiddleName)
        Me.tpgPersonal.Controls.Add(Me.hdrFirstName)
        Me.tpgPersonal.Controls.Add(Me.radOther)
        Me.tpgPersonal.Controls.Add(Me.radFemale)
        Me.tpgPersonal.Controls.Add(Me.radMale)
        Me.tpgPersonal.Controls.Add(Me.dtpDateOfBirth)
        Me.tpgPersonal.Controls.Add(Me.txtLastName)
        Me.tpgPersonal.Controls.Add(Me.txtMiddleName)
        Me.tpgPersonal.Controls.Add(Me.txtFirstName)
        Me.tpgPersonal.Controls.Add(Me.mtbSSN)
        Me.tpgPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tpgPersonal.Name = "tpgPersonal"
        Me.tpgPersonal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgPersonal.Size = New System.Drawing.Size(635, 419)
        Me.tpgPersonal.TabIndex = 0
        Me.tpgPersonal.Text = "Personal"
        Me.ttpMain.SetToolTip(Me.tpgPersonal, "Personal Details")
        Me.tpgPersonal.UseVisualStyleBackColor = True
        '
        'pnlPersonal
        '
        Me.pnlPersonal.Controls.Add(Me.lblFirstName)
        Me.pnlPersonal.Controls.Add(Me.lblGender)
        Me.pnlPersonal.Controls.Add(Me.lblMiddleName)
        Me.pnlPersonal.Controls.Add(Me.lblSSN)
        Me.pnlPersonal.Controls.Add(Me.lblLastName)
        Me.pnlPersonal.Controls.Add(Me.lblDateOfBirth)
        Me.pnlPersonal.Location = New System.Drawing.Point(145, 26)
        Me.pnlPersonal.Name = "pnlPersonal"
        Me.pnlPersonal.Size = New System.Drawing.Size(484, 390)
        Me.pnlPersonal.TabIndex = 12
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(3, 3)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 17)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(3, 243)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(62, 17)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(3, 51)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(101, 17)
        Me.lblMiddleName.TabIndex = 7
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSN.Location = New System.Drawing.Point(3, 195)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(101, 17)
        Me.lblSSN.TabIndex = 10
        Me.lblSSN.Text = "999-99-9999"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(3, 99)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(85, 17)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.Location = New System.Drawing.Point(3, 147)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(81, 17)
        Me.lblDateOfBirth.TabIndex = 9
        Me.lblDateOfBirth.Text = "9/99/9999"
        '
        'hdrGender
        '
        Me.hdrGender.AutoSize = True
        Me.hdrGender.Location = New System.Drawing.Point(23, 269)
        Me.hdrGender.Name = "hdrGender"
        Me.hdrGender.Size = New System.Drawing.Size(64, 17)
        Me.hdrGender.TabIndex = 66
        Me.hdrGender.Text = "Gender: "
        '
        'hdrSSN
        '
        Me.hdrSSN.AutoSize = True
        Me.hdrSSN.Location = New System.Drawing.Point(23, 221)
        Me.hdrSSN.Name = "hdrSSN"
        Me.hdrSSN.Size = New System.Drawing.Size(44, 17)
        Me.hdrSSN.TabIndex = 65
        Me.hdrSSN.Text = "SSN: "
        '
        'hdrDateOfBirth
        '
        Me.hdrDateOfBirth.AutoSize = True
        Me.hdrDateOfBirth.Location = New System.Drawing.Point(23, 173)
        Me.hdrDateOfBirth.Name = "hdrDateOfBirth"
        Me.hdrDateOfBirth.Size = New System.Drawing.Size(95, 17)
        Me.hdrDateOfBirth.TabIndex = 63
        Me.hdrDateOfBirth.Text = "Date of Birth: "
        '
        'hdrLastName
        '
        Me.hdrLastName.AutoSize = True
        Me.hdrLastName.Location = New System.Drawing.Point(23, 125)
        Me.hdrLastName.Name = "hdrLastName"
        Me.hdrLastName.Size = New System.Drawing.Size(84, 17)
        Me.hdrLastName.TabIndex = 62
        Me.hdrLastName.Text = "Last Name: "
        '
        'hdrMiddleName
        '
        Me.hdrMiddleName.AutoSize = True
        Me.hdrMiddleName.Location = New System.Drawing.Point(23, 77)
        Me.hdrMiddleName.Name = "hdrMiddleName"
        Me.hdrMiddleName.Size = New System.Drawing.Size(98, 17)
        Me.hdrMiddleName.TabIndex = 61
        Me.hdrMiddleName.Text = "Middle Name: "
        '
        'hdrFirstName
        '
        Me.hdrFirstName.AutoSize = True
        Me.hdrFirstName.Location = New System.Drawing.Point(23, 29)
        Me.hdrFirstName.Name = "hdrFirstName"
        Me.hdrFirstName.Size = New System.Drawing.Size(84, 17)
        Me.hdrFirstName.TabIndex = 60
        Me.hdrFirstName.Text = "First Name: "
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(294, 267)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(65, 21)
        Me.radOther.TabIndex = 6
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(213, 267)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 6
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(148, 267)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 6
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(145, 168)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(111, 22)
        Me.dtpDateOfBirth.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(145, 122)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(208, 22)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(145, 74)
        Me.txtMiddleName.MaxLength = 30
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(208, 22)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(145, 26)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(208, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'mtbSSN
        '
        Me.mtbSSN.Location = New System.Drawing.Point(145, 218)
        Me.mtbSSN.Mask = "000-00-0000"
        Me.mtbSSN.Name = "mtbSSN"
        Me.mtbSSN.Size = New System.Drawing.Size(111, 22)
        Me.mtbSSN.TabIndex = 5
        '
        'tosCustomerOperations
        '
        Me.tosCustomerOperations.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tosCustomerOperations.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tosbtnAddCustomer, Me.tosbtnDeleteCustomer, Me.ToolStripSeparator2})
        Me.tosCustomerOperations.Location = New System.Drawing.Point(0, 27)
        Me.tosCustomerOperations.Name = "tosCustomerOperations"
        Me.tosCustomerOperations.Size = New System.Drawing.Size(972, 27)
        Me.tosCustomerOperations.TabIndex = 2
        Me.tosCustomerOperations.Text = "Customer Operations"
        '
        'tosbtnAddCustomer
        '
        Me.tosbtnAddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnAddCustomer.Image = CType(resources.GetObject("tosbtnAddCustomer.Image"), System.Drawing.Image)
        Me.tosbtnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnAddCustomer.Name = "tosbtnAddCustomer"
        Me.tosbtnAddCustomer.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnAddCustomer.Text = "Add Customer"
        Me.tosbtnAddCustomer.ToolTipText = "Add a customer"
        '
        'tosbtnDeleteCustomer
        '
        Me.tosbtnDeleteCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tosbtnDeleteCustomer.Image = CType(resources.GetObject("tosbtnDeleteCustomer.Image"), System.Drawing.Image)
        Me.tosbtnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnDeleteCustomer.Name = "tosbtnDeleteCustomer"
        Me.tosbtnDeleteCustomer.Size = New System.Drawing.Size(24, 24)
        Me.tosbtnDeleteCustomer.Text = "Delete Customer"
        Me.tosbtnDeleteCustomer.ToolTipText = "Delete selected customers"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnAddSave
        '
        Me.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddSave.Location = New System.Drawing.Point(527, 531)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(93, 30)
        Me.btnAddSave.TabIndex = 3
        Me.btnAddSave.Text = "&Add"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(651, 531)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbcMain
        '
        Me.tbcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcMain.Controls.Add(Me.tpgPersonal)
        Me.tbcMain.Controls.Add(Me.tpgAccount)
        Me.tbcMain.Controls.Add(Me.tpgCard)
        Me.tbcMain.Controls.Add(Me.tpgContact)
        Me.tbcMain.Location = New System.Drawing.Point(317, 67)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(643, 448)
        Me.tbcMain.TabIndex = 20
        '
        'erpMain
        '
        Me.erpMain.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpMain.ContainerControl = Me
        '
        'frmBanking
        '
        Me.AcceptButton = Me.btnAddSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(972, 578)
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddSave)
        Me.Controls.Add(Me.tosCustomerOperations)
        Me.Controls.Add(Me.tosFileOperations)
        Me.Controls.Add(Me.lstCustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(970, 578)
        Me.Name = "frmBanking"
        Me.Text = "Wells Fargo Banking (Karthik Umashankar #40)"
        Me.tosFileOperations.ResumeLayout(False)
        Me.tosFileOperations.PerformLayout()
        Me.tpgContact.ResumeLayout(False)
        Me.tpgContact.PerformLayout()
        Me.pnlContact.ResumeLayout(False)
        Me.pnlContact.PerformLayout()
        Me.tpgCard.ResumeLayout(False)
        Me.tpgCard.PerformLayout()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.tpgAccount.ResumeLayout(False)
        Me.tpgAccount.PerformLayout()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        Me.tpgPersonal.ResumeLayout(False)
        Me.tpgPersonal.PerformLayout()
        Me.pnlPersonal.ResumeLayout(False)
        Me.pnlPersonal.PerformLayout()
        Me.tosCustomerOperations.ResumeLayout(False)
        Me.tosCustomerOperations.PerformLayout()
        Me.tbcMain.ResumeLayout(False)
        CType(Me.erpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCustomer As ListBox
    Friend WithEvents tosFileOperations As ToolStrip
    Friend WithEvents tosbtnOpenFile As ToolStripButton
    Friend WithEvents tosbtnNewFile As ToolStripButton
    Friend WithEvents tosbtnSaveFile As ToolStripButton
    Friend WithEvents tosbtnSaveAs As ToolStripButton
    Friend WithEvents ttpMain As ToolTip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tosCustomerOperations As ToolStrip
    Friend WithEvents tosbtnAddCustomer As ToolStripButton
    Friend WithEvents tosbtnDeleteCustomer As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnAddSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tpgPersonal As TabPage
    Friend WithEvents lblGender As Label
    Friend WithEvents lblSSN As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents hdrGender As Label
    Friend WithEvents hdrSSN As Label
    Friend WithEvents hdrDateOfBirth As Label
    Friend WithEvents hdrLastName As Label
    Friend WithEvents hdrMiddleName As Label
    Friend WithEvents hdrFirstName As Label
    Friend WithEvents tpgAccount As TabPage
    Friend WithEvents lblAccountPIN As Label
    Friend WithEvents lblRoutingNumber As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblOpenDate As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents hdrAccountPIN As Label
    Friend WithEvents hdrRoutingNumber As Label
    Friend WithEvents hdrBalance As Label
    Friend WithEvents hdrOpenDate As Label
    Friend WithEvents hdrAccountType As Label
    Friend WithEvents hdrAccountNumber As Label
    Friend WithEvents tpgCard As TabPage
    Friend WithEvents lblCVV As Label
    Private WithEvents lblExpirationDate As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblCardType As Label
    Friend WithEvents lblType As Label
    Friend WithEvents hdrCVV As Label
    Private WithEvents hdrExpirationDate As Label
    Friend WithEvents hdrCardNumber As Label
    Friend WithEvents hdrCardType As Label
    Friend WithEvents hdrType As Label
    Friend WithEvents tpgContact As TabPage
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Private WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents hdrZip As Label
    Friend WithEvents hdrState As Label
    Private WithEvents hdrCity As Label
    Friend WithEvents hdrAddress As Label
    Friend WithEvents hdrEmail As Label
    Friend WithEvents hdrPhoneNumber As Label
    Friend WithEvents pnlPersonal As Panel
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents pnlContact As Panel
    Friend WithEvents pnlCard As Panel
    Friend WithEvents mtbSSN As MaskedTextBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtRoutingNumber As TextBox
    Friend WithEvents mtbBalance As MaskedTextBox
    Friend WithEvents dtpOpenDate As DateTimePicker
    Friend WithEvents txtAccountPIN As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lstAccountType As ListBox
    Friend WithEvents radDebit As RadioButton
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents mtbCardNumber As MaskedTextBox
    Friend WithEvents ddlCardType As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbPhoneNumber As MaskedTextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents ddlState As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents erpMain As ErrorProvider
End Class
