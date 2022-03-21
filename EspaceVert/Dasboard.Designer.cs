
namespace EspaceVert
{
    partial class Dasboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasboard));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gestionProdAdminButton = new System.Windows.Forms.Button();
            this.addProdButton = new System.Windows.Forms.Button();
            this.gestionProdButton = new System.Windows.Forms.Button();
            this.dashButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.gestionProdAdminButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.addProdButton);
            this.panel1.Controls.Add(this.gestionProdButton);
            this.panel1.Controls.Add(this.dashButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // gestionProdAdminButton
            // 
            this.gestionProdAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.gestionProdAdminButton, "gestionProdAdminButton");
            this.gestionProdAdminButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gestionProdAdminButton.Name = "gestionProdAdminButton";
            this.gestionProdAdminButton.UseVisualStyleBackColor = false;
            this.gestionProdAdminButton.Click += new System.EventHandler(this.gestAdminButton);
            // 
            // addProdButton
            // 
            this.addProdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.addProdButton, "addProdButton");
            this.addProdButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addProdButton.Name = "addProdButton";
            this.addProdButton.UseVisualStyleBackColor = false;
            this.addProdButton.Click += new System.EventHandler(this.addProdButtonS);
            // 
            // gestionProdButton
            // 
            this.gestionProdButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.gestionProdButton, "gestionProdButton");
            this.gestionProdButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gestionProdButton.Name = "gestionProdButton";
            this.gestionProdButton.UseVisualStyleBackColor = false;
            this.gestionProdButton.Click += new System.EventHandler(this.gestProdButton);
            // 
            // dashButton
            // 
            this.dashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.dashButton, "dashButton");
            this.dashButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashButton.Name = "dashButton";
            this.dashButton.UseVisualStyleBackColor = false;
            this.dashButton.Click += new System.EventHandler(this.dashButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // Dasboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dasboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gestionProdAdminButton;
        private System.Windows.Forms.Button addProdButton;
        private System.Windows.Forms.Button gestionProdButton;
        private System.Windows.Forms.Button dashButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
    }
}