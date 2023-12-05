namespace Laboratorium3_Product.Models;

public class PagingList<T>
{
    public List<T> Data { get; set; }
    public int TotalItems { get; }
    public int TotalPages { get; }
    public int Number { get; }
    public int Size { get; }
    public bool IsFirst { get; }
    public bool IsLast { get; }
    public bool IsNext { get; }
    public bool IsPrevious { get; }

    private PagingList(List<T> data, int totalItems, int number, int size)
    {
        Data = data;
        TotalItems = totalItems;
        Number = number;
        Size = size;
        TotalPages = TotalItems / Size + (TotalItems % Size > 0 ? 1 : 0);
        IsFirst = number <= 1;
        IsLast = number >= TotalPages;
        IsNext = !IsLast;
        IsPrevious = !IsFirst;
    }

    public static PagingList<T> Create(List<T> data, int totalItems, int number, int size)
    {
        var page = new PagingList<T>(data, totalItems, number, size);
        if (number > page.TotalPages)
        {
            return new PagingList<T>(data, totalItems, page.TotalPages, size);
        }

        if (number < 1)
        {
            return new PagingList<T>(data, totalItems, 1, size);
        }

        return new PagingList<T>(data, totalItems, number, size);
    }
}