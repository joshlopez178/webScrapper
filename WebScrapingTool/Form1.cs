//Published by Joshua Lopez
//03-24-2021
//For learning puposes ONLY!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrapingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scrapBTN_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=restaurant&geo_location_terms=Amarillo%2C+TX");

            var HeaderNames = doc.DocumentNode.SelectNodes("//a[@class= 'business-name']").ToList();

            string ListData = "";
            foreach (var item in HeaderNames)
            {

                ListData += Environment.NewLine + item.InnerText;
            
            }
            txtdata.Text = ListData;

        }
    }
}
