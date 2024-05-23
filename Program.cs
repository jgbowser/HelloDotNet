using HelloDotNet;
using CommandLine;

Parser.Default
  .ParseArguments<RenderOptions, FontListOptions>(args)
  .WithParsed<RenderOptions>(AsciiArt.Write)
  .WithParsed<FontListOptions>(FontList.Write)
  .WithNotParsed(_ => WriteLine("Usage: HelloDotNet <text> --font Big"));