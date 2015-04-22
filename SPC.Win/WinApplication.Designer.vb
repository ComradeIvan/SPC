Imports Microsoft.VisualBasic
Imports System

Partial Public Class SPCWindowsFormsApplication
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
		Me.module3 = New Global.SPC.Module.SPCModule()
		Me.module4 = New Global.SPC.Module.Win.SPCWindowsFormsModule()
        Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
        Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
        Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
        Me.cloneObjectModule = New DevExpress.ExpressApp.CloneObject.CloneObjectModule()
        Me.conditionalAppearanceModule = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
        Me.fileAttachmentsWindowsFormsModule = New DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule()
        Me.schedulerModuleBase = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
        Me.schedulerWindowsFormsModule = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
        Me.treeListEditorsModuleBase = New DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase()
        Me.treeListEditorsWindowsFormsModule = New DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule()
        Me.validationModule = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.validationWindowsFormsModule = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
        Me.viewVariantsModule = New DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule()
        Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' securityStrategyComplex1
        ' 
        Me.securityStrategyComplex1.Authentication = Me.authenticationStandard1
        Me.securityStrategyComplex1.RoleType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole)
        Me.securityStrategyComplex1.UserType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser)
        ' 
        ' securityModule1
        ' 
        Me.securityModule1.UserType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser)
        ' 
        ' authenticationStandard1
        ' 
        Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
        ' 
		' SPCWindowsFormsApplication
		' 
		Me.ApplicationName = "SPC"
        Me.Modules.Add(Me.module1)
		Me.Modules.Add(Me.module2)
		Me.Modules.Add(Me.module3)
		Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.securityModule1)
        Me.Security = Me.securityStrategyComplex1
        Me.Modules.Add(Me.objectsModule)
        Me.Modules.Add(Me.cloneObjectModule)
        Me.Modules.Add(Me.conditionalAppearanceModule)
        Me.Modules.Add(Me.fileAttachmentsWindowsFormsModule)
        Me.Modules.Add(Me.schedulerModuleBase)
        Me.Modules.Add(Me.schedulerWindowsFormsModule)
        Me.Modules.Add(Me.treeListEditorsModuleBase)
        Me.Modules.Add(Me.treeListEditorsWindowsFormsModule)
        Me.Modules.Add(Me.validationModule)
        Me.Modules.Add(Me.validationWindowsFormsModule)
        Me.Modules.Add(Me.viewVariantsModule)

        AddHandler Me.DatabaseVersionMismatch, AddressOf SPCWindowsFormsApplication_DatabaseVersionMismatch
        AddHandler Me.CustomizeLanguagesList, AddressOf SPCWindowsFormsApplication_CustomizeLanguagesList

		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.SPC.Module.SPCModule
    Private module4 As Global.SPC.Module.Win.SPCWindowsFormsModule
    Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule 
    Private securityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex
    Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard 
    Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
    Private cloneObjectModule As DevExpress.ExpressApp.CloneObject.CloneObjectModule
    Private conditionalAppearanceModule As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
    Private fileAttachmentsWindowsFormsModule As DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
    Private schedulerModuleBase As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
    Private schedulerWindowsFormsModule As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
    Private treeListEditorsModuleBase As DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase
    Private treeListEditorsWindowsFormsModule As DevExpress.ExpressApp.TreeListEditors.Win.TreeListEditorsWindowsFormsModule
    Private validationModule As DevExpress.ExpressApp.Validation.ValidationModule
    Private validationWindowsFormsModule As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    Private viewVariantsModule As DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule
End Class
