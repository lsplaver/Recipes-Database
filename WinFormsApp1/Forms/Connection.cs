using Recipes.Models.DataLayer;
using Recipes.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Recipes.Forms
{
    public partial class frmConnection : Form
    {
        //public string server = null, database = null, username = null, password = null;
        public frmConnection()
        {
            InitializeComponent();
            MessageBox.Show("Please fill in the fields to connect to the database to start viewing recipes and ingrediants");
        }

        public string Server { get; private set; }
        public string Database { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            /*Server = txtServer.Text;
            Database = txtDatabase.Text;
            Username = txtUsername.Text;
            Password = mtxtPassword.Text;*/
            ServerObject serverObject = CreateServerObject();
            //ServerObject serverObject = new ServerObject(Server, Database, Username, Password);
            try
            {
                RecipesContext context = new RecipesContext(serverObject);
                int count = context.Ingrediants.Count();
                //frmHome frmHome = new frmHome(serverObject);
                frmHome frmHome = new frmHome(serverObject);
                frmHome.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ServerObject CreateServerObject()
        {
            ServerObject serverObject = new ServerObject();
            serverObject.Server = txtServer.Text;
            serverObject.Database = txtDatabase.Text;
            serverObject.Username = txtUsername.Text;
            serverObject.Password = mtxtPassword.Text;
            return serverObject;
        }
    }
}
