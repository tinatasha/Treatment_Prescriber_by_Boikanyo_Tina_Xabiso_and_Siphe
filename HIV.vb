Option Explicit On
Option Strict On
Option Infer Off

Public Class HIV
    Inherits Disease

    'Attributes/ Instance variables
    Private _CD4 As Double
    Private _ViralLoad As Double

    'Constructor
    Sub New()

    End Sub
    Sub New(Type As String, ptptrans As Boolean, prevention As String)
        _Type = Type
        _PtPTrans = ptptrans
        _Prevention = prevention
    End Sub

    'Property Methods
    Public Property CD4 As Double
        Get
            Return _CD4
        End Get
        Set(value As Double)
            _CD4 = value
        End Set
    End Property

    Public Property ViralLoad As Double
        Get
            Return _ViralLoad
        End Get
        Set(value As Double)
            _ViralLoad = value
        End Set
    End Property

    'Utility Methods
    Public Overrides Function PrescTreatment() As String
        Dim Treatment As String
        Treatment = "ARVS"
        Return Treatment
    End Function

    Public Function VirusDetactablility(ViralLoad As Double) As String
        Dim Undetactable As Double = 200
        Dim Message As String
        If ViralLoad <= Undetactable Then
            Message = "Undetactable"
        Else
            Message = "Detactable"
        End If
        Return Message
    End Function

End Class
