using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
		public GameObject _MenuPanel;
		public GameObject _PlayMenu;
        public GameObject GamePanel;
		public GameObject _SettingPanel;
        public GameObject _ControlPanel;
        public GameObject levelLockedMessage;
        public GameObject BuyMessage;
        public GameObject CampanignPanel;
        public GameObject StorePanel;
        public GameObject DifficultyPanel;
        public GameObject SelectGame;
        public GameObject ExitPanel;
        public GameObject ExitGame;
        public GameObject MainPanel;
        public GameObject CreditPanel;
        public GameObject Pause;
        public GameObject Resume;




    public void OnButtonsClick(GameObject _gameObject)
		{
			if (_gameObject.name == "Start")
            {
				_MenuPanel.SetActive (false);
				 DifficultyPanel.SetActive (true);
			}
        if (_gameObject.name == "Easy")
        {
            SelectGame.SetActive(true);
            DifficultyPanel.SetActive(false);
        }
        if (_gameObject.name == "Quit")
        {
            ExitGame.SetActive(true);
            MainPanel.SetActive(false);
        }
        if (_gameObject.name == "Leave")
        {
            _MenuPanel.SetActive(true);
            ExitGame.SetActive(false);
        }
        if (_gameObject.name == "Credits")
        {
            CreditPanel.SetActive(true);
            _MenuPanel.SetActive(false);
        }
        if (_gameObject.name == "NotLeave")
        {
            ExitGame.SetActive(false);
            _PlayMenu.SetActive(true);
        }
        if (_gameObject.name == "Medium")
        {
            SelectGame.SetActive(true);
            DifficultyPanel.SetActive(false);
        }
        if (_gameObject.name == "Hard")
        {
            SelectGame.SetActive(true);
            DifficultyPanel.SetActive(false);
        }
        if (_gameObject.name == "Back")
           {
				_MenuPanel.SetActive (true);
				_PlayMenu.SetActive (false);
                 StorePanel.SetActive(false);
                 _ControlPanel.SetActive(false);
                 SelectGame.SetActive(false);
                 DifficultyPanel.SetActive(false);
                 CreditPanel.SetActive(false);




        }
        if (_gameObject.name == "Setting")
        {
           
            _MenuPanel.SetActive(false);
            _SettingPanel.SetActive(true);
        }
        if (_gameObject.name == "Store")
        {

            _MenuPanel.SetActive(false);
            StorePanel.SetActive(true);
        }
        if (_gameObject.name == "Easy")
        {

            _PlayMenu.SetActive(true);
            StorePanel.SetActive(false);
        }
        if (_gameObject.name == "Medium")
        {

            _PlayMenu.SetActive(true);
            StorePanel.SetActive(false);
        }
        if (_gameObject.name == "Hard")
        {

            _PlayMenu.SetActive(true);
            StorePanel.SetActive(false);
        }
        if (_gameObject.name == "Campanign")
        {
            CampanignPanel.SetActive(true);
            SelectGame.SetActive(false);
        }
        if (_gameObject.name == "Level1")
        {
            CampanignPanel.SetActive(false);
            GamePanel.SetActive(false);
            _PlayMenu.SetActive(true);
        }
        if (_gameObject.name == "Button")
        {
            MainPanel.SetActive(true);
            _PlayMenu.SetActive(false);
        }
        if (_gameObject.name == "Button2")
        {
            _PlayMenu.SetActive(true);
            MainPanel.SetActive(false);
           
        }

        if (_gameObject.name == "No")
        {
            ExitPanel.SetActive(false);
            _MenuPanel.SetActive(true);
        }
        if (_gameObject.name == "Yes")
        {
            ExitPanel.SetActive(false);
            Application.Quit();
        }

        if (_gameObject.name == "New")
        {
            SelectGame.SetActive(false);
            _PlayMenu.SetActive(true);
        }
        if (_gameObject.name == "MainMenu")
        {
            _MenuPanel.SetActive(true);
            _SettingPanel.SetActive(false);
            _ControlPanel.SetActive(false);
            CampanignPanel.SetActive(false);
        }
        if (_gameObject.name == "Pause") {
				Time.timeScale = 0;
            Pause.SetActive(false);
            Resume.SetActive(true);
        }
			if (_gameObject.name == "Resume")
            {
				Time.timeScale = 1;
            Resume.SetActive(false);
            Pause.SetActive(true);
        }
        if (_gameObject.name == "Control")
        {
            _MenuPanel.SetActive(false);
            _ControlPanel.SetActive(true);
        }
        if (_gameObject.name == "Exit")
        {
            _MenuPanel.SetActive(false);
            ExitPanel.SetActive(true);
        }
        if (_gameObject.tag== "locked level")
        {
            levelLockedMessage.SetActive(true);
            Invoke("DeactivateLockedLevel",1.2f);
        }
        if (_gameObject.tag == "Store")
        {
            BuyMessage.SetActive(true);
            Invoke("DeactivateLockedLevel", 1.2f);
        }

    }

    void DeactivateLockedLevel()
    {
        levelLockedMessage.SetActive(false);
        BuyMessage.SetActive(false);

    }

}
