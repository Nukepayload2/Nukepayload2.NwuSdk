Namespace DoorSite
    Public Class MainPageAnalizeResult
        Public ReadOnly Property UserInfo As UserInformation '直接获取
        Public ReadOnly Property CardInfo As CardInformation '外部,Json
        Public ReadOnly Property LibraryTuition# '外部,
        Public ReadOnly Property Notifications As IEnumerable(Of TextLinkPair) '直接
        Public ReadOnly Property SystemNavigation As IEnumerable(Of SystemNavigationItem) '直接
        Public ReadOnly Property HeadmasterMailbox As IEnumerable(Of HeadmasterMailboxItem) '直接
        Public ReadOnly Property SchoolNews As IEnumerable(Of SchoolNewsGroup) '外部,
        Public Property Cookies As DoorSiteCookies
        Sub New(UserInfo As UserInformation, CardInfo As CardInformation,
                LibraryTuition#, Cookies As DoorSiteCookies, Notifications As IEnumerable(Of TextLinkPair),
                SystemNavigation As IEnumerable(Of SystemNavigationItem),
                HeadmasterMailbox As IEnumerable(Of HeadmasterMailboxItem), SchoolNews As IEnumerable(Of SchoolNewsGroup))
            Me.UserInfo = UserInfo
            Me.CardInfo = CardInfo
            Me.LibraryTuition = LibraryTuition
            Me.Notifications = Notifications
            Me.SystemNavigation = SystemNavigation
            Me.HeadmasterMailbox = HeadmasterMailbox
            Me.SchoolNews = SchoolNews
            Me.Cookies = Cookies
        End Sub
#If DEBUG Then
        Public Shared Async Function FakeAsync() As Task(Of MainPageAnalizeResult)
            Await Task.Delay(10)
            Return New MainPageAnalizeResult(New UserInformation(New BitmapImage(New Uri("http://r1.ykimg.com/05140000556BF52667BC3C13A0057A6C")), "纸巾老师", "2012345678", "主持人", "暴走编辑部", Date.Now, New Net.IPAddress({192, 168, 1, 1})), New CardInformation(2012345678, 12345.12), 0, New DoorSiteCookies, {}, {}, {}, {})
        End Function
#End If
    End Class
End Namespace
