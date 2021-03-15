using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Vilage
{
    public partial class MainWindow : Window
    {
        GameState player = new GameState(2000);
        Mint mint = new Mint();
        GoldMine goldMine = new GoldMine();
        LumberjackHouse lumberjackHouse = new LumberjackHouse();
        Querry querry = new Querry();
        Sawmill sawmill = new Sawmill();

        public string errorMsg;

        public MainWindow()
        {

            InitializeComponent();
            GameTimer();
        }

        private void MintButton_Click(object sender, RoutedEventArgs e)
        {
            if (mint.AreBuildingRequierementsMet(player.buildings))
            {
                player.RaiseBuilding(mint);
                errorMsg = player.errorMsg;
            }               
            else
                errorMsg = "Potrzebujesz kamieniolomu hatki siōngŏrza jak tyż tartaku.";
            TextBlocksHandler();

        }
        private void GoldButton_Click(object sender, RoutedEventArgs e)
        {
            if (goldMine.AreBuildingRequierementsMet(player.buildings))
            {
                player.RaiseBuilding(goldMine);
                errorMsg = player.errorMsg;
            }
            else
                errorMsg = "Potrzebujesz kamieniolomu hatki siōngŏrza jak tyż tartaku.";
            TextBlocksHandler();
        }
        private void HouseButton_Click(object sender, RoutedEventArgs e)
        {
            if (lumberjackHouse.AreBuildingRequierementsMet(player.buildings))
            {
                player.RaiseBuilding(lumberjackHouse);
                errorMsg = player.errorMsg;
            }
            TextBlocksHandler();
        }
        private void SawmillButton_Click(object sender, RoutedEventArgs e)
        {
            if (sawmill.AreBuildingRequierementsMet(player.buildings))
            {
                player.RaiseBuilding(sawmill);
                errorMsg = player.errorMsg;
            }
            TextBlocksHandler();
        }
        private void QuerryButton_Click(object sender, RoutedEventArgs e)
        {
            if (querry.AreBuildingRequierementsMet(player.buildings))
            {
                player.RaiseBuilding(querry);
                errorMsg = player.errorMsg;
            }
            TextBlocksHandler();
        }
        private void TextBlocksHandler()
        {
            msg_text.Text = errorMsg;
            gold_text.Text = player.gold.ToString();
            mintAmmount_text.Text = mint.amountOfBuildings.ToString();
            goldAmmount_text.Text = goldMine.amountOfBuildings.ToString();
            houseAmmount_text.Text = lumberjackHouse.amountOfBuildings.ToString();
            sawmillAmmount_text.Text = sawmill.amountOfBuildings.ToString();
            querryAmmount_text.Text = querry.amountOfBuildings.ToString();

            income_text.Text = player.income.ToString();
            mintIncome_text.Text = mint.buildingIncome.ToString();
            goldIncome_text.Text = goldMine.buildingIncome.ToString();
            houseIncome_text.Text = lumberjackHouse.buildingIncome.ToString();
            sawmillIncome_text.Text = sawmill.buildingIncome.ToString();
            querryIncome_text.Text = querry.buildingIncome.ToString();
        }

        private void GameTimer()
        {
            System.Timers.Timer statusTime = new System.Timers.Timer();

            statusTime.Interval = 1000;

            statusTime.Elapsed += new System.Timers.ElapsedEventHandler(StatusTimeElapsed);

            statusTime.Enabled = true;
        }
        private void StatusTimeElapsed(object sender, ElapsedEventArgs e)
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
                TextBlocksHandler();
                player.gold += player.income;
                gold_text.Text = player.gold.ToString();
                errorMsg = ' '.ToString();
            });
        }

    }
}
