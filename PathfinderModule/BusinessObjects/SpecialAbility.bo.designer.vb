'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports System.Collections.Generic
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
<DefaultClassOptions> _
Public Partial Class SpecialAbility
  Inherits DevExpress.Persistent.BaseImpl.BaseObject
  Public Sub New(ByVal session As Session)
    MyBase.New(session)
  End Sub
  <DevExpress.Xpo.AssociationAttribute("SpecialAbilities-Characters")> _
  Public ReadOnly Property Characters As XPCollection(Of PathfinderModule.Character)
    Get
      Return GetCollection(Of PathfinderModule.Character)("Characters")
    End Get
  End Property
End Class
