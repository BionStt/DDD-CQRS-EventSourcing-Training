using Premium.CommandStack.Model;
using Premium.Infrastructure.Repositories;

namespace Premium.CommandStack.Services
{
    public class MatchSynchronizer
    {
        public static void Save(Match match)
        {
            if (match == null)
                return;

            var persistedMatch = CopyFrom(match);
            new MatchRepository().Save(persistedMatch);
        }

        public static void Clear(string matchId)
        {
            if (matchId == null)
                return;

            // Remove record from snapshot table    
            new MatchRepository().DeleteById(matchId);
        }


        private static Infrastructure.Match CopyFrom(Match match)
        {
            var persistedMatch = new Infrastructure.Match()
            {
                Id = match.Id,
                Period = match.CurrentPeriod,
                Score1 = match.CurrentScore.TotalGoals1,
                Score2 = match.CurrentScore.TotalGoals2,
                State = (int) match.State,
                Team1 = match.Team1,
                Team2 = match.Team2,
                Timeouts1 = match.TimeoutSummary(TeamId.Home),
                Timeouts2 = match.TimeoutSummary(TeamId.Visitors)
            };
            return persistedMatch;
        }
    }
}