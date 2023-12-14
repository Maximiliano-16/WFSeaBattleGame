using System;
using System.Drawing;
using System.Windows.Forms;
using WFSeaBattleGame.Game;
using WFSeaBattleGame;

namespace WFSeaBattleGame
{
    public partial class GameForm : Form
    {
        private const int ProgressBarMaximumValue = 100;
        private const int ZeroSign = 0;
        public const int UnitSign = 1;
        private static int s_fieldSize;
        private Button[] _chooseSizeButtons;
        private Label[] _chooseSizeLabels;
        private MapController _mapController;
        private User _user;
        MainForm _mainForm;
        private Enemy _enemy;
        private bool _makeSizeZero = false;
        public static string DefaultStatus { get; } = "----";
        public static Color DefaultStatusColor { get; } = Color.Black;
        public int ChosenSize { get; set; } = 0;
        public int NumberOfShipSizes { get; } = 4;
        public bool IsSelectedShipHorizontal { get; set; } = false;
        public bool ComputerMovingLabelVisible { get; set; } = false;

        public GameForm()
        {
            InitializeComponent();
            const int mediumSpeedSelectedIndex = 1;
            comboBoxComputerMoveSpeed.SelectedIndex = mediumSpeedSelectedIndex;
            comboBoxComputerMoveSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public GameForm(MainForm mainForm)
        {
            InitializeComponent();
            const int mediumSpeedSelectedIndex = 1;
            comboBoxComputerMoveSpeed.SelectedIndex = mediumSpeedSelectedIndex;
            comboBoxComputerMoveSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            _mainForm = mainForm;
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            const string clearFieldButtonText = "Очистить поле";
            ContextMenuStrip.Items[ZeroSign].Text = clearFieldButtonText;
            _mapController = new MapController(this);
            s_fieldSize = MapController.MapSize;
            _chooseSizeButtons = new Button[NumberOfShipSizes];
            _chooseSizeLabels = new Label[NumberOfShipSizes];
            for (int shipSizeIndex = 0; shipSizeIndex < NumberOfShipSizes; shipSizeIndex++)
            {
                _chooseSizeButtons[shipSizeIndex] = (Button)Controls[GetControlText("button", shipSizeIndex + UnitSign)];
                _chooseSizeLabels[shipSizeIndex] = (Label)Controls[GetControlText("label", shipSizeIndex + UnitSign)];
                _chooseSizeButtons[shipSizeIndex].Click += new EventHandler(ButtonToChooseSize_Click);
                ComputerMovesSpeedToolStripMenuItem.DropDownItems[shipSizeIndex].Click += new EventHandler(ToolStripItemToChooseSpeed_Click);
            }
            BindPlayers();
            SetButtonEvents();
            _enemy.MarkMoves = MarkComputerMovesToolStripMenuItem.Checked;
        }

        private void BindPlayers()
        {
            _user = new User(this);
            _enemy = new Enemy(this, _user);
            _user.SetEnemy(_enemy);
            _user.Map = new MapButton[s_fieldSize, s_fieldSize];
            _user.DeclareField();
        }

        private string GetControlText(string controlName, int index)
        {
            return (controlName + (index) + "x").ToString();
        }

        private void SetButtonEvents()
        {
            foreach (MapButton shipButton in _user.Map)
            {
                shipButton.Click += new EventHandler(PlayerButton_Click);
                shipButton.MouseEnter += new EventHandler(PlayerButton_MouseEnter);
                shipButton.MouseLeave += new EventHandler(PlayerButton_MouseLeave);
                shipButton.TextChanged += new EventHandler(ShipButton_TextChanged);
            }
        }

        private void ButtonToChooseSize_Click(object sender, EventArgs e)
        {
            SetFocus();
            int chooseSizeButtonNumber = 0;
            Button chosenButton = (Button)sender;
            SetSizeChoosingButton(chosenButton, ref chooseSizeButtonNumber, firstCheck: true);
            SetSizeChoosingButton(chosenButton, ref chooseSizeButtonNumber, firstCheck: false);
        }

        private void SetSizeChoosingButton(Button chosenButton, ref int chooseSizeButtonNumber,
            bool firstCheck)
        {
            for (int i = 0; i < NumberOfShipSizes; i++)
            {
                if (!firstCheck)
                {
                    Label label = (Label)Controls[GetControlText("label", i + UnitSign)];
                    if (label.Text != ZeroSign.ToString() && i != chooseSizeButtonNumber)
                        ButtonColorToStandart(_chooseSizeButtons[i]);
                }
                else if (chosenButton == _chooseSizeButtons[i])
                {
                    ChosenSize = i + UnitSign;
                    _chooseSizeButtons[i].BackColor = Color.LightSkyBlue;
                    chooseSizeButtonNumber = i;
                }
            }
        }

        private void ToolStripItemToChooseSpeed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfShipSizes; i++)
                if ((ToolStripItem)sender == ComputerMovesSpeedToolStripMenuItem.DropDownItems[i])
                    comboBoxComputerMoveSpeed.SelectedIndex = i;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberOfShipSizes; i++)
                CheckComputerMovesSpeedToolStrip(i, check: false);
            CheckComputerMovesSpeedToolStrip(comboBoxComputerMoveSpeed.SelectedIndex, check: true);
        }

        private void CheckComputerMovesSpeedToolStrip(int index, bool check)
        {
            ((ToolStripMenuItem)ComputerMovesSpeedToolStripMenuItem.
                DropDownItems[index]).Checked = check;
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            SetFocus();
            MapButton senderShipButton = sender as MapButton;
            bool buttonChosen = senderShipButton.BackColor == Color.LightBlue;
            if (!buttonChosen) return;
            ChangeShipsLeft((Button)Controls[GetControlText("button", ChosenSize)],
                (Label)Controls[GetControlText("label", ChosenSize).ToString()]);
            _user.SetShip(senderShipButton);
            if (_makeSizeZero)
            {
                ChosenSize = 0;
                _makeSizeZero = false;
            }
        }

        private void ChangeShipsLeft(Button selectedButton, Label currentSizeShipsLeft)
        {
            const int progressBarIncrement = 10;
            if (progressBar.Value < ProgressBarMaximumValue - progressBarIncrement)
            {
                progressBar.Value += progressBarIncrement;
                currentSizeShipsLeft.Text =
                    Convert.ToString(Convert.ToInt32(currentSizeShipsLeft.Text) - UnitSign);
                if (currentSizeShipsLeft.Text != ZeroSign.ToString()) return;
                selectedButton.Enabled = false;
                ButtonColorToStandart(selectedButton);
                _makeSizeZero = true;
            }
            else ShipsArranged();
        }

        private void ShipsArranged()
        {
            foreach (Button button in _chooseSizeButtons)
            {
                ButtonColorToStandart(button);
                button.Enabled = false;
            }
            foreach (Label label in _chooseSizeLabels)
                label.Text = ZeroSign.ToString();
            progressBar.Value = ProgressBarMaximumValue;
            SetShipArrangeButtonEnables(shipsPlaced: true);
            _user.UnableField();
        }

        private void SetShipArrangeButtonEnables(bool shipsPlaced)
        {
            labelShipPlacement.Visible = !shipsPlaced;
            buttonRotate.Enabled = !shipsPlaced;
            buttonGameStart.Enabled = shipsPlaced;
            buttonArrangeShipsRandomly.Enabled = !shipsPlaced;
        }

        private void PlayerButton_MouseEnter(object sender, EventArgs e)
        {
            SetShipVisibility((MapButton)sender, toAppear: true);
        }

        private void PlayerButton_MouseLeave(object sender, EventArgs e)
        {
            SetShipVisibility((MapButton)sender, toAppear: false);
        }

        private void SetShipVisibility(MapButton button, bool toAppear)
        {
            int previousSize = ChosenSize - UnitSign;
            bool spaceIsFree = IsSelectedShipHorizontal ?
                (button.X + previousSize) < s_fieldSize :
                (button.Y - previousSize) >= _mapController.ZeroCoordinate;
            ShipToAppear(button, ref spaceIsFree, toAppear, firstTest: true);
            ShipToAppear(button, ref spaceIsFree, toAppear, firstTest: false);
        }

        private void ShipToAppear(MapButton button, ref bool spaceIsFree, bool toAppear, bool firstTest)
        {
            int x = button.X, y = button.Y;
            if (!spaceIsFree) return;
            for (int i = 0; i < ChosenSize; i++)
            {
                if (firstTest)
                {
                    spaceIsFree = _user.Map[x, y].Enabled;
                }
                else
                {
                    if (toAppear) _user.Map[x, y].BackColor = Color.LightBlue;
                    else ButtonColorToStandart(_user.Map[x, y]);
                }
                _user.ShiftCoordinates(isHorizontal: IsSelectedShipHorizontal,
                    Add: IsSelectedShipHorizontal, ref x, ref y);
            }
        }

        public static void ButtonColorToStandart(Button button)
        {
            button.BackColor = SystemColors.ButtonFace;
            button.UseVisualStyleBackColor = true;
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            IsSelectedShipHorizontal = !IsSelectedShipHorizontal;
            string shipPositionLabel = "Размещение: ";
            shipPositionLabel += IsSelectedShipHorizontal ? "—" : "|";
            labelShipPlacement.Text = shipPositionLabel;
        }

        private void buttonGameStart_Click(object sender, EventArgs e)
        {
            SetControlsVisibility(visible: false);
            labelStatus.Visible = true;
            labelEnemyField.Visible = true;
            ContextMenuStrip.Items[ZeroSign].Text = "Начать заново";
            _enemy.DeclareField();
            _enemy.SpawnRandomShips();
        }

        public void ShipButton_TextChanged(object sender, EventArgs e)
        {
            MapButton button = sender as MapButton;
            int fontSize = button.Text == "." ? 15 : 8;
            //  button.TextAlign = ContentAlignment.MiddleCenter;
            // button.UseCompatibleTextRendering = true;
            // button.Location = new System.Drawing.Point(16, 16);
            FontStyle fontStyle = button.Text == "." ? FontStyle.Bold : FontStyle.Regular;
            button.Font = new Font(button.Font.Name, fontSize, fontStyle);
        }

        public void SetLabelStatus(string status, Color color)
        {
            labelStatus.Text = "Статус: " + status;
            labelStatus.ForeColor = color;
        }

        public void SetComputerMovesToolStripsEnables(bool enable)
        {
            for (int i = 0; i < NumberOfShipSizes; i++)
                ComputerMovesSpeedToolStripMenuItem.DropDownItems[i].Enabled = enable;
            GameRestartToolStripMenuItem.Enabled = enable;
        }

        public void SetLabelComputerMoveVisibility(bool visible)
        {
            labelComputerMove.Visible = visible;
        }

        private void labelComputerMove_VisibleChanged(object sender, EventArgs e)
        {
            ComputerMovingLabelVisible = labelComputerMove.Visible;
        }

        private void CheckBoxMarkEnemyMoves_CheckedChanged(object sender, EventArgs e)
        {
            _enemy.MarkMoves = checkBoxMarkEnemyMoves.Checked;
            MarkComputerMovesToolStripMenuItem.Checked = checkBoxMarkEnemyMoves.Checked;
        }

        private void MarkComputerMovesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkComputerMovesToolStripMenuItem.Checked = !MarkComputerMovesToolStripMenuItem.Checked;
            _enemy.MarkMoves = MarkComputerMovesToolStripMenuItem.Checked;
            checkBoxMarkEnemyMoves.Checked = MarkComputerMovesToolStripMenuItem.Checked;
            foreach (MapButton button in _user.Map)
                button.RefreshMarking(MarkComputerMovesToolStripMenuItem.Checked);
        }

        public int GetComputerMoveSpeedSelectedIndex()
        {
            return comboBoxComputerMoveSpeed.SelectedIndex;
        }

        public void SetFocus()
        {
            labelYourField.Focus();
        }

        public void FinishGame()
        {
            bool userWon = _enemy.ShipDecksAlive == 0;
            string gameFinishTitle = "Вы ";
            gameFinishTitle += userWon ? "выйграли" : "проиграли";
            Color gameFinishTitleColor = userWon ? Color.Green : Color.Red;
            SetLabelStatus(gameFinishTitle, gameFinishTitleColor);
            _enemy.FinishGame();
            buttonRestart.Visible = true;
        }

        private void SetControlsVisibility(bool visible)
        {
            Control[] controlsToSetVisibility = {
                button1x, button2x, button3x,
                button4x, buttonRotate, label1x, label2x, label3x,
                label4x, labelPlaceShips, labelShipsPlaceLeft, progressBar,
                buttonGameStart, labelComputerMovingSpeed,
                comboBoxComputerMoveSpeed, checkBoxMarkEnemyMoves, panel };
            Label[] labelsToSetOppositeVisibility = { labelStatus, labelEnemyField };
            foreach (Control control in controlsToSetVisibility) control.Visible = visible;
            foreach (Label label in labelsToSetOppositeVisibility) label.Visible = !visible;
        }

        private void RestartGame()
        {
            for (int i = 0; i < NumberOfShipSizes; i++)
            {
                _chooseSizeButtons[i].Enabled = true;
                ((Label)Controls[GetControlText("label", i + UnitSign)]).Text
                    = Convert.ToString(NumberOfShipSizes - i);
                ButtonColorToStandart((Button)Controls[GetControlText("button", i + UnitSign)]);
            }
            SetControlsVisibility(visible: true);
            SetLabelStatus(DefaultStatus, DefaultStatusColor);
            ChosenSize = ZeroSign;
            progressBar.Value = ZeroSign;
            SetShipArrangeButtonEnables(shipsPlaced: false);
            buttonRestart.Visible = false;
            _makeSizeZero = false;
            _mapController.ClearField(_user.Map);
            _mapController.ClearField(_enemy.Map);
            StartGame();
        }

        private void buttonArrangeShipsRandomly_Click(object sender, EventArgs e)
        {
            RestartGame();
            _user.SpawnRandomShips();
            ShipsArranged();
            foreach (MapButton button in _user.Map)
            {
                if (!button.IsShipPart) continue;
                button.BackColor = Color.Blue;
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            labelPrompt.Visible = false;
        }

        private void labelComputerMove_VisibleChanged_1(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // подтверждение выхода
            switch (MessageBox.Show(this, "Вы уверены, что хотите выйти?", "Закрытие", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    if (this.ComputerMovingLabelVisible)
                    {
                        MessageBox.Show("Подождите пока компьютер сделает свой ход");
                        while (this.ComputerMovingLabelVisible) {}
                    }
                    break;
            }
        }
    }
}