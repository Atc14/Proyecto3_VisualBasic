<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Bot_Añadir = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Limpiar = New System.Windows.Forms.Button()
        Me.Bot_Salir = New System.Windows.Forms.Button()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Curso = New System.Windows.Forms.TextBox()
        Me.TextBox_Horas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.List_Asignaturas = New System.Windows.Forms.ListBox()
        Me.Bot_EliminarBBDD = New System.Windows.Forms.Button()
        Me.Bot_Mod = New System.Windows.Forms.Button()
        Me.Bot_Principal = New System.Windows.Forms.Button()
        Me.Bot_Personas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bot_Añadir
        '
        Me.Bot_Añadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Añadir.Location = New System.Drawing.Point(279, 184)
        Me.Bot_Añadir.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Añadir.Name = "Bot_Añadir"
        Me.Bot_Añadir.Size = New System.Drawing.Size(72, 53)
        Me.Bot_Añadir.TabIndex = 0
        Me.Bot_Añadir.Text = "Añadir"
        Me.Bot_Añadir.UseVisualStyleBackColor = True
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Eliminar.Location = New System.Drawing.Point(368, 184)
        Me.Bot_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(71, 53)
        Me.Bot_Eliminar.TabIndex = 1
        Me.Bot_Eliminar.Text = "Eliminar"
        Me.Bot_Eliminar.UseVisualStyleBackColor = True
        '
        'Bot_Limpiar
        '
        Me.Bot_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Limpiar.Location = New System.Drawing.Point(455, 184)
        Me.Bot_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Limpiar.Name = "Bot_Limpiar"
        Me.Bot_Limpiar.Size = New System.Drawing.Size(71, 53)
        Me.Bot_Limpiar.TabIndex = 2
        Me.Bot_Limpiar.Text = "Limpiar"
        Me.Bot_Limpiar.UseVisualStyleBackColor = True
        '
        'Bot_Salir
        '
        Me.Bot_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Salir.Location = New System.Drawing.Point(367, 261)
        Me.Bot_Salir.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Salir.Name = "Bot_Salir"
        Me.Bot_Salir.Size = New System.Drawing.Size(72, 55)
        Me.Bot_Salir.TabIndex = 3
        Me.Bot_Salir.Text = "Salir"
        Me.Bot_Salir.UseVisualStyleBackColor = True
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(380, 48)
        Me.TextBox_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(76, 22)
        Me.TextBox_Name.TabIndex = 5
        '
        'TextBox_Curso
        '
        Me.TextBox_Curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Curso.Location = New System.Drawing.Point(380, 91)
        Me.TextBox_Curso.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Curso.Name = "TextBox_Curso"
        Me.TextBox_Curso.Size = New System.Drawing.Size(76, 22)
        Me.TextBox_Curso.TabIndex = 6
        '
        'TextBox_Horas
        '
        Me.TextBox_Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Horas.Location = New System.Drawing.Point(380, 130)
        Me.TextBox_Horas.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Horas.Name = "TextBox_Horas"
        Me.TextBox_Horas.Size = New System.Drawing.Size(76, 22)
        Me.TextBox_Horas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Curso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Horas:"
        '
        'List_Asignaturas
        '
        Me.List_Asignaturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Asignaturas.FormattingEnabled = True
        Me.List_Asignaturas.ItemHeight = 20
        Me.List_Asignaturas.Location = New System.Drawing.Point(45, 58)
        Me.List_Asignaturas.Margin = New System.Windows.Forms.Padding(2)
        Me.List_Asignaturas.Name = "List_Asignaturas"
        Me.List_Asignaturas.Size = New System.Drawing.Size(157, 204)
        Me.List_Asignaturas.TabIndex = 12
        '
        'Bot_EliminarBBDD
        '
        Me.Bot_EliminarBBDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_EliminarBBDD.Location = New System.Drawing.Point(455, 261)
        Me.Bot_EliminarBBDD.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_EliminarBBDD.Name = "Bot_EliminarBBDD"
        Me.Bot_EliminarBBDD.Size = New System.Drawing.Size(71, 55)
        Me.Bot_EliminarBBDD.TabIndex = 13
        Me.Bot_EliminarBBDD.Text = "Eliminar BBDD"
        Me.Bot_EliminarBBDD.UseVisualStyleBackColor = True
        '
        'Bot_Mod
        '
        Me.Bot_Mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_Mod.Location = New System.Drawing.Point(279, 261)
        Me.Bot_Mod.Name = "Bot_Mod"
        Me.Bot_Mod.Size = New System.Drawing.Size(72, 55)
        Me.Bot_Mod.TabIndex = 14
        Me.Bot_Mod.Text = "Modificar"
        Me.Bot_Mod.UseVisualStyleBackColor = True
        '
        'Bot_Principal
        '
        Me.Bot_Principal.Location = New System.Drawing.Point(45, 310)
        Me.Bot_Principal.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Principal.Name = "Bot_Principal"
        Me.Bot_Principal.Size = New System.Drawing.Size(75, 34)
        Me.Bot_Principal.TabIndex = 15
        Me.Bot_Principal.Text = "Principal"
        Me.Bot_Principal.UseVisualStyleBackColor = True
        '
        'Bot_Personas
        '
        Me.Bot_Personas.Location = New System.Drawing.Point(126, 310)
        Me.Bot_Personas.Margin = New System.Windows.Forms.Padding(2)
        Me.Bot_Personas.Name = "Bot_Personas"
        Me.Bot_Personas.Size = New System.Drawing.Size(75, 34)
        Me.Bot_Personas.TabIndex = 16
        Me.Bot_Personas.Text = "Personas"
        Me.Bot_Personas.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 366)
        Me.Controls.Add(Me.Bot_Personas)
        Me.Controls.Add(Me.Bot_Principal)
        Me.Controls.Add(Me.Bot_Mod)
        Me.Controls.Add(Me.Bot_EliminarBBDD)
        Me.Controls.Add(Me.List_Asignaturas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Horas)
        Me.Controls.Add(Me.TextBox_Curso)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Bot_Salir)
        Me.Controls.Add(Me.Bot_Limpiar)
        Me.Controls.Add(Me.Bot_Eliminar)
        Me.Controls.Add(Me.Bot_Añadir)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Asignaturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bot_Añadir As Button
    Friend WithEvents Bot_Eliminar As Button
    Friend WithEvents Bot_Limpiar As Button
    Friend WithEvents Bot_Salir As Button
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Curso As TextBox
    Friend WithEvents TextBox_Horas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents List_Asignaturas As ListBox
    Friend WithEvents Bot_EliminarBBDD As Button
    Friend WithEvents Bot_Mod As Button
    Friend WithEvents Bot_Principal As Button
    Friend WithEvents Bot_Personas As Button
End Class
