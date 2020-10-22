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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.EnableBtn = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.OutputBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EnableBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HelpBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.59524!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.40476!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(801, 324)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OutputBox
        '
        Me.OutputBox.AcceptsReturn = True
        Me.OutputBox.BackColor = System.Drawing.Color.Black
        Me.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.OutputBox, 3)
        Me.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutputBox.ForeColor = System.Drawing.Color.LawnGreen
        Me.OutputBox.Location = New System.Drawing.Point(3, 85)
        Me.OutputBox.Multiline = True
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.ReadOnly = True
        Me.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputBox.Size = New System.Drawing.Size(795, 236)
        Me.OutputBox.TabIndex = 1
        Me.OutputBox.Text = "Welome to Code Breaker v0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'Enable' to begin or 'Help' to get started." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EnableBtn
        '
        Me.EnableBtn.BackColor = System.Drawing.Color.Salmon
        Me.EnableBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnableBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableBtn.Location = New System.Drawing.Point(3, 3)
        Me.EnableBtn.Name = "EnableBtn"
        Me.EnableBtn.Size = New System.Drawing.Size(260, 76)
        Me.EnableBtn.TabIndex = 2
        Me.EnableBtn.Text = "Enable/Disable"
        Me.EnableBtn.UseVisualStyleBackColor = False
        '
        'HelpBtn
        '
        Me.HelpBtn.BackColor = System.Drawing.Color.Silver
        Me.HelpBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpBtn.Location = New System.Drawing.Point(536, 3)
        Me.HelpBtn.Name = "HelpBtn"
        Me.HelpBtn.Size = New System.Drawing.Size(262, 76)
        Me.HelpBtn.TabIndex = 0
        Me.HelpBtn.Text = "Help"
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(269, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 82)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Code Breaker v0.1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(801, 324)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Code Breaker v0.1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents EnableBtn As Button
    Friend WithEvents HelpBtn As Button
    Friend WithEvents Label1 As Label
End Class
