<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AxWebBrowser1 = New AxSHDocVw.AxWebBrowser()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AxCommonDialog1 = New AxMSComDlg.AxCommonDialog()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCommonDialog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(12, 65)
        Me.AxWebBrowser1.OcxState = CType(resources.GetObject("AxWebBrowser1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser1.Size = New System.Drawing.Size(424, 267)
        Me.AxWebBrowser1.TabIndex = 2
        '
        'AxCommonDialog1
        '
        Me.AxCommonDialog1.Enabled = True
        Me.AxCommonDialog1.Location = New System.Drawing.Point(147, 12)
        Me.AxCommonDialog1.Name = "AxCommonDialog1"
        Me.AxCommonDialog1.OcxState = CType(resources.GetObject("AxCommonDialog1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCommonDialog1.Size = New System.Drawing.Size(32, 32)
        Me.AxCommonDialog1.TabIndex = 3
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(458, 65)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(342, 182)
        Me.WebBrowser1.TabIndex = 4
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 344)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.AxCommonDialog1)
        Me.Controls.Add(Me.AxWebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Editor"
        Me.Text = "Editor"
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCommonDialog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents AxWebBrowser1 As AxSHDocVw.AxWebBrowser
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents AxCommonDialog1 As AxMSComDlg.AxCommonDialog
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
