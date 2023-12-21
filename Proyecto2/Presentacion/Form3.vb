Public Class Form3

    'Funcion que se ejecuta al iniciar el Formulario llamando a la funcion Inicializar'
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    'Creamos la funcion inicializar para iniciar el formulario con todos los datos de las listas cargados'
    Private Sub Inicializar()
        Actualizar1()
        Actualizar2()
        Actualizar3()
        Actualizar4()
    End Sub
    'Creamos los metodos Actualizar 1 2 3 y 4 para actualizar todas las listas del formulario'
    Private Sub Actualizar1()
        Lst_Persona1.Items.Clear() 'Borramos todos los elementos de la lista Personas para que no se dupliquen'
        Dim newPersona As New Persona 'Creamos una nueva instancia de la clase Persona'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Inicializamos una varibale con el valor predefinido 1'
        lista = newPersona.leerTodos() 'LLamamos al metodo leerTodos para obtener la lista de personas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista el dni que hemos agregado, y aumenta en 1 para pasar a la siguiente persona'
            Lst_Persona1.Items.Add(lista.Item(i).MDNI1)
            i = i + 1
        End While
    End Sub
    Private Sub Actualizar2()
        Lst_Persona2.Items.Clear() 'Borramos todos los elementos de la lista Personas para que no se dupliquen'
        Dim newPersona As New Persona 'Creamos una nueva instancia de la clase Persona'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Inicializamos una varibale con el valor predefinido 1'
        lista = newPersona.leerTodos() 'LLamamos al metodo leerTodos para obtener la lista de personas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista el dni que hemos agregado, y aumenta en 1 para pasar a la siguiente persona'
            Lst_Persona2.Items.Add(lista.Item(i).MDNI1)
            i = i + 1
        End While
    End Sub
    Private Sub Actualizar3()
        Lst_Asignaturas1.Items.Clear() 'Borramos todos los elementos de la lista Asignaturas para que no se dupliquen'
        Dim newAsignaturas As New Asignaturas 'Creamos una nueva instancia de la clase Asignaturas'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Inicializamos una varibale con el valor predefinido 1'
        lista = newAsignaturas.LeerTodos() 'LLamamos al metodo leerTodos para obtener la lista de Asignaturas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista la asignatura que hemos agregado, y aumenta en 1 para pasar a la siguiente Asignatura'
            Lst_Asignaturas1.Items.Add(lista.Item(i).Nombre1)
            i = i + 1
        End While
    End Sub
    Private Sub Actualizar4()
        Lst_Asignaturas2.Items.Clear() 'Borramos todos los elementos de la lista Asignaturas para que no se dupliquen'
        Dim newAsignaturas As New Asignaturas 'Creamos una nueva instancia de la clase Asignaturas'
        Dim lista As Collection 'Declaramos una coleccion llamada lista'
        Dim i As Integer = 1 'Declaramos una coleccion llamada lista'
        lista = newAsignaturas.LeerTodos() 'LLamamos al metodo leerTodos para obtener la lista de Asignaturas'
        While i <= lista.Count 'Creamos un bucle que agrega a la lista la asignatura que hemos agregado, y aumenta en 1 para pasar a la siguiente Asignatura'
            Lst_Asignaturas2.Items.Add(lista.Item(i).Nombre1)
            i = i + 1
        End While
    End Sub

    'Creamos la funcion limpiar para limpiar los campos por los que se introduce los datos.'
    Private Sub Limpiar()
        TextBox_Nota1.Clear()
    End Sub

    'Funcionamiento al pulsar el boton de añadir. Inserta una nota al DNI y asignatura seleccionada.'
    Private Sub Bot_Añadir_Click(sender As Object, e As EventArgs) Handles Bot_Añadir.Click
        'Hacemos un try para controlar errores'
        Try
            'Creamos una persona y una asignatura'
            Dim persona As New Persona
            Dim asignatura As New Asignaturas

            'Creamos el DNI, el Nombre y la Nota como variables, que obtienen los datos de las primeras lista de asignatura y persona y del TextBox de la Nota'
            Dim DNI As String = Lst_Persona1.SelectedItem
            Dim Nombre As String = Lst_Asignaturas1.SelectedItem
            Dim Nota As Integer = TextBox_Nota1.Text
            'Asignamos las variables anteriores al DNI de la persona y al Nombre de la asignatura, de los objetos que hemos creado previamente'
            persona.MDNI1 = DNI
            asignatura.Nombre1 = Nombre
            'Creamos 2 nuevos objetos de Persona y Asignaturas'
            Dim newPersona2 As New Persona
            Dim newAsignatura2 As New Asignaturas
            newAsignatura2.LeerAsignatura(Lst_Asignaturas1.SelectedItem) 'Llamamos a LeerAsignatura, el cual, recibe la asignatura seleccionada en la primera Lista de Asignaturas'
            newPersona2.LeerPersona(Lst_Persona1.SelectedItem) 'Llamamos a LeerPersona, el cual, recibe la persona seleccionada en la primera lista de Personas '
            'Creamos una variable que almacenará la nota de la asignatura de una persona (llamando a LeerNota), función que si encuentra una nota la devuelve y si no la encuentra devuelve -1'
            Dim notaComprobar As Integer = newPersona2.LeerNota(newAsignatura2)


            If notaComprobar <> -1 Then 'Comprobamos que no existe ninguna nota para esa persona en esa asignatura'
                MsgBox("No se pueden insertar 2 notas a la misma persona en la misma asignatura")
            Else
                If Nota < 0 Or Nota > 10 Then 'Comprobamos que la nota debe estar entre 0 y 10'
                    MsgBox("La nota debe ser entre 0 10")
                Else
                    asignatura.LeerAsignatura(Nombre) 'Leemos la Asignatura por su Nombre'
                    persona.insertarPersonaAsig(asignatura, Nota) 'Insertamos la Persona, la Asignatura y su Nota'
                    MsgBox("Se ha insertado la nota")
                    Limpiar()
                End If

            End If
            'Capturamos la excepción, si la nota es una letra o se deja el campo vacío'
        Catch ex As InvalidCastException
            MsgBox("Tienes que introducir una nota correcta")

        End Try

    End Sub
    'Funcionamiento al pulsar el boton de limpiar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bot_Limpiar.Click
        Limpiar()
    End Sub
    'Funcionamiento al pulsar el boton de actualizar'
    Private Sub Bot_Actualizar_Click(sender As Object, e As EventArgs) Handles Bot_Actualizar.Click
        Actualizar1()
        Actualizar2()
        Actualizar3()
        Actualizar4()
    End Sub

    'Funcionamiento al pulsar el boton de Salir'
    Private Sub Bot_Salir_Click(sender As Object, e As EventArgs) Handles Bot_Salir.Click
        Close()
    End Sub
    'Funcionamiento al pulsar el boton de Personas'
    Private Sub Bot_Personas_Click(sender As Object, e As EventArgs) Handles Bot_Personas.Click
        Me.Hide()
        Form1.Show() 'Muestra el formulario de Personas'
    End Sub
    'Funcionamiento al pulsar el boton de Asignaturas'
    Private Sub Bot_Asignaturas_Click(sender As Object, e As EventArgs) Handles Bot_Asignaturas.Click
        Me.Hide()
        Form2.Show() 'Muestra el formulario de Asignaturas'
    End Sub


    'Funcionamiento al pulsar el boton de Eliminar'
    Private Sub Bot_Eliminar_Click(sender As Object, e As EventArgs) Handles Bot_Eliminar.Click
        'Comprobamos que existe una persona y una asignatura'
        If Lst_Asignaturas1.SelectedItem IsNot Nothing And Lst_Persona1.SelectedItem IsNot Nothing Then
            'Creamos el DNI y el Nombre, como variables, que reciben el valor de la Persona y Asignatura seleccionadas en las primeras listas'
            Dim DNI As String = Lst_Persona1.SelectedItem
            Dim Nombre As String = Lst_Asignaturas1.SelectedItem
            'Creamos a una persona y a una asignatura'
            Dim persona As New Persona
            Dim asignatura As New Asignaturas
            'Guardamos en sus atributos (DNI,Nombre), las variables anteriores'
            persona.MDNI1 = DNI
            asignatura.Nombre1 = Nombre
            'Leemos la Asignatura por su Nombre'
            asignatura.LeerAsignatura(Nombre)
            'Llamamos a borrarPersonaAsig que recibe una persona y una asignatura'
            persona.borrarPersonaAsig(asignatura)
            'Informamos por pantalla'
            MsgBox("Se ha eliminado la nota")
            Limpiar()
        Else
            MsgBox("Debes seleccionar una asignatura y a una persona")
        End If


    End Sub
    'Funcionamiento para que cuando seleccionamos a una persona en la segunda lista, se muestren sus notas'
    Private Sub Lst_Persona2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Persona2.SelectedIndexChanged
        'Creamos a una persona'
        Dim newPersona2 As New Persona
        'Creamos una variable DNI, que obtiene su valor de la persona seleccionada en la segunda lista'
        Dim dni As String = Lst_Persona2.SelectedItem
        'Llamamos al método LeerPersona, buscando por el DNI'
        newPersona2.LeerPersona(dni)
        'Llamamos a LeerAsignaturaPersona, que selecciona las asignaturas de una persona'
        newPersona2.LeerAsignaturaPersona()
        'Limpiamos la segunda lista de asignaturas'
        Lst_Asignaturas2.Items.Clear()
        'Creamos una colección'
        Dim listaA As Collection
        'La igualamos al atributo ListaAsignatura1 que almacena las asignaturas de una persona'
        listaA = newPersona2.ListaAsignatura1

        Dim i As Integer = 1
        'Hacemos un bucle hasta el tamaño de la lista'
        While i <= listaA.Count
            'Añadimos a la segunda lista de asignaturas el nombre de cada asignatura de la listaA'
            Lst_Asignaturas2.Items.Add(listaA.Item(i).Nombre1)

            i = i + 1 'Añadimos un incremento para que el bucle avance'
        End While


    End Sub

    'Funcionamiento para que cuando seleccionamos a una persona y asignatura de la segunda lista, aparezca su nota en el TextBox '
    Private Sub Lst_Asignaturas2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Asignaturas2.SelectedIndexChanged
        'Creamos a una persona y a una asignatura'
        Dim newPersona2 As New Persona
        Dim newAsignatura2 As New Asignaturas
        'Creamos un nombre, como variable, que recibe el valor de la asignatura seleccionada en la segunda lista'
        Dim nombre As String = Lst_Asignaturas2.SelectedItem
        'Leemos la Asignaturas por su nombre'
        newAsignatura2.LeerAsignatura(nombre)
        'Creamos un DNI, como variable, que recieb el valor de la persona seleccionada en la segunda lista'
        Dim dni As String = Lst_Persona2.SelectedItem
        'Leemos la persona por su DNI'
        newPersona2.LeerPersona(dni)
        'Rellenamos el TextBox_Nota con la nota que devuelve el método LeerNota'
        TextBox_Nota1.Text = newPersona2.LeerNota(newAsignatura2)
    End Sub
End Class