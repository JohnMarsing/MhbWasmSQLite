using MhbWasmSQLite.Client.Features.Lists.Components;
using MhbWasmSQLite.Shared;
using System.Net.Http.Json;


namespace MhbWasmSQLite.Client.Features.Lists;

public interface IBibleListService
{
    public List<Mitzvah> Mitzvot { get; set; }
    Task GetMitzvotByTorahBookId(Enums.TorahBookFilter torahBookFilter);
    Task<Mitzvah> GetById(int id);
}

public class BibleListService : IBibleListService
{
    private HttpClient _http;
    private readonly ILogger<BibleListService> _logger;
    public BibleListService(HttpClient http, ILogger<BibleListService> logger)
    {
        _http = http;
        _logger = logger;
    }

    public HttpClient? Http { get; }
    public List<Mitzvah> Mitzvot { get; set; } = new();
    public List<JotAndTittleVM> JotAndTittles { get; set; } = new();

    public async Task GetMitzvotByTorahBookId(Enums.TorahBookFilter torahBookFilter)
    {
        string Uri = $"api/mitzvot/book/{torahBookFilter.Value}";
        _logger.LogDebug(string.Format("Inside {0}; Uri: {1}"
            , nameof(BibleListService) + "!" + nameof(GetMitzvotByTorahBookId), Uri));
        var result = await _http.GetFromJsonAsync<List<Mitzvah>>(requestUri: Uri);

        if (result is not null)
        {
            Mitzvot = result;
        }
    }

    public Task<Mitzvah> GetById(int id)
    {
        throw new NotImplementedException();
    }

}
