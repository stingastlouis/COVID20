Module Module1
	Public Function checkforCollision(ByVal ob1 As Object, ByVal ob2 As Object) As Boolean
		If ob1.Top + ob1.Height >= ob2.Top - 5 And ob2.Top + ob2.Height >= ob1.Top And ob1.Left + ob1.Width >= ob2.Left And ob2.Left + ob2.Width >= ob1.Left Then
			Return True
		End If
		Return False
	End Function

End Module
