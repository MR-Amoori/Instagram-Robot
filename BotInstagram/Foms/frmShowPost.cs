using InstagramApiSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotInstagram.Foms
{
    public partial class frmShowPost : Form
    {
        public string UserName { get; set; }
        public frmShowPost()
        {
            InitializeComponent();
        }

        private async void frmShowPost_Load(object sender, EventArgs e)
        {
            this.Text = "Postes " + UserName;
            var userMedias = await ctx.api.UserProcessor.GetUserMediaAsync(UserName, PaginationParameters.MaxPagesToLoad(1));
            string html = "";
            if (userMedias.Succeeded)
            {
                foreach (var item in userMedias.Value)
                {
                    html += $"</br> <div style='width:100%'>";

                    if (item.Images.Any())
                    {
                        html += $"<img src='{item.Images[0].Uri}' style='width:100%'/>";
                    }
                    else if (item.Carousel.Any())
                    {
                        html += $"<img src='{item.Carousel[0].Images[0].Uri}' style='width:100%'/>";
                    }
                    else if (item.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Video)
                    {
                        html += $"<video controls> < source src = '{item.Videos[0].Uri}' type = 'video/mp4' > </ video > ";
                    }

                    html += $"<p><span> Like: {item.LikesCount} </span>" +
                     $"<span>  Comments: {item.CommentsCount} </span>" +
                     $"</p>" +
                     $"<p>" +
                     $"{item.Caption?.Text}" +
                     $"</p>"
                     +
                     $"</div> </br>";

                    //html += $"<p>";
                    //foreach (var itemm in item.Likers)
                    //{
                    //    html += $"{itemm.UserName} </br>";
                    //}
                    //html += "</p>";
                }
                webBrowser1.DocumentText = html;
            }
        }
    }
}
