Public Class WetterstationTemperaturSetzen

    Dim wetterstationGarten As New Wetterstation
    Dim wetteranzeigeWohnzimmer As New Wetteranzeige
    Dim wetteranzeigeFlur As New Wetteranzeige

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.wetterstationGarten.AnzeigeAnmelden(wetteranzeigeWohnzimmer)
        Me.wetterstationGarten.AnzeigeAnmelden(wetteranzeigeFlur)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.wetterstationGarten.Temperatur = TextBox1.Text
    End Sub
End Class
