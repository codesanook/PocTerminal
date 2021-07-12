// The code below is done with the new Top-level statements in C# 9.0.
using Terminal.Gui;
using NStack;

Application.Init();
var top = Application.Top;

// Creates the top-level window to show
var win = new Window("MyApp")
{
    // By using Dim.Fill(), it will automatically resize without manual intervention
    Width = Dim.Fill(),
    Height = Dim.Fill()
};
top.Add(win);

var messageLabel = new Label("Message: ") { X = 3, Y = 2 };
var messageText = new TextField("")
{
    X = Pos.Right(messageLabel),
    Y = Pos.Top(messageLabel),
    Width = 40
};

// Add some controls, 
win.Add(messageLabel, messageText);

// Run the application
Application.Run();
