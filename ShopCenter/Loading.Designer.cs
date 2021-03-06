﻿namespace ShopCenter
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage4 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage3 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonClientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonClientPanel1.Controls.Add(this.progressBarX1);
            this.ribbonClientPanel1.Controls.Add(this.reflectionLabel1);
            this.ribbonClientPanel1.Controls.Add(this.reflectionImage4);
            this.ribbonClientPanel1.Controls.Add(this.reflectionImage3);
            this.ribbonClientPanel1.Controls.Add(this.reflectionImage1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(1, 2);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(623, 326);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.ribbonClientPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.ribbonClientPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.ribbonClientPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 1;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(11, 286);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(600, 20);
            this.progressBarX1.TabIndex = 10;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(242, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(194, 62);
            this.reflectionLabel1.TabIndex = 9;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Shop  </i><font color=\"#B02B2C\"><i>Center</i></font></font>" +
    "</b>";
            // 
            // reflectionImage4
            // 
            this.reflectionImage4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage4.Image = global::ShopCenter.Properties.Resources.shop_icon;
            this.reflectionImage4.Location = new System.Drawing.Point(482, 7);
            this.reflectionImage4.Name = "reflectionImage4";
            this.reflectionImage4.Size = new System.Drawing.Size(138, 225);
            this.reflectionImage4.TabIndex = 3;
            // 
            // reflectionImage3
            // 
            this.reflectionImage3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage3.Image = global::ShopCenter.Properties.Resources.if_User_Customers_1218712;
            this.reflectionImage3.Location = new System.Drawing.Point(242, 80);
            this.reflectionImage3.Name = "reflectionImage3";
            this.reflectionImage3.Size = new System.Drawing.Size(138, 226);
            this.reflectionImage3.TabIndex = 2;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Image = global::ShopCenter.Properties.Resources.shopping_bags_icon;
            this.reflectionImage1.Location = new System.Drawing.Point(24, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(138, 225);
            this.reflectionImage1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 330);
            this.Controls.Add(this.ribbonClientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loading_KeyDown);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage4;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage3;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;

    }
}