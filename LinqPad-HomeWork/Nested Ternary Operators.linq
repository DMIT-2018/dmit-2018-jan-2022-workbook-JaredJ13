<Query Kind="Expression">
  <Connection>
    <ID>9ec88cd9-e288-4e03-b5b9-b8d110d51041</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook2018</Database>
  </Connection>
</Query>

//HOMEWORK -- List all albums showing the Title, Artist name, Year and decade of 
//	releases (oldies, 70s, 80s, 90s, or modern)
//Order by decade

Albums 
	.Select(x => new{
		Title = x.Title,
		Artist = x.Artist.Name,
		ReleaseYear = x.ReleaseYear,
		DecadeReleased = x.ReleaseYear < 1970 ? "Oldie" : (x.ReleaseYear < 1980 ? "70s" : (x.ReleaseYear < 1990 ? "80s" : (x.ReleaseYear < 2000 ? "90s" : "Modern")))
	})
	.OrderBy(x => x.DecadeReleased)
	.ThenBy(x => x.ReleaseYear)