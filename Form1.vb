Option Strict On
Option Explicit On
Option Infer Off
Public Class FrmDisease

    Private Diseases() As Disease
    Private nDiseases, cHiv, cCancer, cMalaria As Integer
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        nDiseases = CInt(InputBox("Enter the number of patients: "))
        ReDim Diseases(nDiseases)  'Resize the Array according to Number of Diseases

        For i As Integer = 1 To nDiseases
            Dim choice As Integer
            choice = CInt(InputBox("1.) HIV, 2.) Malaria, 3.) Cancer : ")) 'Choose which Disease you want to capture(Upcasting)
            Select Case choice

                Case 1
                    Dim HIVs As HIV
                    HIVs = New HIV()
                    HIVs.Type = InputBox("What type of disease is this: ")
                    HIVs.Prevention = InputBox("How to prevent this disease? ")
                    Dim PtP As String
                    PtP = InputBox("Is it person to person transmitted? y-yes, n-no")
                    Select Case PtP
                        Case "y"
                            HIVs.PtPTrans = True
                        Case "n"
                            HIVs.PtPTrans = False
                    End Select
                    HIVs.CD4 = CDbl(InputBox("What is the CD4 count of a patient?"))
                    HIVs.ViralLoad = CDbl(InputBox("What is the viral Load?"))
                    Diseases(i) = HIVs
                    cHiv += 1

                Case 2
                    Dim Malarias As Malaria
                    Malarias = New Malaria()
                    Malarias.Type = InputBox("What type of disease is this: ")
                    Malarias.Prevention = InputBox("How to prevent this disease? ")
                    Dim PtP As String
                    PtP = InputBox("Is it person to person transmitted? y-yes, n-no")
                    Select Case PtP
                        Case "y"
                            Malarias.PtPTrans = True
                        Case "n"
                            Malarias.PtPTrans = False
                    End Select
                    Malarias.Weight = CDbl(InputBox("What's the weight of the patient?"))
                    Malarias.MalariaType = InputBox("What type of Malaria?")
                    Malarias.Duration = CInt(InputBox("How long as the patient been diagnosed"))
                    Diseases(i) = Malarias
                    cMalaria += 1

                Case 3
                    Dim Cancers As Cancer
                    Cancers = New Cancer()
                    Cancers.Type = InputBox("What type of disease is this: ")
                    Cancers.Prevention = InputBox("How to prevent this disease? ")
                    Dim PtP As String
                    PtP = InputBox("Is it person to person transmitted? y-yes, n-no")
                    Select Case PtP
                        Case "y"
                            Cancers.PtPTrans = True
                        Case "n"
                            Cancers.PtPTrans = False
                    End Select
                    Cancers.CancerType = InputBox("What type of Cancer")
                    Cancers.Stage = CInt(InputBox("What stage is the cancer?"))
                    Diseases(i) = Cancers
                    cCancer += 1
            End Select
        Next i

    End Sub

    Public Sub PT(r As Integer, c As Integer, t As String)
        grdDiseases.Row = r
        grdDiseases.Col = c
        grdDiseases.Text = t
    End Sub

    Private Sub BtnHiv_Click(sender As Object, e As EventArgs) Handles BtnHiv.Click
        'Grid setup
        grdDiseases.Cols = 8
        grdDiseases.Rows = nDiseases + 1

        'Labelling grid
        PT(0, 1, "Type")
        PT(0, 2, "Prevention")
        PT(0, 3, "Transmittable")
        PT(0, 4, "CD4")
        PT(0, 5, "Viral Load")
        PT(0, 6, "Detactability")
        PT(0, 7, "Treatment")

        For i As Integer = 1 To nDiseases
            Dim HIvs As HIV
            HIvs = TryCast(Diseases(i), HIV) 'Downcasting
            If Not (HIvs Is Nothing) Then
                'Displaying in grid
                PT(i, 0, "HIV #" & CStr(i))
                PT(i, 1, HIvs.Type)
                PT(i, 2, HIvs.Prevention)
                PT(i, 3, CStr(HIvs.PtPTrans))
                PT(i, 4, CStr(HIvs.CD4))
                PT(i, 5, CStr(HIvs.ViralLoad))
                PT(i, 6, HIvs.VirusDetactablility(HIvs.ViralLoad))
                PT(i, 7, HIvs.PrescTreatment)
            End If

        Next i
    End Sub

    Private Sub BtnCancer_Click(sender As Object, e As EventArgs) Handles BtnCancer.Click


        'Grid setup
        grdDiseases.Cols = 8
        grdDiseases.Rows = nDiseases + 1

        'Labelling grid
        PT(0, 1, "Type")
        PT(0, 2, "Prevention")
        PT(0, 3, "Transmittable")
        PT(0, 4, "Cancer Type")
        PT(0, 5, "Stage")
        PT(0, 6, "Survival Likelihood")
        PT(0, 7, "Treatment")

        For i As Integer = 1 To nDiseases

            Dim Cancers As Cancer

            Cancers = TryCast(Diseases(i), Cancer) 'Downcasting
            If Not (Cancers Is Nothing) Then
                'Displaying in grid
                PT(i, 0, "Cancer #" & CStr(i))
                PT(i, 1, Cancers.Type)
                PT(i, 2, Cancers.Prevention)
                PT(i, 3, CStr(Cancers.PtPTrans))
                PT(i, 4, Cancers.CancerType)
                PT(i, 5, CStr(Cancers.Stage))
                PT(i, 6, Cancers.SurvivalLikelyhood)
                PT(i, 7, Cancers.PrescTreatment)
            End If
        Next i
    End Sub

    Private Sub BtnMalaria_Click(sender As Object, e As EventArgs) Handles BtnMalaria.Click
        'Grid setup
        grdDiseases.Cols = 8
        grdDiseases.Rows = nDiseases + 1

        'Labelling grid
        PT(0, 1, "Type")
        PT(0, 2, "Prevention")
        PT(0, 3, "Transmittable")
        PT(0, 4, "Malaria Type")
        PT(0, 5, "Duration")
        PT(0, 6, "Treatment")


        For i As Integer = 1 To nDiseases
            Dim Malarias As Malaria
            Malarias = TryCast(Diseases(i), Malaria) 'Downcasting
            If Not (Malarias Is Nothing) Then
                'Displaying in grid
                PT(i, 0, "Malaria #" & CStr(i))
                PT(i, 1, Malarias.Type)
                PT(i, 2, Malarias.Prevention)
                PT(i, 3, CStr(Malarias.PtPTrans))
                PT(i, 4, Malarias.MalariaType)
                PT(i, 5, CStr(Malarias.Duration))
                PT(i, 6, Malarias.isCelebralMalaria)
                PT(i, 7, Malarias.PrescTreatment)
            End If

        Next i
    End Sub
End Class
