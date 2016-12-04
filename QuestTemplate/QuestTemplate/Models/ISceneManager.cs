using System;

namespace QuestTemplate.Models
{
	interface ISceneManager
	{
		Scene SwitchSceneTo(int sceneId);

		event Action GameOver;
		string GetGameOverText();
	}
}
