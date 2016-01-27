Namespace EduAdminSys
    Public Class LoginInfo
        Dim ResID$ = "jwxtusrpass"
        Public Property UserName$
            Get
                Return LoadValue(Of String)(NameOf(UserName))
            End Get
            Set(value$)
                SaveValue(NameOf(UserName), value)
            End Set
        End Property
        Public Property Password$
        Public Property LoginType$ 'out gb2312 encoding
        Public Property CheckCode$ '[a-z]{4}
        Public Property RememberPassword As Boolean
            Get
                Return LoadValue(Of Boolean)(NameOf(RememberPassword))
            End Get
            Set(value As Boolean)
                SaveValue(NameOf(RememberPassword), value)
            End Set
        End Property
        Public ReadOnly Property LoginTypes As String() = {"学生", "访客", "教师", "部门"}
    End Class

End Namespace
