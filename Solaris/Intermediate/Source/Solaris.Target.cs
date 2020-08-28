using UnrealBuildTool;

public class SolarisTarget : TargetRules
{
	public SolarisTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Solaris");
	}
}
