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
        Me.Text_Personas = New System.Windows.Forms.Label()
        Me.Text_DNI = New System.Windows.Forms.Label()
        Me.Text_Nombre = New System.Windows.Forms.Label()
        Me.TextBox_Dni = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Bot_Añadir = New System.Windows.Forms.Button()
        Me.Bot_Modificar = New System.Windows.Forms.Button()
        Me.Bot_Eliminar = New System.Windows.Forms.Button()
        Me.Bot_Limpiar = New System.Windows.Forms.Button()
        Me.Bot_Salir = New System.Windows.Forms.Button()
        Me.Bot_BorrarBBDD = New System.Windows.Forms.Button()
        Me.Lst_Personas = New System.Windows.Forms.CheckedListBox()
        Me.Bot_principal = New System.Windows.Forms.Button()
        Me.Bot_Asignaturas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Text_Personas
        '
        Me.Text_Personas.AutoSize = True
        Me.Text_Personas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Personas.Location = New System.Drawing.Point(68, 49)
        Me.Text_Personas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Text_Personas.Name = "Text_Personas"
        Me.Text_Personas.Size = New System.Drawing.Size(90, 16)
        Me.Text_Personas.TabIndex = 0
        Me.Text_Personas.Text = "PERSONAS"
        '
        'Text_DNI
        '
        Me.Text_DNI.AutoSize = True
        Me.Text_DNI.Location = New System.Drawing.Point(304, 49)
        Me.Text_DNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Text_DNI.Name = "Text_DNI"
        Me.Text_DNI.Size = New System.Drawing.Size(26, 13)
        Me.Text_DNI.TabIndex = 1
        Me.Text_DNI.Text = "DNI"
        '
        'Text_Nombre
        '
        Me.Text_Nombre.AutoSize = True
        Me.Text_Nombre.Location = New System.Drawing.Point(304, 87)
        Me.Text_Nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Text_Nombre.Name = "Text_Nombre"
        Me.Text_Nombre.Size = New System.Drawing.Size(54, 13)
        Me.Text_Nombre.TabIndex = 2
        Me.Text_Nombre.Text = "NOMBRE"
        '
        'TextBox_Dni
        '
        Me.TextBox_Dni.Location = New System.Drawing.Point(379, 44)
        Me.TextBox_Dni.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_Dni.Name = "TextBox_Dni"
        Me.TextBox_Dni.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Dni.TabIndex = 3
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.Location = New System.Drawing.Point(379, 82)
        Me.TextBox_Nombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.Size = New System.Drawing.Size(152, 20)
        Me.TextBox_Nombre.TabIndex = 4
        '
        'Bot_Añadir
        '
        Me.Bot_Añadir.Location = New System.Drawing.Point(258, 132)
        Me.Bot_Añadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Añadir.Name = "Bot_Añadir"
        Me.Bot_Añadir.Size = New System.Drawing.Size(88, 74)
        Me.Bot_Añadir.TabIndex = 5
        Me.Bot_Añadir.Text = "AÑADIR"
        Me.Bot_Añadir.UseVisualStyleBackColor = True
        '
        'Bot_Modificar
        '
        Me.Bot_Modificar.Location = New System.Drawing.Point(371, 132)
        Me.Bot_Modificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Modificar.Name = "Bot_Modificar"
        Me.Bot_Modificar.Size = New System.Drawing.Size(88, 74)
        Me.Bot_Modificar.TabIndex = 6
        Me.Bot_Modificar.Text = "MODIFICAR"
        Me.Bot_Modificar.UseVisualStyleBackColor = True
        '
        'Bot_Eliminar
        '
        Me.Bot_Eliminar.Location = New System.Drawing.Point(482, 132)
        Me.Bot_Eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Eliminar.Name = "Bot_Eliminar"
        Me.Bot_Eliminar.Size = New System.Drawing.Size(88, 74)
        Me.Bot_Eliminar.TabIndex = 7
        Me.Bot_Eliminar.Text = "ELIMINAR"
        Me.Bot_Eliminar.UseVisualStyleBackColor = True
        '
        'Bot_Limpiar
        '
        Me.Bot_Limpiar.Location = New System.Drawing.Point(258, 219)
        Me.Bot_Limpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Limpiar.Name = "Bot_Limpiar"
        Me.Bot_Limpiar.Size = New System.Drawing.Size(88, 74)
        Me.Bot_Limpiar.TabIndex = 8
        Me.Bot_Limpiar.Text = "LIMPIAR"
        Me.Bot_Limpiar.UseVisualStyleBackColor = True
        '
        'Bot_Salir
        '
        Me.Bot_Salir.Location = New System.Drawing.Point(371, 219)
        Me.Bot_Salir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Salir.Name = "Bot_Salir"
        Me.Bot_Salir.Size = New System.Drawing.Size(88, 74)
        Me.Bot_Salir.TabIndex = 9
        Me.Bot_Salir.Text = "SALIR"
        Me.Bot_Salir.UseVisualStyleBackColor = True
        '
        'Bot_BorrarBBDD
        '
        Me.Bot_BorrarBBDD.Location = New System.Drawing.Point(482, 219)
        Me.Bot_BorrarBBDD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_BorrarBBDD.Name = "Bot_BorrarBBDD"
        Me.Bot_BorrarBBDD.Size = New System.Drawing.Size(88, 74)
        Me.Bot_BorrarBBDD.TabIndex = 10
        Me.Bot_BorrarBBDD.Text = "BORRAR BBDD"
        Me.Bot_BorrarBBDD.UseVisualStyleBackColor = True
        '
        'Lst_Personas
        '
        Me.Lst_Personas.FormattingEnabled = True
        Me.Lst_Personas.Location = New System.Drawing.Point(36, 82)
        Me.Lst_Personas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lst_Personas.Name = "Lst_Personas"
        Me.Lst_Personas.Size = New System.Drawing.Size(168, 184)
        Me.Lst_Personas.TabIndex = 11
        '
        'Bot_principal
        '
        Me.Bot_principal.Location = New System.Drawing.Point(36, 307)
        Me.Bot_principal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_principal.Name = "Bot_principal"
        Me.Bot_principal.Size = New System.Drawing.Size(76, 31)
        Me.Bot_principal.TabIndex = 12
        Me.Bot_principal.Text = "Principal"
        Me.Bot_principal.UseVisualStyleBackColor = True
        '
        'Bot_Asignaturas
        '
        Me.Bot_Asignaturas.Location = New System.Drawing.Point(127, 307)
        Me.Bot_Asignaturas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bot_Asignaturas.Name = "Bot_Asignaturas"
        Me.Bot_Asignaturas.Size = New System.Drawing.Size(76, 31)
        Me.Bot_Asignaturas.TabIndex = 13
        Me.Bot_Asignaturas.Text = "Asignaturas"
        Me.Bot_Asignaturas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Bot_Asignaturas)
        Me.Controls.Add(Me.Bot_principal)
        Me.Controls.Add(Me.Lst_Personas)
        Me.Controls.Add(Me.Bot_BorrarBBDD)
        Me.Controls.Add(Me.Bot_Salir)
        Me.Controls.Add(Me.Bot_Limpiar)
        Me.Controls.Add(Me.Bot_Eliminar)
        Me.Controls.Add(Me.Bot_Modificar)
        Me.Controls.Add(Me.Bot_Añadir)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.TextBox_Dni)
        Me.Controls.Add(Me.Text_Nombre)
        Me.Controls.Add(Me.Text_DNI)
        Me.Controls.Add(Me.Text_Personas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Text_Personas As Label
    Friend WithEvents Text_DNI As Label
    Friend WithEvents Text_Nombre As Label
    Friend WithEvents TextBox_Dni As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents Bot_Añadir As Button
    Friend WithEvents Bot_Modificar As Button
    Friend WithEvents Bot_Eliminar As Button
    Friend WithEvents Bot_Limpiar As Button
    Friend WithEvents Bot_Salir As Button
    Friend WithEvents Bot_BorrarBBDD As Button
    Friend WithEvents Lst_Personas As CheckedListBox
    Friend WithEvents Bot_principal As Button
    Friend WithEvents Bot_Asignaturas As Button
End Class
