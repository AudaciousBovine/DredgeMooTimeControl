
![MOO Title](/Images/DredgeMoo.png)
# MOO Template
### A Dredge Mod Template for my mods with the things I've learned and as a reminder for myself! I tried to do my best to comment within the script files to help understanding of how they work

## Using This Template
- Press "Use This Template" in the top right
- Name the repository your mod name
- It creates a copy to use and edit as you see fit

## mod_meta.json
- The main mod info file, make sure to always update it

"ModAssemply" 
- is what the final mod assembly file will be called
- should be ModName.dll

"Entrypoint"
- the first class (.cs file) and method that runs when the mod loads
- I like calling it "Main"

## Main.cs
- first script that runs
- can be named anything but needs the same name in the mod_meta "Entrypoint"
- Initialize(); is the first method that is run

new Harmony("com.Username.Modname").PatchAll(Assembly.GetExecutingAssembly());
- line in Initialize(); that makes the mod run all the Harmony Patches

## Harmony Patches
- Can be a Prefix or Postfix
- Runs before a method or after a method is run by the game respectively
- Patchname_Patch.cs files should be consolidated in a "Patches" folder or categorized folders for good file management

Example Patches Folder
- Contains patches ive made for editing
- Edit or delete Example Patches folder before building the mod

## ModName.sln
- The solution file is one of the files that is used by IDEs to tell how the mod files are set up
- Remember to change the line that starts with "Project" to have the mod name

## ModName.csproj
- file the build compiler uses
- make sure to add entries into the "ItemGroup" that has "Include" in it
- otherwise only script files will compile

## ModName.csproj.user
- make sure to change to your own DREDGE filepath

## default_config.json
- The default config the game uses
- This will show up in the game Mod menu
- examples of all the config types are inside
- rename them as needed

## Assets
- any assets the mod uses go in here in their respective folders

## Assets/Localization/en.json
- holds the string values for the english localization that the game replaces the addresses in code with
- address format is "Modname.Category.SpecificCategory"

## "Building" The Mod
- To actually package the mod a build task must be run
- If all the prerequisites are properly installed
- Click the top left "Terminal" option
- Press "Run Build Task..."
- Top Center some options appear
- Select "dotnet: build"

## Images
- Just my own media asset images I use when making a DREDGE mod page
- Just download or link them to have them in README files and such
- Free to use by anyone
- 1296 x 104
![Mod Updates](/Images/DredgeUpdates.png)
![Mod Description](/Images/DredgeDescription.png)
![Mod Features](/Images/DredgeFeatures.png)
![Mod Installation](/Images/DredgeInstallation.png)
![Mod Credits](/Images/DredgeCredits.png)
![Mod Credits And Special Thanks](/Images/DredgeCreditsAndSpecialThanks.png)
![Mod Credits And Special Thanks ♥](/Images/DredgeCreditsAndSpecialThanksHeart.png)
![Mod Recommendations](/Images/DredgeRecommendedMods.png)
![Mod Recommendations](/Images/DredgeModRecommendations.png)
![Mod Recommendations](/Images/DredgeOtherModsYouShouldUse.png)
![Mod Other Mods](/Images/DredgeMyOtherMods.png)
![Mod Other Mods](/Images/DredgeOtherModsByMe.png)
