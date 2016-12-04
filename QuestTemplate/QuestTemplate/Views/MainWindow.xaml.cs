using System.Windows;
using System.Windows.Input;
using QuestTemplate.ViewModels;

namespace QuestTemplate
{
	public partial class MainWindow : Window
	{
		public MainWindow(MainWindowViewModel viewModel)
		{
			InitializeComponent();
			DataContext = viewModel;
		}
		public void ElementMouseLeftButtonDown(object sender, MouseEventArgs e) => DragMove();
	}
}
