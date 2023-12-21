Imports System.Data.OleDb
Imports System.Net

Public Class PersonaDAO
    'Definimos 2 atributos 1 de tipo AgenteBD y una colección'
    Private mlistaPersonas As Collection
    Private Agente As AgenteBD
    Private mListaAsignatura As Collection
    'Constructores'
    Sub New()
        MlistaPersonas1 = New Collection
        MListaAsignatura1 = New Collection

    End Sub

    'Creamos el método insert. Recibe una persona, crea un String con un insert y llama a create de AgenteDB'
    Sub insert(ByVal newPersona As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO Persona VALUES('" & newPersona.MDNI1 & "', '" & newPersona.MNombre1 & "')"
        Me.Agente.create(sSQL)
    End Sub

    'Creamos el método update. Recibe una persona, crea un String con un update y llama a update de AgenteDB'
    Sub update(ByVal modPersona As Persona)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE Persona SET Nombre='" & modPersona.MNombre1 & "'WHERE DNI = '" & modPersona.MDNI1 & "'"
        Agente1.update(sSQL)
    End Sub

    'Creamos el método delete. Recibe una persona, crea un String con un delete (buscando a la persona por el DNI) y llama a delete de AgenteDB'
    Sub delete(ByVal noPersona As Persona)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE FROM Persona WHERE DNI ='" & noPersona.MDNI1 & "'"
        Agente1.delete(sSQL)
    End Sub

    'Creamos el metodo deleteAll que borra a todas las personas de la BBDD, llamando al delete de AgenteDB'
    Sub deleteAll()
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM PERSONA"
        Agente1.delete(sSQL)
    End Sub
    'Creamos el metodo read. Recibe un dni y una persona, llama al read de AgenteDB, comprueba si tiene filas y lee según el nombre y dni'
    Sub read(ByVal dni As String, ByRef per As Persona)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Persona WHERE DNI ='" & dni & "'"
        Dim reader As OleDbDataReader
        reader = Agente1.read(sSQL)
        If reader.HasRows Then
            reader.Read()
            per.MDNI1 = reader(0)
            per.MNombre1 = reader(1)
        End If
    End Sub
    'Creamos el metodo readAll que lee la BBDD entera llamando al read de Agente DB'
    Sub readAll()
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT * FROM Persona ORDER BY DNI" 'Selecciona a todas la personas y las ordena por el DNI'
        Dim reader As OleDbDataReader
        reader = Agente1.read(sSQL)
        While reader.Read() 'Crea un bucle'
            Me.MlistaPersonas1.Add(New Persona(reader.GetString(0), reader.GetString(1))) 'Añade el DNI y Nombre de las personas a la coleccón'
        End While
    End Sub
    'Creamos el metodo insertarPersona_Asignatura. Recibe una persona una asignatura y una notra, y realiza un insert con los datos recibidos llamando al Create de AgenteDB'
    Friend Sub insertarPersona_Asignatura(persona As Persona, asignatura As Asignaturas, nota As Integer)
        Agente1 = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO AsignaturasPersonas VALUES ('" & persona.MDNI1 & "', " & asignatura.Id1 & "," & nota & ")"
        Me.Agente.create(sSQL)

    End Sub
    'Creamos el metodo BorrarPersona_Asig. Recibe una persona y una asignatura, y realiza un delete comparando los datos recibidos con los de la base de datos llamando al delete de AgenteDB'
    Friend Sub BorrarPersona_Asig(newpersona As Persona, newasignatura As Asignaturas)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM AsignaturasPersonas WHERE Persona = '" & newpersona.MDNI1 & "' AND Asignatura = " & newasignatura.Id1
        Agente.delete(sSQL)
    End Sub
    'Creamos el metodo LeerAsignaturasPersona. Recibimos una persona y nos muestra con un selec las asintauras que tiene'
    Friend Sub LeerAsignaturasPersona(ByRef p As Persona)
        Me.Agente = AgenteBD.getInstancia()
        Dim asignatura2 As New Asignaturas
        Dim sSQL As String = "SELECT a.id, a.nombre, a.curso, a.horas FROM AsignaturasPersonas ap, Asignaturas a WHERE ap.asignatura=a.id AND persona= '" & p.MDNI1 & "'"
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        While reader.Read()
            Me.MListaAsignatura1.Add(New Asignaturas(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)))
        End While
    End Sub

    'Creamos la función LeerNota, Recibimos una persona y una asignatura, y hace un consulta que devuelve la Nota, buscando por el DNI de la persona y el ID de su asignatura'
    Public Function LeerNota(Persona As Persona, Asignatura As Asignaturas)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "SELECT Nota FROM AsignaturasPersonas WHERE Persona = '" & Persona.MDNI1 & "' AND Asignatura = " & Asignatura.Id1
        Dim reader As OleDbDataReader
        reader = Me.Agente.read(sSQL)
        If reader.Read() Then   'Si tiene una nota ya puesta devuelve ésta'
            Return reader.GetInt32(0)
        End If
        Return -1 'Si no tiene una nota puesta devuelve -1'
    End Function


    'Getter y Setter'
    Public Property MListaAsignatura1 As Collection
        Get
            Return mListaAsignatura
        End Get
        Set(value As Collection)
            mListaAsignatura = value
        End Set
    End Property
    Public Property MlistaPersonas1 As Collection
        Get
            Return mlistaPersonas
        End Get
        Set(value As Collection)
            mlistaPersonas = value
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