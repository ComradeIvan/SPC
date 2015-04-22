Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Strategy
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
Public Class Updater
    Inherits ModuleUpdater
    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub

    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()
        'Dim name As String = "MyName"
        'Dim theObject As DomainObject1 = ObjectSpace.FindObject(Of DomainObject1)(CriteriaOperator.Parse("Name=?", name))
        'If (theObject Is Nothing) Then
        '    theObject = ObjectSpace.CreateObject(Of DomainObject1)()
        '    theObject.Name = name
        'End If
		Dim userAdmin As SecuritySystemUser = ObjectSpace.FindObject(Of SecuritySystemUser)(New BinaryOperator("UserName", "Admin"))
		If userAdmin Is Nothing Then
			userAdmin = ObjectSpace.CreateObject(Of SecuritySystemUser)()
			userAdmin.UserName = "Admin"
			' Set a password if the standard authentication type is used
			userAdmin.SetPassword("")
		End If
		' If a role with the Administrators name doesn't exist in the database, create this role
		Dim adminRole As SecuritySystemRole = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", "Administrators"))
		If adminRole Is Nothing Then
			adminRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
			adminRole.Name = "Administrators"
		End If
		adminRole.IsAdministrative = True
		userAdmin.Roles.Add(adminRole)
		ObjectSpace.CommitChanges()
    End Sub

    Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
        MyBase.UpdateDatabaseBeforeUpdateSchema()
        'If (CurrentDBVersion < New Version("1.1.0.0") AndAlso CurrentDBVersion > New Version("0.0.0.0")) Then
        '    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName")
        'End If
    End Sub
End Class