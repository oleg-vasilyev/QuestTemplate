using System.Windows;
using QuestTemplate.ViewModels;

namespace QuestTemplate
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void ApplicationStartup(object sender, StartupEventArgs e)
		{
			MainWindowViewModel viewModel = new MainWindowViewModel();
			MainWindow mainWindow = new MainWindow(viewModel);
			mainWindow.Show();
		}
	}
}
