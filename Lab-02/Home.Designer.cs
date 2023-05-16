namespace Lab_02
{
    partial class Home
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_blue = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.lb_NumRedCores = new System.Windows.Forms.Label();
            this.lb_NumBlueCores = new System.Windows.Forms.Label();
            this.lb_NumGreeCore = new System.Windows.Forms.Label();
            this.lb_paleta = new System.Windows.Forms.Label();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(274, 31);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(226, 24);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Laboratório de Cores";
            this.lb_titulo.UseWaitCursor = true;
            // 
            // lb_red
            // 
            this.lb_red.BackColor = System.Drawing.Color.Red;
            this.lb_red.Location = new System.Drawing.Point(57, 83);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(52, 30);
            this.lb_red.TabIndex = 1;
            this.lb_red.UseWaitCursor = true;
            // 
            // lb_blue
            // 
            this.lb_blue.BackColor = System.Drawing.Color.Blue;
            this.lb_blue.Location = new System.Drawing.Point(57, 169);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(52, 30);
            this.lb_blue.TabIndex = 2;
            this.lb_blue.UseWaitCursor = true;
            // 
            // lb_green
            // 
            this.lb_green.BackColor = System.Drawing.Color.Green;
            this.lb_green.Location = new System.Drawing.Point(57, 126);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(52, 30);
            this.lb_green.TabIndex = 3;
            this.lb_green.UseWaitCursor = true;
            // 
            // lb_NumRedCores
            // 
            this.lb_NumRedCores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_NumRedCores.Location = new System.Drawing.Point(144, 83);
            this.lb_NumRedCores.Name = "lb_NumRedCores";
            this.lb_NumRedCores.Size = new System.Drawing.Size(130, 30);
            this.lb_NumRedCores.TabIndex = 4;
            this.lb_NumRedCores.Text = "0";
            this.lb_NumRedCores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_NumRedCores.UseWaitCursor = true;
            // 
            // lb_NumBlueCores
            // 
            this.lb_NumBlueCores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_NumBlueCores.Location = new System.Drawing.Point(144, 169);
            this.lb_NumBlueCores.Name = "lb_NumBlueCores";
            this.lb_NumBlueCores.Size = new System.Drawing.Size(130, 30);
            this.lb_NumBlueCores.TabIndex = 5;
            this.lb_NumBlueCores.Text = "0";
            this.lb_NumBlueCores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_NumBlueCores.UseWaitCursor = true;
            // 
            // lb_NumGreeCore
            // 
            this.lb_NumGreeCore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_NumGreeCore.Location = new System.Drawing.Point(144, 126);
            this.lb_NumGreeCore.Name = "lb_NumGreeCore";
            this.lb_NumGreeCore.Size = new System.Drawing.Size(130, 30);
            this.lb_NumGreeCore.TabIndex = 6;
            this.lb_NumGreeCore.Text = "0";
            this.lb_NumGreeCore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_NumGreeCore.UseWaitCursor = true;
            // 
            // lb_paleta
            // 
            this.lb_paleta.BackColor = System.Drawing.Color.White;
            this.lb_paleta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_paleta.Location = new System.Drawing.Point(12, 235);
            this.lb_paleta.Name = "lb_paleta";
            this.lb_paleta.Size = new System.Drawing.Size(776, 206);
            this.lb_paleta.TabIndex = 7;
            this.lb_paleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_paleta.UseWaitCursor = true;
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(318, 126);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(423, 30);
            this.hScrollBarGreen.TabIndex = 10;
            this.hScrollBarGreen.UseWaitCursor = true;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(318, 169);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(423, 30);
            this.hScrollBarBlue.TabIndex = 9;
            this.hScrollBarBlue.UseWaitCursor = true;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(318, 83);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(423, 30);
            this.hScrollBarRed.TabIndex = 8;
            this.hScrollBarRed.UseWaitCursor = true;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lb_paleta);
            this.Controls.Add(this.lb_NumGreeCore);
            this.Controls.Add(this.lb_NumBlueCores);
            this.Controls.Add(this.lb_NumRedCores);
            this.Controls.Add(this.lb_green);
            this.Controls.Add(this.lb_blue);
            this.Controls.Add(this.lb_red);
            this.Controls.Add(this.lb_titulo);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório 02";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titulo;
        private Label lb_red;
        private Label lb_blue;
        private Label lb_green;
        private Label lb_NumRedCores;
        private Label lb_NumBlueCores;
        private Label lb_NumGreeCore;
        private Label lb_paleta;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private HScrollBar hScrollBarRed;
    }
}