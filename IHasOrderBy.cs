namespace DRR.Application.Common.Extensions
{
    public interface IHasOrderBy
    {
        //Contains string expression like ("Name ASC, ChildEntity.Name DESC")
        public string OrderByExpression { get; set; }
    }
}
