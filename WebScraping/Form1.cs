/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnScrape.Visible = false;
//          txtURL.Text = "http://petcare.com/";
            txtURL.Text = "http://yahoo.com";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Navigate to the URL in txtURL
            wbScrape.Navigate(txtURL.Text);
        }

        private void wbScrape_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // We will end up here when the URL is loaded into the Web Browser control
            // Put the HTML into lblHTML
            txtHTML.Text = wbScrape.DocumentText;
            btnScrape.Visible = true;
            txtURL.Text +=  " loaded ";
            
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            // Load all the links on the page in wbScrape into a listBox control
            foreach (HtmlElement myLink in wbScrape.Document.Links)
            {
                try
                {
                    lbLinks.Items.Add(myLink.GetAttribute("HREF"));
                }
                catch (Exception ex) { }
            }
        }
    }
}
