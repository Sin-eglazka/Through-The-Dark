using UnrealBuildTool;

public class GameTarget : TargetRules
{
	public GameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Game");
	}
}
