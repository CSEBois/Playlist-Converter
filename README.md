# Playlist-Converter

Allowing users to convert their current playlists from multiple streaming services from clean to explicit (and vice-versa) and transfer between different streaming services.


Follow the steps in this document to make sure that code is created and committed correctly to the repository.
Let me know if you have questions or need any help! Excited to get back to work!
-Josh
______________________________________________
## Setting up your machine:
1. Download the Repository onto your machine from GitHub - Green button, download zip
2. Unzip the file to a location on your machine
3. Install Visual Studio Community Edition - This is the preferred IDE for .NET development
4. Install Git https://git-scm.com/downloads
5. Install GitKraken https://www.gitkraken.com/download
6. Navigate to the folder where you saved the zip file
7. In the file explorer, click the top where the Folder Name is
	a. Type "cmd" and the command prompt should open in that folder
8. Now, we're going to run a few basic git commands
9. Type in "git checkout -b branchName" branchName can be whatever you want to name your local branchName
	a. When we start to work, the branch will be titled with the Story Card number that you are working on (convention)
	b. For now, anything is fine
10. Close command prompt and open the "Playlist Converter.sln" file
	a. This contains all the files needed for the project, this is where you will work index
	b. You should be working on your new branch
11. Navigate to Tools->Nuget Package Manager->Manage NuGet Packages for Solution
	a. Install the NuGet Packages listed below through the installer
12. Click the Green arrow at the top that says IIS Express to run the code and see the current home page
13. If no errors appear, you have done this correctly!
______________________________________________
## Working on a Branch
All code should be written on a branch off master. This is done by cutting a branch which can be done like you did to set up your machine or from GitKraken.
Make the branch name relevant to the work you will be doing so that we can keep track of it later. 
______________________________________________
## Committing Code
When you have code to be merged, commit all code through the Git CLI or GitKraken.
If it is the first time this branch is being pushed, make sure to attach it to the origin track.
Commit all files that you physically changed, if GitKraken says that it is a binary file, **do not** stage it.
When it is pushed to origin, a pull request can be started to merge your new code with the master branch.
All pull requests **require** a code review before merging.
**Keep email notifications on for this repository or send a message in the group chat** this is how we know to check the code so that it can be added and tested.
Master should **always** be kept clean and working so that is what the requests are for.
______________________________________________
## Links
JIRA: https://playlistconverter.atlassian.net/secure/RapidBoard.jspa?rapidView=1&selectedIssue=PC-7 - Text Josh to be added

Spotify: 
	https://developer.spotify.com/
	https://developer.spotify.com/documentation/web-api/quick-start/
	
	
Soundcloud:
	https://developers.soundcloud.com/
	
Apple Music:
	https://developer.apple.com/documentation/applemusicapi

.NET Tutorials:
	https://docs.microsoft.com/en-us/visualstudio/ide/quickstart-aspnet-core?view=vs-2019
	https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2019
	https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1
	https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core-ef-step-02?view=vs-2019
	

Example Projects:
	https://github.com/fsahin/artist-explorer
	
DB:
	https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx
	https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet
	https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli#revert-a-migration
	https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations?view=aspnetcore-3.1
	https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.1&tabs=visual-studio
	
Other:
	https://www.codeproject.com/Articles/657981/ASP-NET-MVC-4-with-Knockout-Js
	https://oauth.net/articles/authentication/
	https://spotipy.readthedocs.io/en/2.9.0/
	https://github.com/plamere/spotipy/blob/master/spotipy/util.py
	https://github.com/plamere/spotipy
	
______________________________________________
## File List:
### A basic list of files and where to find certain files
/Views - Holds all site pages (razor)
/Controllers - Holds all Controllers
/Models - Holds all Models
/ViewModels - Holds all ViewModels
/Shared - Holds all files that are needed by multiple pages (might change this structure)
/wwwroot - Holds all front end work - JS/CSS code
	Create new JS and CSS files inside of the specific folders and they will be generated into the site.css and site.js files on build
/Data - All Database files

/home/index.cshtml holds the main home page for the site

______________________________________________
## NuGetPackage Install:
BuildBundlerMinifier - needed for generating site.js and site.css
	Gives ability to create multiple js files and combine them into one file

Knockout.Mapping
	Adds knockoutjs to the project
	
EntityFrammwork
	Adding db contexts to the project
