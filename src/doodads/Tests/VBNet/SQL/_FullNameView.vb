
'===============================================================================
'  Generated From - VbNet_SQL_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
'===============================================================================

' Generated by MyGeneration Version # (1.1.3.5)

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Specialized

Imports MyGeneration.dOOdads

NameSpace MyGeneration.dOOdads.Tests.SQL

Public MustInherit Class _FullNameView
	Inherits  SqlClientEntity
	
		Public Sub New() 
			Me.QuerySource = "FullNameView"
			Me.MappingName = "FullNameView"
		End Sub

	'=================================================================
	'  	Public Function LoadAll() As Boolean
	'=================================================================
	'  Loads all of the records in the database, and sets the currentRow to the first row
	'=================================================================
	Public Function LoadAll() As Boolean
    	Return MyBase.Query.Load()
	End Function
	
	Public Overrides Sub FlushData()
		Me._whereClause = nothing
		Me._aggregateClause = nothing		
		MyBase.FlushData()
	End Sub	

	#Region "Parameters"
	Protected class Parameters 
		
		Public Shared ReadOnly Property FullName As SqlParameter
			Get
				Return New SqlParameter("FullName", SqlDbType.VarChar, 42)
			End Get
		End Property
		
		Public Shared ReadOnly Property DepartmentID As SqlParameter
			Get
				Return New SqlParameter("DepartmentID", SqlDbType.Int, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property HireDate As SqlParameter
			Get
				Return New SqlParameter("HireDate", SqlDbType.DateTime, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property Salary As SqlParameter
			Get
				Return New SqlParameter("Salary", SqlDbType.Decimal, 0)
			End Get
		End Property
		
		Public Shared ReadOnly Property IsActive As SqlParameter
			Get
				Return New SqlParameter("IsActive", SqlDbType.Bit, 0)
			End Get
		End Property
		
	End Class
	#End Region	

	#Region "ColumnNames"
	Public class ColumnNames
		
        Public Const FullName As String = "FullName"
        Public Const DepartmentID As String = "DepartmentID"
        Public Const HireDate As String = "HireDate"
        Public Const Salary As String = "Salary"
        Public Const IsActive As String = "IsActive"

		Shared Public Function ToPropertyName(ByVal columnName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(FullName) = _FullNameView.PropertyNames.FullName
				ht(DepartmentID) = _FullNameView.PropertyNames.DepartmentID
				ht(HireDate) = _FullNameView.PropertyNames.HireDate
				ht(Salary) = _FullNameView.PropertyNames.Salary
				ht(IsActive) = _FullNameView.PropertyNames.IsActive

			End If
			
			Return CType(ht(columnName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing		 
	End Class
	#End Region	
	
	#Region "PropertyNames"
	Public class PropertyNames
		
        Public Const FullName As String = "FullName"
        Public Const DepartmentID As String = "DepartmentID"
        Public Const HireDate As String = "HireDate"
        Public Const Salary As String = "Salary"
        Public Const IsActive As String = "IsActive"

		Shared Public Function ToColumnName(ByVal propertyName As String) As String

			If ht Is Nothing Then
			
				ht = new Hashtable
				
				ht(FullName) = _FullNameView.ColumnNames.FullName
				ht(DepartmentID) = _FullNameView.ColumnNames.DepartmentID
				ht(HireDate) = _FullNameView.ColumnNames.HireDate
				ht(Salary) = _FullNameView.ColumnNames.Salary
				ht(IsActive) = _FullNameView.ColumnNames.IsActive

			End If
			
			Return CType(ht(propertyName), String)
			
		End Function
		
		Shared Private ht  As Hashtable = Nothing
		
	End Class
	#End Region	
	
	#Region "StringPropertyNames"
	Public class StringPropertyNames
		
        Public Const FullName As String = "s_FullName"
        Public Const DepartmentID As String = "s_DepartmentID"
        Public Const HireDate As String = "s_HireDate"
        Public Const Salary As String = "s_Salary"
        Public Const IsActive As String = "s_IsActive"

	End Class
	#End Region		
	
	#Region "Properties" 
		Public Overridable Property FullName As String
			Get
				Return MyBase.GetString(ColumnNames.FullName)
			End Get
			Set(ByVal Value As String)
				MyBase.SetString(ColumnNames.FullName, Value)
			End Set
		End Property

		Public Overridable Property DepartmentID As Integer
			Get
				Return MyBase.GetInteger(ColumnNames.DepartmentID)
			End Get
			Set(ByVal Value As Integer)
				MyBase.SetInteger(ColumnNames.DepartmentID, Value)
			End Set
		End Property

		Public Overridable Property HireDate As DateTime
			Get
				Return MyBase.GetDateTime(ColumnNames.HireDate)
			End Get
			Set(ByVal Value As DateTime)
				MyBase.SetDateTime(ColumnNames.HireDate, Value)
			End Set
		End Property

		Public Overridable Property Salary As Decimal
			Get
				Return MyBase.GetDecimal(ColumnNames.Salary)
			End Get
			Set(ByVal Value As Decimal)
				MyBase.SetDecimal(ColumnNames.Salary, Value)
			End Set
		End Property

		Public Overridable Property IsActive As Boolean
			Get
				Return MyBase.GetBoolean(ColumnNames.IsActive)
			End Get
			Set(ByVal Value As Boolean)
				MyBase.SetBoolean(ColumnNames.IsActive, Value)
			End Set
		End Property


	#End Region  
	
	#Region "String Properties" 

		Public Overridable Property s_FullName As String
			Get
				If Me.IsColumnNull(ColumnNames.FullName) Then
					Return String.Empty
				Else
					Return MyBase.GetStringAsString(ColumnNames.FullName)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.FullName)
				Else
					Me.FullName = MyBase.SetStringAsString(ColumnNames.FullName, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_DepartmentID As String
			Get
				If Me.IsColumnNull(ColumnNames.DepartmentID) Then
					Return String.Empty
				Else
					Return MyBase.GetIntegerAsString(ColumnNames.DepartmentID)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.DepartmentID)
				Else
					Me.DepartmentID = MyBase.SetIntegerAsString(ColumnNames.DepartmentID, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_HireDate As String
			Get
				If Me.IsColumnNull(ColumnNames.HireDate) Then
					Return String.Empty
				Else
					Return MyBase.GetDateTimeAsString(ColumnNames.HireDate)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.HireDate)
				Else
					Me.HireDate = MyBase.SetDateTimeAsString(ColumnNames.HireDate, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_Salary As String
			Get
				If Me.IsColumnNull(ColumnNames.Salary) Then
					Return String.Empty
				Else
					Return MyBase.GetDecimalAsString(ColumnNames.Salary)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.Salary)
				Else
					Me.Salary = MyBase.SetDecimalAsString(ColumnNames.Salary, Value)
				End If
			End Set
		End Property

		Public Overridable Property s_IsActive As String
			Get
				If Me.IsColumnNull(ColumnNames.IsActive) Then
					Return String.Empty
				Else
					Return MyBase.GetBooleanAsString(ColumnNames.IsActive)
				End If
			End Get
			Set(ByVal Value As String)
				If String.Empty = value Then
					Me.SetColumnNull(ColumnNames.IsActive)
				Else
					Me.IsActive = MyBase.SetBooleanAsString(ColumnNames.IsActive, Value)
				End If
			End Set
		End Property


	#End Region 

	#Region "Where Clause"
    Public Class WhereClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffWhereParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffWhereParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "TearOff's"
		Public class TearOffWhereParameter

			Public Sub New(ByVal clause As WhereClause)
				Me._clause = clause
			End Sub
		
	
		Public ReadOnly Property FullName() As WhereParameter
			Get
				Dim where As WhereParameter = New WhereParameter(ColumnNames.FullName, Parameters.FullName)
				Me._clause._entity.Query.AddWhereParemeter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property DepartmentID() As WhereParameter
			Get
				Dim where As WhereParameter = New WhereParameter(ColumnNames.DepartmentID, Parameters.DepartmentID)
				Me._clause._entity.Query.AddWhereParemeter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property HireDate() As WhereParameter
			Get
				Dim where As WhereParameter = New WhereParameter(ColumnNames.HireDate, Parameters.HireDate)
				Me._clause._entity.Query.AddWhereParemeter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Salary() As WhereParameter
			Get
				Dim where As WhereParameter = New WhereParameter(ColumnNames.Salary, Parameters.Salary)
				Me._clause._entity.Query.AddWhereParemeter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IsActive() As WhereParameter
			Get
				Dim where As WhereParameter = New WhereParameter(ColumnNames.IsActive, Parameters.IsActive)
				Me._clause._entity.Query.AddWhereParemeter(where)
				Return where
			End Get
		End Property


		Private _clause as WhereClause
	End Class
	#End Region	

		Public ReadOnly Property FullName() As WhereParameter 
			Get
				If _FullName_W Is Nothing Then
					_FullName_W = TearOff.FullName
				End If
				Return _FullName_W
			End Get
		End Property

		Public ReadOnly Property DepartmentID() As WhereParameter 
			Get
				If _DepartmentID_W Is Nothing Then
					_DepartmentID_W = TearOff.DepartmentID
				End If
				Return _DepartmentID_W
			End Get
		End Property

		Public ReadOnly Property HireDate() As WhereParameter 
			Get
				If _HireDate_W Is Nothing Then
					_HireDate_W = TearOff.HireDate
				End If
				Return _HireDate_W
			End Get
		End Property

		Public ReadOnly Property Salary() As WhereParameter 
			Get
				If _Salary_W Is Nothing Then
					_Salary_W = TearOff.Salary
				End If
				Return _Salary_W
			End Get
		End Property

		Public ReadOnly Property IsActive() As WhereParameter 
			Get
				If _IsActive_W Is Nothing Then
					_IsActive_W = TearOff.IsActive
				End If
				Return _IsActive_W
			End Get
		End Property

		Private _FullName_W As WhereParameter = Nothing
		Private _DepartmentID_W As WhereParameter = Nothing
		Private _HireDate_W As WhereParameter = Nothing
		Private _Salary_W As WhereParameter = Nothing
		Private _IsActive_W As WhereParameter = Nothing

		Public Sub WhereClauseReset()

		_FullName_W = Nothing
		_DepartmentID_W = Nothing
		_HireDate_W = Nothing
		_Salary_W = Nothing
		_IsActive_W = Nothing
			Me._entity.Query.FlushWhereParameters()

		End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffWhereParameter
    End Class	

	Public ReadOnly Property Where() As WhereClause
		Get
			If _whereClause Is Nothing Then
				_whereClause = New WhereClause(Me)
			End If
	
			Return _whereClause
		End Get
	End Property
	
	Private _whereClause As WhereClause = Nothing	
#End Region	

#Region "Aggregate Clause"
    Public Class AggregateClause

        Public Sub New(ByVal entity As BusinessEntity)
            Me._entity = entity
        End Sub
		
		Public ReadOnly Property TearOff As TearOffAggregateParameter
			Get
				If _tearOff Is Nothing Then
					_tearOff = new TearOffAggregateParameter(Me)
				End If

				Return _tearOff
			End Get
		End Property

		#Region "AggregateParameter TearOff's"
		Public class TearOffAggregateParameter

			Public Sub New(ByVal clause As AggregateClause)
				Me._clause = clause
			End Sub
		
	
		Public ReadOnly Property FullName() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.FullName, Parameters.FullName)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property DepartmentID() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.DepartmentID, Parameters.DepartmentID)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property HireDate() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.HireDate, Parameters.HireDate)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property Salary() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.Salary, Parameters.Salary)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property

		Public ReadOnly Property IsActive() As AggregateParameter
			Get
				Dim where As AggregateParameter = New AggregateParameter(ColumnNames.IsActive, Parameters.IsActive)
				Me._clause._entity.Query.AddAggregateParameter(where)
				Return where
			End Get
		End Property


			Private _clause as AggregateClause
		End Class
		#End Region	

		Public ReadOnly Property FullName() As AggregateParameter 
			Get
				If _FullName_W Is Nothing Then
					_FullName_W = TearOff.FullName
				End If
				Return _FullName_W
			End Get
		End Property

		Public ReadOnly Property DepartmentID() As AggregateParameter 
			Get
				If _DepartmentID_W Is Nothing Then
					_DepartmentID_W = TearOff.DepartmentID
				End If
				Return _DepartmentID_W
			End Get
		End Property

		Public ReadOnly Property HireDate() As AggregateParameter 
			Get
				If _HireDate_W Is Nothing Then
					_HireDate_W = TearOff.HireDate
				End If
				Return _HireDate_W
			End Get
		End Property

		Public ReadOnly Property Salary() As AggregateParameter 
			Get
				If _Salary_W Is Nothing Then
					_Salary_W = TearOff.Salary
				End If
				Return _Salary_W
			End Get
		End Property

		Public ReadOnly Property IsActive() As AggregateParameter 
			Get
				If _IsActive_W Is Nothing Then
					_IsActive_W = TearOff.IsActive
				End If
				Return _IsActive_W
			End Get
		End Property

		Private _FullName_W As AggregateParameter = Nothing
		Private _DepartmentID_W As AggregateParameter = Nothing
		Private _HireDate_W As AggregateParameter = Nothing
		Private _Salary_W As AggregateParameter = Nothing
		Private _IsActive_W As AggregateParameter = Nothing

		Public Sub AggregateClauseReset()

		_FullName_W = Nothing
		_DepartmentID_W = Nothing
		_HireDate_W = Nothing
		_Salary_W = Nothing
		_IsActive_W = Nothing
			Me._entity.Query.FlushAggregateParameters()

		End Sub
	
		Private _entity As BusinessEntity
		Private _tearOff As TearOffAggregateParameter
    End Class	

	Public ReadOnly Property Aggregate() As AggregateClause
		Get
			If _aggregateClause Is Nothing Then
				_aggregateClause = New AggregateClause(Me)
			End If
	
			Return _aggregateClause
		End Get
	End Property
	
	Private _aggregateClause As AggregateClause = Nothing	
#End Region	

	Protected Overrides Function GetInsertCommand() As IDbCommand
		Return Nothing
	End Function
	
	Protected Overrides Function GetUpdateCommand() As IDbCommand
		Return Nothing
	End Function
	
	Protected Overrides Function GetDeleteCommand() As IDbCommand
		Return Nothing
	End Function
	
End Class

End NameSpace
