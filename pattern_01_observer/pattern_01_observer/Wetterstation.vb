''' <summary>
''' Die Wetterstation misst eine Temperatur (wird hier in der Form neu festgelegt).
''' Wetteranzeigen aller Art sollen beim Wechsel der Temperatur informiert werden.
''' Die Wetterstation ist also das "Subjekt" (observable).
''' Der geneigte Betrachter wird feststellen, dass es auch sinnvoll wäre ein Interface für 
''' das Subjekt zu erstellen. Zur Vermeidung der Komplexität wird hier darauf verzichtet.
''' Einen Blick wert sind die Interfaces IObserver und IObservable des .NET-Frameworks.
''' </summary>
''' <remarks></remarks>
Public Class Wetterstation

    Private _Temperatur As Double
    ''' <summary>
    ''' Die von der Wetterstation gemessene Temperatur.
    ''' Eine Änderung wird an die Observer gesendet.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Temperatur() As Double
        Get
            Return _Temperatur
        End Get
        Set(ByVal value As Double)
            _Temperatur = value
            Me.AnzeigenInformieren()
        End Set
    End Property

    ''' <summary>
    ''' In diesem Feld werden die Wetteranzeigen gemerkt.
    ''' </summary>
    ''' <remarks></remarks>
    Private _wetteranzeigen As New List(Of IWetteranzeige)

    ''' <summary>
    ''' Eine Wetteranzeige abonniert den Dienst, indem sie sich hier anmeldet.
    ''' </summary>
    ''' <param name="anzeige"></param>
    ''' <remarks></remarks>
    Public Sub AnzeigeAnmelden(anzeige As IWetteranzeige)
        _wetteranzeigen.Add(anzeige)
    End Sub

    ''' <summary>
    ''' Eine Wetteranzeige kann sich auch wieder abmelden.
    ''' </summary>
    ''' <param name="anzeige"></param>
    ''' <remarks></remarks>
    Public Sub AnzeigeAbmelden(anzeige As IWetteranzeige)
        _wetteranzeigen.Remove(anzeige)
    End Sub

    ''' <summary>
    ''' Die Wetterstation informiert hier alle Wetteranzeigen über die neue Temperatur.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub AnzeigenInformieren()
        For Each anzeige In _wetteranzeigen
            anzeige.Temperatur = _Temperatur
        Next
    End Sub

End Class
