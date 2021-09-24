
namespace MOBILE_SHOP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MINIMIZE = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customerbutton = new System.Windows.Forms.Button();
            this.NewPhone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNewPhone1 = new MOBILE_SHOP.AllUserenfo.AddNewPhone();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.customer1 = new MOBILE_SHOP.AllUserenfo.customer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.MINIMIZE);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.customerbutton);
            this.panel1.Controls.Add(this.NewPhone);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 748);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MINIMIZE
            // 
            this.MINIMIZE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MINIMIZE.Image = ((System.Drawing.Image)(resources.GetObject("MINIMIZE.Image")));
            this.MINIMIZE.Location = new System.Drawing.Point(56, 3);
            this.MINIMIZE.Name = "MINIMIZE";
            this.MINIMIZE.Size = new System.Drawing.Size(47, 47);
            this.MINIMIZE.TabIndex = 6;
            this.MINIMIZE.UseVisualStyleBackColor = false;
            this.MINIMIZE.Click += new System.EventHandler(this.MINIMIZE_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(11, 603);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "     DELETE PHONE RECORD";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "           CUSTOMER RECORDS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "STOCK";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // customerbutton
            // 
            this.customerbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerbutton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbutton.Image = ((System.Drawing.Image)(resources.GetObject("customerbutton.Image")));
            this.customerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerbutton.Location = new System.Drawing.Point(11, 309);
            this.customerbutton.Name = "customerbutton";
            this.customerbutton.Size = new System.Drawing.Size(224, 55);
            this.customerbutton.TabIndex = 2;
            this.customerbutton.Text = "   CUSTOMERS";
            this.customerbutton.UseVisualStyleBackColor = false;
            this.customerbutton.Click += new System.EventHandler(this.customerbutton_Click);
            // 
            // NewPhone
            // 
            this.NewPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NewPhone.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPhone.Image = ((System.Drawing.Image)(resources.GetObject("NewPhone.Image")));
            this.NewPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewPhone.Location = new System.Drawing.Point(11, 209);
            this.NewPhone.Name = "NewPhone";
            this.NewPhone.Size = new System.Drawing.Size(224, 55);
            this.NewPhone.TabIndex = 1;
            this.NewPhone.Text = "     ADD NEW PHONE";
            this.NewPhone.UseVisualStyleBackColor = false;
            this.NewPhone.Click += new System.EventHandler(this.NewPhone_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.customer1);
            this.panel2.Controls.Add(this.addNewPhone1);
            this.panel2.Location = new System.Drawing.Point(265, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 900);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addNewPhone1
            // 
            this.addNewPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPhone1.Location = new System.Drawing.Point(3, 3);
            this.addNewPhone1.Name = "addNewPhone1";
            this.addNewPhone1.Size = new System.Drawing.Size(1100, 788);
            this.addNewPhone1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // customer1
            // 
            this.customer1.Location = new System.Drawing.Point(3, 4);
            this.customer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1100, 800);
            this.customer1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(992, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME PAGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewPhone;
        private System.Windows.Forms.Button MINIMIZE;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button customerbutton;
        private AllUserenfo.AddNewPhone addNewPhone1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserenfo.customer customer1;
    }
}

