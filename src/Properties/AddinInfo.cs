using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "Sample",
    Namespace = "Sample",
    Version = "1.0"
)]

[assembly: AddinName("My First Extension")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("My first Visual Studio for Mac extension")]
[assembly: AddinAuthor("Christian Resma Helle")]
