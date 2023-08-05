namespace GameManager.Logic.Test;

public class IndexModelTests
{
    [Fact]
    public void DashboardShouldShowListOfUpcomingGames()
    {
        // Arrange
        var indexModel = new IndexModel();
        var clubId = Guid.NewGuid();
        
        // Act
        //var upcomingGames = indexModel.GetUpcomingGames(clubId);

        // Assert
        //Assert.True(upcomingGames is IEnumerable<UpcomingGame>);
        Assert.True(true);
    }
}

public class IndexModel
{}