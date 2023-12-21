Public Class Form1
    'Funcion que se ejecuta al iniciar el Formulario llamando a la funcion Inicializar'
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    'Creamos la funcion inicializar para iniciar el formulario con todos los datos en la lista de personas'
    Private Sub Inicializar()
        Dim newPersona As New Persona
        Dim lista As Collection
        Dim i As Integer = 1
        lista = newPersona.leerTodos() 'Leemos todas las personas'
        While i <= lista.Count 'Creamos un bucle desde 1 hasta el tamño de la lista'
            Lst_Personas.Items.Add(lista.Item(i).MDNI1)
            i = i + 1
            'Añadimos las personas a la Lista en el diseño y añadimos un incremento a i'
        End While
    End Sub

    'Creamos la funcion limpiar para limpiar los campos por los que se introduce los datos.'
    Private Sub Limpiar()
        TextBox_Dni.Clear()
        TextBox_Nombre.Clear()
    End Sub

    'Creamos la funcion actualizar, para actualizar la lista de personas.'
    Private Sub Actualizar()
        Lst_Personas.Items.Clear() 'Borramos todos los elementos de la lista Personas para que no se dupliquen'
        Dim newPersona As New Persona 'Creamos una nueva instancia de la clase Persona'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Inicializamos una varibale con el valor predefinido 1'
        lista = newPersona.leerTodos() 'LLamamos al metodo leerTodos para obtener la lista de personas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista el dni que hemos agregado, y aumenta en 1 para pasar a la siguiente persona'
            Lst_Personas.Items.Add(lista.Item(i).MDNI1)
            i = i + 1
        End While
    End Sub

    'Funcionamiento al pulsar el boton de añadir'
    Private Sub Bot_Añadir_Click(sender As Object, e As EventArgs) Handles Bot_Añadir.Click
        If TextBox_Dni IsNot Nothing And TextBox_Nombre IsNot Nothing Then 'Comprobamos si el Dni y el nombre no está vacio'
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.LeerPersona(TextBox_Dni.Text)
            'Comprobamos si existe una persona con ese DNI y su longitud'
            If TextBox_Dni.Text <> selPersona.MDNI1 And TextBox_Dni.Text.Length = 9 Then
                newPersona.MDNI1 = TextBox_Dni.Text
                newPersona.MNombre1 = TextBox_Nombre.Text
                newPersona.insertarPersona()
                Actualizar()
                MessageBox.Show("Se ha añadido la persona: " & newPersona.MNombre1 & "', con DNI: '" & newPersona.MDNI1 & "'.'")
                'Informamos de la longitud'
            ElseIf (TextBox_Dni.Text.Length < 9 Or TextBox_Dni.Text.Length > 9) Then
                MessageBox.Show("La longitud debe ser de 9 caracteres")
                'Informamos de la duplicidad del DNI'
            Else
                MessageBox.Show("No seas borrico que ese DNI ya existe.")
            End If

        End If
    End Sub


    'Funcionamiento al pulsar el boton de eiminar'
    Private Sub Bot_Eliminar_Click(sender As Object, e As EventArgs) Handles Bot_Eliminar.Click
        If TextBox_Dni IsNot Nothing Then 'Comporbamos que el campo que queremos rellenar no esta vacio'
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.LeerPersona(TextBox_Dni.Text) 'LLamamos al metodo leerPersona para obtener los datos que se han ingresado del TextBox_Dni'
            If TextBox_Dni.Text = selPersona.MDNI1 Then 'Le indicamos que compruebe que esa persona existe'
                newPersona.MDNI1 = TextBox_Dni.Text
                newPersona.MNombre1 = TextBox_Nombre.Text
                newPersona.eliminarPersona() 'Llamamos a la funcion eliminarPersona, para que elimine la persona seleccionada'
                Actualizar() 'Actualizamos los campos en la base de datos'
                Limpiar() 'Limpiamos los textboxes'
                'Una vez los ha eliminado hacemos saltar un mensaje por pantalla con los datos de la persona que se ha eliminado'
                MessageBox.Show("Se ha eliminado la persona: " & newPersona.MNombre1 & "', con DNI: '" & newPersona.MDNI1 & "'.'")
            Else  'Si no se ha eliminado esa persona es por que no existe en la base de datos, por lo que hacemos un mensaje con que no existe es dni'

                MessageBox.Show("El DNI no existe.")
            End If
        End If
    End Sub
    'Funcionamiento al pulsar el boton de modificar'
    Private Sub Bot_Modificar_Click(sender As Object, e As EventArgs) Handles Bot_Modificar.Click
        If TextBox_Dni IsNot Nothing Then 'Indicamos que si el texto tiene datos que realice los siguiente:'
            Dim newPersona As New Persona 'Creamos una nueva Persona de la clase Persona'
            Dim selPersona As New Persona 'Creamos una nueva Persona de la clase Persona'
            selPersona.LeerPersona(TextBox_Dni.Text) 'La variable sel llama a la funcion leerPersona'
            If TextBox_Dni.Text = selPersona.MDNI1 Then ''Hacemos que compruebe que ese dni correponde a un dni existente'
                'Sustituimos los campos anteriores por los nuevos, y llamamos al metodo actualizar para que se refleje en la tabla'
                newPersona.MDNI1 = TextBox_Dni.Text
                newPersona.MNombre1 = TextBox_Nombre.Text
                newPersona.modificarPersona()
                Actualizar()
                MessageBox.Show("Se ha modificado la persona: " & newPersona.MNombre1 & "', con DNI: '" & newPersona.MDNI1 & "'.'")
            Else 'Si el dni no esta en la base de datos, que escriba por pantalla que no existe tal dni'
                MessageBox.Show("El DNI no existe.")

            End If

        End If
    End Sub

    'Funcionamiento al pulsar el boton de limpiar'
    Private Sub Bot_Limpiar_Click(sender As Object, e As EventArgs) Handles Bot_Limpiar.Click 'El boton de limpiar llama a la funcion de limpiar'
        Limpiar()

    End Sub

    'Funcionamiento al pulsar el boton de Salir'
    Private Sub Bot_Salir_Click(sender As Object, e As EventArgs) Handles Bot_Salir.Click 'El boton de salir llama a la funcion close, que cierra el programa'
        Close()
    End Sub
    'Funcionamiento al pulsar el boton de BorrarBBDD'
    Private Sub Bot_BorrarBBDD_Click(sender As Object, e As EventArgs) Handles Bot_BorrarBBDD.Click 'boton de borrarBBDD'
        Dim newPersona As New Persona 'Creamos una nueva Persona con la clase persona, y le metemos la funcion de elimnar la BBDD'
        newPersona.eliminarBBDD() 'Aqui llamamos dicha funcion'
        Actualizar() 'Actualizamos la base '
        Limpiar() 'Borra todos los datos de la tabla'
        MessageBox.Show("Se ha borrado toda la base de datos.") 'Salta un mensaje informando de que se ha eliminado la base de datos'
    End Sub

    'Funcionamiento al seleccionar a una persona cuando haces click en la lista'
    Private Sub Lst_Personas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Personas.SelectedIndexChanged, Lst_Personas.Click
        Dim p As New Persona 'Creamos un objeto persona'
        p.LeerPersona(Lst_Personas.SelectedItem) 'Leemos la persona mediante el DNI del item seleccionado'
        'Guardamos los campos del DNI y nombre en los TextBox'
        TextBox_Dni.Text = p.MDNI1
        TextBox_Nombre.Text = p.MNombre1
    End Sub

    'Funcionamiento al pulsar el boton de Principal'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bot_principal.Click
        Me.Hide()
        Form3.Show() 'Muestra el formulario de principal'
    End Sub

    'Funcionamiento al pulsar el boton de Asignaturas'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bot_Asignaturas.Click
        Me.Hide()
        Form2.Show() 'Muestra el formulario de Asignaturas'
    End Sub
End Class
