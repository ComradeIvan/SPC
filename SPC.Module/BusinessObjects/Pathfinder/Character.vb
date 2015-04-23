Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Namespace Pathfinder
    '<ImageName("BO_Contact")> _
    '<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
    '<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
    '<Persistent("DatabaseTableName")>
    <NavigationItem("Pathfinder")>
    <DefaultProperty("Name")>
    <DefaultClassOptions()>
    Public Class Character ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
        Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).

#Region "Properties"

        <Size(32)>
        Public Property Name As String

        <Size(3)>
        Public Property Level As Integer
        <Size(11)>
        Public Property Experience As Integer

        ' Fluff
        <Size(11)>
        Public Property Age As Integer

        <Size(10)>
        Public Property Height As Double
        <Size(10)>
        Public Property Weight As Double

        <Size(16)>
        Public Property SkinColor As String
        <Size(16)>
        Public Property HairColor As String
        <Size(16)>
        Public Property EyeColor As String

        <Size(32)>
        Public Property Deity As String
        <Size(32)>
        Public Property Homeland As String
        <Size(512)>
        Public Property Background As String
        <Size(512)>
        Public Property Notes As String


        Public Property Player As User

        Public Property Alignment As Alignment
        Public Property Gender As Gender
        Public Property Size As Size

        Public Property Race As Race

        Public ReadOnly Property Classes As XPCollection(Of [Class])
            Get
                Return GetCollection(Of [Class])("Classes")
            End Get
        End Property

#End Region

#Region "Methods"
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
        End Sub
#End Region

    End Class
End Namespace
