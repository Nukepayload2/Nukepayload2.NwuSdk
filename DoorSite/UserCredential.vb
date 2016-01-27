Namespace DoorSite
    ''' <summary>
    ''' 表示用户登录my.nwu.edu.com的凭据
    ''' </summary>
    Public Class UserCredential
        Public Property UserID$
            Get
                Return LoadValue(Of String)(NameOf(UserID))
            End Get
            Set(value$)
                SaveValue(NameOf(UserID), value)
            End Set
        End Property
        Public Property Password$
        Public Property RememberPassword As Boolean
            Get
                Return LoadValue(Of Boolean)("Door" & NameOf(RememberPassword))
            End Get
            Set(value As Boolean)
                SaveValue("Door" & NameOf(RememberPassword), value)
            End Set
        End Property
        Const ResID$ = "my.nwu.edu.com"
        Public Sub SaveOrClearPassword()
            If RememberPassword Then
                SaveCredential(ResID, UserID, Password)
            Else
                SaveCredential(ResID, UserID, "")
            End If
        End Sub
        Public Sub FillPasswordByUserID()
            If String.IsNullOrEmpty(Password) Then
                If Not String.IsNullOrEmpty(UserID) Then
                    Password = LoadCredential(ResID, UserID)
                End If
            End If
        End Sub
    End Class
End Namespace
