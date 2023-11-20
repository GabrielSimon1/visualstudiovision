var dte = (DTE2)GetService(typeof(DTE));
     var commandService = (OleMenuCommandService)GetService(typeof(IMenuCommandService));

     var increaseFontSizeCommandId = new CommandID(Guid.NewGuid(), 0x100);
     var increaseFontSizeCommand = new OleMenuCommand((s, e) =>
     {
         var currentFontSize = (int)dte.Properties["FontsAndColors", "TextEditor"].Item("FontSize").Value;
         dte.Properties["FontsAndColors", "TextEditor"].Item("FontSize").Value = currentFontSize + 2;
     }, increaseFontSizeCommandId);
     commandService.AddCommand(increaseFontSizeCommand);

     var decreaseFontSizeCommandId = new CommandID(Guid.NewGuid(), 0x101);
     var decreaseFontSizeCommand = new OleMenuCommand((s, e) =>
     {
         var currentFontSize = (int)dte.Properties["FontsAndColors", "TextEditor"].Item("FontSize").Value;
         dte.Properties["FontsAndColors", "TextEditor"].Item("FontSize").Value = currentFontSize - 2;
     }, decreaseFontSizeCommandId);
     commandService.AddCommand(decreaseFontSizeCommand);
