using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using InstaSharper.Logger;
using System;
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
           
            var api = InstaApiBuilder.CreateBuilder()
        .SetUser(userSession)
        .UseLogger(new DebugLogger(LogLevel.Exceptions))
        .SetRequestDelay(new TimeSpan(0, 0, 30))
        .Build();

            IResult<InstaLoginResult> loggedIn = await api.LoginAsync();

            while (true)
            {
                var Followers = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(1));
                var Followings = await api.GetUserFollowingAsync("manosv_11", PaginationParameters.MaxPagesToLoad(1));
                fllowerslbl.Text = Followers.Value.Count.ToString();
                followingslbl.Text = Followings.Value.Count.ToString();
            }

        }
    }
}
