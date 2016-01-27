Imports Windows.UI

Public Class CssInjectHelper
    Public Function InjectThemeFontColorAndTableLines$(Html$)
        Dim theme = DirectCast(DirectCast(Window.Current.Content, Frame).Content, Page).RequestedTheme
        Dim color = If(theme = ElementTheme.Dark, "white", "black")
        Dim css = $"<style type=""text/css"">body{{color:{color}}}
td{{Border:solid {color}; border-width:0px 1px 1px 0px; padding:10px 0px;}}
table{{Border:solid {color}; border-width:1px 0px 0px 1px;}}</style>"
        Return Html.Replace("</HEAD>", css & "</HEAD>")
    End Function
End Class
