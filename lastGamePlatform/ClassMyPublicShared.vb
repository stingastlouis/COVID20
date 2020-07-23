Public Class ClassMyPublicShared
	Public Shared universalScore As Integer


	Public Shared allPictureBoxes As New List(Of PictureBox)
	Public Shared waitBeforeFight As Integer = 3 'number of second to wait before fight


	Public Shared randomItemImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\adn.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\coin.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\gun.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Items\life.png")})
	Public Shared randomWallImages As New List(Of String)({IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall1.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall2.png"), IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Walls\wall3.png")})
	'Public Shared randomEnemyImage As New List?????


End Class
