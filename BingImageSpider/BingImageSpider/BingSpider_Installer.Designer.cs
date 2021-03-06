﻿namespace BingImageSpider
{
    partial class BingSpider_Installer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BingSpider_ServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.BingSpider_ServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // BingSpider_ServiceProcessInstaller
            // 
            this.BingSpider_ServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.BingSpider_ServiceProcessInstaller.Password = null;
            this.BingSpider_ServiceProcessInstaller.Username = null;
            // 
            // BingSpider_ServiceInstaller
            // 
            this.BingSpider_ServiceInstaller.Description = "必应官网背景图抓取服务，停止此服务将不能正常下载必应网站图片。";
            this.BingSpider_ServiceInstaller.DisplayName = "BingImageSpiderService";
            this.BingSpider_ServiceInstaller.ServiceName = "BingImageSpiderService";
            this.BingSpider_ServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // BingSpider_Installer
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.BingSpider_ServiceProcessInstaller,
            this.BingSpider_ServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller BingSpider_ServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller BingSpider_ServiceInstaller;
    }
}