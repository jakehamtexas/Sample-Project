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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInputAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbServiceCharge = New System.Windows.Forms.RadioButton()
        Me.rdbCheck = New System.Windows.Forms.RadioButton()
        Me.rdbDeposit = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccountBallance = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Label:"
        '
        'txtInputAmount
        '
        Me.txtInputAmount.Location = New System.Drawing.Point(30, 55)
        Me.txtInputAmount.Name = "txtInputAmount"
        Me.txtInputAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtInputAmount.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbServiceCharge)
        Me.GroupBox1.Controls.Add(Me.rdbCheck)
        Me.GroupBox1.Controls.Add(Me.rdbDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'rdbServiceCharge
        '
        Me.rdbServiceCharge.AutoSize = True
        Me.rdbServiceCharge.Location = New System.Drawing.Point(10, 84)
        Me.rdbServiceCharge.Name = "rdbServiceCharge"
        Me.rdbServiceCharge.Size = New System.Drawing.Size(98, 17)
        Me.rdbServiceCharge.TabIndex = 2
        Me.rdbServiceCharge.TabStop = True
        Me.rdbServiceCharge.Text = "Service Charge"
        Me.rdbServiceCharge.UseVisualStyleBackColor = True
        '
        'rdbCheck
        '
        Me.rdbCheck.AutoSize = True
        Me.rdbCheck.Location = New System.Drawing.Point(10, 52)
        Me.rdbCheck.Name = "rdbCheck"
        Me.rdbCheck.Size = New System.Drawing.Size(56, 17)
        Me.rdbCheck.TabIndex = 1
        Me.rdbCheck.TabStop = True
        Me.rdbCheck.Text = "Check"
        Me.rdbCheck.UseVisualStyleBackColor = True
        '
        'rdbDeposit
        '
        Me.rdbDeposit.AutoSize = True
        Me.rdbDeposit.Location = New System.Drawing.Point(10, 19)
        Me.rdbDeposit.Name = "rdbDeposit"
        Me.rdbDeposit.Size = New System.Drawing.Size(61, 17)
        Me.rdbDeposit.TabIndex = 0
        Me.rdbDeposit.TabStop = True
        Me.rdbDeposit.Text = "Deposit"
        Me.rdbDeposit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Ballance:"
        '
        'lblAccountBallance
        '
        Me.lblAccountBallance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountBallance.Location = New System.Drawing.Point(289, 62)
        Me.lblAccountBallance.Name = "lblAccountBallance"
        Me.lblAccountBallance.Size = New System.Drawing.Size(122, 23)
        Me.lblAccountBallance.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(289, 114)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(289, 147)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(289, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 257)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAccountBallance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInputAmount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Checking Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInputAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbServiceCharge As RadioButton
    Friend WithEvents rdbCheck As RadioButton
    Friend WithEvents rdbDeposit As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccountBallance As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
