﻿public interface IUrlShortenerService
{
    string ShortenUrl(string longUrl);
    string GetOriginalUrl(string shortCode);
    IEnumerable<Url> GetPaginatedUrls(int pageNumber, int pageSize = 10); // Paginasiyalashni qo'llab-quvvatlash
}