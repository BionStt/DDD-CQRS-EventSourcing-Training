namespace DomainModel.Aggregates
{
    public class Party : Aggregate
    {
        public string VatIndex { get; protected set; }
        public string SocialSecurityNumber { get; protected set; }
    }
}
