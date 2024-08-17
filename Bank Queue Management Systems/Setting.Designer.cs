
namespace Bank_Queue_Management_Systems
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSdisplay = new System.Windows.Forms.Button();
            this.btnScounter = new System.Windows.Forms.Button();
            this.btnSticket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnSdisplay);
            this.panel1.Controls.Add(this.btnScounter);
            this.panel1.Controls.Add(this.btnSticket);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 322);
            this.panel1.TabIndex = 0;
            // 
            // btnSdisplay
            // 
            this.btnSdisplay.BackColor = System.Drawing.Color.White;
            this.btnSdisplay.Font = new System.Drawing.Font("Kh Jrung Thom", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSdisplay.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSdisplay.Location = new System.Drawing.Point(28, 218);
            this.btnSdisplay.Name = "btnSdisplay";
            this.btnSdisplay.Size = new System.Drawing.Size(515, 42);
            this.btnSdisplay.TabIndex = 24;
            this.btnSdisplay.Text = "Screen Display";
            this.btnSdisplay.UseVisualStyleBackColor = false;
            this.btnSdisplay.Click += new System.EventHandler(this.btnSdisplay_Click);
            // 
            // btnScounter
            // 
            this.btnScounter.BackColor = System.Drawing.Color.White;
            this.btnScounter.Font = new System.Drawing.Font("Kh Jrung Thom", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScounter.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnScounter.Location = new System.Drawing.Point(28, 139);
            this.btnScounter.Name = "btnScounter";
            this.btnScounter.Size = new System.Drawing.Size(515, 42);
            this.btnScounter.TabIndex = 23;
            this.btnScounter.Text = "Screen Counter";
            this.btnScounter.UseVisualStyleBackColor = false;
            this.btnScounter.Click += new System.EventHandler(this.btnScounter_Click);
            // 
            // btnSticket
            // 
            this.btnSticket.BackColor = System.Drawing.Color.White;
            this.btnSticket.Font = new System.Drawing.Font("Kh Jrung Thom", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSticket.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSticket.Location = new System.Drawing.Point(28, 63);
            this.btnSticket.Name = "btnSticket";
            this.btnSticket.Size = new System.Drawing.Size(515, 42);
            this.btnSticket.TabIndex = 22;
            this.btnSticket.Text = "Screen Ticket";
            this.btnSticket.UseVisualStyleBackColor = false;
            this.btnSticket.Click += new System.EventHandler(this.btnSticket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Setting";
            // 
            // PClose
            // 
            this.PClose.Image = ((System.Drawing.Image)(resources.GetObject("PClose.Image")));
            this.PClose.Location = new System.Drawing.Point(559, 9);
            this.PClose.Name = "PClose";
            this.PClose.Size = new System.Drawing.Size(26, 25);
            this.PClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PClose.TabIndex = 27;
            this.PClose.TabStop = false;
            this.PClose.Click += new System.EventHandler(this.PClose_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 408);
            this.ControlBox = false;
            this.Controls.Add(this.PClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSdisplay;
        private System.Windows.Forms.Button btnScounter;
        private System.Windows.Forms.Button btnSticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PClose;
    }
}