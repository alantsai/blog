#tool nuget:?package=Wyam&version=2.1.3
#addin nuget:?package=Cake.Wyam&version=2.1.3
#addin nuget:?package=Cake.Npm&version=0.17.0

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

Task("Preview")
   .Does(() =>
   {
       Wyam(new WyamSettings
       {
           Recipe = "Blog",
           Theme = "CleanBlog",
           UpdatePackages = true,
           Preview = true,
           Watch = true,
           RootPath = sourceDirectory
       });        
   });

Task("Deploy")
    .IsDependentOn("Build")
    .Does(() =>
    {
        var netlify_token_name = "NETLIFY_TOKEN";
        var site_name_key = "SITE_NAME";

        // Add NETLIFY_TOKEN to your enviornment variables or argument
        string token = EnvironmentVariable(netlify_token_name) ?? Argument(netlify_token_name, "");
        string site_name = EnvironmentVariable(site_name_key) ?? Argument(site_name_key, "blog-pro.netlify.com");
        
        if(string.IsNullOrEmpty(token))
        {
            throw new Exception($"Could not get {netlify_token_name} environment variable");
        }

        // zip the output directory and upload using curl
        // Zip($"{sourceDirectory}/output", "output.zip", $"{sourceDirectory}/output/**/*");

        // Install the Netlify CLI locally and then run the deploy command
        NpmInstall("netlify-cli@2.68.6");
        StartProcess(
            MakeAbsolute(File("./node_modules/.bin/netlify.cmd")), 
            $"deploy --dir {sourceDirectory}/output --site {site_name} --auth {token} --prod" );
    });

Task("Default")
   .IsDependentOn("Build");    
   
RunTarget(target);