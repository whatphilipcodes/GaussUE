using UnrealBuildTool;

public class GaussUE : ModuleRules
{
    public GaussUE(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            [
                "Core",
            ]
        );

        PrivateDependencyModuleNames.AddRange(
            [
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
            ]
        );
    }
}