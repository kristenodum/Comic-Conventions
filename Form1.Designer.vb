<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblComicConvention = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grbBadgeType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radSuperHero = New System.Windows.Forms.RadioButton()
        Me.lblRegCost = New System.Windows.Forms.Label()
        Me.txtsize = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Comic_Conventions.My.Resources.Resources.comic
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(797, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblComicConvention
        '
        Me.lblComicConvention.AutoSize = True
        Me.lblComicConvention.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicConvention.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblComicConvention.Location = New System.Drawing.Point(100, 182)
        Me.lblComicConvention.Name = "lblComicConvention"
        Me.lblComicConvention.Size = New System.Drawing.Size(484, 45)
        Me.lblComicConvention.TabIndex = 1
        Me.lblComicConvention.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroupSize.Location = New System.Drawing.Point(172, 227)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(127, 27)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size: "
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(167, 483)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 41)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(386, 483)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'grbBadgeType
        '
        Me.grbBadgeType.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grbBadgeType.Controls.Add(Me.radConvention)
        Me.grbBadgeType.Controls.Add(Me.radAutograph)
        Me.grbBadgeType.Controls.Add(Me.radSuperHero)
        Me.grbBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBadgeType.ForeColor = System.Drawing.Color.OrangeRed
        Me.grbBadgeType.Location = New System.Drawing.Point(167, 272)
        Me.grbBadgeType.Name = "grbBadgeType"
        Me.grbBadgeType.Size = New System.Drawing.Size(329, 164)
        Me.grbBadgeType.TabIndex = 5
        Me.grbBadgeType.TabStop = False
        Me.grbBadgeType.Text = "Select Badge Type "
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(35, 133)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(103, 25)
        Me.radConvention.TabIndex = 2
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Location = New System.Drawing.Point(35, 84)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(214, 25)
        Me.radAutograph.TabIndex = 1
        Me.radAutograph.Text = "Convention + Autographs "
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radSuperHero
        '
        Me.radSuperHero.AutoSize = True
        Me.radSuperHero.Checked = True
        Me.radSuperHero.ForeColor = System.Drawing.Color.OrangeRed
        Me.radSuperHero.Location = New System.Drawing.Point(35, 36)
        Me.radSuperHero.Name = "radSuperHero"
        Me.radSuperHero.Size = New System.Drawing.Size(283, 25)
        Me.radSuperHero.TabIndex = 0
        Me.radSuperHero.TabStop = True
        Me.radSuperHero.Text = "Convention + Superhero Experience"
        Me.radSuperHero.UseVisualStyleBackColor = True
        '
        'lblRegCost
        '
        Me.lblRegCost.AutoSize = True
        Me.lblRegCost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegCost.Location = New System.Drawing.Point(133, 439)
        Me.lblRegCost.Name = "lblRegCost"
        Me.lblRegCost.Size = New System.Drawing.Size(178, 27)
        Me.lblRegCost.TabIndex = 6
        Me.lblRegCost.Text = "Registration Cost:"
        '
        'txtsize
        '
        Me.txtsize.Location = New System.Drawing.Point(330, 234)
        Me.txtsize.Name = "txtsize"
        Me.txtsize.Size = New System.Drawing.Size(46, 20)
        Me.txtsize.TabIndex = 7
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTotalCost.Location = New System.Drawing.Point(356, 443)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(98, 23)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "$0000.000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 536)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtsize)
        Me.Controls.Add(Me.lblRegCost)
        Me.Controls.Add(Me.grbBadgeType)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblComicConvention)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbBadgeType.ResumeLayout(False)
        Me.grbBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblComicConvention As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grbBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuperHero As RadioButton
    Friend WithEvents lblRegCost As Label
    Friend WithEvents txtsize As TextBox
    Friend WithEvents lblTotalCost As Label
End Class
