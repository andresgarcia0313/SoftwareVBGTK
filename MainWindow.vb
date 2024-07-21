Imports Gtk

Public Class MainWindow
    Inherits Window

    Public Sub New()
        MyBase.New("Aplicación") ' Título de la ventana
        Dim vbox As New Box(Orientation.Vertical, 0) ' Contenedor vertical
        Dim label As New Label("¡Bienvenido!") ' Etiqueta
        Dim button As New Button("Haz clic aquí") ' Botón
        Dim entry As New Entry() ' Input de texto
        AddHandler button.Clicked, Sub() label.Text = entry.Text ' Cambiar el texto de la etiqueta al texto introducido en el input
        vbox.PackStart(entry, False, False, 10) ' Añadir el input al contenedor
        vbox.PackStart(label, False, False, 10) ' Añadir la etiqueta al contenedor        
        vbox.PackStart(button, False, False, 10) ' Añadir el botón al contenedor
        Add(vbox) ' Añadir el contenedor a la ventana
        SetSizeRequest(800, 600) ' Establecer el tamaño de la ventana
        AddHandler DeleteEvent, AddressOf OnDelete ' Al cerrar la ventana, cierra la aplicación ejecutando el método OnDelete
    End Sub
    ' Método para manejar el evento DeleteEvent
    Private Sub OnDelete(sender As Object, e As DeleteEventArgs)
        Application.Quit() ' Salir de la aplicación
    End Sub
End Class
