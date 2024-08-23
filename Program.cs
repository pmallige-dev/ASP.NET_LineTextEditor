using LineTextEditor;
using LineTextEditor.CommandProcessor;
using LineTextEditor.Commands;
using Microsoft.Extensions.DependencyInjection;

IServiceProvider serviceProvider = new ServiceCollection()
    .AddSingleton<ICommandProcessor, CommandProcessor>()
    .AddSingleton<ICommands, Commands>()
    .AddSingleton<LineEditor>()
    .BuildServiceProvider();

LineEditor editor = serviceProvider.GetService<LineEditor>();
editor.Run();
