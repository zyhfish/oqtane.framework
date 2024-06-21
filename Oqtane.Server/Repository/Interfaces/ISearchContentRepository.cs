using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oqtane.Models;

namespace Oqtane.Repository
{
    public interface ISearchContentRepository
    {
        Task<IEnumerable<SearchContent>> GetSearchContentsAsync(SearchQuery searchQuery);
        SearchContent AddSearchContent(SearchContent searchContent);
        void DeleteSearchContent(int searchContentId);
        void DeleteSearchContent(string uniqueKey, bool recursive);
        void DeleteAllSearchContent();

        SearchWord GetSearchWord(string word);
        SearchWord AddSearchWord(SearchWord searchWord);

        IEnumerable<SearchContentWord> GetSearchContentWords(int searchContentId);
        SearchContentWord AddSearchContentWord(SearchContentWord searchContentWord);
        SearchContentWord UpdateSearchContentWord(SearchContentWord searchContentWord);
    }
}
