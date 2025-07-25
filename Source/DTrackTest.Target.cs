// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class DTrackTestTarget : TargetRules
{
	public DTrackTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "DTrackTest" } );
				
#if UE_5_4_OR_LATER
		DefaultBuildSettings = BuildSettingsVersion.V5;
#elif UE_5_0_OR_LATER
		DefaultBuildSettings = BuildSettingsVersion.V4;
#else
		DefaultBuildSettings = BuildSettingsVersion.V2;
#endif

	}
}
