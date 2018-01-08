using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace BingImageSpider.Service
{
    [RunInstaller(true)]
    public partial class BingSpider_Installer : Installer
    {
        public BingSpider_Installer()
        {
            InitializeComponent();
        }
    }
}
