'******************************************************
'* Name:       Karthik Umashankar
'* Class:      CIS-2510
'* Assignment: Project 1 Spring 2020
'* File:       frmBanking.vb
'* Purpose:    Application for banks to store information of customers

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.Xml
Imports System.Text.RegularExpressions
Public Class frmBanking

    Private customerList As List(Of Customer) = New List(Of Customer)
    Private fileName As String = ""
    Private fileSaved As Boolean = True
    Private lastSelectedCustomer As Integer = 0
    Private projectFilePath As String = IO.Directory.GetParent(IO.Directory.GetParent(My.Application.Info.DirectoryPath).ToString).ToString
    '"M:\Spring 2020\CIS 2510 - GUI\Week 12\Project\Umashankar_Giridhar_40_Project1" 
    Private accountTypeFileName As String = projectFilePath & "\AccountType.xml"
    Private cardTypeFileName As String = projectFilePath & "\CardType.xml"
    Private statesFileName As String = projectFilePath & "\States.xml"

    Private Sub frmBanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
        LoadFieldOptions()
        radCredit.Checked = True
        LoadCardTypes()
        ClearFields()
    End Sub

    Private Sub tosbtnNewFile_Click(sender As Object, e As EventArgs) Handles tosbtnNewFile.Click
        If tosbtnSaveFile.Enabled = True OrElse fileSaved = False OrElse lstCustomer.Items.Count > 0 Then
            Dim result As Integer = MessageBox.Show("You have unsaved changes! Are you sure you want to create a customer file?", "Confirm",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If
        Initialize()
        ClearFields()
        ClearList()
        erpMain.SetError(txtFirstName, "")
        EditMode()
        tbcMain.Enabled = False
        btnAddSave.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub tosbtnAddCustomer_Click(sender As Object, e As EventArgs) Handles tosbtnAddCustomer.Click
        If tbcMain.Visible = True AndAlso tbcMain.Enabled = True AndAlso txtFirstName.Text <> "" AndAlso btnAddSave.Enabled = True Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to enter a new customer?", "Confirm",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If
        ClearFields()
        EditMode()
        tbcMain.Enabled = True
        btnAddSave.Enabled = True
        btnAddSave.Text = "&Add"
        btnClear.Enabled = True
        pnlPersonal.Select()
        txtFirstName.Select()

    End Sub

    Private Sub PlaceErrorLabel(errorLabel As Label, c As Control)
        'Function designed to use one error label 'errorLabel' and place it next to the control 'c' which has an error
        errorLabel.Location = New Point(c.Location.X + c.Width - 2, c.Location.Y)
        errorLabel.Visible = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click
        'Add or edit a customer 
        Dim newCustomer As Customer = New Customer()
        Try
            newCustomer.FirstName = txtFirstName.Text
        Catch ex As Exception
            tbcMain.SelectTab(0)
            txtFirstName.Select()
            txtFirstName.SelectAll()
            erpMain.SetError(txtFirstName, ex.Message)
            Return
        End Try

        Try
            newCustomer.MiddleName = txtMiddleName.Text
        Catch ex As Exception
            tbcMain.SelectTab(0)
            txtMiddleName.Select()
            txtMiddleName.SelectAll()
            Return
        End Try
        Try
            newCustomer.LastName = txtLastName.Text
        Catch ex As Exception
            tbcMain.SelectTab(0)
            txtLastName.Select()
            txtLastName.SelectAll()
            erpMain.SetError(txtLastName, ex.Message)
            Return
        End Try

        Try
            newCustomer.DateOfBirth = dtpDateOfBirth.Value
        Catch ex As Exception
            tbcMain.SelectTab(0) '
            erpMain.SetError(dtpDateOfBirth, ex.Message)
            Return
        End Try

        Try
            newCustomer.SSN = mtbSSN.Text.Replace("-", "")
        Catch ex As Exception
            tbcMain.SelectTab(0)
            mtbSSN.Select()
            mtbSSN.SelectAll()
            erpMain.SetError(mtbSSN, ex.Message)
            Return
        End Try

        Try
            If radMale.Checked = True Then
                newCustomer.Gender = radMale.Text
            ElseIf radFemale.Checked = True Then
                newCustomer.Gender = radFemale.Text
            ElseIf radOther.Checked = True Then
                newCustomer.Gender = radOther.Text
            Else
                newCustomer.Gender = ""
            End If
        Catch ex As Exception
            tbcMain.SelectTab(0)
            erpMain.SetError(radOther, ex.Message)
            Return
        End Try

        Try
            newCustomer.AccountNumber = txtAccountNumber.Text
        Catch ex As Exception
            tbcMain.SelectTab(1)
            txtAccountNumber.Select()
            txtAccountNumber.SelectAll()
            erpMain.SetError(txtAccountNumber, ex.Message)
            Return
        End Try

        Try
            newCustomer.AccountPIN = txtAccountPIN.Text
        Catch ex As Exception
            tbcMain.SelectTab(1)
            txtAccountPIN.Select()
            txtAccountPIN.SelectAll()
            erpMain.SetError(txtAccountPIN, ex.Message)

            Return
        End Try

        Try
            newCustomer.OpenDate = dtpOpenDate.Value
        Catch ex As Exception
            tbcMain.SelectTab(1)
            erpMain.SetError(dtpOpenDate, ex.Message)
            Return
        End Try

        Try
            Dim balance As String = ""
            balance = mtbBalance.Text
            If balance = "" Then
                balance = "-999999999"
            End If
            newCustomer.AccountBalance = Convert.ToDecimal(balance)
        Catch ex As Exception
            tbcMain.SelectTab(1)
            mtbBalance.Select()
            mtbBalance.SelectAll()
            erpMain.SetError(mtbBalance, ex.Message)
            Return
        End Try

        Try
            newCustomer.RoutingNumber = txtRoutingNumber.Text
        Catch ex As Exception
            tbcMain.SelectTab(1)
            txtRoutingNumber.Select()
            txtRoutingNumber.SelectAll()
            erpMain.SetError(txtRoutingNumber, ex.Message)
            Return
        End Try

        Try
            If lstAccountType.SelectedIndex > -1 Then
                newCustomer.AccountType = lstAccountType.SelectedItem.ToString()
            Else
                newCustomer.AccountType = ""
            End If
        Catch ex As Exception
            tbcMain.SelectTab(1)
            erpMain.SetError(lstAccountType, ex.Message)
            Return
        End Try

        Try
            If radCredit.Checked = True Then
                newCustomer.CardType = radCredit.Text
            ElseIf radDebit.Checked = True Then
                newCustomer.CardType = radDebit.Text
            Else
                newCustomer.CardType = ""
            End If
        Catch ex As Exception
            tbcMain.SelectTab(2)
            erpMain.SetError(radDebit, ex.Message)
            Return
        End Try

        Try
            If ddlCardType.SelectedIndex > -1 Then
                newCustomer.Type2 = ddlCardType.SelectedItem.ToString()
            Else
                newCustomer.Type2 = ""
            End If
        Catch ex As Exception
            tbcMain.SelectTab(2)
            erpMain.SetError(ddlCardType, ex.Message)
            Return
        End Try

        Try
            newCustomer.CardNumber = mtbCardNumber.Text.Replace("-", "")
        Catch ex As Exception
            tbcMain.SelectTab(2)
            mtbCardNumber.Select()
            mtbCardNumber.SelectAll()
            erpMain.SetError(mtbCardNumber, ex.Message)
            Return
        End Try

        Try
            newCustomer.ExpirationDate = dtpExpirationDate.Value
        Catch ex As Exception
            tbcMain.SelectTab(2)
            erpMain.SetError(dtpExpirationDate, ex.Message)
            Return
        End Try

        Try
            newCustomer.CVV = txtCVV.Text
        Catch ex As Exception
            tbcMain.SelectTab(2)
            txtCVV.Select()
            txtCVV.SelectAll()
            erpMain.SetError(txtCVV, ex.Message)
            Return
        End Try

        Try
            Dim phoneNumber As String = mtbPhoneNumber.Text.Replace("-", "")
            phoneNumber = phoneNumber.Replace("(", "")
            phoneNumber = phoneNumber.Replace(") ", "")
            newCustomer.Phone = phoneNumber
        Catch ex As Exception
            tbcMain.SelectTab(3)
            mtbPhoneNumber.Select()
            mtbPhoneNumber.SelectAll()
            erpMain.SetError(mtbPhoneNumber, ex.Message)
            Return
        End Try

        Try
            newCustomer.Email = txtEmail.Text
        Catch ex As Exception
            tbcMain.SelectTab(3)
            txtEmail.Select()
            txtEmail.SelectAll()
            erpMain.SetError(txtEmail, ex.Message)
            Return
        End Try

        Try
            newCustomer.Address = txtAddress.Text
        Catch ex As Exception
            tbcMain.SelectTab(3)
            txtAddress.Select()
            txtAddress.SelectAll()
            erpMain.SetError(txtAddress, ex.Message)
            Return
        End Try

        Try
            newCustomer.City = txtCity.Text
        Catch ex As Exception
            tbcMain.SelectTab(3)
            txtCity.Select()
            txtCity.SelectAll()
            erpMain.SetError(txtCity, ex.Message)
            Return
        End Try

        Try
            If ddlState.SelectedIndex > -1 Then
                newCustomer.State = ddlState.SelectedItem.ToString()
            Else
                newCustomer.State = ""
            End If
        Catch ex As Exception
            tbcMain.SelectTab(3)
            erpMain.SetError(ddlState, ex.Message)
            Return
        End Try

        Try
            newCustomer.ZIP = txtZip.Text
        Catch ex As Exception
            tbcMain.SelectTab(3)
            txtZip.Select()
            txtZip.SelectAll()
            erpMain.SetError(txtZip, ex.Message)
            Return
        End Try


        If btnAddSave.Text = "&Add" Then
            customerList.Add(newCustomer)
            lastSelectedCustomer = customerList.IndexOf(newCustomer)
            customerList.Sort()
            lastSelectedCustomer = customerList.IndexOf(newCustomer)
        ElseIf btnAddSave.Text = "&Save" Then
            customerList(lstCustomer.SelectedIndex) = newCustomer
            lastSelectedCustomer = customerList.IndexOf(newCustomer)
            customerList.Sort()
            lastSelectedCustomer = customerList.IndexOf(newCustomer)
        End If

        LoadCustomerList()
        ReadMode()
        lstCustomer.SelectedIndex = lastSelectedCustomer
    End Sub

    Private Sub allowNumbersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccountNumber.KeyPress,
                                                                                            txtAccountPIN.KeyPress, txtCVV.KeyPress,
                                                                                            txtRoutingNumber.KeyPress, txtZip.KeyPress

        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub allowAlphabetsOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress,
                                                                                           txtLastName.KeyPress, txtMiddleName.KeyPress,
                                                                                           txtCity.KeyPress
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar < "A" Or e.KeyChar > "z" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub mtbBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbBalance.KeyPress
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If mtbBalance.Text.Contains(".") = False Then
            If e.KeyChar = "." Then
                Return
            End If
        End If
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub radCards_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged, radDebit.CheckedChanged
        LoadCardTypes()
    End Sub

    Private Sub lstMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomer.SelectedIndexChanged
        If lstCustomer.SelectedIndices.Count = 1 AndAlso lstCustomer.SelectedIndex > -1 Then
            lblFirstName.Text = customerList(lstCustomer.SelectedIndex).FirstName
            txtFirstName.Text = customerList(lstCustomer.SelectedIndex).FirstName
            lblMiddleName.Text = customerList(lstCustomer.SelectedIndex).MiddleName
            txtMiddleName.Text = customerList(lstCustomer.SelectedIndex).MiddleName
            lblLastName.Text = customerList(lstCustomer.SelectedIndex).LastName
            txtLastName.Text = customerList(lstCustomer.SelectedIndex).LastName
            lblAccountNumber.Text = customerList(lstCustomer.SelectedIndex).AccountNumber
            txtAccountNumber.Text = customerList(lstCustomer.SelectedIndex).AccountNumber
            lblAccountPIN.Text = customerList(lstCustomer.SelectedIndex).AccountPIN
            txtAccountPIN.Text = customerList(lstCustomer.SelectedIndex).AccountPIN
            lblRoutingNumber.Text = customerList(lstCustomer.SelectedIndex).RoutingNumber
            txtRoutingNumber.Text = customerList(lstCustomer.SelectedIndex).RoutingNumber
            lblCVV.Text = customerList(lstCustomer.SelectedIndex).CVV
            txtCVV.Text = customerList(lstCustomer.SelectedIndex).CVV
            lblEmail.Text = customerList(lstCustomer.SelectedIndex).Email
            txtEmail.Text = customerList(lstCustomer.SelectedIndex).Email
            lblAddress.Text = customerList(lstCustomer.SelectedIndex).Address
            txtAddress.Text = customerList(lstCustomer.SelectedIndex).Address
            lblCity.Text = customerList(lstCustomer.SelectedIndex).City
            txtCity.Text = customerList(lstCustomer.SelectedIndex).City
            lblZip.Text = customerList(lstCustomer.SelectedIndex).ZIP
            txtZip.Text = customerList(lstCustomer.SelectedIndex).ZIP
            lblDateOfBirth.Text = customerList(lstCustomer.SelectedIndex).DateOfBirth.ToString().Substring(0, 9)
            dtpDateOfBirth.Value = customerList(lstCustomer.SelectedIndex).DateOfBirth
            lblOpenDate.Text = customerList(lstCustomer.SelectedIndex).OpenDate.ToString().Substring(0, 9)
            dtpOpenDate.Value = customerList(lstCustomer.SelectedIndex).OpenDate
            lblExpirationDate.Text = customerList(lstCustomer.SelectedIndex).ExpirationDate.ToString().Substring(0, 9)
            dtpExpirationDate.Value = customerList(lstCustomer.SelectedIndex).ExpirationDate
            lblSSN.Text = customerList(lstCustomer.SelectedIndex).SSN.Insert(3, "-").Insert(6, "-")
            mtbSSN.Text = customerList(lstCustomer.SelectedIndex).SSN
            lblBalance.Text = customerList(lstCustomer.SelectedIndex).AccountBalance.ToString()
            mtbBalance.Text = customerList(lstCustomer.SelectedIndex).AccountBalance.ToString()
            lblCardNumber.Text = customerList(lstCustomer.SelectedIndex).CardNumber.Insert(4, "-").Insert(9, "-").Insert(14, "-")
            mtbCardNumber.Text = customerList(lstCustomer.SelectedIndex).CardNumber
            lblPhoneNumber.Text = customerList(lstCustomer.SelectedIndex).Phone.Insert(0, "(").Insert(4, ")").Insert(8, "-")
            mtbPhoneNumber.Text = customerList(lstCustomer.SelectedIndex).Phone

            lblGender.Text = customerList(lstCustomer.SelectedIndex).Gender
            If customerList(lstCustomer.SelectedIndex).Gender = "Male" Then
                radMale.Checked = True
            ElseIf customerList(lstCustomer.SelectedIndex).Gender = "Female" Then
                radFemale.Checked = True
            ElseIf customerList(lstCustomer.SelectedIndex).Gender = "Other" Then
                radOther.Checked = True
            End If


            lblType.Text = customerList(lstCustomer.SelectedIndex).CardType
            If customerList(lstCustomer.SelectedIndex).CardType = "Credit" Then
                radCredit.Checked = True
            ElseIf customerList(lstCustomer.SelectedIndex).CardType = "Debit" Then
                radDebit.Checked = True
            End If

            lblAccountType.Text = customerList(lstCustomer.SelectedIndex).AccountType
            lstAccountType.SelectedIndex = lstAccountType.Items.IndexOf(customerList(lstCustomer.SelectedIndex).AccountType)

            lblCardType.Text = customerList(lstCustomer.SelectedIndex).Type2
            ddlCardType.SelectedIndex = ddlCardType.Items.IndexOf(customerList(lstCustomer.SelectedIndex).Type2)

            lblState.Text = customerList(lstCustomer.SelectedIndex).State
            ddlState.SelectedIndex = ddlState.Items.IndexOf(customerList(lstCustomer.SelectedIndex).State)

            Me.Text = "Wells Fargo Banking (" & customerList(lstCustomer.SelectedIndex).FirstName & " " & customerList(lstCustomer.SelectedIndex).LastName & " #" & lstCustomer.SelectedIndex & ")"
            ReadMode()
            tbcMain.SelectTab(0)
            tosbtnDeleteCustomer.Enabled = True
            lastSelectedCustomer = lstCustomer.SelectedIndex
        ElseIf lstCustomer.SelectedIndex = -1 Then
            tbcMain.Visible = False
            tosbtnDeleteCustomer.Enabled = False
            btnAddSave.Enabled = False
            btnClear.Enabled = False
            Me.Text = "Wells Fargo Banking (Karthik Umashankar #40)"
        End If

    End Sub

    Private Sub lstMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstCustomer.MouseDoubleClick
        If lstCustomer.SelectedIndex > -1 Then
            btnAddSave.Text = "&Save"
            EditMode()
        Else
            tbcMain.Visible = False
        End If
    End Sub

    Private Sub lstCustomer_KeyUp(sender As Object, e As KeyEventArgs) Handles lstCustomer.KeyUp
        If e.KeyValue = ConsoleKey.Delete And lstCustomer.SelectedIndex <> 1 Then
            tosbtnDeleteCustomer_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub frmBanking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If tosbtnSaveFile.Enabled = True OrElse fileSaved = False Then
            Dim result As Integer = MessageBox.Show("You have unsaved changes! Are you sure you want to quit?", "Confirm",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
        ClearErrors()
    End Sub

    Private Sub tosbtnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles tosbtnDeleteCustomer.Click
        If (lstCustomer.SelectedIndex <> -1) Then
            Dim deletedRecords As Integer = 0
            Dim lastSelected As Integer = 0
            For Each index As Integer In lstCustomer.SelectedIndices
                customerList.RemoveAt(index - deletedRecords)
                deletedRecords += 1
                lastSelected = index
            Next
            LoadCustomerList()
            If lastSelected < customerList.Count - 1 Then
                lstCustomer.SelectedIndex = lastSelected
            ElseIf customerList.Count = 0 Then
                Initialize()
            Else
                lstCustomer.SelectedIndex = customerList.Count - 1
            End If
        End If
    End Sub

    Private Sub tosbtnOpenFile_Click(sender As Object, e As EventArgs) Handles tosbtnOpenFile.Click
        If tosbtnSaveFile.Enabled = True OrElse fileSaved = False Then
            Dim result As Integer = MessageBox.Show("You have unsaved changes! Are you sure you want to create a customer file?", "Confirm",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If
        Initialize()
        ClearFields()
        ClearErrors()
        Dim openWindow As OpenFileDialog = New OpenFileDialog

        openWindow.Filter = "Bank File|*.xml"
        openWindow.Title = "Open a bank file"
        openWindow.ShowDialog()

        If openWindow.FileName = "" Then
            Return
        End If

        fileName = openWindow.FileName
        ClearList()

        Dim settings As New XmlReaderSettings
        settings.IgnoreComments = True
        settings.IgnoreWhitespace = True

        Dim reader As XmlReader = XmlReader.Create(fileName, settings)
        reader.Read()
        Try
            While reader.ReadState <> ReadState.EndOfFile
                If (reader.Name = "customer" AndAlso reader.NodeType = XmlNodeType.Element) Then
                    Dim newCustomer As Customer = New Customer()
                    newCustomer.FirstName = reader("firstName")
                    If Not reader("middleName") Is Nothing Then
                        newCustomer.MiddleName = reader("middleName")
                    End If
                    newCustomer.LastName = reader("lastName")
                    newCustomer.DateOfBirth = GetFormattedDate(reader("birthDate"))
                    newCustomer.SSN = reader("ssn")
                    newCustomer.Gender = reader("gender")
                    newCustomer.AccountNumber = reader("accountNumber")
                    newCustomer.AccountPIN = reader("accountPin")
                    newCustomer.OpenDate = GetFormattedDate(reader("openDate"))
                    newCustomer.AccountBalance = Convert.ToDecimal(reader("accountBalance"))
                    newCustomer.RoutingNumber = reader("routingNumber")
                    newCustomer.AccountType = reader("accountType")
                    newCustomer.CardType = reader("cardType")
                    newCustomer.Type2 = reader("type2")
                    newCustomer.CardNumber = reader("cardNumber")
                    newCustomer.ExpirationDate = GetFormattedDate(reader("expirationDate"))
                    newCustomer.CVV = reader("cvv")
                    newCustomer.Phone = reader("phone")
                    newCustomer.Email = reader("email")
                    newCustomer.Address = reader("address")
                    newCustomer.City = reader("city")
                    newCustomer.State = reader("state")
                    newCustomer.ZIP = reader("zip")
                    customerList.Add(newCustomer)
                End If
                reader.Read()
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("There was an error loading the file!", MsgBoxStyle.Critical, "Error")
            Return
        End Try
        customerList.Sort()
        LoadCustomerList()
        tosbtnSaveFile.Enabled = False
    End Sub

    Private Sub tosbtnSaveFile_Click(sender As Object, e As EventArgs) Handles tosbtnSaveFile.Click
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        settings.IndentChars = "    "
        Dim xmlOut As XmlWriter = XmlWriter.Create(fileName, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("bank")

        For counter As Integer = 0 To customerList.Count - 1
            xmlOut.WriteStartElement("customer")
            xmlOut.WriteAttributeString("firstName", customerList(counter).FirstName)
            If (customerList(counter).MiddleName IsNot Nothing AndAlso customerList(counter).MiddleName <> "") Then
                xmlOut.WriteAttributeString("middleName", customerList(counter).MiddleName)
            End If
            xmlOut.WriteAttributeString("lastName", customerList(counter).LastName)
            xmlOut.WriteAttributeString("birthDate", customerList(counter).DateOfBirth.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("ssn", customerList(counter).SSN)
            xmlOut.WriteAttributeString("gender", customerList(counter).Gender)
            xmlOut.WriteAttributeString("accountNumber", customerList(counter).AccountNumber)
            xmlOut.WriteAttributeString("accountPin", customerList(counter).AccountPIN)
            xmlOut.WriteAttributeString("openDate", customerList(counter).OpenDate.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("accountBalance", customerList(counter).AccountBalance.ToString())
            xmlOut.WriteAttributeString("routingNumber", customerList(counter).RoutingNumber)
            xmlOut.WriteAttributeString("accountType", customerList(counter).AccountType)
            xmlOut.WriteAttributeString("cardType", customerList(counter).CardType)
            xmlOut.WriteAttributeString("type2", customerList(counter).Type2)
            xmlOut.WriteAttributeString("cardNumber", customerList(counter).CardNumber)
            xmlOut.WriteAttributeString("expirationDate", customerList(counter).ExpirationDate.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("cvv", customerList(counter).CVV)
            xmlOut.WriteAttributeString("phone", customerList(counter).Phone)
            xmlOut.WriteAttributeString("email", customerList(counter).Email)
            xmlOut.WriteAttributeString("address", customerList(counter).Address)
            xmlOut.WriteAttributeString("city", customerList(counter).City)
            xmlOut.WriteAttributeString("state", customerList(counter).State)
            xmlOut.WriteAttributeString("zip", customerList(counter).ZIP)
            xmlOut.WriteEndElement()
        Next
        xmlOut.WriteEndElement()
        xmlOut.Close()
        fileSaved = True
        tosbtnSaveFile.Enabled = False
    End Sub

    Private Sub tosbtnSaveAs_Click(sender As Object, e As EventArgs) Handles tosbtnSaveAs.Click
        Dim saveWindow As SaveFileDialog = New SaveFileDialog()

        saveWindow.Filter = "Bank File|*.xml"
        saveWindow.Title = "Save an bank File"
        saveWindow.ShowDialog()

        If (saveWindow.FileName = "") Then
            Return
        End If

        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        settings.IndentChars = "    "
        fileName = saveWindow.FileName
        Dim xmlOut As XmlWriter = XmlWriter.Create(fileName, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("bank")

        For counter As Integer = 0 To customerList.Count - 1
            xmlOut.WriteStartElement("customer")
            xmlOut.WriteAttributeString("firstName", customerList(counter).FirstName)
            If (customerList(counter).MiddleName IsNot Nothing AndAlso customerList(counter).MiddleName <> "") Then
                xmlOut.WriteAttributeString("middleName", customerList(counter).MiddleName)
            End If
            xmlOut.WriteAttributeString("lastName", customerList(counter).LastName)
            xmlOut.WriteAttributeString("birthDate", customerList(counter).DateOfBirth.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("ssn", customerList(counter).SSN)
            xmlOut.WriteAttributeString("gender", customerList(counter).Gender)
            xmlOut.WriteAttributeString("accountNumber", customerList(counter).AccountNumber)
            xmlOut.WriteAttributeString("accountPin", customerList(counter).AccountPIN)
            xmlOut.WriteAttributeString("openDate", customerList(counter).OpenDate.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("accountBalance", customerList(counter).AccountBalance.ToString())
            xmlOut.WriteAttributeString("routingNumber", customerList(counter).RoutingNumber)
            xmlOut.WriteAttributeString("accountType", customerList(counter).AccountType)
            xmlOut.WriteAttributeString("cardType", customerList(counter).CardType)
            xmlOut.WriteAttributeString("type2", customerList(counter).Type2)
            xmlOut.WriteAttributeString("cardNumber", customerList(counter).CardNumber)
            xmlOut.WriteAttributeString("expirationDate", customerList(counter).ExpirationDate.ToString("MMddyyyy"))
            xmlOut.WriteAttributeString("cvv", customerList(counter).CVV)
            xmlOut.WriteAttributeString("phone", customerList(counter).Phone)
            xmlOut.WriteAttributeString("email", customerList(counter).Email)
            xmlOut.WriteAttributeString("address", customerList(counter).Address)
            xmlOut.WriteAttributeString("city", customerList(counter).City)
            xmlOut.WriteAttributeString("state", customerList(counter).State)
            xmlOut.WriteAttributeString("zip", customerList(counter).ZIP)
            xmlOut.WriteEndElement()
        Next
        xmlOut.WriteEndElement()
        xmlOut.Close()
        fileSaved = True
    End Sub

    Private Sub Initialize()
        Me.Text = "Wells Fargo Banking (Karthik Umashankar #40)"
        tbcMain.Visible = False
        tosbtnDeleteCustomer.Enabled = False
        tosbtnSaveFile.Enabled = False
        tosbtnSaveAs.Enabled = False
        btnAddSave.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub EditMode()
        tbcMain.Visible = True
        pnlAccount.Visible = False
        pnlPersonal.Visible = False
        pnlCard.Visible = False
        pnlContact.Visible = False
        ClearErrors()
        btnAddSave.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub LoadFieldOptions()

        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        Try
            Dim reader As XmlReader = XmlReader.Create(accountTypeFileName, settings)
            While reader.ReadState <> ReadState.EndOfFile
                If reader.Name = "type" AndAlso reader.NodeType = XmlNodeType.Element Then
                    lstAccountType.Items.Add(reader.ReadElementContentAsString())
                Else
                    reader.Read()
                End If
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
            Return
        End Try

        Try
            Dim reader As XmlReader = XmlReader.Create(statesFileName, settings)
            While reader.ReadState <> ReadState.EndOfFile
                If reader.Name = "state" AndAlso reader.NodeType = XmlNodeType.Element Then
                    ddlState.Items.Add(reader.ReadElementContentAsString())
                Else
                    reader.Read()
                End If
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
            Return
        End Try

    End Sub

    Private Sub LoadCardTypes()
        ddlCardType.Items.Clear()
        Dim settings As New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        Try
            Dim reader As XmlReader = XmlReader.Create(cardTypeFileName, settings)

            If radCredit.Checked = True Then
                While reader.ReadState <> ReadState.EndOfFile
                    If reader.Name = "credit" AndAlso reader.NodeType = XmlNodeType.Element Then
                        ddlCardType.Items.Add(reader.ReadElementContentAsString())
                    Else
                        reader.Read()
                    End If
                End While
            ElseIf radDebit.Checked = True Then
                While reader.ReadState <> ReadState.EndOfFile
                    If reader.Name = "debit" AndAlso reader.NodeType = XmlNodeType.Element Then
                        ddlCardType.Items.Add(reader.ReadElementContentAsString())
                    Else
                        reader.Read()
                    End If
                End While
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
            Return
        End Try
    End Sub

    Private Sub ClearFields()
        For Each page As TabPage In tbcMain.TabPages
            For Each control As Control In page.Controls()
                If control.GetType().Name = "TextBox" Or control.GetType().Name = "MaskedTextBox" Then
                    control.GetType().GetProperty("Text").SetValue(control, "", Nothing)
                ElseIf control.GetType().Name = "DateTimePicker" Then
                    control.GetType().GetProperty("Value").SetValue(control, Date.Now(), Nothing)
                ElseIf control.GetType().Name = "ListBox" Then
                    control.GetType().GetProperty("SelectedIndex").SetValue(control, -1, Nothing)
                ElseIf control.GetType().Name = "ComboBox" Then
                    control.GetType().GetProperty("SelectedIndex").SetValue(control, -1, Nothing)
                ElseIf control.GetType().Name = "RadioButton" Then
                    control.GetType().GetProperty("Checked").SetValue(control, False, Nothing)
                End If
            Next
        Next
    End Sub

    Private Sub LoadCustomerList()
        'Add the list of customers to the ListBox
        Dim nameString As String
        lstCustomer.Items.Clear()

        For counter As Integer = 0 To customerList.Count - 1
            nameString = customerList(counter).LastName & ", " & customerList(counter).FirstName
            lstCustomer.Items.Add(nameString)
        Next
        If fileName <> "" Then
            tosbtnSaveFile.Enabled = True
        End If
        tosbtnSaveAs.Enabled = True

    End Sub


    Private Sub ReadMode()
        tbcMain.Visible = True
        tbcMain.Enabled = True
        pnlPersonal.Visible = True
        pnlAccount.Visible = True
        pnlCard.Visible = True
        pnlContact.Visible = True
        tbcMain.SelectTab(0)
        btnAddSave.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub ClearList()
        lstCustomer.Items.Clear()
        customerList.Clear()
    End Sub
    Private Sub ClearErrors()
        erpMain.SetError(txtFirstName, "")
        erpMain.SetError(txtLastName, "")
        erpMain.SetError(dtpDateOfBirth, "")
        erpMain.SetError(mtbSSN, "")
        erpMain.SetError(radOther, "")
        erpMain.SetError(txtAccountNumber, "")
        erpMain.SetError(txtAccountPIN, "")
        erpMain.SetError(dtpOpenDate, "")
        erpMain.SetError(mtbBalance, "")
        erpMain.SetError(txtRoutingNumber, "")
        erpMain.SetError(lstAccountType, "")
        erpMain.SetError(radDebit, "")
        erpMain.SetError(mtbCardNumber, "")
        erpMain.SetError(dtpExpirationDate, "")
        erpMain.SetError(txtCVV, "")
        erpMain.SetError(mtbPhoneNumber, "")
        erpMain.SetError(txtEmail, "")
        erpMain.SetError(txtAddress, "")
        erpMain.SetError(txtCity, "")
        erpMain.SetError(ddlState, "")
        erpMain.SetError(txtZip, "")
    End Sub

    Private Function GetFormattedDate(rawDate As String) As Date
        Dim month As String = rawDate.Substring(0, 2)
        Dim day As String = rawDate.Substring(2, 2)
        Dim year As String = rawDate.Substring(4, 4)
        Dim formattedDate As Date = New Date(Convert.ToInt16(year), Convert.ToInt16(month), Convert.ToInt16(day))

        Return formattedDate
    End Function

    ''-------------------------------------------NEW ERROR HANDLING USING ERROR PROVIDER--------------------------------------------------''
    Private Sub txtFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        Dim text As String = txtFirstName.Text.Trim()

        If Regex.Matches(text, "^[A-Z][a-z]+(-[A-Z][a-z]*)?$").Count <> 1 Then
            erpMain.SetError(txtFirstName, "First Name is required, cannot exceed 30 characters and must start with an upper case character")
            e.Cancel = True
        Else
            erpMain.SetError(txtFirstName, "")
        End If
    End Sub
    Private Sub txtLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        Dim text As String = txtLastName.Text.Trim()

        If Regex.Matches(text, "^[A-Z]('[A-Z])?[a-z]+([- ]('[A-Z])?[a-z]+){0,3}$").Count <> 1 Then
            erpMain.SetError(txtLastName, "Last Name is required, cannot exceed 30 characters and must start with an upper case character")
            e.Cancel = True
        Else
            erpMain.SetError(txtLastName, "")
        End If
    End Sub

    Private Sub dtpDateOfBirth_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDateOfBirth.Validating
        If dtpDateOfBirth.Value > DateAndTime.Now Then
            erpMain.SetError(dtpDateOfBirth, "Date of birth cannot be in the future")
            e.Cancel = True
        Else
            erpMain.SetError(dtpDateOfBirth, "")
        End If
    End Sub

    Private Sub mtbSSN_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbSSN.Validating
        If mtbSSN.Text.Length <> 11 Then
            erpMain.SetError(mtbSSN, "Social Security Number is a required field must be exactly 9 digits. ")
            e.Cancel = True
        Else
            erpMain.SetError(mtbSSN, "")
        End If
    End Sub

    Private Sub txtAccountNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAccountNumber.Validating
        If txtAccountNumber.Text.Length < 10 Or txtAccountNumber.Text.Length > 12 Then
            erpMain.SetError(txtAccountNumber, "Account number is a required field must be between 10-12 digits ")
            e.Cancel = True
        Else
            erpMain.SetError(txtAccountNumber, "")
        End If
    End Sub

    Private Sub txtAccountPIN_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAccountPIN.Validating
        If txtAccountPIN.Text.Length <> 4 Then
            erpMain.SetError(txtAccountPIN, "Account PIN is a required field must be exactly 4 digits ")
            e.Cancel = True
        Else
            erpMain.SetError(txtAccountPIN, "")
        End If
    End Sub

    Private Sub dtpOpenDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpOpenDate.Validating
        If (dtpOpenDate.Value >= Date.Now() OrElse dtpOpenDate.Value < Date.MinValue) Then
            erpMain.SetError(dtpOpenDate, "Open date cannot be in the future")
            e.Cancel = True
        Else
            erpMain.SetError(dtpOpenDate, "")
        End If
    End Sub

    Private Sub mtbBalance_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbBalance.Validating
        If (mtbBalance.Text = "" OrElse Convert.ToDecimal(mtbBalance.Text) < -999999999 OrElse Convert.ToDecimal(mtbBalance.Text) > 999999999) Then
            erpMain.SetError(mtbBalance, "Account balance is a required field and must be between -$999999999 and $999999999!")
            e.Cancel = True
        Else
            erpMain.SetError(mtbBalance, "")
        End If
    End Sub

    Private Sub txtRoutingNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRoutingNumber.Validating
        If txtRoutingNumber.Text.Length <> 9 Then
            erpMain.SetError(txtRoutingNumber, "Routing number is a required field must be between exactly 9 digits ")
            e.Cancel = True
        Else
            erpMain.SetError(txtRoutingNumber, "")
        End If
    End Sub

    Private Sub mtbCardNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbCardNumber.Validating
        If mtbCardNumber.Text.Length <> 19 Then
            erpMain.SetError(mtbCardNumber, "Card number is a required field must be between exactly 16 digits ")
            e.Cancel = True
        Else
            erpMain.SetError(mtbCardNumber, "")
        End If
    End Sub

    Private Sub dtpExpirationDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpExpirationDate.Validating
        If (dtpExpirationDate.Value >= Date.MaxValue OrElse dtpOpenDate.Value < Date.MinValue) Then
            erpMain.SetError(dtpExpirationDate, "Open date cannot be in the future")
            e.Cancel = True
        Else
            erpMain.SetError(dtpExpirationDate, "")
        End If
    End Sub

    Private Sub txtCVV_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCVV.Validating
        If txtCVV.Text.Length <> 3 Then
            erpMain.SetError(txtCVV, "CVV must be exactly 3 digits ")
            e.Cancel = True
        Else
            erpMain.SetError(txtCVV, "")
        End If
    End Sub

    Private Sub mtbPhoneNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtbPhoneNumber.Validating
        Dim text As String = mtbPhoneNumber.Text.Trim()

        If Regex.Matches(text, "^\(\d{3}\) \d{3}-\d{4}$").Count <> 1 Then
            erpMain.SetError(mtbPhoneNumber, "Phone number is required and must be in the format (999) 999-9999")
            e.Cancel = True
        Else
            erpMain.SetError(mtbPhoneNumber, "")
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If (txtEmail.Text.Contains("@") = False OrElse txtEmail.Text.Contains(".") = False _
                  OrElse txtEmail.Text.IndexOf("@") < 2 OrElse txtEmail.Text.IndexOf("@") > txtEmail.Text.Length - 5 _
                  OrElse txtEmail.Text.IndexOf("@") <> txtEmail.Text.LastIndexOf("@") _
                  OrElse txtEmail.Text.IndexOf("@") > txtEmail.Text.LastIndexOf(".") _
                  OrElse txtEmail.Text.LastIndexOf(".") > txtEmail.Text.Length() - 3) Then
            erpMain.SetError(txtEmail, "Email is required and must be in a valid email format(example@example.com)")
            e.Cancel = True
        Else
            erpMain.SetError(txtEmail, "")
        End If
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If txtAddress.Text = "" Or txtAddress.Text.Length > 50 Then
            erpMain.SetError(txtAddress, "Address is a required field and cannot exceed 50 characters")
            e.Cancel = True
        Else
            erpMain.SetError(txtAddress, "")
        End If
    End Sub

    Private Sub txtCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCity.Validating
        If txtCity.Text = "" Or txtCity.Text.Length > 30 Then
            erpMain.SetError(txtCity, "City is a required field and cannot exceed 30 characters")
            e.Cancel = True
        Else
            erpMain.SetError(txtCity, "")
        End If
    End Sub

    Private Sub txtZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZip.Validating
        If txtZip.Text = "" Or txtZip.Text.Length > 5 Then
            erpMain.SetError(txtZip, "Zip Code is a required field and cannot exceed 5 characters")
            e.Cancel = True
        Else
            erpMain.SetError(txtZip, "")
        End If
    End Sub
End Class
