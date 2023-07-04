<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connect
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
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 34)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(212, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(360, 34)
        Panel4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Product Sans", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(300, 0, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 34)
        Label1.TabIndex = 0
        Label1.Text = "undefined"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(212, 34)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(212, 34)
        Panel3.TabIndex = 1
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Dock = DockStyle.Fill
        WebView21.Location = New Point(0, 34)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(800, 416)
        WebView21.TabIndex = 1
        WebView21.ZoomFactor = 1R
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Dock = DockStyle.Right
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(323, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 34)
        Button1.TabIndex = 1
        Button1.Text = "✖️"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Connect
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(WebView21)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Connect"
        Text = "Connect"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button1 As Button
End Class
