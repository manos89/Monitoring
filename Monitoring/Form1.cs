using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using InstaSharper.Logger;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class Form1 : Form
    {
        ArrayList userlist = new ArrayList();
        IDictionary<string, int> startingusers = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }

        public object RequestDelay { get; private set; }

        private async void submitbttn_Click(object sender, EventArgs e)
        {
            string UserName = usrnmbox.Text;
            string Password = passwdbox.Text;
            var userSession = new UserSessionData
            {
                UserName = UserName,
                Password = Password
            };
            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Profile Photo");
            dt.Columns.Add("Followers");
            dt.Columns.Add("Followings");
            dt.Columns.Add("Mutual Followers");
            dt.Columns.Add("Followers Difference");
            dataGridView1.DataSource = dt;
            var api = InstaApiBuilder.CreateBuilder()
        .SetUser(userSession)
        .UseLogger(new DebugLogger(LogLevel.Exceptions))
        .SetRequestDelay(new TimeSpan(0, 0, Int32.Parse(delaybox.Text.ToString())))
        .Build();

            IResult<InstaLoginResult> loggedIn = await api.LoginAsync();
            if(loggedIn.Value.ToString()== "BadPassword")
            {
                MessageBox.Show("Failed to login");
                Application.Exit();
            }
           
            System.Diagnostics.Debug.WriteLine(loggedIn.Value.ToString());



            while (true)
            {
                foreach (string user in userlist)
                {
                    try
                    {
                        usrchcklbl.Text = "Checking User: " + user.ToString();
                        var followingsdata = await api.GetUserFollowingAsync(user, PaginationParameters.MaxPagesToLoad(1));
                        var Userinfo = await api.GetUserAsync(user);
                        string Username = Userinfo.Value.UserName.ToString();
                        string Profilephoto = Userinfo.Value.ProfilePicture.ToString();
                        string Followers = Userinfo.Value.FollowersCount.ToString();
                        string Followings = followingsdata.Value.Count.ToString();
                        string MutualFollowers = Userinfo.Value.MutualFollowers.ToString();
  
                        DataRow[] foundAuthors = dt.Select("Username = '" + Username + "'");
                        if (foundAuthors.Length == 0)
                        {
                            startingusers.Add(new KeyValuePair<string, int>(Username, Int32.Parse(Followers)));
                            dt.Rows.Add(Username, Profilephoto, Followers, Followings, MutualFollowers, "0");
                        }
                        else
                        {
                            int Difference = Int32.Parse(Followers) - startingusers[Username];
                            DataRow dr = dt.Select("Username='" + Username + "'").FirstOrDefault();
                            dr["Profile Photo"] = Profilephoto;
                            dr["Followers"] = Followers;
                            dr["Followings"] = Followings;
                            dr["Mutual Followers"] = MutualFollowers;
                            dr["Followers Difference"] = Difference;

                        }
                        dataGridView1.DataSource = dt;

                    }

                    catch
                    {
                        
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            int counter = 0;
            usrsfiledialog.Filter= "Text|*.txt|All|*.*";
            if (usrsfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filelbl.Text = usrsfiledialog.FileName.ToString();
                System.IO.StreamReader file = new System.IO.StreamReader(usrsfiledialog.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    userlist.Add(line.ToString());
                    counter++;
                }


                file.Close();
            }
        }
    }
}
