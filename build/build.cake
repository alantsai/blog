#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam

var target = Argument("target", "Default");

Task("Build")
   .Does(() =>
   {
       Wyam(new WyamSettings
       {
           Recipe = "Blog",
           Theme = "CleanBlog",
           UpdatePackages = true,
           RootPath = "..\\src\\"
       });
   });

Task("Default")
   .IsDependentOn("Build");    
   
RunTarget(target);