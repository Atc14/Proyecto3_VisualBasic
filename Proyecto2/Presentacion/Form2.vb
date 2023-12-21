Public Class Form2

    'Funcion que se ejecuta al iniciar el Formulario llamando a la funcion Inicializar'
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    'Creamos la funcion inicializar para iniciar el formulario con todos los datos en la lista de asignaturas'
    Private Sub Inicializar()
        Dim newAsignatura As New Asignaturas
        Dim lista As Collection
        Dim i As Integer = 1
        lista = newAsignatura.LeerTodos() 'Leemos todas las asignaturas'
        While i <= lista.Count 'Creamos un bucle desde 1 hasta el tamño de la lista'
            List_Asignaturas.Items.Add(lista.Item(i).Nombre1)
            i = i + 1
            'Añadimos las asignaturas a la Lista en el diseño y añadimos un incremento a i'
        End While
    End Sub

    'Creamos la funcion actualizar, para actualizar la lista de asignaturas.'
    Private Sub Actualizar()
        List_Asignaturas.Items.Clear()
        Dim newAsignatura As New Asignaturas 'Creamos una nueva instancia de la clase Asignturas'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Inicializamos una varibale con el valor predefinido 1'
        lista = newAsignatura.LeerTodos() 'LLamamos al metodo leerTodos para obtener la lista de asignaturas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista el nombre que hemos agregado, y aumenta en 1 para pasar a la siguiente asignatura'
            List_Asignaturas.Items.Add(lista.Item(i).Nombre1)
            i = i + 1
        End While
    End Sub

    'Creamos la funcion limpiar para limpiar los campos por los que se introduce los datos.'
    Private Sub Limpiar()
        TextBox_Name.Clear()
        TextBox_Curso.Clear()
        TextBox_Horas.Clear()
    End Sub

    'Funcionamiento al pulsar el boton de añadir'
    Private Sub Bot_Añadir_Click(sender As Object, e As EventArgs) Handles Bot_Añadir.Click
        If TextBox_Name IsNot Nothing And TextBox_Curso IsNot Nothing And TextBox_Horas IsNot Nothing Then
            Dim newAsignatura As New Asignaturas
            Dim selAsignatura As New Asignaturas
            selAsignatura.LeerAsignatura(TextBox_Name.Text)
            'Comprobamos si existe una asignatura con ese nombre'
            If TextBox_Name.Text <> selAsignatura.Nombre1 Then
                newAsignatura.Nombre1 = TextBox_Name.Text
                newAsignatura.Curso1 = TextBox_Curso.Text
                newAsignatura.Horas1 = TextBox_Horas.Text
                newAsignatura.insertarAsignatura()
                Actualizar()
                MessageBox.Show("Se ha añadido la asignatura: " & newAsignatura.Nombre1 & "'.'")

                'Informamos de la duplicidad de la asignatura'
            Else
                MessageBox.Show("No seas borrico que esa asignatura ya existe.")
            End If

        End If
    End Sub

    'Funcionamiento al pulsar el boton de eliminar'
    Private Sub Bot_Eliminar_Click(sender As Object, e As EventArgs) Handles Bot_Eliminar.Click
        If TextBox_Name IsNot Nothing Then 'Comprobamos que el campo que queremos rellenar no esta vacio'
            Dim newAsignatura As New Asignaturas
            Dim selAsignatura As New Asignaturas
            selAsignatura.LeerAsignatura(TextBox_Name.Text) 'LLamamos al metodo leerAsignatura para obtener los datos que se han ingresado del TextBox_Name'
            If TextBox_Name.Text = selAsignatura.Nombre1 Then 'Le indicamos que compruebe que esa asignatura existe'
                newAsignatura.Nombre1 = TextBox_Name.Text
                newAsignatura.Curso1 = TextBox_Curso.Text
                newAsignatura.Horas1 = TextBox_Horas.Text
                newAsignatura.EliminarAsignatura() 'Llamamos a la funcion eliminarAsignatura, para que elimine la asignatura seleccionada'
                Actualizar() 'Actualizamos los campos en la base de datos'
                Limpiar() 'Limpiamos los textboxes'
                'Una vez los ha eliminado hacemos saltar un mensaje por pantalla con los datos de la asignatura que se ha eliminado'
                MessageBox.Show("Se ha eliminado la asignatura: " & newAsignatura.Nombre1 & "'.'")
            Else  'Si no se ha eliminado esa asignatura es por que no existe en la base de datos, por lo que hacemos un mensaje con que no existe esa asignatura'

                MessageBox.Show("La asignatura no existe.")
            End If
        End If
    End Sub

    'Funcionamiento al pulsar el boton de modificar'
    Private Sub Bot_Modificar_Click(sender As Object, e As EventArgs) Handles Bot_Mod.Click
        If TextBox_Name IsNot Nothing Then 'Indicamos que si el texto tiene datos que realice los siguiente:'
            Dim newAsignatura As New Asignaturas
            Dim selAsignatura As New Asignaturas
            selAsignatura.LeerAsignatura(TextBox_Name.Text) 'La variable sel llama a la funcion leerAsignatura'
            If TextBox_Name.Text = selAsignatura.Nombre1 Then ''Hacemos que compruebe que ese nombre correponde a un nombre existente'
                'Sustituimos los campos anteriores por los nuevos, y llamamos al metodo actualizar para que se refleje en la tabla'
                newAsignatura.Nombre1 = TextBox_Name.Text
                newAsignatura.Curso1 = TextBox_Curso.Text
                newAsignatura.Horas1 = TextBox_Horas.Text
                newAsignatura.ModificarAsignatura()
                Actualizar()
                MessageBox.Show("Se ha modificado la asignatura: " & newAsignatura.Nombre1 & "'.'")
            Else
                MessageBox.Show("La asignatura no existe.")

            End If

        End If
    End Sub
    'Funcionamiento al pulsar el boton de Salir'
    Private Sub Bot_Salir_Click(sender As Object, e As EventArgs) Handles Bot_Salir.Click
        Close()
    End Sub

    'Funcionamiento al pulsar el boton de limpiar'
    Private Sub Bot_Limpiar_Click(sender As Object, e As EventArgs) Handles Bot_Limpiar.Click
        Limpiar()
    End Sub

    'Funcionamiento al pulsar el boton de BorrarBBDD'
    Private Sub Bot_EliminarBBDD_Click(sender As Object, e As EventArgs) Handles Bot_EliminarBBDD.Click

        Dim newAsignatura As New Asignaturas 'Creamos una nueva asignatura con la clase asignatura, y le metemos la funcion de elimnar la BBDD'
        newAsignatura.eliminarBBDD()
        Actualizar() 'Actualizamos la base '
        Limpiar() 'Borra todos los datos de la tabla'
        MessageBox.Show("Se ha borrado toda la base de datos.") 'Salta un mensaje informando de que se ha eliminado la base de datos'

    End Sub

    'Funcionamiento al seleccionar a una persona cuando haces click en la lista'
    Private Sub List_Asignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Asignaturas.SelectedIndexChanged
        Dim p As New Asignaturas 'Creamos un objeto asignatura'
        p.LeerAsignatura(List_Asignaturas.SelectedItem) 'Leemos la asignatura mediante el nombre del item seleccionado'
        'Guardamos los campos de nombre, curso y horas en los TextBox'
        TextBox_Name.Text = p.Nombre1
        TextBox_Curso.Text = p.Curso1
        TextBox_Horas.Text = p.Horas1
    End Sub

    'Funcionamiento al pulsar el boton de Principal'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bot_Principal.Click
        Me.Hide()
        Form3.Show() 'Muestra el formulario de principal'
    End Sub
    'Funcionamiento al pulsar el boton de Asignaturas'
    Private Sub Bot_Personas_Click(sender As Object, e As EventArgs) Handles Bot_Personas.Click
        Me.Hide()
        Form1.Show() 'Muestra el formulario de Asignaturas'
    End Sub


End Class