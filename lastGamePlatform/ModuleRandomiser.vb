Module ModuleRandomiser
	Dim random As New Random()


	Function numberOfEnemies()
		Dim noOfEnemies As Integer = 0
		If ClassMyPublicShared.level = 1 Then
			noOfEnemies = numberBetween(1, 3) '1-3
		ElseIf ClassMyPublicShared.level = 2 Then
			noOfEnemies = numberBetween(3, 5) '3-5
		ElseIf ClassMyPublicShared.level = 3 Then
			noOfEnemies = numberBetween(5, 8) '5-8
		End If
		Return noOfEnemies
	End Function

	Function enemyMoveSpeed()
		Dim moveSpeed As Integer = 0
		If ClassMyPublicShared.level = 1 Then
			moveSpeed = numberBetween(1, 5)
		ElseIf ClassMyPublicShared.level = 2 Then
			moveSpeed = numberBetween(5, 6)
		ElseIf ClassMyPublicShared.level = 3 Then
			moveSpeed = numberBetween(6, 10)
		End If
		Return moveSpeed
	End Function

	Function numberBetween(a As Integer, b As Integer)
		Return random.Next(a, b + 1)
	End Function
End Module
