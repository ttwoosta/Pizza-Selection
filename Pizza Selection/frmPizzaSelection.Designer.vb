<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPizzaSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnThinCrush = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(93, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(226, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'picDeepDish
        '
        Me.picDeepDish.Location = New System.Drawing.Point(12, 46)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.picDeepDish.TabIndex = 1
        Me.picDeepDish.TabStop = False
        '
        'picThinCrust
        '
        Me.picThinCrust.Location = New System.Drawing.Point(215, 46)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.picThinCrust.TabIndex = 2
        Me.picThinCrust.TabStop = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.Location = New System.Drawing.Point(47, 214)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(104, 23)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = True
        '
        'btnThinCrush
        '
        Me.btnThinCrush.Location = New System.Drawing.Point(267, 214)
        Me.btnThinCrush.Name = "btnThinCrush"
        Me.btnThinCrush.Size = New System.Drawing.Size(104, 23)
        Me.btnThinCrush.TabIndex = 4
        Me.btnThinCrush.Text = "Thin Crust"
        Me.btnThinCrush.UseVisualStyleBackColor = True
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.Location = New System.Drawing.Point(157, 214)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(104, 23)
        Me.btnSelectPizza.TabIndex = 5
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = True
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Location = New System.Drawing.Point(34, 252)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(345, 17)
        Me.lblInstruction.TabIndex = 6
        Me.lblInstruction.Text = "Choose a pizza and then click the Select Pizza button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(119, 280)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(175, 18)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your pizza selection"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 348)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnThinCrush)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picDeepDish As PictureBox
    Friend WithEvents picThinCrust As PictureBox
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnThinCrush As Button
    Friend WithEvents btnSelectPizza As Button
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
