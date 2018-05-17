Imports System.Resources
Imports System.Reflection
Imports System.Globalization
Imports System.ComponentModel

Module MLString

    Private RootNamespace As String = "TAVUFU" 'MLHIDE
    Private ResMgr As ResourceManager

    Sub New()
        If RootNamespace.Length > 0 Then
            ResMgr = New ResourceManager(RootNamespace & ".MultiLang", [Assembly].GetExecutingAssembly)   'MLHIDE
        Else
            ResMgr = New ResourceManager("MultiLang", [Assembly].GetExecutingAssembly)                    'MLHIDE
        End If
    End Sub

    Public Sub ml_UseCulture(ByVal ci As CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentUICulture = ci
    End Sub

    Public Function ml_string(ByVal StringID As Integer, Optional ByVal Text As String = "") As String   'MLHIDE
        Return ml_resource(StringID)
    End Function

    Public Function ml_resource(ByVal StringID As Integer) As String 'MLHIDE
        Return ResMgr.GetString("_" & StringID.ToString())                                              'MLHIDE
    End Function

    Public SupportedCultures() As String = {"pt-BR", "en"} 'MLHIDE
End Module
