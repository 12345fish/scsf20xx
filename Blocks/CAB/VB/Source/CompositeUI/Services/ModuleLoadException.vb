'===============================================================================
' Microsoft patterns & practices
' CompositeUI Application Block
'===============================================================================
' Copyright � Microsoft Corporation.  All rights reserved.
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
' OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
' LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
' FITNESS FOR A PARTICULAR PURPOSE.
'===============================================================================


Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Runtime.Serialization

Namespace Services
	''' <summary>
	''' Exception thrown by <see cref="IModuleLoaderService"/> implementations whenever 
	''' a module fails to load.
	''' </summary>
	<Serializable()> _
	Public Class ModuleLoadException
		Inherits Exception

		''' <summary>
		''' Initializes a new instance.
		''' </summary>
		Public Sub New()
			MyBase.New()
		End Sub

		''' <summary>
		''' Initializes a new instance with a specified error message.
		''' </summary>
		''' <param name="message">The message that describes the error.</param>
		Public Sub New(ByVal message As String)
			MyBase.New(message)
		End Sub

		''' <summary>
		''' Initializes a new instance with a specified error message 
		''' and a reference to the inner exception that is the cause of this exception.
		''' </summary>
		''' <param name="message">The error message that explains the reason for the exception.</param>
		''' <param name="exception">The exception that is the cause of the current exception, 
		''' or a null reference if no inner exception is specified.</param>
		Public Sub New(ByVal message As String, ByVal exception As Exception)
			MyBase.New(message, exception)
		End Sub


		''' <summary>
		''' Initializes the exception with a particular module and error message.
		''' </summary>
		Public Sub New(ByVal moduleAssembly As String, ByVal message As String)
			MyBase.New(String.Format(CultureInfo.CurrentCulture, My.Resources.FailedToLoadModule, moduleAssembly, message))
		End Sub

		''' <summary>
		''' Initializes the exception with a particular module, error message and inner exception 
		''' that happened.
		''' </summary>
		Public Sub New(ByVal moduleAssembly As String, ByVal message As String, ByVal innerException As Exception)
			MyBase.New(String.Format(CultureInfo.CurrentCulture, My.Resources.FailedToLoadModule, moduleAssembly, message), innerException)
		End Sub

		''' <summary>
		''' Initializes a new instance with serialized data.
		''' </summary>
		''' <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
		''' <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub
	End Class
End Namespace