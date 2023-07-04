<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Screenshot_2023_07_03_212423
        PictureBox1.Location = New Point(12, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(183, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Product Sans", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(212, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 43)
        Label1.TabIndex = 1
        Label1.Text = "Connect"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(9, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(780, 24)
        Label2.TabIndex = 2
        Label2.Text = "QNAP Connect is an unofficial QNAP Connection service to connect to your local QNAP NAS."
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(337, 139)
        TextBox1.MaxLength = 327670
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(412, 26)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Product Sans", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(27, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(270, 28)
        Label3.TabIndex = 4
        Label3.Text = "Enter your QNAP Server IP:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(24, 399)
        Label4.Name = "Label4"
        Label4.Size = New Size(655, 15)
        Label4.TabIndex = 5
        Label4.Text = "Product License Key: EEROM-301-PI3SA-SA5O9-QMORO-N2ZK1-KKOPM-EEROM-064RX-IIYLOT"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(209, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Connect"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 428)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Product Sans", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.Gray
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "QNAP Connect"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
