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
        public string TextForSearch { get; set; }
        public int Id = 0;
        public frmShowPost()
        {
            InitializeComponent();
        }

        private async void frmShowPost_Load(object sender, EventArgs e)
        {
            this.Text = "Postes " + UserName;
            var userMedias = await ctx.api.UserProcessor.GetUserMediaAsync(UserName, PaginationParameters.Empty);
            int count = userMedias.Value.Count;
            string html = "";

            if (Id == 0)
            {

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
                         $"</p>" +
                         $"</br>";

                        if (item.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Video)
                        {
                            int countt = item.Videos.Count;
                            html += $"<a href='{item.Videos[countt - 1].Uri}'>Link Download</a>";
                        }

                        html += $"</div> </br>";

                    }
                    webBrowser1.DocumentText = html;
                }

            }
            else
            {
                if (userMedias.Succeeded)
                {
                    foreach (var item in userMedias.Value)
                    {
                        if (item.Caption.Text != null)
                        {
                            if (item.Caption.Text.Contains(TextForSearch))
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

                                var postt = await ctx.api.MediaProcessor.GetMediaByIdAsync(item.InstaIdentifier);

                                html += $"<p><span> Like: {item.LikesCount} </span>" +
                                 $"<span>  Comments: {item.CommentsCount} </span>" +
                                 $"</p>" +
                                 $"<p>" +
                                 $"{item.Caption?.Text}" +
                                 $"</p>" +
                                 $"</br>";

                                if (item.MediaType == InstagramApiSharp.Classes.Models.InstaMediaType.Video)
                                {
                                    int countt = item.Videos.Count;
                                    html += $"<a href='{item.Videos[countt - 1].Uri}'>Link Download</a>";
                                }

                                html += $"</div> </br>";
                            }
                            else
                            {
                                if (userMedias.Value[count - 1].InstaIdentifier == item.InstaIdentifier)
                                {
                                    html += "<p> Not Find ! </p>";
                                    webBrowser1.DocumentText = html;
                                }
                            }
                        }
                        else
                        {
                            html += $"</br> <div style='width:100%'> < p> Not Find ! </p> </div>";
                            webBrowser1.DocumentText = html;
                        }
                    }
                    webBrowser1.DocumentText = html;
                }
            }
        }
    }
}
