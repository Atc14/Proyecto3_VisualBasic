Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class AsignaturasDAO
    'Definimos 2 atributos 1 de tipo AgenteBD y una colección'
    Private listaAsignaturas As Collection
    Private Agente As AgenteBD

    'Constructores'
    Sub New()
        ListaAsignaturas1 = New Collection
    End Sub

    'Creamos el método insert. Recibe una asignatura, crea un String con un insert y llama a create de AgenteDB'
    Sub insert(ByVal newAsignatura As Asignaturas)
        Me.Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO ASIGNATURAS (NOMBRE,CURSO,HORAS) VALUES('" & newAsignatura.Nombre1 & "', '" & newAsignatura.Curso1 & "', '" & newAsignatura.Horas1 & "')"
        Me.Agente1.create(sSQL)
    End Sub

    'Creamos el método update. Recibe una asignatura, crea un String con un update y llama a update de AgenteDB'
    Sub update(ByVal newAsignatura As Asignaturas)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Asignaturas SET Curso='" & newAsignatura.Curso1 & "', Horas ='" & newAsignatura.Horas1 & "'WHERE NOMBRE = '" & newAsignatura.Nombre1 & "'"
        Agente1.update(sSQL)
    End Sub

    'Creamos el método delete. Recibe una asignatura, crea un String con un delete (buscando la asignatura por el nombre) y llama a delete de AgenteDB'
    Sub delete(ByVal newAsignatura As Asignaturas)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM ASIGNATURAS WHERE Nombre ='" & newAsignatura.Nombre1 & "'"
        Agente1.delete(sSQL)
    End Sub
    'Creamos el metodo deleteAll que borra a todas las asignaturas de la BBDD, llamando al delete de AgenteDB'
    Sub deleteAll()
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM ASIGNATURAS"
        Agente1.delete(sSQL)
    End Sub

    'Creamos el metodo read. Recibe un nombre de asignatura y una asignatura, llama al read de AgenteDB, comprueba si tiene filas y lee según el nombre, el curso y las horas'
    Sub read(ByVal nombre As String, ByRef asig As Asignaturas)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM ASIGNATURAS WHERE Nombre ='" & nombre & "'"
        Dim reader As OleDbDataReader
        reader = Agente1.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            asig.Id1 = reader(0)
            asig.Nombre1 = reader(1)
            asig.Curso1 = reader(2)
            asig.Horas1 = reader(3)
        End If
    End Sub

    'Creamos el metodo readAll que lee la BBDD entera llamando al read de Agente DB'
    Sub readAll()
        Me.Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Asignaturas ORDER BY Nombre"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        While reader.Read()

            Me.ListaAsignaturas1.Add(New Asignaturas(reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)))
        End While
    End Sub

    'Getter y Setter'
    Public Property ListaAsignaturas1 As Collection
        Get
            Return listaAsignaturas
        End Get
        Set(value As Collection)
            listaAsignaturas = value
        End Set
    End Property

    Public Property Agente1 As AgenteBD
        Get
            Return Agente
        End Get
        Set(value As AgenteBD)
            Agente = value
        End Set
    End Property


End Class
