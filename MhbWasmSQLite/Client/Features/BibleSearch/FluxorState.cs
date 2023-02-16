using Fluxor;

namespace MhbWasmSQLite.Client.Features.BibleSearch;

// 1. Action
public record SetWebsite_Action(Enums.BibleWebsite BibleWebsite);



// 2. State
public record State
{
  //public Enums.BibleBook? BibleBook { get; init; }
  public Enums.BibleWebsite? BibleWebsite { get; init; }
  public bool ShowDetails { get; init; }
}

// 3. Feature
public class FeatureImplementation : Feature<State>
{
  public override string GetName() => "Header";

  protected override State GetInitialState()
  {
    return new State
    {
      // Don't set default BibleBook (e.g. Genesis) because we don't want <BibleSearch> to be collapsed from it's details
      BibleWebsite = Enums.BibleWebsite.MyHebrewBible,
      ShowDetails = false
    };
  }
}

// 4. Reducers
public static class Reducers
{
  [ReducerMethod]
  public static State OnSetBibleWebsite(
  State state,
  SetWebsite_Action action)
  {
    return state with { BibleWebsite = action.BibleWebsite };
  }
}