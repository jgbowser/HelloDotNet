using CommandLine;

namespace HelloDotNet;
[Verb("write", isDefault: true)]
public record RenderOptions
{
  [Value(0, Required = true, MetaName = "text", HelpText = "Text to render"), ]
  public string? Text { get; init; }

  [Option('f', "font", HelpText = "Font to use")]
  public string? Font { get; init; }
}

[Verb("list")]
public record FontListOptions
{
  [Option('l', "list", HelpText = "List available fonts")]
  public bool List { get; init; }
}