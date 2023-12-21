Public Class Asignaturas
    'Creamos los atributos'
    Private Id As Integer
    Private nombre As String
    Private curso As Integer
    Private horas As Integer
    Private Gestor As AsignaturasDAO
    'Definimos los constructores'
    'En los constructores Gestor1, es un objeto de tipo AsignaturasDAO'
    Public Sub New(nombre As String, curso As Integer, horas As Integer)
        Me.Nombre1 = nombre
        Me.Curso1 = curso
        Me.Horas1 = horas
        Me.Gestor1 = New AsignaturasDAO
    End Sub
    Public Sub New(mId As Integer, nombre As String, curso As Integer, horas As Integer)
        Me.Id = Id1
        Me.Nombre1 = nombre
        Me.Curso1 = curso
        Me.Horas1 = horas
        Me.Gestor1 = New AsignaturasDAO
    End Sub
    Sub New()
        Gestor1 = New AsignaturasDAO
    End Sub

    'Creamos el método InsertarAsignatura, que llama al insert de AsignaturasDAO '

    Sub InsertarAsignatura()
        Me.Gestor.insert(Me)
    End Sub

    'Creamos el método eliminarAsignatura, que llama al delete de AsignaturasDAO'
    Sub EliminarAsignatura()
        Me.Gestor.delete(Me)
    End Sub
    'Creamos el método eliminarBBDD la Base de Datos, que llama al deleteAll de AsignaturasDAO'
    Sub EliminarBBDD()
        Me.Gestor.deleteAll()
    End Sub

    'Creamos el método modificarAsignatura, que llama al update de AsignaturasDAO'
    Sub ModificarAsignatura()
        Me.Gestor.update(Me)
    End Sub

    'Creamos el método leerTodos para leer todas las asignaturas de la base de datos, que llama al readAll de AsignaturaDAO'
    Function LeerTodos()
        Dim todos As Collection
        Me.Gestor.readAll()
        todos = Me.Gestor.ListaAsignaturas1
        Return todos
    End Function
    'Creamos el método leerAsignatura. Recibe un nombre de asignatura, y llama al read de AsignaturaDAO'
    Sub LeerAsignatura(ByVal Nombre1 As String)
        Me.Gestor.read(Nombre1, Me)
    End Sub


    'Getter y Setter'
    Public Property Id1 As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Curso1 As Integer
        Get
            Return curso
        End Get
        Set(value As Integer)
            curso = value
        End Set
    End Property

    Public Property Horas1 As Integer
        Get
            Return horas
        End Get
        Set(value As Integer)
            horas = value
        End Set
    End Property

    Public Property Gestor1 As AsignaturasDAO
        Get
            Return Gestor
        End Get
        Set(value As AsignaturasDAO)
            Gestor = value
        End Set
    End Property
End Class
