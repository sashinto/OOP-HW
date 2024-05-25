using ArenaGameEngine;

namespace ArenaGameWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddItemToListBoxKnight(string s)
        {
            ListBoxKnight.Items.Add(s);
        }

        public void AddItemToListBoxRogue(string s)
        {
            ListBoxRogue.Items.Add(s);
        }

        private void bNewGame_Click(object sender, EventArgs e)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();

            MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Druid druid = new Druid("Darvin");
            Warlock warlock = new Warlock("Gul'dan");
            Arena arena = new Arena(druid, warlock);
            arena.EventListener = new WinFormsGameEventListener(this);
            Hero winner = arena.Battle();
            MessageBox.Show($"Winner is {winner.Name}", "Battle ended.");
        }
    }
}
