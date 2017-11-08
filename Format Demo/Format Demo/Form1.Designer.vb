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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.btnFixedpointFormat = New System.Windows.Forms.Button()
        Me.btnExponentialformat = New System.Windows.Forms.Button()
        Me.btnCurrencyformat = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.txtUserEntery = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(41, 32)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(127, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a number or a date:"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(43, 75)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(57, 13)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(133, 74)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(200, 23)
        Me.lblResult.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnCurrencyformat)
        Me.GroupBox1.Controls.Add(Me.btnExponentialformat)
        Me.GroupBox1.Controls.Add(Me.btnFixedpointFormat)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 254)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a format"
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(16, 36)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(116, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number Format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'btnFixedpointFormat
        '
        Me.btnFixedpointFormat.Location = New System.Drawing.Point(16, 83)
        Me.btnFixedpointFormat.Name = "btnFixedpointFormat"
        Me.btnFixedpointFormat.Size = New System.Drawing.Size(116, 23)
        Me.btnFixedpointFormat.TabIndex = 1
        Me.btnFixedpointFormat.Text = "Fixed-point format (f)"
        Me.btnFixedpointFormat.UseVisualStyleBackColor = True
        '
        'btnExponentialformat
        '
        Me.btnExponentialformat.Location = New System.Drawing.Point(15, 133)
        Me.btnExponentialformat.Name = "btnExponentialformat"
        Me.btnExponentialformat.Size = New System.Drawing.Size(117, 23)
        Me.btnExponentialformat.TabIndex = 2
        Me.btnExponentialformat.Text = "Exponential format (e)"
        Me.btnExponentialformat.UseVisualStyleBackColor = True
        '
        'btnCurrencyformat
        '
        Me.btnCurrencyformat.Location = New System.Drawing.Point(14, 181)
        Me.btnCurrencyformat.Name = "btnCurrencyformat"
        Me.btnCurrencyformat.Size = New System.Drawing.Size(118, 23)
        Me.btnCurrencyformat.TabIndex = 3
        Me.btnCurrencyformat.Text = "Currency Format (c)"
        Me.btnCurrencyformat.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 225)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Percent format (p)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(179, 35)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(106, 23)
        Me.btnShortDate.TabIndex = 5
        Me.btnShortDate.Text = "Short Date (d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(179, 83)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(106, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long Date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(179, 133)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(106, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short Time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(179, 181)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(106, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long Time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(179, 225)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(106, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full Date/ Time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'txtUserEntery
        '
        Me.txtUserEntery.Location = New System.Drawing.Point(197, 32)
        Me.txtUserEntery.Name = "txtUserEntery"
        Me.txtUserEntery.Size = New System.Drawing.Size(100, 20)
        Me.txtUserEntery.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(465, 415)
        Me.Controls.Add(Me.txtUserEntery)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnCurrencyformat As System.Windows.Forms.Button
    Friend WithEvents btnExponentialformat As System.Windows.Forms.Button
    Friend WithEvents btnFixedpointFormat As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents txtUserEntery As System.Windows.Forms.TextBox

End Class
