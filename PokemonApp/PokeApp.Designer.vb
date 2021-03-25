<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokeApp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboSeries = New System.Windows.Forms.ComboBox()
        Me.cboSets = New System.Windows.Forms.ComboBox()
        Me.cboCards = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblRarity = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.webImage = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pokemon Expansion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pokemon Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number in the Set:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rarity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of Duplicates:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(36, 309)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(181, 88)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Changes"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cboSeries
        '
        Me.cboSeries.FormattingEnabled = True
        Me.cboSeries.Location = New System.Drawing.Point(153, 29)
        Me.cboSeries.Name = "cboSeries"
        Me.cboSeries.Size = New System.Drawing.Size(280, 21)
        Me.cboSeries.TabIndex = 6
        '
        'cboSets
        '
        Me.cboSets.FormattingEnabled = True
        Me.cboSets.Location = New System.Drawing.Point(153, 64)
        Me.cboSets.Name = "cboSets"
        Me.cboSets.Size = New System.Drawing.Size(280, 21)
        Me.cboSets.TabIndex = 7
        '
        'cboCards
        '
        Me.cboCards.FormattingEnabled = True
        Me.cboCards.Location = New System.Drawing.Point(153, 99)
        Me.cboCards.Name = "cboCards"
        Me.cboCards.Size = New System.Drawing.Size(280, 21)
        Me.cboCards.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pokemon Series:"
        '
        'lblNumber
        '
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber.Location = New System.Drawing.Point(172, 132)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblNumber.TabIndex = 13
        '
        'lblRarity
        '
        Me.lblRarity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRarity.Location = New System.Drawing.Point(172, 167)
        Me.lblRarity.Name = "lblRarity"
        Me.lblRarity.Size = New System.Drawing.Size(100, 23)
        Me.lblRarity.TabIndex = 14
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(172, 212)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 15
        '
        'webImage
        '
        Me.webImage.Location = New System.Drawing.Point(464, 12)
        Me.webImage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webImage.Name = "webImage"
        Me.webImage.Size = New System.Drawing.Size(313, 426)
        Me.webImage.TabIndex = 16
        '
        'PokeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.webImage)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lblRarity)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCards)
        Me.Controls.Add(Me.cboSets)
        Me.Controls.Add(Me.cboSeries)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PokeApp"
        Me.Text = "PokeApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cboSeries As ComboBox
    Friend WithEvents cboSets As ComboBox
    Friend WithEvents cboCards As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblRarity As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents webImage As WebBrowser
End Class
