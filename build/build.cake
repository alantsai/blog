#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam

var target = Argument("target", "Default");

var sourceDirectory = MakeAbsolute(Directory("..\\src\\")); 

Task("Build")
   .Does(() =>
   {
       Wyam(new WyamSettings
       {
           Recipe = "Blog",
           Theme = "CleanBlog",
           UpdatePackages = true,
           RootPath = sourceDirectory
       });
   });

Task("Default")
   .IsDependentOn("Build");    
   
RunTarget(target);