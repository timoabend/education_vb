''' <summary>
''' Eine Wetteranzeige zeigt nur die Temperatur an. Da darüber hinaus auch ein Computer, 
''' ein Fernseher u. v. m die Temperatur darstellen könnte, wird die Schnittstelle IWetteranzeige verwendet.
''' </summary>
''' <remarks></remarks>
Public Class Wetteranzeige
    Implements IWetteranzeige

    Private _Temperatur As Double
    Public Property Temperatur() As Double Implements IWetteranzeige.Temperatur
        Get
            Return _Temperatur
        End Get
        Set(ByVal value As Double)
            _Temperatur = value
            Dim test = Me.GetType.GetProperties()
            MessageBox.Show(String.Format("{0}: {1}", Me.GetType.Name, _Temperatur))
        End Set
    End Property

End Class
