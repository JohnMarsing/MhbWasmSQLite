using Microsoft.AspNetCore.Components;
using MhbWasmSQLite.Shared;
using MhbWasmSQLite.Client.Services;
using MhbWasmSQLite.Client.Enums;

namespace MhbWasmSQLite.Client.Features.Scripture;

public partial class Index
{
	//private List<ScriptureVM>? scriptures;

	[Inject] public  IScriptureService svc { get; set; }
	[Inject] public ILogger<Index>? Logger { get; set; }

	Status _status;
	string _msg = string.Empty;

	protected override async Task OnInitializedAsync()
	{
		try
		{
			_status = Status.Loading;
			Logger!.LogInformation("...Calling svc.GetByBookChapter");

			//scriptures = await svc.GetByBookChapter(1);
			await svc.GetByBookChapter(1);
			if (svc.Scriptures is not null)
			{
				_status = Status.Loaded;
			}
			
		}
		catch (Exception ex)
		{
			_status = Status.Error;
			_msg = ex.ToString();
			Logger!.LogError(ex, "...Exception occurred");
		}
	}
}