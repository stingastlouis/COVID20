﻿Module ModuleRandomiser
	Dim random As New Random()


	Function numberOfEnemies()
		Dim noOfEnemies As Integer = 0

		If ClassMyPublicShared.level = 1 Then
			noOfEnemies = random.Next(1, 4) '1-3
		ElseIf ClassMyPublicShared.level = 2 Then
			noOfEnemies = random.Next(3, 6) '3-5
		ElseIf ClassMyPublicShared.level = 3 Then
			noOfEnemies = random.Next(5, 9) '5-8
		End If

		Return noOfEnemies
	End Function



	Function numberBetween(a As Integer, b As Integer)
		Return random.Next(a, b + 1)
	End Function
End Module