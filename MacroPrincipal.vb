Imports Gma.System.MouseKeyHook
Imports System.Runtime.InteropServices

Public Class MacroPrincipal

    Private WithEvents _globalHook As IKeyboardMouseEvents

    Private Const MOUSEEVENTF_LEFTDOWN As UInteger = &H2
    Private Const MOUSEEVENTF_LEFTUP As UInteger = &H4

    Private _clicks As New List(Of ClickInfo)

    Public Grabando As Boolean = False
    Public FechaUltimoEvento As DateTime = Now

    Public Sub New()
        InitializeComponent()
        _globalHook = Hook.GlobalEvents()
    End Sub


    Private Sub GlobalHookMouseDownExt(sender As Object, e As MouseEventExtArgs) Handles _globalHook.MouseDownExt
        If Not Grabando Then
            Return
        End If

        _clicks.Add(New ClickInfo With {.Time = DateTime.Now, .Segundos = Math.Round(Convert.ToDouble((DateTime.Now - FechaUltimoEvento).TotalMilliseconds / 1000), 2), .Position = e.Location})
        FechaUltimoEvento = Now
        RefreshMacros()
    End Sub

    Private Sub GlobalHookKeyPress(sender As Object, e As KeyPressEventArgs) Handles _globalHook.KeyPress
        If Not Grabando Then
            Return
        End If
        If e.KeyChar = ChrW(Keys.Escape) Then
            Grabando = True
            btnEjecutar.PerformClick()
        End If
        MsgBox($"Key press: {e.KeyChar}")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub RefreshMacros()
        Try
            grdClicks.Rows.Clear()
            For Each click As ClickInfo In _clicks
                grdClicks.Rows.Add(click.Time, click.Segundos, click.Position.X, click.Position.Y)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    <DllImport("user32.dll")>
    Private Shared Sub mouse_event(dwFlags As UInteger, dx As UInteger, dy As UInteger, dwData As UInteger, dwExtraInfo As Integer)
    End Sub


    Private Sub HacerClick(x As Integer, y As Integer)
        Cursor.Position = New Point(x, y)
        mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0)
    End Sub

    Private Sub grdClicks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdClicks.CellDoubleClick
        Try
            If grdClicks.CurrentRow.Cells("Fecha").Value IsNot Nothing AndAlso IsDate(grdClicks.CurrentRow.Cells("Fecha").Value) Then
                HacerClick(grdClicks.CurrentRow.Cells("X").Value, grdClicks.CurrentRow.Cells("Y").Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Ejecutar(True)
    End Sub

    Sub Ejecutar(Optional RemoverUltimo As Boolean = False)
        If Grabando Then
            If RemoverUltimo Then
                If _clicks.Count > 0 Then
                    _clicks.RemoveAt(_clicks.Count - 1)
                End If
            End If
        End If
        Grabando = Not Grabando
        FechaUltimoEvento = Now
        btnEjecutar.Text = IIf(Grabando, "Detener", "Grabar")
        RefreshMacros()
    End Sub

    Private Sub btnEjecutarMacro_Click(sender As Object, e As EventArgs) Handles btnEjecutarMacro.Click
        ReplayClicks()
    End Sub

    Private Sub ReplayClicks()
        Try
            Dim previousClick As ClickInfo = Nothing

            For Each click As ClickInfo In _clicks
                If previousClick IsNot Nothing Then
                    ' Calcula la diferencia de tiempo en segundos
                    Dim timeDifference = (click.Time - previousClick.Time).TotalMilliseconds

                    ' Haz clic en la posición del clic anterior
                    HacerClick(previousClick.Position.X, previousClick.Position.Y)

                    ' Espera la diferencia de tiempo antes de hacer el siguiente clic
                    Threading.Thread.Sleep((timeDifference / 1000) * 1000)
                End If

                previousClick = click
            Next

            ' Haz clic en la posición del último clic
            If previousClick IsNot Nothing Then
                HacerClick(previousClick.Position.X, previousClick.Position.Y)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        _clicks = New List(Of ClickInfo)
        RefreshMacros()
    End Sub
End Class
