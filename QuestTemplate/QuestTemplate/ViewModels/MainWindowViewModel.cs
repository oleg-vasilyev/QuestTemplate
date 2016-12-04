using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using QuestTemplate.Commands;
using QuestTemplate.Models;

namespace QuestTemplate.ViewModels
{
	public class MainWindowViewModel : ViewModelCore
	{
		private Model _model;

		public MainWindowViewModel()
		{
			MenuGameText = "[Меню]";

			StartGameButtonIsVisible = true;
			ContinueGameButtonIsVisible = false;
			RestartGameButtonIsVisible = false;
			MenuGridIsVisible = true;
		}

		private void modelOnGameOver()
		{
			MenuGameText = _model.GameOverText;
			MenuGridIsVisible = true;
			ContinueGameButtonIsVisible = false;
		}


		private bool _starteGameButtonIsVisible;
		public bool StartGameButtonIsVisible
		{
			get { return _starteGameButtonIsVisible; }
			set
			{
				_starteGameButtonIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private bool _continueGameButtonIsVisible;
		public bool ContinueGameButtonIsVisible
		{
			get { return _continueGameButtonIsVisible; }
			set
			{
				_continueGameButtonIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private bool _restartGameButtonIsVisible;
		public bool RestartGameButtonIsVisible
		{
			get { return _restartGameButtonIsVisible; }
			set
			{
				_restartGameButtonIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private bool _menuIconIsVisible;
		public bool MenuIconIsVisible
		{
			get { return _menuIconIsVisible; }
			set
			{
				_menuIconIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private bool _gameGridIsVisible;
		public bool GameGridIsVisible
		{
			get { return _gameGridIsVisible; }
			set
			{
				if (value)
				{
					MenuGridIsVisible = false;
					MenuIconIsVisible = true;
				}
				_gameGridIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private bool _menuGridIsVisible;
		public bool MenuGridIsVisible
		{
			get { return _menuGridIsVisible; }
			set
			{
				if (value)
				{
					GameGridIsVisible = false;
					MenuIconIsVisible = false;
				}
				_menuGridIsVisible = value;
				RaisePropertyChanged();
			}
		}


		private string _menuGameText;
		public string MenuGameText
		{
			get { return _menuGameText; }
			set
			{
				_menuGameText = value;
				RaisePropertyChanged();
			}
		}


		private string _questImagePath;
		public string QuestImagePath
		{
			get { return _questImagePath; }
			set
			{
				_questImagePath = value;
				RaisePropertyChanged();
			}
		}


		private string _questData;
		public string QuestData
		{
			get { return _questData; }
			set
			{
				_questData = value;
				RaisePropertyChanged();
			}
		}


		private DelegateCommand _menuClickDelegate;
		public ICommand MenuClick
		{
			get
			{
				_menuClickDelegate = new DelegateCommand(delegate
				{
					MenuGridIsVisible = true;
					MenuGameText = "[Меню]";
				});
				return _menuClickDelegate;
			}
		}


		private DelegateCommand _topBtnClickDelegate;
		public ICommand TopBtnClick
		{
			get
			{
				_topBtnClickDelegate = new DelegateCommand(delegate
				{
                    Scene scene = _model.ProcessQuestAnswer(_topBtnAnswer);
                    if (scene == null) return;
                    fillScene(scene);
				});
				return _topBtnClickDelegate;
			}
		}

		private QuestAnswer _topBtnAnswer;
		public string GetTopBtnAnswer
		{
			get { return _topBtnAnswer?.Text; }
		}
		public QuestAnswer SetTopBtnAnswer
		{
			set
			{
				_topBtnAnswer = value;
				RaisePropertyChanged("GetTopBtnAnswer");
			}
		}


		private DelegateCommand _rightBtnClickDelegate;
		public ICommand RightBtnClick
		{
			get
			{
				_rightBtnClickDelegate = new DelegateCommand(delegate
				{
                    Scene scene = _model.ProcessQuestAnswer(_rightBtnAnswer);
                    if (scene == null) return;
                    fillScene(scene);
                });
				return _rightBtnClickDelegate;
			}
		}

		private QuestAnswer _rightBtnAnswer;
		public string GetRightBtnAnser
		{
			get { return _rightBtnAnswer?.Text; }
		}
		public QuestAnswer SetRightBtnAnser
		{
			set
			{
				_rightBtnAnswer = value;
				RaisePropertyChanged("GetRightBtnAnser");
			}
		}


		private DelegateCommand _bottomBtnClickDelegate;
		public ICommand BottomBtnClick
		{
			get
			{
				_bottomBtnClickDelegate = new DelegateCommand(delegate
				{
                    Scene scene = _model.ProcessQuestAnswer(_bottomBtnAnswer);
                    if (scene == null) return;
                    fillScene(scene);
                });
				return _bottomBtnClickDelegate;
			}
		}

		private QuestAnswer _bottomBtnAnswer;
		public string GetBottomBtnAnswer
		{
			get { return _bottomBtnAnswer?.Text; }
		}
		public QuestAnswer SetBottomBtnAnswer
		{
			set
			{
				_bottomBtnAnswer = value;
				RaisePropertyChanged("GetBottomBtnAnswer");
			}
		}


		private DelegateCommand _leftBtnClickDelegate;
		public ICommand LeftBtnClick
		{
			get
			{
				_leftBtnClickDelegate = new DelegateCommand(delegate
				{
                    Scene scene = _model.ProcessQuestAnswer(_leftBtnAnswer);
                    if (scene == null) return;
                    fillScene(scene);
                });
				return _leftBtnClickDelegate;
			}
		}

		private QuestAnswer _leftBtnAnswer;
		public string GetLeftBtnAnswer
		{
			get { return _leftBtnAnswer?.Text; }
		}
		public QuestAnswer SetLeftBtnAnswer
		{
			set
			{
				_leftBtnAnswer = value;
				RaisePropertyChanged("GetLeftBtnAnswer");
			}
		}

		#region Menu Commands

		private DelegateCommand _startGameClickDelegate;
		public ICommand StartGameClick
		{
			get
			{
				_startGameClickDelegate = new DelegateCommand(delegate
				{
					gettingReadyToStartTheGame();

					GameGridIsVisible = true;
					StartGameButtonIsVisible = false;
					ContinueGameButtonIsVisible = true;
					RestartGameButtonIsVisible = true;
				});
				return _startGameClickDelegate;
			}
		}


		private DelegateCommand _сontinueGameClickDelegate;
		public ICommand СontinueGameClick
		{
			get
			{
				_сontinueGameClickDelegate = new DelegateCommand(delegate
				{
					GameGridIsVisible = true;
				});
				return _сontinueGameClickDelegate;
			}
		}


		private DelegateCommand _restartGameClickDelegate;
		public ICommand RestartGameClick
		{
			get
			{
				_restartGameClickDelegate = new DelegateCommand(delegate
				{
					gettingReadyToStartTheGame();
					GameGridIsVisible = true;
					ContinueGameButtonIsVisible = true;
				});
				return _restartGameClickDelegate;
			}
		}


		private DelegateCommand _exitClickDelegate;
		public ICommand ExitClick
		{
			get
			{
				_exitClickDelegate = new DelegateCommand(delegate
				{
					Application.Current.Shutdown();
				});
				return _exitClickDelegate;
			}
		}

		#endregion


		private void fillScene(Scene scene)
		{
			if (scene == null) return;

			QuestImagePath = scene.ImagePath;
			QuestData = scene.Text;

			List<QuestAnswer> questAnswerList = (scene.QuestAnswerSet).ToList();
			SetTopBtnAnswer = questAnswerList?.Count >= 1 && questAnswerList[0] != null ? questAnswerList[0] : _model.GetBlankAnswer();
			SetRightBtnAnser = questAnswerList?.Count >= 2 && questAnswerList[1] != null ? questAnswerList[1] : _model.GetBlankAnswer();
			SetBottomBtnAnswer = questAnswerList?.Count >= 3 && questAnswerList[2] != null ? questAnswerList[2] : _model.GetBlankAnswer();
			SetLeftBtnAnswer = questAnswerList?.Count >= 4 && questAnswerList[3] != null ? questAnswerList[3] : _model.GetBlankAnswer();
		}

		private void gettingReadyToStartTheGame()
		{
			_model = new Model();
			_model.GameOver += modelOnGameOver;
			Scene currentScene = _model.GetStartScene();
			fillScene(currentScene);
		}
	}
}
