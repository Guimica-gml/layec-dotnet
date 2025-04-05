﻿using LayeC.Diagnostics;
using LayeC.Driver;
using LayeC.FrontEnd.C.Preprocess;
using LayeC.Source;

namespace LayeC.FrontEnd;

public sealed class CDriver
    : ICompilerDriver
{
    public static int RunWithArgs(DiagnosticConsumerProvider diagProvider, string[] args, string programName = "layecc")
    {
        CDriverOptions options;
        using (var parserDiag = diagProvider(true))
        using (var diag = new DiagnosticEngine(parserDiag))
        {
            options = CDriverOptions.Parse(diag, new(args));
            if (diag.HasEmittedErrors)
                return 1;
        }

        if (options.ShowVersion)
        {
            Console.WriteLine("TODO: Show C compiler version text");
            return 0;
        }

        if (options.ShowHelp)
        {
            Console.WriteLine("TODO: Show C compiler help text");
            return 0;
        }

        using var driverDiag = diagProvider(options.OutputColoring);
        var driver = Create(driverDiag, options, programName);
        return driver.Execute();
    }

    public static CDriver Create(IDiagnosticConsumer diagConsumer, CDriverOptions options, string programName = "chc")
    {
        return new CDriver(programName, diagConsumer, options);
    }

    public string ProgramName { get; set; }
    public CompilerContext Context { get; set; }
    public CDriverOptions Options { get; set; }

    private CDriver(string programName, IDiagnosticConsumer diagConsumer, CDriverOptions options)
    {
        ProgramName = programName;
        Context = new CompilerContext(diagConsumer, Target.X86_64);
        Options = options;
    }

    public int Execute()
    {
        foreach (var (fileName, file) in Options.InputFiles)
        {
            var source = new SourceText(fileName, File.ReadAllText(file.FullName));
            var ppTokens = CLexer.ReadTokens(Context, source);

            foreach (var t in ppTokens)
            {
                Console.Error.Write($"{t.Kind} <{t.Location.Offset}>{(t.IsAtStartOfLine ? " BOL" : "")} '{source.Substring(t.Range)}'");
                if (t.StringValue.Length > 0)
                    Console.Error.Write($" ({t.StringValue})");
                Console.Error.WriteLine();
            }

            Console.Error.WriteLine("----");

            var macroStore = new CPPMacroStore();
            var tokens = CPreprocessor.PreprocessTokens(Context, macroStore, source, ppTokens);

            foreach (var t in tokens)
            {
                Console.Error.Write($"{t.Kind} <{t.Location.Offset}> '{source.Substring(t.Range)}'");
                if (t.StringValue.Length > 0)
                    Console.Error.Write($" ({t.StringValue})");
                Console.Error.WriteLine();
            }
        }

        return 0;
    }
}
