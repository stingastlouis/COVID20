Public Class ClassMyPublicShared
	Public Shared level As Integer = 0
	Public Shared universalScore As Integer


	Public Shared allPictureBoxes As New List(Of PictureBox)
	Public Shared waitBeforeFight As Integer = 3 'number of second to wait before fight


	Public Shared randomItemImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\adn.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\coin.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\gun.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\life.png")})
	Public Shared randomWallImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\wall1.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\wall2.png")})
	'Public Shared randomEnemyImage As New List


End Class
