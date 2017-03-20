using Premium.Server.Application.SignalR;
using Premium.Server.Common.Actions;

namespace Premium.Server.Application
{
    public class AdminService
    {
        public void ProcessAction(AdminAction action)
        {
            var repository = new MiscRepository();
            var matchService = new MatchService();
            switch (action)
            {
                case AdminAction.ResetDb:
                    repository.ResetDb();
                    matchService.ProcessAction("WP0001", EventType.Created, "Frogs", "Sharks");
                    matchService.ProcessAction("WP0002", EventType.Created, "Sharks", "Eels");
                    break;
            }
            LiveScoreHub.Refresh();
        }
    }
}