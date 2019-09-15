Public Class Form1

    Private Sub cmdValidar_Click(sender As Object, e As EventArgs) Handles cmdValidar.Click
        Dim D As Integer = 0
        Dim M As Integer = 0
        Dim A As Integer = 0

        If FechaValida(txtDia, txtMes, txtAño) = True Then
            LblResultado.Text = "Resultado: FECHA VALIDA"
        Else
            LblResultado.Text = "Resultado: FECHA INVALIDA!"
        End If
    End Sub

    Function FechaValida(D, M, A)
        Dim Valida As Boolean = True 'Por defecto, se considera que es valida
        D = Val(txtDia.Text)
        M = Val(txtMes.Text)
        A = Val(txtAño.Text)
        If M < 1 Or M > 12 Then
            Valida = False
        Else
            If (M = 1 Or M = 3 Or M = 5 Or M = 7 Or M = 8 Or M = 10 Or M = 12) And (D < 1 Or D > 31) Then
                Valida = False
            Else
                If (M = 4 Or M = 6 Or M = 9 Or M = 11) And (D < 1 Or D > 30) Then
                    Valida = False
                Else
                    If M = 2 And Bisiesto(A) = True And (D < 1 Or D > 29) Then
                        Valida = False
                    Else
                        If M = 2 And Bisiesto(A) = False And (D < 1 Or D > 28) Then
                            Valida = False
                        End If
                    End If
                End If
            End If
        End If
        Return Valida
    End Function

    Function Bisiesto(A)
        Dim EsBisiesto As Boolean = False  'Por defecto, se considera que no es bisiesto 

        If A Mod 4 = 0 Then
            If A Mod 100 = 0 Then
                If A Mod 400 = 0 Then
                    EsBisiesto = True
                End If
            Else
                EsBisiesto = True
            End If
        End If
        Return EsBisiesto
    End Function

End Class
