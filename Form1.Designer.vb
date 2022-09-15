<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisease
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
        Me.BtnInit = New System.Windows.Forms.Button()
        Me.BtnHiv = New System.Windows.Forms.Button()
        Me.BtnMalaria = New System.Windows.Forms.Button()
        Me.BtnCancer = New System.Windows.Forms.Button()
        Me.grdDiseases = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'BtnInit
        '
        Me.BtnInit.Location = New System.Drawing.Point(13, 13)
        Me.BtnInit.Name = "BtnInit"
        Me.BtnInit.Size = New System.Drawing.Size(111, 39)
        Me.BtnInit.TabIndex = 0
        Me.BtnInit.Text = "Initialize"
        Me.BtnInit.UseVisualStyleBackColor = True
        '
        'BtnHiv
        '
        Me.BtnHiv.Location = New System.Drawing.Point(13, 58)
        Me.BtnHiv.Name = "BtnHiv"
        Me.BtnHiv.Size = New System.Drawing.Size(111, 38)
        Me.BtnHiv.TabIndex = 1
        Me.BtnHiv.Text = "View HIV"
        Me.BtnHiv.UseVisualStyleBackColor = True
        '
        'BtnMalaria
        '
        Me.BtnMalaria.Location = New System.Drawing.Point(13, 102)
        Me.BtnMalaria.Name = "BtnMalaria"
        Me.BtnMalaria.Size = New System.Drawing.Size(111, 40)
        Me.BtnMalaria.TabIndex = 2
        Me.BtnMalaria.Text = "View Malaria"
        Me.BtnMalaria.UseVisualStyleBackColor = True
        '
        'BtnCancer
        '
        Me.BtnCancer.Location = New System.Drawing.Point(13, 148)
        Me.BtnCancer.Name = "BtnCancer"
        Me.BtnCancer.Size = New System.Drawing.Size(111, 44)
        Me.BtnCancer.TabIndex = 3
        Me.BtnCancer.Text = "View Cancer"
        Me.BtnCancer.UseVisualStyleBackColor = True
        '
        'grdDiseases
        '
        Me.grdDiseases.FixedCols = 1
        Me.grdDiseases.FixedRows = 1
        Me.grdDiseases.Location = New System.Drawing.Point(130, 13)
        Me.grdDiseases.Name = "grdDiseases"
        Me.grdDiseases.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDiseases.Size = New System.Drawing.Size(614, 324)
        Me.grdDiseases.TabIndex = 4
        '
        'FrmDisease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 354)
        Me.Controls.Add(Me.grdDiseases)
        Me.Controls.Add(Me.BtnCancer)
        Me.Controls.Add(Me.BtnMalaria)
        Me.Controls.Add(Me.BtnHiv)
        Me.Controls.Add(Me.BtnInit)
        Me.Name = "FrmDisease"
        Me.Text = "Treatment Prescriber"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnInit As Button
    Friend WithEvents BtnHiv As Button
    Friend WithEvents BtnMalaria As Button
    Friend WithEvents BtnCancer As Button
    Friend WithEvents grdDiseases As UJGrid.UJGrid
End Class
