Imports System.Data.OleDb

Public Class Persona
    'Creamos los atributos'
    Private mDNI As String
    Private mNombre As String
    Private Gestor As PersonaDAO
    Private listaAsignatura As Collection

    'Definimos los constructores'
    Sub New(ByVal dni As String, ByVal nombre As String)
        Me.MDNI1 = dni
        Me.MNombre1 = nombre
        Gestor1 = New PersonaDAO
    End Sub

    'En ambos constructores Gestor1, es un objeto de tipo PersonaDAO'
    Sub New()
        Gestor1 = New PersonaDAO
    End Sub
    'Creamos el método insertarPersona, que llama al insert de PersonaDAO '
    Sub insertarPersona()
        Me.Gestor.insert(Me)
    End Sub
    'Creamos el método modificarPersona, que llama al update de PersonaDAO'
    Sub modificarPersona()
        Me.Gestor.update(Me)
    End Sub
    'Creamos el método eliminarPersona, que llama al delete de PersonaDAO'
    Sub eliminarPersona()
        Me.Gestor.delete(Me)
    End Sub
    'Creamos el método eliminarBBDD la Base de Datos, que llama al deleteAll de PersonaDAO'
    Sub eliminarBBDD()
        Me.Gestor.deleteAll()
    End Sub

    'Creamos el método leerTodos para leer todas las personas la base de datos, que llama al readAll de PersonaDAO'
    Function leerTodos()
        Dim todos As Collection
        Me.Gestor.readAll()
        todos = Me.Gestor.MlistaPersonas1
        Return todos
    End Function
    'Creamos el método LeerPersona. Recibe un DNI de persona  y llama al read de PersonaDAO'
    Sub LeerPersona(ByVal dni As String)
        Me.Gestor.read(dni, Me)
    End Sub
    'Creamos el método insertarPersonaAsig. Recibe una Asignatura y una nota, y llama al insertarPersona_Asignatura de PersonaDAO'
    Sub insertarPersonaAsig(asignatura As Asignaturas, nota As Integer)
        Me.Gestor.insertarPersona_Asignatura(Me, asignatura, nota)
    End Sub
    'Creamos el método borrarPersonaAsig. Recibe una asignatura y una persona, y llama al BorrarPersona_Asig de PersonaDAO'
    Friend Sub borrarPersonaAsig(asignatura As Asignaturas)
        Me.Gestor.BorrarPersona_Asig(Me, asignatura)

    End Sub
    'Creamos el método LeerAsignaturaPersona. Se encarga de leer las asignaturas de una persona y cargarlas en la lista'
    Friend Sub LeerAsignaturaPersona()
        Me.Gestor.LeerAsignaturasPersona(Me)
        Me.ListaAsignatura1 = Me.Gestor.MListaAsignatura1
    End Sub

    'Creamos el método LeerNota. Recube una persona y una asignatura, y llama al LeerNota de PersonaDAO'
    Public Function LeerNota(asignatura As Asignaturas) As Integer
        Return Me.Gestor.LeerNota(Me, asignatura)
    End Function
    'Getter y Setter'
    Public Property MDNI1 As String
        Get
            Return mDNI
        End Get
        Set(value As String)
            mDNI = value
        End Set
    End Property

    Public Property MNombre1 As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property Gestor1 As PersonaDAO
        Get
            Return Gestor
        End Get
        Set(value As PersonaDAO)
            Gestor = value
        End Set
    End Property

    Public Property ListaAsignatura1 As Collection
        Get
            Return listaAsignatura
        End Get
        Set(value As Collection)
            listaAsignatura = value
        End Set
    End Property

End Class
