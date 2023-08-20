Public Class hookEvents

    Public Shadows Event Click(sender As Object, e As EventArgs)

    Private Sub InnerOnClick(sender As Object, e As EventArgs)
        RaiseEvent Click(Me, e)
    End Sub

    Private Sub hookClickEventsOfChildrens(control As Control)
        For Each subControl As Control In control.Controls
            AddHandler subControl.Click, AddressOf InnerOnClick
            hookClickEventsOfChildrens(subControl)
        Next
    End Sub

    ''' <summary>
    ''' Initialise l'évènement Control.Click au contrôle utilisateur
    ''' </summary>
    Public Sub InitializeClickHook()
        hookClickEventsOfChildrens(Me)
    End Sub

End Class
