<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Lst_Persona1 = New System.Windows.Forms.ListBox()
        Me.Lst_Persona2 = New System.Windows.Forms.ListBox()
        Me.Lst_Asignaturas1 = New System.Windows.Forms.ListBox()
        Me.Lst_Asignaturas2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Nota1 = New System.Windows.Forms.TextBox()
        Me.Bot_Añadir = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Limpiar = New System.Windows.Forms.Button()
        Me.Bot_Personas = New System.Windows.Forms.Button()
        Me.Bot_Asignaturas = New System.Windows.Forms.Button()
        Me.Bot_Salir = New System.Windows.Forms.Button()
        Me.Bot_Actualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lst_Persona1
        '
        Me.Lst_Persona1.FormattingEnabled = True
        Me.Lst_Persona1.Location = New System.Drawing.Point(19, 58)
        Me.Lst_Persona1.Margin = New System.Windows.Forms.Padding(2)
        Me.Lst_Persona1.Name = "Lst_Persona1"
        Me.Lst_Persona1.Size = New System.Drawing.Size(120, 121)
        Me.Lst_Persona1.TabIndex = 0
        '
        'Lst_Persona2
        '
        Me.Lst_Persona2.FormattingEnabled = True
        Me.Lst_Persona2.Location = New System.Drawing.Point(19, 209)
        Me.Lst_Persona2.Margin = New System.Windows.Forms.Padding(2)
        Me.Lst_Persona2.Name = "Lst_Persona2"
        Me.Lst_Persona2.Size = New System.Drawing.Size(120, 121)
        Me.Lst_Persona2.TabIndex = 1
        '
        'Lst_Asignaturas1
        '
        Me.Lst_Asignaturas1.FormattingEnabled = True
        Me.Lst_Asignaturas1.Location = New System.Drawing.Point(165, 58)
        Me.Lst_Asignaturas1.Margin = New System.Windows.Forms.Padding(2)
        Me.Lst_Asignaturas1.Name = "Lst_Asignaturas1"
        Me.Lst_Asignaturas1.Size = New System.Drawing.Size(120, 121)
        Me.Lst_Asignaturas1.TabIndex = 2
        '
        'Lst_Asignaturas2
        '
        Me.Lst_Asignaturas2.FormattingEnabled = True
        Me.Lst_Asignaturas2.Location = New System.Drawing.Point(165, 209)
        Me.Lst_Asignaturas2.Margin = New System.Windows.Forms.Padding(2)
        Me.Lst_Asignaturas2.Name = "Lst_Asignaturas2"
        Me.Lst_Asignaturas2.Size = New System.Drawing.Size(120, 121)
        Me.Lst_Asignaturas2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Personas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Asignaturas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nota"
        '
        'TextBox_Nota1
        '
        Me.TextBox_Nota1.Location = New System.Drawing.Point(387, 58)
        Me.TextBox_Nota1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Nota1.Name = "TextBox_Nota1"
        Me.TextBox_Nota1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox_Nota1.TabIndex = 8
        '
        'Bot_Añadir
        '
        Me.Bot_Añadir.Location = New System.Drawing.Point(316, 119)
        Me.Bot_Añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Añadir.Name = "Bot_Añadir"
        Me.Bot_Añadir.Size = New System.Drawing.Size(64, 42)
        Me.Bot_Añadir.TabIndex = 10
        Me.Bot_Añadir.Text = "Añadir"
        Me.Bot_Añadir.UseVisualStyleBackColor = True
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Location = New System.Drawing.Point(398, 119)
        Me.Bot_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(64, 42)
        Me.Bot_Eliminar.TabIndex = 11
        Me.Bot_Eliminar.Text = "Eliminar"
        Me.Bot_Eliminar.UseVisualStyleBackColor = True
        '
        'Bot_Limpiar
        '
        Me.Bot_Limpiar.Location = New System.Drawing.Point(479, 119)
        Me.Bot_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Limpiar.Name = "Bot_Limpiar"
        Me.Bot_Limpiar.Size = New System.Drawing.Size(64, 42)
        Me.Bot_Limpiar.TabIndex = 12
        Me.Bot_Limpiar.Text = "Limpiar"
        Me.Bot_Limpiar.UseVisualStyleBackColor = True
        '
        'Bot_Personas
        '
        Me.Bot_Personas.Location = New System.Drawing.Point(457, 239)
        Me.Bot_Personas.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Personas.Name = "Bot_Personas"
        Me.Bot_Personas.Size = New System.Drawing.Size(87, 42)
        Me.Bot_Personas.TabIndex = 13
        Me.Bot_Personas.Text = "Personas"
        Me.Bot_Personas.UseVisualStyleBackColor = True
        '
        'Bot_Asignaturas
        '
        Me.Bot_Asignaturas.Location = New System.Drawing.Point(316, 238)
        Me.Bot_Asignaturas.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Asignaturas.Name = "Bot_Asignaturas"
        Me.Bot_Asignaturas.Size = New System.Drawing.Size(87, 43)
        Me.Bot_Asignaturas.TabIndex = 14
        Me.Bot_Asignaturas.Text = "Asignaturas"
        Me.Bot_Asignaturas.UseVisualStyleBackColor = True
        '
        'Bot_Salir
        '
        Me.Bot_Salir.Location = New System.Drawing.Point(387, 299)
        Me.Bot_Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Salir.Name = "Bot_Salir"
        Me.Bot_Salir.Size = New System.Drawing.Size(87, 43)
        Me.Bot_Salir.TabIndex = 15
        Me.Bot_Salir.Text = "Salir"
        Me.Bot_Salir.UseVisualStyleBackColor = True
        '
        'Bot_Actualizar
        '
        Me.Bot_Actualizar.Location = New System.Drawing.Point(388, 180)
        Me.Bot_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Actualizar.Name = "Bot_Actualizar"
        Me.Bot_Actualizar.Size = New System.Drawing.Size(86, 42)
        Me.Bot_Actualizar.TabIndex = 16
        Me.Bot_Actualizar.Text = "Actualizar"
        Me.Bot_Actualizar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Bot_Actualizar)
        Me.Controls.Add(Me.Bot_Salir)
        Me.Controls.Add(Me.Bot_Asignaturas)
        Me.Controls.Add(Me.Bot_Personas)
        Me.Controls.Add(Me.Bot_Limpiar)
        Me.Controls.Add(Me.Bot_Eliminar)
        Me.Controls.Add(Me.Bot_Añadir)
        Me.Controls.Add(Me.TextBox_Nota1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lst_Asignaturas2)
        Me.Controls.Add(Me.Lst_Asignaturas1)
        Me.Controls.Add(Me.Lst_Persona2)
        Me.Controls.Add(Me.Lst_Persona1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lst_Persona1 As ListBox
    Friend WithEvents Lst_Persona2 As ListBox
    Friend WithEvents Lst_Asignaturas1 As ListBox
    Friend WithEvents Lst_Asignaturas2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Nota1 As TextBox
    Friend WithEvents Bot_Añadir As Button
    Friend WithEvents Bot_Eliminar As Button
    Friend WithEvents Bot_Limpiar As Button
    Friend WithEvents Bot_Personas As Button
    Friend WithEvents Bot_Asignaturas As Button
    Friend WithEvents Bot_Salir As Button
    Friend WithEvents Bot_Actualizar As Button
End Class
