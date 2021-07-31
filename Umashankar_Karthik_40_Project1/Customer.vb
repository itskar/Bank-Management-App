'******************************************************
'* Name:       Karthik Umashankar
'* Class:      CIS-2510
'* Assignment: Project 1 Spring 2020
'* File:       Customer.vb
'* Purpose:    Custom Customer class
'******************************************************

Public Class Customer

    Implements IComparable

    Private _FirstName As String
    Private _MiddleName As String
    Private _LastName As String
    Private _DateOfBirth As Date
    Private _SSN As String
    Private _Gender As String

    Private _AccountNumber As String
    Private _AccountPIN As String
    Private _OpenDate As Date
    Private _AccountBalance As Decimal
    Private _RoutingNumber As String
    Private _AccountType As String

    Private _CardType As String
    Private _Type2 As String
    Private _CardNumber As String
    Private _ExpirationDate As Date
    Private _CVV As String

    Private _Phone As String
    Private _Email As String
    Private _Address As String
    Private _City As String
    Private _State As String
    Private _ZIP As String

    Public Sub New()
        _FirstName = ""
        _MiddleName = ""
        _LastName = ""
        _DateOfBirth = Date.Now()
        _SSN = ""
        _Gender = ""

        _AccountNumber = ""
        _AccountPIN = ""
        _OpenDate = Date.Now()
        _AccountBalance = 0
        _RoutingNumber = ""
        _AccountType = ""

        _CardType = ""
        _Type2 = ""
        _CardNumber = ""
        _ExpirationDate = Date.Now()
        _CVV = ""

        _Phone = ""
        _Email = ""
        _Address = ""
        _City = ""
        _State = ""
        _ZIP = ""

    End Sub

    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() > 30) Then
                Throw New System.Exception("First Name is required and cannot exceed 30 characters")
            End If
            _FirstName = value
        End Set
    End Property
    Public Property MiddleName() As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            If (value.Length() > 30) Then
                Throw New System.Exception("Middle Name cannot exceed 30 characters")
            End If
            _MiddleName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() > 30) Then
                Throw New System.Exception("Last Name is required and cannot exceed 30 characters")
            End If
            _LastName = value
        End Set
    End Property

    Public Property DateOfBirth() As Date
        Get
            Return _DateOfBirth
        End Get
        Set(ByVal value As Date)
            If (value = Nothing OrElse value >= Date.Now() OrElse value < Date.MinValue) Then
                Throw New System.Exception("Date of birth is required and cannot be in the future")
            End If
            _DateOfBirth = value
        End Set
    End Property
    Public Property SSN() As String
        Get
            Return _SSN
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() <> 9) Then
                Throw New System.Exception("Social Security Number is required and must be 9 digits")
            End If
            _SSN = value
        End Set
    End Property
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            If (value = Nothing) Then
                Throw New System.Exception("Gender is a required field, please selected one the options.")
            End If
            _Gender = value
        End Set
    End Property
    Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            If (value = "" OrElse value.Length() < 10 OrElse value.Length() > 12) Then
                Throw New System.Exception("Account number is required and must be between 10-12 digits")
            End If
            _AccountNumber = value
        End Set
    End Property

    Public Property AccountPIN() As String
        Get
            Return _AccountPIN
        End Get
        Set(ByVal value As String)
            If (value = "" OrElse value.Length() <> 4) Then
                Throw New System.Exception("Account PIN is required and must be exactly 4 digits")
            End If
            _AccountPIN = value
        End Set
    End Property
    Public Property OpenDate() As Date
        Get
            Return _OpenDate
        End Get
        Set(ByVal value As Date)
            If (value = Nothing OrElse value >= Date.Now() OrElse value < Date.MinValue) Then
                Throw New System.Exception("Open Date is required and cannot be in the future")
            End If
            _OpenDate = value
        End Set
    End Property
    Public Property AccountBalance() As Decimal
        Get
            Return _AccountBalance
        End Get
        Set(ByVal value As Decimal)
            If (value = -999999999 OrElse value < -999999999 OrElse value > 999999999) Then
                Throw New System.Exception("Account balance is a required field and must be between -$999999999 and $999999999!")
            End If
            _AccountBalance = value
        End Set
    End Property

    Public Property RoutingNumber() As String
        Get
            Return _RoutingNumber
        End Get
        Set(ByVal value As String)
            If (value = "" OrElse value.Length() <> 9) Then
                Throw New System.Exception("Routing number is required and must be exactly 9 digits")
            End If
            _RoutingNumber = value
        End Set
    End Property

    Public Property AccountType() As String
        Get
            Return _AccountType
        End Get
        Set(ByVal value As String)
            If (value = "") Then
                Throw New System.Exception("Account type is a required field, please select an option")
            End If
            _AccountType = value
        End Set
    End Property

    Public Property CardType() As String
        Get
            Return _CardType
        End Get
        Set(ByVal value As String)
            If (value <> "Credit" AndAlso value <> "Debit") Then
                Throw New System.Exception("Card type must be either Credit or Debit")
            End If
            _CardType = value
        End Set
    End Property

    Public Property Type2() As String
        Get
            Return _Type2
        End Get
        Set(ByVal value As String)
            If (value = "") Then
                Throw New System.Exception("Type is a required field, please select an option")
            End If
            _Type2 = value
        End Set
    End Property

    Public Property CardNumber() As String
        Get
            Return _CardNumber
        End Get
        Set(ByVal value As String)
            If (value = "" OrElse value.Length() <> 16) Then
                Throw New System.Exception("Card number is a required field and must be in the format 0000-0000-0000-0000")
            End If
            _CardNumber = value
        End Set
    End Property

    Public Property ExpirationDate() As Date
        Get
            Return _ExpirationDate
        End Get
        Set(ByVal value As Date)
            If (value = Nothing OrElse value < Date.MinValue OrElse value > Date.MaxValue) Then
                Throw New System.Exception("Expiration date is a required field")
            End If
            _ExpirationDate = value
        End Set
    End Property

    Public Property CVV() As String
        Get
            Return _CVV
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() <> 3) Then
                Throw New System.Exception("CVV is a required field and must be 3 digits")
            End If
            _CVV = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() <> 10) Then
                Throw New System.Exception("Phone number is required and must be in the format (999) 999-9999")
            End If
            _Phone = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            If (value = "" OrElse value.Length() < 8) Then
                If (value.Contains("@") = False OrElse value.Contains(".") = False _
                    OrElse value.IndexOf("@") < 2 OrElse value.IndexOf("@") > value.Length - 5 _
                    OrElse value.IndexOf("@") <> value.LastIndexOf("@") _
                    OrElse value.IndexOf("@") > value.LastIndexOf(".") _
                    OrElse value.LastIndexOf(".") > value.Length() - 3) Then
                    Throw New System.Exception("Email is required and must be in a valid email format(example@example.com)")
                End If
            End If
            _Email = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() > 50) Then
                Throw New System.Exception("Address is required and cannot exceed 50 characters")
            End If
            _Address = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() > 30) Then
                Throw New System.Exception("City is required and cannot exceed 30 characters")
            End If
            _City = value
        End Set
    End Property

    Public Property State() As String
        Get
            Return _State
        End Get
        Set(ByVal value As String)
            If (value = "") Then
                Throw New System.Exception("State is a required field, please select an option")
            End If
            _State = value
        End Set
    End Property

    Public Property ZIP() As String
        Get
            Return _ZIP
        End Get
        Set(ByVal value As String)
            If (value = Nothing OrElse value.Length() > 5) Then
                Throw New System.Exception("Zip code is required and cannot exceed 5 digits")
            End If
            _ZIP = value
        End Set
    End Property


    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        If Me._LastName < obj.LastName Then
            Return -1
        ElseIf Me._LastName > obj.LastName Then
            Return 1
        ElseIf Me._FirstName < obj.FirstName Then
            Return -1
        ElseIf Me._FirstName > obj.FirstName Then
            Return 1
        ElseIf Me._MiddleName < obj.MiddleName Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
