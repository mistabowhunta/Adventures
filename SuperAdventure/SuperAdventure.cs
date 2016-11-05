using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1); // this is the constructor creating an object

            Location location = new Location(1, "Home", "This is your house."); // custom constructor that passes values to Location Class
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";

            //_player.CurrentHitPoints = 10;
            //_player.MaximumHitPoints = 10;
            //_player.Gold = 20;
            //_player.ExperiencePoints = 0;
            //_player.Level = 1; DO NOT NEED THESE MANUALLY ENTERED VARIABLES B/C WE ADDED A CUSTOM CONSTRUCTOR TO PLAYER CLASS AND PASS THE VARIABLES IN "NEW PLAYER(10,10,20,0,1)

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
