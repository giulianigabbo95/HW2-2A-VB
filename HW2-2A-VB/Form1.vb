Public Class Finestra
    Public R As New Random
    Dim Persone As New List(Of Persona)
    Private Sub GeneraPersone_Click(sender As Object, e As EventArgs) Handles GeneraPersone.Click
        Dim PersoneCount = 100
        Dim AltezzaMin As Double = 100
        Dim AltezzaMax As Double = 200

        Me.SpazioStampa.AppendText("DATASET: Età e Altezza delle persone" & Environment.NewLine & Environment.NewLine)
        Me.SpazioStampa.AppendText("Totale: " & Environment.NewLine & Environment.NewLine)

        For i As Integer = 1 To PersoneCount
            Dim RandomAltezza As Double = Math.Round(AltezzaMin + (AltezzaMax - AltezzaMin) * R.NextDouble, 2)
            Dim RandomEta As Integer = R.Next(10, 100)
            Dim p As New Persona
            p.Altezza = RandomAltezza
            p.Eta = RandomEta
            Persone.Add(p)

            Me.SpazioStampa.AppendText(("Persona" & i).PadRight(10) & RandomAltezza.ToString.PadRight(10) & RandomEta & Environment.NewLine)
        Next
    End Sub

    Private Sub MediaNormale_Click(sender As Object, e As EventArgs) Handles MediaNormale.Click
        Dim Somma As Integer = 0
        For Each p As Persona In Persone
            Somma += p.Eta
        Next
        Dim Media As Double = Somma / Persone.Count
        Me.SpazioStampa.AppendText(" " & Environment.NewLine & Environment.NewLine)
        Me.SpazioStampa.AppendText("Media Normale Eta: " & Media & Environment.NewLine)
    End Sub

    Private Sub MediaOnline_Click(sender As Object, e As EventArgs) Handles MediaOnline.Click
        Dim MediaAttuale As Double = 0
        Dim PersonaAttuale As Integer = 0
        For Each p As Persona In Persone
            PersonaAttuale += 1
            MediaAttuale = MediaAttuale + (p.Eta - MediaAttuale)
            Me.SpazioStampa.AppendText("Media Online Eta: " & MediaAttuale & Environment.NewLine)
        Next
        Me.SpazioStampa.AppendText(" " & Environment.NewLine & Environment.NewLine)
        Me.SpazioStampa.AppendText("Media Online Definitiva Eta: " & MediaAttuale & Environment.NewLine)
    End Sub

    Private Sub Frequenza_Click(sender As Object, e As EventArgs) Handles Frequenza.Click
        Dim FrequenzaDistribuzione As New SortedDictionary(Of Integer, FrequenzaEta)
        For Each p As Persona In Persone
            If FrequenzaDistribuzione.ContainsKey(p.Eta) Then
                FrequenzaDistribuzione(p.Eta).Count += 1
            Else
                FrequenzaDistribuzione.Add(p.Eta, New FrequenzaEta)
            End If
            Me.SpazioStampa.AppendText(" " & Environment.NewLine & Environment.NewLine)
            Me.SpazioStampa.AppendText("Distribuzione Eta: " & Environment.NewLine & Environment.NewLine)
            Me.SpazioStampa.AppendText("Eta".PadRight(7) & "Numero".PadRight(7) & "Freq".PadRight(7) & "PErc".PadRight(7) & Environment.NewLine)
            For Each kvp As KeyValuePair(Of Integer, FrequenzaEta) In FrequenzaDistribuzione
                Me.SpazioStampa.AppendText(kvp.Key.ToString.PadRight(7) & kvp.Value.Count.ToString.PadRight(7) & kvp.Value.FrequenzaRelativa.ToString("0.##").PadRight(7) & kvp.Value.Count.ToString.PadRight(7) & " % " & Environment.NewLine)
            Next
        Next

        Dim GrandezzaIntervallo As Double = 10
        Dim PuntoFine As Double = 170
        Dim Intervallo_0 As New Interval
        Intervallo_0.LowerEnd = PuntoFine
        Intervallo_0.UpperEnd = Intervallo_0.LowerEnd + GrandezzaIntervallo
        Dim ListaIntervalli As New List(Of Interval)
        ListaIntervalli.Add(Intervallo_0)
        For Each p As Persona In Persone
            Dim PersoneAllocate As Boolean = False
            For Each Interval In ListaIntervalli
                If p.Altezza > Interval.LowerEnd AndAlso p.Altezza <= Interval.UpperEnd Then
                    Interval.Count += 1
                    PersoneAllocate = True
                    Exit For
                End If
            Next
            If PersoneAllocate = True Then Continue For
            If p.Altezza <= ListaIntervalli(0).LowerEnd Then
                Do
                    Dim NewLeftInterval As New Interval
                    NewLeftInterval.UpperEnd = ListaIntervalli(0).LowerEnd
                    NewLeftInterval.LowerEnd = NewLeftInterval.UpperEnd - ListaIntervalliSize
                    ListaIntervalli.Insert(0, NewLeftInterval)
                    If p.Altezza > NewLeftInterval.LowerEnd AndAlso p.Altezza <= NewLeftInterval.UpperEnd Then
                        NewLeftInterval.Count += 1
                        Exit Do
                    End If
                Loop
            ElseIf p.Altezza > ListaIntervalli(ListaIntervalli.Count - 1).UpperEnd Then
                Do
                    Dim NewRightInterval As New Interval
                    NewRightInterval.LowerEnd = ListaIntervalli(ListaIntervalli.Count - 1).UpperEnd
                    NewRightInterval.UpperEnd = NewRightInterval.LowerEnd + IntervalSize
                    ListaIntervalli.Add(NewRightInterval)
                    If p.Altezza > NewRightInterval.LowerEnd AndAlso p.Altezza <= NewRightInterval.UpperEnd Then
                        NewRightInterval.Count += 1
                        Exit Do
                    End If
                Loop
            Else
                Throw New Exception("Not Expected Occurence")
            End If
        Next
        Me.SpazioStampa.AppendText(" " & Environment.NewLine & Environment.NewLine)
        Me.SpazioStampa.AppendText("Distribuzione Altezza: " & Environment.NewLine & Environment.NewLine)
        Me.SpazioStampa.AppendText("Altezza".PadRight(7) & "Numero" & Environment.NewLine)
        Dim SommaNumero As Integer
        For Each Interval As Interval In ListaIntervalli
            SommaNumero += Interval.Count
            Me.SpazioStampa.AppendText(("(" & Interval.LowerEnd & " - " & Interval.UpperEnd & ")").PadRight(7) & Interval.Count & vbCrLf)
        Next
        Me.SpazioStampa.AppendText(vbCrLf & vbCrLf & "Somma Numero: " & SommaNumero & vbCrLf)
    End Sub
End Class
