using System.Collections.Generic;

namespace EventSourcing.SharedKernel
{
    public class JavaScriptSlotHistory
    {
        public int BookingId { get; set; }
        public IList<JavaScriptSlotInfo> ChangeList { get; set; }
    }
}