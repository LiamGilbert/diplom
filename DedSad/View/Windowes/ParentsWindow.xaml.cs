using DedSad.Models;
using DedSad.Repository;
using System.Linq;
using System.Windows;

namespace DedSad.View.Windowes
{
    public partial class ParentsWindow : Window
    {
        public ParentsWindow(Children children)
        {
            InitializeComponent();
            Initialize(children);
        }

        private async void Initialize(Children children)
        {
            var repo = new ParentsRepository();
            var items = (await repo.GetAllAsync()).Where(x => x.id_child == children.id_children).ToList();
            dgParent.ItemsSource = items;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
