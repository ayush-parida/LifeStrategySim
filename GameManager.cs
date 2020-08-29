using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Button NewGame;
    public Button Continue;
    public Button Settings;
    public Button Quit;
    public GameObject MenuPannel;
    public GameObject PromptPannel;
    public GameObject GamePannel;
    public Button CareerPannelButton;
    public Button SkillsPannelButton;
    public Button BankingPannelButton;
    public Button InvestmentPannelButton;
    public Button TimeManagementPannelButton;
    public Button TradingPannelButton;
    public Button BuyPropertyPannelButton;
    public Button WeeklyOverviewPannelButton;
    public Button NextWeekPannelButton;
    public Text PromptText;
    public Button PromptContinue;
    public Button PromptClose;
    public GameObject TradingPannel, InvestmentPannel, BankingPannel, CareerPannel, SkillsPannel, BuyPropertiesPannel, ManageTimePannel, ExpencesPannel;
    public Button TradingButton, InvestmentButton, BankingButton, CareerButton, SkillsButton, BuyPropertiesButton, ManageTimeButton, ExpencesButton, NextWeekButton;
    Button BackButton;
    void Start()
    {
        MenuPannel.SetActive(true);
        PromptPannel.SetActive(false);
        GamePannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void NewGameClick()
    {
        PromptPannel.SetActive(true);
        PromptText.text = "This will delete your previous saved game.\nDo you wish to continue?";
        PromptContinue.onClick.AddListener(delegate { StartNewGame(); });
    }
    public void CloseClick()
    {
        PromptPannel.SetActive(false);
        PromptText.text = "Continue the previous saved game?";
    }
    public void ContinueClick()
    {
        PromptPannel.SetActive(true);
        PromptText.text = "Continue previously saved game?";
        PromptContinue.onClick.AddListener(delegate { ContinueGame(); });
    }
    public void SettingsClick()
    {
        PromptPannel.SetActive(true);
    }
    public void QuitClick()
    {
        PromptPannel.SetActive(true);
        PromptText.text = "Do you really want to quit?";
        PromptContinue.onClick.AddListener(delegate { QuitGame(); });
    }
    public void TradingButtonClick() 
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(true);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void InvestmentButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(true);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void BankingButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(true);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void CareerButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(true);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void SkillsButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(true);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void BuyPropertiesButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(true);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    public void ManageTimeButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(true);
        ExpencesPannel.SetActive(false);
    }
    public void ExpencesButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(true);
    }
    public void NextWeekButtonClick() { }

    public void BackButtonClick()
    {
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
        TradingPannel.SetActive(false);
        InvestmentPannel.SetActive(false);
        BankingPannel.SetActive(false);
        CareerPannel.SetActive(false);
        SkillsPannel.SetActive(false);
        BuyPropertiesPannel.SetActive(false);
        ManageTimePannel.SetActive(false);
        ExpencesPannel.SetActive(false);
    }
    void StartNewGame()
    {
        GamePannel.SetActive(true);
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
    }
    void ContinueGame()
    {
        GamePannel.SetActive(true);
        MenuPannel.SetActive(false);
        PromptPannel.SetActive(false);
    }

    void QuitGame()
    {
        Application.Quit();
    }
    void Update()
    {
        
    }
}
