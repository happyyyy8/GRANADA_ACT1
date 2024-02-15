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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lblfn = New Label()
        Txt1 = New TextBox()
        lblsn = New Label()
        txt2 = New TextBox()
        btndevide = New Button()
        lblresult = New TextBox()
        SuspendLayout()
        ' 
        ' lblfn
        ' 
        lblfn.AutoSize = True
        lblfn.Location = New Point(38, 29)
        lblfn.Name = "lblfn"
        lblfn.Size = New Size(86, 15)
        lblfn.TabIndex = 0
        lblfn.Text = "FIRST NUMBER"
        ' 
        ' Txt1
        ' 
        Txt1.Location = New Point(40, 64)
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(86, 23)
        Txt1.TabIndex = 1
        ' 
        ' lblsn
        ' 
        lblsn.AutoSize = True
        lblsn.Location = New Point(39, 104)
        lblsn.Name = "lblsn"
        lblsn.Size = New Size(104, 15)
        lblsn.TabIndex = 2
        lblsn.Text = "SECOND NUMBER"
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(43, 136)
        txt2.Name = "txt2"
        txt2.Size = New Size(90, 23)
        txt2.TabIndex = 3
        ' 
        ' btndevide
        ' 
        btndevide.Location = New Point(49, 178)
        btndevide.Name = "btndevide"
        btndevide.Size = New Size(72, 30)
        btndevide.TabIndex = 4
        btndevide.Text = "DIVIDE"
        btndevide.UseVisualStyleBackColor = True
        ' 
        ' lblresult
        ' 
        lblresult.Location = New Point(52, 234)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(85, 23)
        lblresult.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        Controls.Add(lblresult)
        Controls.Add(btndevide)
        Controls.Add(txt2)
        Controls.Add(lblsn)
        Controls.Add(Txt1)
        Controls.Add(lblfn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblfn As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents lblsn As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btndevide As Button
    Friend WithEvents lblresult As TextBox
End Class
