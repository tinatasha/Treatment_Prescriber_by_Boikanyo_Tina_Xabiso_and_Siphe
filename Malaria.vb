Option Strict On
Option Explicit On
Option Infer Off
Public Class Malaria

    Inherits Disease

    'Instance Variables
    Private _Duration As Integer
    Private _MalariaType As String
    Private _Weight As Double
    'Constuctor
    Sub New()

    End Sub

    Sub New(type As String, ptptrans As Boolean, prevention As String)
        _Type = type
        _PtPTrans = ptptrans
        _Prevention = prevention
    End Sub

    'Property Methods
    Public Property Duration As Integer
        Get
            Return _Duration
        End Get
        Set(value As Integer)
            _Duration = value
        End Set
    End Property
    Public Property MalariaType As String
        Get
            Return _MalariaType
        End Get
        Set(value As String)
            _MalariaType = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return _Weight
        End Get
        Set(value As Double)
            _Weight = value
        End Set
    End Property


    Public Function isCelebralMalaria() As String
        Dim Damage As String
        Damage = ""
        If _Duration >= 4 Then
            Damage = "Celebral Malaria is possible"
        End If
        If _Duration < 4 Then
            Damage = "No Celebral Malaria"
        End If
        Return Damage
    End Function

    'Utility Functions
    Public Overrides Function PrescTreatment() As String
        Dim Treatment As String
        Treatment = " "
        If _Weight >= 5 And _Weight <= 10 Then
            Treatment = "Atovapoune/Proguanil(1/2 tablet daily)"
        ElseIf _Weight > 10 And _Weight <= 20 Then
            Treatment = "Atovapoune/Proguanil(1 pediatric tablet daily)"
        ElseIf _Weight > 20 And _Weight <= 30 Then
            Treatment = "Atovapoune/Proguanil(2 pediatric tablet daily)"
        ElseIf _Weight > 30 And _Weight <= 40 Then
            Treatment = "Atovapoune/Proguanil(3 pediatric tablet daily)"
        ElseIf _Weight > 40 Then
            Treatment = "Atovapoune/Proguanil(1 adult tablet daily)"
        End If

        Return Treatment
    End Function
End Class
