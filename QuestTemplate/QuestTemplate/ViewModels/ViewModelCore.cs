using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuestTemplate.ViewModels
{
	public abstract class ViewModelCore : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
