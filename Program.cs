using Figgle;

if (args.Length == 0)
{
  Console.WriteLine("Usage: HelloDotNet <text>");
  Environment.Exit(1);
}

Console.WriteLine(FiggleFonts.Standard.Render(args[0]));
