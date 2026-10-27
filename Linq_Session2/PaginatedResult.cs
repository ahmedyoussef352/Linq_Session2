namespace Linq_Session2;

public class PaginatedResult<T>
{
    public List<T> Items = [];
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public int TotalPages =>
        (int)Math.Ceiling(TotalCount / (double)PageSize);

    public bool HasNextPage => PageNumber < TotalPages;

    public bool HasPerviousPage => PageNumber > 1;


}
