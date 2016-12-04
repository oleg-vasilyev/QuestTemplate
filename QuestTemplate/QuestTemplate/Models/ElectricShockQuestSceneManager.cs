using System;

namespace QuestTemplate.Models
{
	class ElectricShockQuestSceneManager : ISceneManager
	{
		private Data _data;
		private int _currentSceneId;
		private AffectedCharacter _electric;
		private string _gameOverText;

		public event Action GameOver;


		public ElectricShockQuestSceneManager()
		{
			_data = new Data();
			_currentSceneId = 0;

			_electric = new AffectedCharacter(AffectedCharacterState.Bad);
		}

		public Scene GetCurrentScene()
		{
			return _data.GetSceneById(_currentSceneId);
		}

		public string GetGameOverText()
		{
			return _gameOverText;
		}

		public Scene ToNextScene(int sceneId)
		{
			Scene current = GetCurrentScene();
			//Проверка тут
			Scene output = _data.GetSceneById(sceneId);
			if (output == null) { return GetCurrentScene(); }
			_currentSceneId = output.Id;

			//if (true) { _gameOverText = "the end"; GameOver(); }

			return output;
		}
	}
}
