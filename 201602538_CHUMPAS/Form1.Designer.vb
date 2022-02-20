<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cbLona = New System.Windows.Forms.CheckBox()
        Me.cbSeda = New System.Windows.Forms.CheckBox()
        Me.cbAlgodón = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLarge = New System.Windows.Forms.CheckBox()
        Me.cbMedium = New System.Windows.Forms.CheckBox()
        Me.cbSmall = New System.Windows.Forms.CheckBox()
        Me.lblTamaños = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.cbLona)
        Me.GroupBox1.Controls.Add(Me.cbSeda)
        Me.GroupBox1.Controls.Add(Me.cbAlgodón)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbLarge)
        Me.GroupBox1.Controls.Add(Me.cbMedium)
        Me.GroupBox1.Controls.Add(Me.cbSmall)
        Me.GroupBox1.Controls.Add(Me.lblTamaños)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 357)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chumpas"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(368, 238)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 38)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(368, 174)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(84, 38)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(368, 109)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(84, 38)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'cbLona
        '
        Me.cbLona.AutoSize = True
        Me.cbLona.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLona.Location = New System.Drawing.Point(10, 299)
        Me.cbLona.Name = "cbLona"
        Me.cbLona.Size = New System.Drawing.Size(63, 23)
        Me.cbLona.TabIndex = 7
        Me.cbLona.Text = "Lona"
        Me.cbLona.UseVisualStyleBackColor = True
        '
        'cbSeda
        '
        Me.cbSeda.AutoSize = True
        Me.cbSeda.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeda.Location = New System.Drawing.Point(10, 256)
        Me.cbSeda.Name = "cbSeda"
        Me.cbSeda.Size = New System.Drawing.Size(64, 23)
        Me.cbSeda.TabIndex = 6
        Me.cbSeda.Text = "Seda"
        Me.cbSeda.UseVisualStyleBackColor = True
        '
        'cbAlgodón
        '
        Me.cbAlgodón.AutoSize = True
        Me.cbAlgodón.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlgodón.Location = New System.Drawing.Point(10, 217)
        Me.cbAlgodón.Name = "cbAlgodón"
        Me.cbAlgodón.Size = New System.Drawing.Size(89, 23)
        Me.cbAlgodón.TabIndex = 5
        Me.cbAlgodón.Text = "Algodón"
        Me.cbAlgodón.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Material"
        '
        'cbLarge
        '
        Me.cbLarge.AutoSize = True
        Me.cbLarge.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLarge.Location = New System.Drawing.Point(10, 145)
        Me.cbLarge.Name = "cbLarge"
        Me.cbLarge.Size = New System.Drawing.Size(69, 23)
        Me.cbLarge.TabIndex = 3
        Me.cbLarge.Text = "Large"
        Me.cbLarge.UseVisualStyleBackColor = True
        '
        'cbMedium
        '
        Me.cbMedium.AutoSize = True
        Me.cbMedium.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMedium.Location = New System.Drawing.Point(10, 109)
        Me.cbMedium.Name = "cbMedium"
        Me.cbMedium.Size = New System.Drawing.Size(86, 23)
        Me.cbMedium.TabIndex = 2
        Me.cbMedium.Text = "Medium"
        Me.cbMedium.UseVisualStyleBackColor = True
        '
        'cbSmall
        '
        Me.cbSmall.AutoSize = True
        Me.cbSmall.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSmall.Location = New System.Drawing.Point(10, 72)
        Me.cbSmall.Name = "cbSmall"
        Me.cbSmall.Size = New System.Drawing.Size(68, 23)
        Me.cbSmall.TabIndex = 1
        Me.cbSmall.Text = "Small"
        Me.cbSmall.UseVisualStyleBackColor = True
        '
        'lblTamaños
        '
        Me.lblTamaños.AutoSize = True
        Me.lblTamaños.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaños.Location = New System.Drawing.Point(7, 38)
        Me.lblTamaños.Name = "lblTamaños"
        Me.lblTamaños.Size = New System.Drawing.Size(69, 19)
        Me.lblTamaños.TabIndex = 0
        Me.lblTamaños.Text = "Tamaños"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(200, 118)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents cbLona As CheckBox
    Friend WithEvents cbSeda As CheckBox
    Friend WithEvents cbAlgodón As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbLarge As CheckBox
    Friend WithEvents cbMedium As CheckBox
    Friend WithEvents cbSmall As CheckBox
    Friend WithEvents lblTamaños As Label
    Friend WithEvents txt1 As TextBox
End Class
