using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Common.Responses
{
    public class PagedResult<T>
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public List<T> Items { get; set; }

       

        public PagedResult(List<T> items, int totalCount, int pageIndex, int pageSize)
        {
            
            TotalCount = totalCount;
            CurrentPage = pageIndex;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            Items = items;
        }
        public static async Task<PagedResult<T>> ToPagedListAsync(IQueryable<T> query, int pageNumber, int pageSize)
        {
            var count = await query.CountAsync();
            var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            var result = new PagedResult<T>(items, count, pageNumber, pageSize);

            return result;
        }
    }

}
