#include "MyMinimalPlugin.h"

#define LOCTEXT_NAMESPACE "FMyMinimalPluginModule"

void FMyMinimalPluginModule::StartupModule()
{
	// This code will execute after your module is loaded into memory.
}

void FMyMinimalPluginModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FMyMinimalPluginModule, MyMinimalPlugin)