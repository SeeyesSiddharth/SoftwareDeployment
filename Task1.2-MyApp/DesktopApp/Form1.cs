using AppCore;
using Newtonsoft.Json;

namespace DesktopApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Text = "Note Viewer";

        var note = new Note { Title = "Deployment Test", Body = "Packaged with WiX v7" };

        var box = new TextBox
        {
            Multiline = true,
            Dock = DockStyle.Fill,
            ScrollBars = ScrollBars.Vertical,
            Text = NoteStore.Describe(note) + Environment.NewLine + Environment.NewLine
                 + JsonConvert.SerializeObject(note, Formatting.Indented)
        };
        Controls.Add(box);
    }
}