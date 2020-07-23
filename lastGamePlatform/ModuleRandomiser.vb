Module ModuleRandomiser
	ReadOnly random As New Random()
	Public randomItemImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\adn.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\coin.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\gun.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\life.png")})
	Public randomWallImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall1.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall2.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall3.png")})
	Function NumberOfEnemies()
		Dim noOfEnemies As Integer = 1
		If ModuleGameManager.level = 1 Then
			noOfEnemies = NumberBetween(1, 3) '1-3
		ElseIf ModuleGameManager.level = 2 Then
			noOfEnemies = NumberBetween(3, 5) '3-5
		ElseIf ModuleGameManager.level = 3 Then
			noOfEnemies = NumberBetween(5, 8) '5-8
		End If
		Return noOfEnemies
	End Function

	Function EnemyMoveSpeed()
		Dim moveSpeed As Integer = 1
		If ModuleGameManager.level = 1 Then
			moveSpeed = NumberBetween(1, 5)
		ElseIf ModuleGameManager.level = 2 Then
			moveSpeed = NumberBetween(5, 6)
		ElseIf ModuleGameManager.level = 3 Then
			moveSpeed = NumberBetween(6, 10)
		End If
		Return moveSpeed
	End Function

	Function NumberBetween(a As Integer, b As Integer)
		Return random.Next(a, b + 1)
	End Function
End Module
