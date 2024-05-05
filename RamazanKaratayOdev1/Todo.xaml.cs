using System.Formats.Tar;

namespace RamazanKaratayOdev1;


public partial class Todo : ContentPage
{
    private readonly IList<string> elements = new List<string>();
    public Todo()
    {
        InitializeComponent();
        RefreshTodoList();
    }

    private void AddClicked(object sender, EventArgs e)
    {
        string task_ = task.Text.Trim();
        if (!string.IsNullOrEmpty(task_))
        {
            elements.Add(task_);
            RefreshTodoList();
        }
    }
    private void RemoveClicked(object sender, EventArgs e)
    {
        if (ListElements.SelectedItem != null)
        {
            string selectedTask = (string)ListElements.SelectedItem;
            elements.Remove(selectedTask);
            RefreshTodoList();
        }
    }

    private void ListElementTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item != null && e.Item is string task)
        {
            string selectedTask = (string)e.Item;
        }
    }
    private void RefreshTodoList()
    {
        ListElements.ItemsSource = null;
        ListElements.ItemsSource = elements;
    }


}