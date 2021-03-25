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
        Me.txtPokeExpan = New System.Windows.Forms.TextBox()
        Me.txtPokeName = New System.Windows.Forms.TextBox()
        Me.txtNumberinSet = New System.Windows.Forms.TextBox()
        Me.txtRarity = New System.Windows.Forms.TextBox()
        Me.txtNumberDuplicates = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pokemon Expansion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pokemon Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number in the Set:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rarity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of Duplicates:"
        '
        'txtPokeExpan
        '
        Me.txtPokeExpan.Location = New System.Drawing.Point(143, 41)
        Me.txtPokeExpan.Name = "txtPokeExpan"
        Me.txtPokeExpan.Size = New System.Drawing.Size(100, 20)
        Me.txtPokeExpan.TabIndex = 5
        '
        'txtPokeName
        '
        Me.txtPokeName.Location = New System.Drawing.Point(143, 67)
        Me.txtPokeName.Name = "txtPokeName"
        Me.txtPokeName.Size = New System.Drawing.Size(100, 20)
        Me.txtPokeName.TabIndex = 6
        '
        'txtNumberinSet
        '
        Me.txtNumberinSet.Location = New System.Drawing.Point(143, 106)
        Me.txtNumberinSet.Name = "txtNumberinSet"
        Me.txtNumberinSet.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberinSet.TabIndex = 7
        '
        'txtRarity
        '
        Me.txtRarity.Location = New System.Drawing.Point(143, 150)
        Me.txtRarity.Name = "txtRarity"
        Me.txtRarity.Size = New System.Drawing.Size(100, 20)
        Me.txtRarity.TabIndex = 8
        '
        'txtNumberDuplicates
        '
        Me.txtNumberDuplicates.Location = New System.Drawing.Point(143, 183)
        Me.txtNumberDuplicates.Name = "txtNumberDuplicates"
        Me.txtNumberDuplicates.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberDuplicates.TabIndex = 9
        '
        'PokeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNumberDuplicates)
        Me.Controls.Add(Me.txtRarity)
        Me.Controls.Add(Me.txtNumberinSet)
        Me.Controls.Add(Me.txtPokeName)
        Me.Controls.Add(Me.txtPokeExpan)
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
    Friend WithEvents txtPokeExpan As TextBox
    Friend WithEvents txtPokeName As TextBox
    Friend WithEvents txtNumberinSet As TextBox
    Friend WithEvents txtRarity As TextBox
    Friend WithEvents txtNumberDuplicates As TextBox
End Class
